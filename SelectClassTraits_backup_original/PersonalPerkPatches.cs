using Base.Core;
using Base.Defs;
using HarmonyLib;
using PhoenixPoint.Common.Core;
using PhoenixPoint.Common.Entities;
using PhoenixPoint.Tactical.Entities.Abilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SelectClassTraits
{
    public static class PersonalPerkPatches
    {
        private const string AbilityTrackTypeNamePreferred = "PhoenixPoint.Common.Entities.Characters.AbilityTrack";
        private const string AbilityTrackSlotTypeNamePreferred = "PhoenixPoint.Common.Entities.Characters.AbilityTrackSlot";
        private const string AbilityTrackTypeNameAlt = "PhoenixPoint.Tactical.Entities.Abilities.AbilityTrack";
        private const string AbilityTrackSlotTypeNameAlt = "PhoenixPoint.Tactical.Entities.Abilities.AbilityTrackSlot";

        private static readonly BindingFlags Any =
            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;

        private static Type _abilityTrackType;
        private static Type _slotType;
        private static MethodInfo _miCreatePersonalTrack;

        public static void InitializePatches(Harmony harmony)
        {
            var asm = typeof(GameUtl).Assembly; // Assembly-CSharp

            _abilityTrackType = FindTypeLoose(asm, AbilityTrackTypeNamePreferred, "AbilityTrack") ??
                                FindTypeLoose(asm, AbilityTrackTypeNameAlt, "AbilityTrack");
            _slotType = FindTypeLoose(asm, AbilityTrackSlotTypeNamePreferred, "AbilityTrackSlot") ??
                                FindTypeLoose(asm, AbilityTrackSlotTypeNameAlt, "AbilityTrackSlot");

            if (_abilityTrackType != null)
            {
                _miCreatePersonalTrack = _abilityTrackType
                    .GetMethods(BindingFlags.Public | BindingFlags.Static)
                    .FirstOrDefault(m =>
                    {
                        if (m.Name != "CreatePersonalAbilityTrack") return false;
                        var p = m.GetParameters();
                        if (p.Length < 2 || p.Length > 3) return false;
                        if (p[0].ParameterType != typeof(int)) return false;
                        return typeof(IDictionary).IsAssignableFrom(p[1].ParameterType);
                    });
            }

            var candidates = new List<MethodBase>();
            foreach (var t in asm.GetTypes())
            {
                var tn = t.FullName ?? t.Name;
                if (!(tn.Contains("Character") || tn.Contains("Progression") || tn.Contains("Generator") ||
                      tn.Contains("Ability") || tn.Contains("Perk") || tn.Contains("Descriptor") ||
                      tn.Contains("GeoUnit") || tn.Contains("Geo"))) continue;

                foreach (var m in t.GetMethods(Any))
                {
                    if (m.IsGenericMethodDefinition) continue;

                    bool returnsTrack =
                        (m.ReturnType == _abilityTrackType) ||
                        (m.ReturnType?.FullName == AbilityTrackTypeNamePreferred) ||
                        (m.ReturnType?.FullName == AbilityTrackTypeNameAlt) ||
                        (m.ReturnType?.Name == "AbilityTrack");

                    bool returnsEnumerable = typeof(IEnumerable).IsAssignableFrom(m.ReturnType) && m.ReturnType != typeof(string);

                    var mn = m.Name;
                    bool nameMatch =
                        mn.IndexOf("Personal", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        mn.IndexOf("CreatePersonal", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        mn.IndexOf("Generate", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        mn.IndexOf("Perk", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        mn.IndexOf("PersonalAbilityTrack", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        mn.Equals("get_PersonalAbilityTrack", StringComparison.OrdinalIgnoreCase);

                    if ((returnsTrack || returnsEnumerable) && nameMatch)
                        candidates.Add(m);
                }
            }
            candidates = candidates.Distinct().ToList();

            var postfix = new HarmonyMethod(typeof(PersonalPerkPatches).GetMethod(nameof(OverridePersonalPerks), Any));

            int ok = 0, fail = 0;
            foreach (var m in candidates)
            {
                try { harmony.Patch(m, postfix: postfix); ok++; SelectClassTraitsMain.LogDebug($"Patched: {m.DeclaringType?.FullName}.{m.Name}"); }
                catch (Exception e) { fail++; SelectClassTraitsMain.LogWarning($"Failed to patch {m.DeclaringType?.FullName}.{m.Name}: {e.Message}"); }
            }
            SelectClassTraitsMain.LogDebug($"Perk patch init: OK={ok}, Fail={fail}");
        }

        public static void OverridePersonalPerks(ref object __result, object __instance, MethodBase __originalMethod)
        {
            try
            {
                if (__result == null) return;

                var callerType = __originalMethod?.DeclaringType?.FullName ?? "";
                var callerName = __originalMethod?.Name ?? "";
                SelectClassTraitsMain.LogDebug($"OverridePersonalPerks caller: {callerType}.{callerName}");

                // Do not touch early generator or encyclopedia
                if (callerType.Contains("Geoscape.Core.FactionCharacterGenerator") ||
                    callerType.Contains("GeoPhoenixpediaEntriesDbDef"))
                {
                    return;
                }

                var (className, rng, found) = ResolveContext(__instance, __originalMethod);
                if (!found || string.IsNullOrEmpty(className))
                {
                    SelectClassTraitsMain.LogDebug("Class could not be resolved with confidence; leaving vanilla result.");
                    return; // IMPORTANT: no defaulting to Assault
                }

                var cfg = SelectClassTraitsMain.Main.Config;
                var perks = PerkSetManager.SelectRandomSet(className, cfg, rng);
                if (perks == null || perks.Count == 0)
                {
                    SelectClassTraitsMain.LogDebug($"No configured perks for class '{className}', leaving vanilla result.");
                    return;
                }
                var levels = PerkSetManager.GetPerkLevels(perks, cfg, rng);

                // Build level->def map
                var defRepo = GameUtl.GameComponent<DefRepository>();
                var levelToDef = new Dictionary<int, TacticalAbilityDef>();
                int count = Math.Min(perks.Count, levels.Count);
                for (int i = 0; i < count; i++)
                {
                    var def = ResolveDef(defRepo, perks[i]);
                    if (def == null) continue;
                    int lvl = Math.Max(2, Math.Min(7, levels[i]));
                    if (!levelToDef.ContainsKey(lvl))
                        levelToDef[lvl] = def;
                }

                if (levelToDef.Count == 0)
                {
                    SelectClassTraitsMain.LogWarning("All configured perks failed to resolve to defs; leaving vanilla.");
                    return;
                }

                // Preferred: replace with clean 7-slot track on GeoUnitDescriptor getter
                if (callerType.Contains("Geoscape.Entities.GeoUnitDescriptor") &&
                    (callerName.IndexOf("GetPersonalAbilityTrack", StringComparison.OrdinalIgnoreCase) >= 0 ||
                     callerName.Equals("get_PersonalAbilityTrack", StringComparison.OrdinalIgnoreCase)))
                {
                    if (TryBuildPersonalTrack_7Slots(levelToDef, out var newTrack))
                    {
                        __result = newTrack;
                        SelectClassTraitsMain.LogDebug($"Rebuilt AbilityTrack via CreatePersonalAbilityTrack (len=7, entries={levelToDef.Count}).");
                        return;
                    }
                }

                // Common shapes
                if (__result is IList<TacticalAbilityDef> listDefs)
                {
                    listDefs.Clear();
                    foreach (var kv in levelToDef.OrderBy(k => k.Key)) listDefs.Add(kv.Value);
                    SelectClassTraitsMain.LogDebug($"Wrote {listDefs.Count} TacticalAbilityDef entries (list).");
                    return;
                }

                if (__result is IDictionary<string, int> idMap)
                {
                    var idToLevel = PerkSetManager.ConvertToIdMapping(perks, levels);
                    idMap.Clear();
                    foreach (var kv in idToLevel) idMap[kv.Key] = kv.Value;
                    SelectClassTraitsMain.LogDebug($"Wrote {idMap.Count} entries to ID map.");
                    return;
                }

                if (__result is IDictionary<int, TacticalAbilityDef> intDefMap)
                {
                    intDefMap.Clear();
                    foreach (var kv in levelToDef) intDefMap[kv.Key] = kv.Value;
                    SelectClassTraitsMain.LogDebug($"Wrote {intDefMap.Count} entries to int->def map.");
                    return;
                }

                // AbilityTrack object: rewrite internals then shim
                var rt = __result.GetType();
                if (rt == _abilityTrackType || rt.FullName == AbilityTrackTypeNamePreferred || rt.FullName == AbilityTrackTypeNameAlt || rt.Name == "AbilityTrack")
                {
                    if (TryRewriteTrackInternals(__result, levelToDef))
                    {
                        EnsureSevenSlotsShim(__result, 7, levelToDef);
                        return;
                    }
                }

                // Fallback: create/find slots container, then shim
                if (TryWriteSlotsInsideObject(__result))
                {
                    EnsureSevenSlotsShim(__result, 7, levelToDef);
                    return;
                }

                SelectClassTraitsMain.LogWarning($"OverridePersonalPerks: Unhandled result type {__result.GetType().FullName}");
            }
            catch (Exception e)
            {
                SelectClassTraitsMain.LogWarning("OverridePersonalPerks failed: " + e);
            }
        }

        // ---------- Track builders & internals ----------

        private static bool TryBuildPersonalTrack_7Slots(Dictionary<int, TacticalAbilityDef> levelToDef, out object track)
        {
            track = null;
            try
            {
                if (_abilityTrackType == null || _miCreatePersonalTrack == null) return false;

                var dictType = typeof(Dictionary<,>).MakeGenericType(typeof(int), typeof(TacticalAbilityDef));
                var dict = Activator.CreateInstance(dictType);
                var add = dictType.GetMethod("Add", new[] { typeof(int), typeof(TacticalAbilityDef) });
                foreach (var kv in levelToDef) add.Invoke(dict, new object[] { kv.Key, kv.Value });

                var p = _miCreatePersonalTrack.GetParameters();
                object newTrack;
                if (p.Length == 2)
                {
                    newTrack = _miCreatePersonalTrack.Invoke(null, new object[] { 7, dict });
                }
                else
                {
                    var sourceType = p[2].ParameterType;
                    object sourceVal = sourceType.IsEnum ? Enum.GetValues(sourceType).GetValue(0)
                                                         : (sourceType.IsValueType ? Activator.CreateInstance(sourceType) : null);
                    newTrack = _miCreatePersonalTrack.Invoke(null, new object[] { 7, dict, sourceVal });
                }

                if (newTrack != null)
                {
                    EnsureSevenSlotsShim(newTrack, 7, levelToDef);
                    track = newTrack;
                    return true;
                }
            }
            catch (Exception e)
            {
                SelectClassTraitsMain.LogWarning("TryBuildPersonalTrack_7Slots failed: " + e);
            }
            return false;
        }

        private static bool TryRewriteTrackInternals(object trackObj, Dictionary<int, TacticalAbilityDef> levelToDef)
        {
            try
            {
                var t = trackObj.GetType();

                foreach (var f in t.GetFields(Any))
                    if (typeof(IDictionary<string, int>).IsAssignableFrom(f.FieldType))
                        return WriteIdToLevelMap(f.GetValue(trackObj), levelToDef);
                foreach (var p in t.GetProperties(Any))
                    if (p.CanRead && typeof(IDictionary<string, int>).IsAssignableFrom(p.PropertyType))
                        return WriteIdToLevelMap(p.GetValue(trackObj, null), levelToDef);

                foreach (var f in t.GetFields(Any))
                    if (IsIntToDefDict(f.FieldType))
                        return WriteIntToDefMap(f.GetValue(trackObj), levelToDef);
                foreach (var p in t.GetProperties(Any))
                    if (p.CanRead && IsIntToDefDict(p.PropertyType))
                        return WriteIntToDefMap(p.GetValue(trackObj, null), levelToDef);

                foreach (var f in t.GetFields(Any))
                    if (typeof(IList<TacticalAbilityDef>).IsAssignableFrom(f.FieldType))
                        return WriteDefList(f.GetValue(trackObj), levelToDef);
                foreach (var p in t.GetProperties(Any))
                    if (p.CanRead && typeof(IList<TacticalAbilityDef>).IsAssignableFrom(p.PropertyType))
                        return WriteDefList(p.GetValue(trackObj, null), levelToDef);
            }
            catch { }
            return false;
        }

        private static bool WriteIdToLevelMap(object dictObj, Dictionary<int, TacticalAbilityDef> levelToDef)
        {
            if (dictObj == null) return false;
            var dict = dictObj as IDictionary<string, int>;
            if (dict == null) return false;

            dict.Clear();
            foreach (var kv in levelToDef)
                dict[kv.Value.name] = kv.Key;

            SelectClassTraitsMain.LogDebug($"Wrote {dict.Count} entries to ID map inside track.");
            return true;
        }

        private static bool IsIntToDefDict(Type t)
        {
            if (!typeof(IDictionary).IsAssignableFrom(t)) return false;
            if (!t.IsGenericType) return false;
            var ga = t.GetGenericArguments();
            return ga.Length == 2 && ga[0] == typeof(int) && ga[1] == typeof(TacticalAbilityDef);
        }

        private static bool WriteIntToDefMap(object dictObj, Dictionary<int, TacticalAbilityDef> levelToDef)
        {
            if (dictObj == null) return false;
            if (!IsIntToDefDict(dictObj.GetType())) return false;

            var clear = dictObj.GetType().GetMethod("Clear", Any);
            clear?.Invoke(dictObj, null);

            var add = dictObj.GetType().GetMethod("Add", new[] { typeof(int), typeof(TacticalAbilityDef) });
            foreach (var kv in levelToDef)
                add?.Invoke(dictObj, new object[] { kv.Key, kv.Value });

            SelectClassTraitsMain.LogDebug($"Wrote {levelToDef.Count} entries to int->def map inside track.");
            return true;
        }

        private static bool WriteDefList(object listObj, Dictionary<int, TacticalAbilityDef> levelToDef)
        {
            var list = listObj as IList<TacticalAbilityDef>;
            if (list == null) return false;

            list.Clear();
            foreach (var def in levelToDef.OrderBy(k => k.Key).Select(k => k.Value))
                list.Add(def);

            SelectClassTraitsMain.LogDebug($"Wrote {list.Count} TacticalAbilityDef entries to track list.");
            return true;
        }

        /// <summary>
        /// EPPS-safe: ensure the track exposes exactly 7 non-null slots.
        /// For indices not mapped in levelToDef, we insert a placeholder slot with null Ability.
        /// </summary>
        private static void EnsureSevenSlotsShim(object track, int trackLen, Dictionary<int, TacticalAbilityDef> levelToDef)
        {
            try
            {
                if (_slotType == null) return;

                var (container, kind) = FindSlotsContainer(track);
                if (container == null)
                {
                    var newArr = Array.CreateInstance(_slotType, trackLen);
                    ReplaceSlotsContainer(track, newArr);
                    (container, kind) = FindSlotsContainer(track);
                    if (container == null) return;
                }

                if (kind == SlotsKind.Array)
                {
                    var arr = (Array)container;
                    if (arr.Length != trackLen)
                    {
                        var newArr = Array.CreateInstance(_slotType, trackLen);
                        int copy = Math.Min(arr.Length, trackLen);
                        for (int i = 0; i < copy; i++) newArr.SetValue(arr.GetValue(i), i);
                        ReplaceSlotsContainer(track, newArr);
                        arr = newArr;
                    }

                    for (int i = 0; i < trackLen; i++)
                    {
                        var slot = arr.GetValue(i) ?? Activator.CreateInstance(_slotType);
                        var lvl = i + 1;
                        levelToDef.TryGetValue(lvl, out var def);
                        SetIfExists(slot, "Ability", def);
                        SetIfExists(slot, "TacticalAbility", def);
                        SetIfExists(slot, "Level", lvl);
                        SetIfExists(slot, "TargetLevel", lvl);
                        SetIfExists(slot, "UnlockLevel", lvl);
                        arr.SetValue(slot, i);
                    }
                    SelectClassTraitsMain.LogDebug("EnsureSevenSlotsShim: normalized array slots to 7.");
                }
                else if (kind == SlotsKind.List)
                {
                    var list = (IList)container;
                    while (list.Count < trackLen) list.Add(Activator.CreateInstance(_slotType));
                    while (list.Count > trackLen) list.RemoveAt(list.Count - 1);

                    for (int i = 0; i < trackLen; i++)
                    {
                        var slot = list[i] ?? Activator.CreateInstance(_slotType);
                        var lvl = i + 1;
                        levelToDef.TryGetValue(lvl, out var def);
                        SetIfExists(slot, "Ability", def);
                        SetIfExists(slot, "TacticalAbility", def);
                        SetIfExists(slot, "Level", lvl);
                        SetIfExists(slot, "TargetLevel", lvl);
                        SetIfExists(slot, "UnlockLevel", lvl);
                        list[i] = slot;
                    }
                    SelectClassTraitsMain.LogDebug("EnsureSevenSlotsShim: normalized list slots to 7.");
                }
            }
            catch (Exception e)
            {
                SelectClassTraitsMain.LogWarning("EnsureSevenSlotsShim failed: " + e);
            }
        }

        private enum SlotsKind { None, Array, List }

        private static (object container, SlotsKind kind) FindSlotsContainer(object track)
        {
            var t = track.GetType();

            foreach (var f in t.GetFields(Any))
            {
                var ft = f.FieldType;
                if (ft.IsArray && (ft.GetElementType()?.Name?.Contains("AbilityTrackSlot") ?? false))
                    return (f.GetValue(track), SlotsKind.Array);

                if (IsListOfSlot(ft))
                    return (f.GetValue(track), SlotsKind.List);
            }

            foreach (var p in t.GetProperties(Any))
            {
                var pt = p.PropertyType;
                if (!p.CanRead) continue;

                if (pt.IsArray && (pt.GetElementType()?.Name?.Contains("AbilityTrackSlot") ?? false))
                    return (p.GetValue(track, null), SlotsKind.Array);

                if (IsListOfSlot(pt))
                    return (p.GetValue(track, null), SlotsKind.List);
            }

            return (null, SlotsKind.None);
        }

        private static bool IsListOfSlot(Type t)
        {
            if (!typeof(IList).IsAssignableFrom(t)) return false;
            if (!t.IsGenericType) return false;
            var ga = t.GetGenericArguments();
            return ga.Length == 1 && (ga[0].Name?.Contains("AbilityTrackSlot") ?? false);
        }

        private static void ReplaceSlotsContainer(object track, Array newArray)
        {
            var t = track.GetType();
            foreach (var f in t.GetFields(Any))
                if (f.FieldType.IsArray && (f.FieldType.GetElementType()?.Name?.Contains("AbilityTrackSlot") ?? false))
                { f.SetValue(track, newArray); return; }

            foreach (var p in t.GetProperties(Any))
                if (p.CanWrite && p.PropertyType.IsArray && (p.PropertyType.GetElementType()?.Name?.Contains("AbilityTrackSlot") ?? false))
                { p.SetValue(track, newArray, null); return; }
        }

        private static bool TryWriteSlotsInsideObject(object obj)
        {
            try
            {
                if (_slotType == null || obj == null) return false;

                var (container, kind) = FindSlotsContainer(obj);
                if (container == null)
                {
                    var newArr = Array.CreateInstance(_slotType, 7);
                    ReplaceSlotsContainer(obj, newArr);
                    (container, kind) = FindSlotsContainer(obj);
                }
                return container != null && kind != SlotsKind.None;
            }
            catch { return false; }
        }

        // ---------- Reflection helpers ----------

        private static void SetIfExists(object obj, string member, object value)
        {
            if (obj == null) return;
            var t = obj.GetType();

            var f = t.GetField(member, Any);
            if (f != null && (value == null || f.FieldType.IsInstanceOfType(value))) { f.SetValue(obj, value); return; }

            var p = t.GetProperty(member, Any);
            if (p != null && p.CanWrite && (value == null || p.PropertyType.IsInstanceOfType(value))) { p.SetValue(obj, value, null); }
        }

        private static object GetMemberValue(object obj, string name)
        {
            if (obj == null) return null;
            var t = obj.GetType();
            var p = t.GetProperty(name, Any);
            if (p != null && p.CanRead) return p.GetValue(obj, null);
            var f = t.GetField(name, Any);
            if (f != null) return f.GetValue(obj);
            return null;
        }

        private static string TryGetName(object obj)
        {
            if (obj == null) return null;
            var t = obj.GetType();
            try
            {
                var p = t.GetProperty("Name", Any);
                if (p != null && p.PropertyType == typeof(string)) return p.GetValue(obj, null) as string;

                var f = t.GetField("Name", Any);
                if (f != null && f.FieldType == typeof(string)) return f.GetValue(obj) as string;

                var pf = t.GetField("name", Any);
                if (pf != null && pf.FieldType == typeof(string)) return pf.GetValue(obj) as string;

                var pp = t.GetProperty("name", Any);
                if (pp != null && pp.PropertyType == typeof(string)) return pp.GetValue(obj, null) as string;
            }
            catch { }
            return null;
        }

        // ---------- Class detection ----------

        private static string CanonClass(string raw)
        {
            if (string.IsNullOrWhiteSpace(raw)) return null;
            var s = raw.ToLowerInvariant();
            if (s.Contains("assault")) return "Assault";
            if (s.Contains("heavy")) return "Heavy";
            if (s.Contains("sniper")) return "Sniper";
            if (s.Contains("berserk")) return "Berserker";
            if (s.Contains("priest")) return "Priest";
            if (s.Contains("technician") || s.Contains("tech")) return "Technician";
            if (s.Contains("infil")) return "Infiltrator";
            return null; // IMPORTANT: do not default here
        }

        private static string TryExtractClassFromObject(object o)
        {
            if (o == null) return null;
            var t = o.GetType();

            var tn = t.FullName ?? t.Name;
            var canonFromType = CanonClass(tn);
            if (!string.IsNullOrEmpty(canonFromType))
                return canonFromType;

            var ownName = TryGetName(o);
            var canonFromOwnName = CanonClass(ownName ?? "");
            if (!string.IsNullOrEmpty(canonFromOwnName))
                return canonFromOwnName;

            string[] classProps =
            {
                "PrimaryClassDef","ClassDef","ClassDefinition","PrimarySpecializationDef",
                "SpecializationDef","TacticalClassDef","MainClassDef","MainSpecializationDef"
            };

            foreach (var name in classProps)
            {
                var v = GetMemberValue(o, name);
                var n = TryGetName(v) ?? v?.GetType().Name;
                var canon = CanonClass(n ?? "");
                if (!string.IsNullOrEmpty(canon))
                    return canon;
            }

            string[] tagMembers = { "ClassTag", "ClassTags", "Tags" };
            foreach (var nm in tagMembers)
            {
                var v = GetMemberValue(o, nm);
                var fromTags = TryExtractFromTags(v);
                if (!string.IsNullOrEmpty(fromTags))
                    return fromTags;
            }

            return null;
        }

        private static string TryExtractFromTags(object tagsObj)
        {
            if (tagsObj == null) return null;

            if (tagsObj is IEnumerable en)
            {
                int scanned = 0;
                foreach (var tag in en)
                {
                    scanned++;
                    if (scanned > 24) break;
                    var tagName = TryGetName(tag) ?? tag?.GetType().Name ?? "";
                    var canon = CanonClass(tagName);
                    if (!string.IsNullOrEmpty(canon))
                        return canon;
                }
                return null;
            }

            var singleName = TryGetName(tagsObj) ?? tagsObj.GetType().Name;
            var singleCanon = CanonClass(singleName);
            if (!string.IsNullOrEmpty(singleCanon))
                return singleCanon;

            return null;
        }

        private static string ResolveFromProgression(object progression)
        {
            if (progression == null) return null;

            // 1) owner/character
            var owner = GetMemberValue(progression, "Owner") ?? GetMemberValue(progression, "Character");
            var cls = TryExtractClassFromObject(owner);
            if (!string.IsNullOrEmpty(cls)) return cls;

            // 2) owner -> primary spec / class
            var primarySpec = GetMemberValue(owner, "PrimarySpecializationDef") ??
                              GetMemberValue(owner, "PrimaryClassDef") ??
                              GetMemberValue(owner, "ClassDef");
            cls = TryExtractClassFromObject(primarySpec);
            if (!string.IsNullOrEmpty(cls)) return cls;

            // 3) owner -> template / def -> tags
            var template = GetMemberValue(owner, "Template") ?? GetMemberValue(owner, "Def") ?? GetMemberValue(owner, "TacCharacterDef");
            cls = TryExtractClassFromObject(template);
            if (!string.IsNullOrEmpty(cls)) return cls;

            // 4) progression/owner -> Specializations collection
            var specs = GetMemberValue(progression, "Specializations") ?? GetMemberValue(owner, "Specializations");
            cls = TryExtractFromTags(specs);
            if (!string.IsNullOrEmpty(cls)) return cls;

            return null;
        }

        private static string ProbeLikelyChildren(object instance)
        {
            if (instance == null) return null;
            var t = instance.GetType();
            string[] children = { "Owner", "Character", "Template", "Descriptor", "Unit", "GeoUnit", "TacCharacter", "Progression", "Identity" };

            foreach (var name in children)
            {
                var v = GetMemberValue(instance, name);
                var canon = TryExtractClassFromObject(v);
                if (!string.IsNullOrEmpty(canon)) return canon;
            }
            return null;
        }

        private static (string className, Random rng, bool found) ResolveContext(object instance, MethodBase caller)
        {
            string className = null;
            var rng = new Random();

            if (instance != null)
            {
                var tn = instance.GetType().FullName ?? instance.GetType().Name;

                // Special handling for CharacterProgression
                if (tn.IndexOf(".Characters.CharacterProgression", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    var cls = ResolveFromProgression(instance);
                    if (!string.IsNullOrEmpty(cls))
                    {
                        SelectClassTraitsMain.LogDebug($"Resolved class '{cls}' from CharacterProgression owner/template.");
                        className = cls;
                    }
                }

                // GeoUnitDescriptor: direct path
                if (className == null && tn.IndexOf("GeoUnitDescriptor", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    var p = instance.GetType().GetProperty("ClassDef", Any)
                         ?? instance.GetType().GetProperty("PrimaryClassDef", Any)
                         ?? instance.GetType().GetProperty("PrimarySpecializationDef", Any)
                         ?? instance.GetType().GetProperty("TacticalClassDef", Any);

                    var v = p?.GetValue(instance, null);
                    var n = TryGetName(v) ?? v?.GetType().Name;
                    var canon = CanonClass(n ?? "");
                    if (!string.IsNullOrEmpty(canon))
                    {
                        SelectClassTraitsMain.LogDebug($"Resolved class '{canon}' from GeoUnitDescriptor");
                        className = canon;
                    }
                }

                // Generic probes
                if (className == null)
                {
                    var direct = TryExtractClassFromObject(instance);
                    if (!string.IsNullOrEmpty(direct)) className = direct;
                    else
                    {
                        var child = ProbeLikelyChildren(instance);
                        if (!string.IsNullOrEmpty(child)) className = child;
                    }
                }

                // Try to reuse RNG if available on instance
                try
                {
                    var rngField = instance.GetType().GetFields(Any).FirstOrDefault(f => f.FieldType == typeof(Random));
                    var r = rngField?.GetValue(instance) as Random;
                    if (r != null) rng = r;
                }
                catch { }
            }

            if (!string.IsNullOrEmpty(className))
            {
                SelectClassTraitsMain.LogDebug($"Resolved class '{className}' from instance type '{instance?.GetType().FullName ?? "null"}'");
                return (className, rng, true);
            }

            return (null, rng, false); // IMPORTANT: signal "not found"
        }

        // ---------- AbilityDef resolution ----------

        private static string Norm(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return string.Empty;
            var chars = s.Where(char.IsLetterOrDigit).ToArray();
            return new string(chars).ToUpperInvariant();
        }

        private static readonly Dictionary<string, string[]> DisplayToDefNames =
            new Dictionary<string, string[]>(StringComparer.OrdinalIgnoreCase)
        {
            { Norm("Biochemist"),                new[] { "BioChemist_AbilityDef" } },
            { Norm("Cautious"),                  new[] { "Cautious_AbilityDef" } },
            { Norm("Close Quarter Specialist"),  new[] { "CloseQuartersSpecialist_AbilityDef" } },
            { Norm("Close Quarters Specialist"), new[] { "CloseQuartersSpecialist_AbilityDef" } },
            { Norm("Farsighted"),                new[] { "Brainiac_AbilityDef" } },
            { Norm("Healer"),                    new[] { "Helpful_AbilityDef" } },
            { Norm("Quarterback"),               new[] { "Pitcher_AbilityDef" } },
            { Norm("Reckless"),                  new[] { "Reckless_AbilityDef" } },
            { Norm("Resourceful"),               new[] { "Resourceful_AbilityDef" } },
            { Norm("Self Defense Specialist"),   new[] { "SelfDefenseSpecialist_AbilityDef" } },
            { Norm("Sniperist"),                 new[] { "Focused_AbilityDef" } },
            { Norm("Focused"),                   new[] { "Focused_AbilityDef" } },
            { Norm("Strongman"),                 new[] { "Strongman_AbilityDef" } },
            { Norm("Thief"),                     new[] { "Thief_AbilityDef" } },
            { Norm("Trooper"),                   new[] { "GoodShot_AbilityDef" } },
            { Norm("Bombardier"),                new[] { "Crafty_AbilityDef" } },
        };

        private static TacticalAbilityDef ResolveDef(DefRepository repo, string perkDisplay)
        {
            if (string.IsNullOrWhiteSpace(perkDisplay)) return null;

            var key = Norm(perkDisplay);
            var all = repo.GetAllDefs<TacticalAbilityDef>();

            if (DisplayToDefNames.TryGetValue(key, out var candidates))
            {
                foreach (var name in candidates)
                {
                    var hit = all.FirstOrDefault(d => d.name.Equals(name, StringComparison.OrdinalIgnoreCase));
                    if (hit != null) return hit;
                }
            }

            var def = all.FirstOrDefault(d =>
                d.name.Equals(perkDisplay, StringComparison.OrdinalIgnoreCase) ||
                Norm(d.name) == key ||
                d.name.IndexOf(perkDisplay, StringComparison.OrdinalIgnoreCase) >= 0 ||
                (d.name.EndsWith("_AbilityDef", StringComparison.OrdinalIgnoreCase) &&
                 Norm(d.name.Substring(0, d.name.Length - "_AbilityDef".Length)) == key)
            );

            if (def == null)
                SelectClassTraitsMain.LogWarning($"Could not resolve TacticalAbilityDef for '{perkDisplay}'.");

            return def;
        }

        // ---------- small utils ----------

        private static Type FindTypeLoose(Assembly asm, string preferredFullName, string simpleName)
        {
            var exact = asm.GetTypes().FirstOrDefault(tt => tt.FullName == preferredFullName);
            if (exact != null) return exact;
            return asm.GetTypes().FirstOrDefault(tt => tt.Name == simpleName);
        }
    }
}
