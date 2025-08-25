using System.Collections.Generic;
using PhoenixPoint.Modding;

namespace SelectClassTraits
{
    /// <summary>
    /// Test config using fields with ConfigField attributes (proper Phoenix Point pattern)
    /// </summary>
    public class SelectClassTraitsConfig : ModConfig
    {
        // Global Options
        [ConfigField(text: "Debug Logging")]
        public bool DebugLogging = false;

        [ConfigField(text: "Randomize Perk Levels")]
        public bool RandomizePerkLevels = true;

        [ConfigField(text: "Allowed Perk Levels (comma-separated 2-7)")]
        public string AllowedPerkLevelsStr = "2,3,4,5,6,7";

        // Test just one class with a few sets
        [ConfigField(text: "Assault Set 1 Enabled")]
        public bool AssaultSet1Enabled = true;
        
        [ConfigField(text: "Assault Set 1: Reckless")]
        public bool AssaultSet1_RECKLESS = true;
        
        [ConfigField(text: "Assault Set 1: Thief")]
        public bool AssaultSet1_THIEF = true;
        
        [ConfigField(text: "Assault Set 1: Strongman")]
        public bool AssaultSet1_STRONGMAN = true;

        [ConfigField(text: "Assault Set 2 Enabled")]
        public bool AssaultSet2Enabled = true;
        
        [ConfigField(text: "Assault Set 2: Reckless")]
        public bool AssaultSet2_RECKLESS = true;
        
        [ConfigField(text: "Assault Set 2: Trooper")]
        public bool AssaultSet2_TROOPER = true;

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