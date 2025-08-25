using com.ootii.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SelectClassTraits
{
    public static class PerkSetManager
    {
        private static readonly BindingFlags Any =
            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;

        public static List<string> SelectRandomSet(string className, SelectClassTraitsConfig config, Random random)
        {
            var cls = CanonTitle(className);
            var enabledSets = GetEnabledSets(cls, config);
            if (enabledSets.Count == 0)
            {
                SelectClassTraitsMain.LogWarning($"No enabled sets for class '{cls}'. Falling back to defaults.");
                return GetFallbackPerks(cls);
            }

            int set = enabledSets[random.Next(enabledSets.Count)];
            var candidates = GetPerkCandidatesForSet(cls, set, config);
            if (candidates.Count == 0)
            {
                SelectClassTraitsMain.LogWarning($"[{cls} Set {set}] has no enabled perks; using fallback.");
                return GetFallbackPerks(cls);
            }

            return candidates.Count > 3 ? SelectRandomPerks(candidates, 3, random) : candidates;
        }

        // Random distinct levels in 2..7 (sorted). If config exposes toggles, they’re respected; otherwise default random ON.
        public static List<int> GetPerkLevels(List<string> perks, SelectClassTraitsConfig config, Random random)
        {
            bool randomize = ReadBool(config, "RandomizePerkLevels") ?? true;

            var allowed = TryReadIntList(config, "AllowedPerkLevels");
            if (allowed == null || allowed.Count == 0)
                allowed = Enumerable.Range(2, 6).ToList(); // 2..7
            else
            {
                allowed = allowed.Where(l => l >= 2 && l <= 7).Distinct().OrderBy(l => l).ToList();
                if (allowed.Count == 0) allowed = Enumerable.Range(2, 6).ToList();
            }

            if (!randomize)
            {
                int[] defaults = { 2, 4, 6 };
                var levels = new List<int>();
                for (int i = 0; i < perks.Count; i++)
                    levels.Add(i < defaults.Length ? defaults[i] : Math.Min(7, defaults.Last() + (i - defaults.Length + 1)));
                return levels;
            }

            var pool = new List<int>(allowed);
            var chosen = new List<int>();
            int need = Math.Min(perks.Count, pool.Count);
            for (int i = 0; i < need; i++)
            {
                int idx = random.Next(pool.Count);
                chosen.Add(pool[idx]);
                pool.RemoveAt(idx);
            }
            chosen.Sort();
            return chosen;
        }

        public static Dictionary<string, int> ConvertToIdMapping(List<string> perks, List<int> levels)
        {
            var map = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            for (int i = 0; i < perks.Count; i++)
            {
                string id = ResolveAbilityNameFromDisplay(perks[i]);
                if (string.IsNullOrEmpty(id))
                {
                    SelectClassTraitsMain.LogWarning($"ConvertToIdMapping: No ability id for '{perks[i]}'.");
                    continue;
                }
                int lvl = (levels != null && levels.Count > i) ? levels[i] : (i + 1) * 2;
                map[id] = lvl;
            }
            return map;
        }

        // -------- internals --------

        private static string CanonTitle(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return "Assault";
            var s = name.ToLowerInvariant();
            if (s.Contains("assault")) return "Assault";
            if (s.Contains("heavy")) return "Heavy";
            if (s.Contains("sniper")) return "Sniper";
            if (s.Contains("berserk")) return "Berserker";
            if (s.Contains("priest")) return "Priest";
            if (s.Contains("technician") || s.Contains("tech")) return "Technician";
            if (s.Contains("infil")) return "Infiltrator";
            return char.ToUpperInvariant(s[0]) + s.Substring(1);
        }

        private static List<int> GetEnabledSets(string cls, SelectClassTraitsConfig cfg)
        {
            var enabled = new List<int>();
            for (int set = 1; set <= 5; set++)
                if (ReadBool(cfg, $"{cls}Set{set}Enabled") == true)
                    enabled.Add(set);
            return enabled;
        }

        private static List<string> GetPerkCandidatesForSet(string cls, int set, SelectClassTraitsConfig cfg)
        {
            string prefix = $"{cls}Set{set}_";
            var type = cfg.GetType();
            var result = new List<string>();

            foreach (var f in type.GetFields(BindingFlags.Public | BindingFlags.Instance))
            {
                if (f.FieldType == typeof(bool) && f.Name.StartsWith(prefix, StringComparison.Ordinal))
                {
                    bool on = (bool)f.GetValue(cfg);
                    if (!on) continue;
                    var label = DisplayFromSuffix(f.Name.Substring(prefix.Length));
                    if (!label.Equals("ENABLED", StringComparison.OrdinalIgnoreCase))
                        result.Add(label);
                }
            }

            foreach (var p in type.GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                if (p.PropertyType == typeof(bool) && p.CanRead && p.Name.StartsWith(prefix, StringComparison.Ordinal))
                {
                    bool on = (bool)p.GetValue(cfg, null);
                    if (!on) continue;
                    var label = DisplayFromSuffix(p.Name.Substring(prefix.Length));
                    if (!label.Equals("ENABLED", StringComparison.OrdinalIgnoreCase))
                        result.Add(label);
                }
            }

            return result.Distinct(StringComparer.OrdinalIgnoreCase).ToList();
        }

        private static List<string> SelectRandomPerks(List<string> source, int count, Random rng)
        {
            var list = new List<string>(source);
            for (int i = 0; i < count && i < list.Count; i++)
            {
                int j = i + rng.Next(list.Count - i);
                (list[i], list[j]) = (list[j], list[i]);
            }
            return list.Take(Math.Min(count, list.Count)).ToList();
        }

        private static bool? ReadBool(object obj, string name)
        {
            if (obj == null) return null;
            var t = obj.GetType();

            var f = t.GetField(name, Any);
            if (f != null && f.FieldType == typeof(bool)) return (bool)f.GetValue(obj);

            var p = t.GetProperty(name, Any);
            if (p != null && p.PropertyType == typeof(bool) && p.CanRead) return (bool)p.GetValue(obj, null);

            return null;
        }

        private static List<int> TryReadIntList(object obj, string name)
        {
            if (obj == null) return null;
            var t = obj.GetType();

            var f = t.GetField(name, Any);
            if (f != null)
            {
                var v = f.GetValue(obj);
                var list = AsIntList(v);
                if (list != null) return list;
            }

            var p = t.GetProperty(name, Any);
            if (p != null && p.CanRead)
            {
                var v = p.GetValue(obj, null);
                var list = AsIntList(v);
                if (list != null) return list;
            }

            return null;
        }

        private static List<int> AsIntList(object v)
        {
            if (v == null) return null;
            if (v is int[] a) return a.ToList();
            if (v is List<int> l) return new List<int>(l);
            if (v is IEnumerable<int> ien) return ien.ToList();
            if (v is string s)
            {
                var parts = s.Split(new[] { ',', ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var outList = new List<int>();
                foreach (var part in parts)
                    if (int.TryParse(part.Trim(), out var n)) outList.Add(n);
                return outList;
            }
            return null;
        }

        private static string DisplayFromSuffix(string suffix)
        {
            if (string.IsNullOrWhiteSpace(suffix)) return string.Empty;
            var s = suffix.Replace("__", "_").Replace("_", " ").Trim();
            if (s.IndexOf(' ') < 0)
            {
                var chars = new List<char>(s.Length + 8);
                for (int i = 0; i < s.Length; i++)
                {
                    char c = s[i];
                    if (i > 0 && char.IsUpper(c) && char.IsLetterOrDigit(s[i - 1]))
                        chars.Add(' ');
                    chars.Add(c);
                }
                s = new string(chars.ToArray());
            }
            s = System.Text.RegularExpressions.Regex.Replace(s, @"\s+", " ");
            s = s.Replace("-", " ").Trim();
            return s.ToUpperInvariant();
        }

        private static List<string> GetFallbackPerks(string cls)
            => new List<string> { "RECKLESS", "THIEF", "STRONGMAN" };

        // ----- ability name resolution (display -> def id string) -----

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

        public static string ResolveAbilityNameFromDisplay(string display)
        {
            var key = Norm(display);
            if (DisplayToDefNames.TryGetValue(key, out var candidates))
                return candidates.FirstOrDefault();

            // Heuristic: "CLOSE QUARTERS SPECIALIST" => "CloseQuartersSpecialist_AbilityDef"
            var parts = SplitWords(display);
            var pascal = string.Concat(parts.Select(w => char.ToUpperInvariant(w[0]) + w.Substring(1).ToLowerInvariant()));
            return pascal + "_AbilityDef";
        }

        private static IEnumerable<string> SplitWords(string s)
        {
            var raw = s.Replace("_", " ").Replace("-", " ");
            var buf = new List<char>(raw.Length + 8);
            for (int i = 0; i < raw.Length; i++)
            {
                char c = raw[i];
                if (i > 0 && char.IsUpper(c) && char.IsLetterOrDigit(raw[i - 1]) && raw[i - 1] != ' ')
                    buf.Add(' ');
                buf.Add(c);
            }
            return new string(buf.ToArray()).Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
