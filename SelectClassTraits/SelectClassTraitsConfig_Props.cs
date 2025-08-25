using System.Collections.Generic;
using PhoenixPoint.Modding;

namespace SelectClassTraits
{
    /// <summary>
    /// Minimal test config to verify ConfigField attributes work
    /// </summary>
    public class SelectClassTraitsConfig : ModConfig
    {
        // Global Options
        [ConfigField("Debug Logging", "Enable debug logging output")]
        public bool DebugLogging { get; set; } = false;

        [ConfigField("Randomize Perk Levels", "Randomly assign perk levels 2-7")]
        public bool RandomizePerkLevels { get; set; } = true;

        [ConfigField("Allowed Perk Levels", "Comma-separated levels 2-7, e.g. 2,3,4,5,6,7")]
        public string AllowedPerkLevelsStr { get; set; } = "2,3,4,5,6,7";

        // Test just one class with a few sets
        [ConfigField("Assault Set 1 Enabled", "Enable Assault Set 1")]
        public bool AssaultSet1Enabled { get; set; } = true;
        
        [ConfigField("Assault Set 1: Reckless", "")]
        public bool AssaultSet1_RECKLESS { get; set; } = true;
        
        [ConfigField("Assault Set 1: Thief", "")]
        public bool AssaultSet1_THIEF { get; set; } = true;
        
        [ConfigField("Assault Set 1: Strongman", "")]
        public bool AssaultSet1_STRONGMAN { get; set; } = true;

        [ConfigField("Assault Set 2 Enabled", "Enable Assault Set 2")]
        public bool AssaultSet2Enabled { get; set; } = true;
        
        [ConfigField("Assault Set 2: Reckless", "")]
        public bool AssaultSet2_RECKLESS { get; set; } = true;
        
        [ConfigField("Assault Set 2: Trooper", "")]
        public bool AssaultSet2_TROOPER { get; set; } = true;

        // Helper property for backward compatibility
        public List<int> AllowedPerkLevels
        {
            get
            {
                var result = new List<int>();
                if (!string.IsNullOrEmpty(AllowedPerkLevelsStr))
                {
                    var parts = AllowedPerkLevelsStr.Split(',');
                    foreach (var part in parts)
                    {
                        if (int.TryParse(part.Trim(), out int level) && level >= 2 && level <= 7)
                            result.Add(level);
                    }
                }
                return result.Count > 0 ? result : new List<int> { 2, 3, 4, 5, 6, 7 };
            }
        }
    }
}