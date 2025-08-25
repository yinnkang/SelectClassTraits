using HarmonyLib;
using PhoenixPoint.Modding;
using System;
using System.Linq;

namespace SelectClassTraits
{
    public class SelectClassTraitsMain : ModMain
    {
        internal static SelectClassTraitsMain Main;
        private Harmony _harmony;

        public new SelectClassTraitsConfig Config => (SelectClassTraitsConfig)base.Config;

        public override void OnModEnabled()
        {
            Main = this;

            // Safety: if the user hasn't enabled any sets, turn them all on once.
            EnableAllIfEmpty(Config);

            _harmony = new Harmony("com.modder.SelectClassTraits");
            try
            {
                PersonalPerkPatches.InitializePatches(_harmony);
                Logger.LogInfo("[SelectClassTraits] Enabled and patches applied.");
            }
            catch (Exception e)
            {
                Logger.LogError("[SelectClassTraits] Failed to apply patches: " + e);
            }
        }

        public override void OnModDisabled()
        {
            try { _harmony?.UnpatchAll(_harmony?.Id); } catch { /* ignore */ }
            Logger.LogInfo("[SelectClassTraits] Disabled.");
            Main = null;
        }

        // ---- Static logging helpers used across files ----
        public static void LogDebug(string message)
        {
            if (Main != null && Main.Config != null && Main.Config.DebugLogging)
                Main.Logger.LogInfo("[SelectClassTraits][DEBUG] " + message);
        }

        public static void LogWarning(string message)
        {
            if (Main != null)
                Main.Logger.LogWarning("[SelectClassTraits] " + message);
        }

        public static void LogError(string message)
        {
            if (Main != null)
                Main.Logger.LogError("[SelectClassTraits] " + message);
        }

        // Turn on all *SetXEnabled flags if none are true (first run convenience)
        private void EnableAllIfEmpty(SelectClassTraitsConfig cfg)
        {
            try
            {
                var flags = typeof(SelectClassTraitsConfig)
                    .GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance)
                    .Where(f => f.FieldType == typeof(bool) && f.Name.EndsWith("Enabled"))
                    .ToList();

                bool anyTrue = flags.Any(f => (bool)f.GetValue(cfg));
                if (!anyTrue)
                {
                    foreach (var f in flags) f.SetValue(cfg, true);
                    Logger.LogInfo("[SelectClassTraits] No sets enabled; force-enabled all by default.");
                }
            }
            catch (Exception e)
            {
                Logger.LogWarning("[SelectClassTraits] EnableAllIfEmpty failed: " + e.Message);
            }
        }
    }
}
