using System.Collections.Generic;
using System.ComponentModel;
using PhoenixPoint.Modding;

namespace SelectClassTraits
{
    /// <summary>
    /// UI-Compatible config that works with Phoenix Point's in-game mod settings.
    /// Uses flat properties but with better organization and helper methods for maintainability.
    /// </summary>
    public class SelectClassTraitsConfig : ModConfig
    {
        // ─────────────────────────── Global Options ───────────────────────────
        [ConfigField("Debug Logging", "Enable debug logging output")]
        public bool DebugLogging { get; set; } = false;

        [ConfigField("Randomize Perk Levels", "Randomly assign perk levels (2-7)")]
        public bool RandomizePerkLevels { get; set; } = true;

        [ConfigField("Allowed Perk Level Min", "Minimum perk level (2-7)")]
        public int AllowedPerkLevelMin { get; set; } = 2;

        [ConfigField("Allowed Perk Level Max", "Maximum perk level (2-7)")]
        public int AllowedPerkLevelMax { get; set; } = 7;

        // ─────────────────────────── ASSAULT CLASS ──────────────────────────
        [ConfigField("Assault Set 1 Enabled", "Enable Assault Set 1 (All Perks)")]
        public bool AssaultSet1Enabled { get; set; } = true;
        [ConfigField("Assault Set 1: Reckless", "")] public bool AssaultSet1_Reckless { get; set; } = true;
        [ConfigField("Assault Set 1: Thief", "")] public bool AssaultSet1_Thief { get; set; } = true;
        [ConfigField("Assault Set 1: Strongman", "")] public bool AssaultSet1_Strongman { get; set; } = true;
        [ConfigField("Assault Set 1: Resourceful", "")] public bool AssaultSet1_Resourceful { get; set; } = true;
        [ConfigField("Assault Set 1: Trooper", "")] public bool AssaultSet1_Trooper { get; set; } = true;
        [ConfigField("Assault Set 1: Close Quarter Specialist", "")] public bool AssaultSet1_CloseQuarters { get; set; } = true;
        [ConfigField("Assault Set 1: Cautious", "")] public bool AssaultSet1_Cautious { get; set; } = true;
        [ConfigField("Assault Set 1: Biochemist", "")] public bool AssaultSet1_Biochemist { get; set; } = true;
        [ConfigField("Assault Set 1: Healer", "")] public bool AssaultSet1_Healer { get; set; } = true;
        [ConfigField("Assault Set 1: Quarterback", "")] public bool AssaultSet1_Quarterback { get; set; } = true;
        [ConfigField("Assault Set 1: Self Defense Specialist", "")] public bool AssaultSet1_SelfDefense { get; set; } = true;
        [ConfigField("Assault Set 1: Sniperist", "")] public bool AssaultSet1_Sniperist { get; set; } = true;
        [ConfigField("Assault Set 1: Farsighted", "")] public bool AssaultSet1_Farsighted { get; set; } = true;
        [ConfigField("Assault Set 1: Bombardier", "")] public bool AssaultSet1_Bombardier { get; set; } = true;

        [ConfigField("Assault Set 2 Enabled", "Enable Assault Set 2 (Combat Focus)")]
        public bool AssaultSet2Enabled { get; set; } = true;
        [ConfigField("Assault Set 2: Reckless", "")] public bool AssaultSet2_Reckless { get; set; } = true;
        [ConfigField("Assault Set 2: Thief", "")] public bool AssaultSet2_Thief { get; set; } = false;
        [ConfigField("Assault Set 2: Strongman", "")] public bool AssaultSet2_Strongman { get; set; } = false;
        [ConfigField("Assault Set 2: Resourceful", "")] public bool AssaultSet2_Resourceful { get; set; } = false;
        [ConfigField("Assault Set 2: Trooper", "")] public bool AssaultSet2_Trooper { get; set; } = true;
        [ConfigField("Assault Set 2: Close Quarter Specialist", "")] public bool AssaultSet2_CloseQuarters { get; set; } = true;
        [ConfigField("Assault Set 2: Cautious", "")] public bool AssaultSet2_Cautious { get; set; } = false;
        [ConfigField("Assault Set 2: Biochemist", "")] public bool AssaultSet2_Biochemist { get; set; } = false;
        [ConfigField("Assault Set 2: Healer", "")] public bool AssaultSet2_Healer { get; set; } = false;
        [ConfigField("Assault Set 2: Quarterback", "")] public bool AssaultSet2_Quarterback { get; set; } = false;
        [ConfigField("Assault Set 2: Self Defense Specialist", "")] public bool AssaultSet2_SelfDefense { get; set; } = false;
        [ConfigField("Assault Set 2: Sniperist", "")] public bool AssaultSet2_Sniperist { get; set; } = false;
        [ConfigField("Assault Set 2: Farsighted", "")] public bool AssaultSet2_Farsighted { get; set; } = false;
        [ConfigField("Assault Set 2: Bombardier", "")] public bool AssaultSet2_Bombardier { get; set; } = false;

        [ConfigField("Assault Set 3 Enabled", "Enable Assault Set 3 (Stealth Assault)")]
        public bool AssaultSet3Enabled { get; set; } = true;
        [ConfigField("Assault Set 3: Reckless", "")] public bool AssaultSet3_Reckless { get; set; } = true;
        [ConfigField("Assault Set 3: Thief", "")] public bool AssaultSet3_Thief { get; set; } = true;
        [ConfigField("Assault Set 3: Strongman", "")] public bool AssaultSet3_Strongman { get; set; } = false;
        [ConfigField("Assault Set 3: Resourceful", "")] public bool AssaultSet3_Resourceful { get; set; } = false;
        [ConfigField("Assault Set 3: Trooper", "")] public bool AssaultSet3_Trooper { get; set; } = false;
        [ConfigField("Assault Set 3: Close Quarter Specialist", "")] public bool AssaultSet3_CloseQuarters { get; set; } = true;
        [ConfigField("Assault Set 3: Cautious", "")] public bool AssaultSet3_Cautious { get; set; } = false;
        [ConfigField("Assault Set 3: Biochemist", "")] public bool AssaultSet3_Biochemist { get; set; } = false;
        [ConfigField("Assault Set 3: Healer", "")] public bool AssaultSet3_Healer { get; set; } = false;
        [ConfigField("Assault Set 3: Quarterback", "")] public bool AssaultSet3_Quarterback { get; set; } = false;
        [ConfigField("Assault Set 3: Self Defense Specialist", "")] public bool AssaultSet3_SelfDefense { get; set; } = false;
        [ConfigField("Assault Set 3: Sniperist", "")] public bool AssaultSet3_Sniperist { get; set; } = false;
        [ConfigField("Assault Set 3: Farsighted", "")] public bool AssaultSet3_Farsighted { get; set; } = false;
        [ConfigField("Assault Set 3: Bombardier", "")] public bool AssaultSet3_Bombardier { get; set; } = false;

        // ─────────────────────────── SNIPER CLASS ───────────────────────────
        [ConfigField("Sniper Set 1 Enabled", "Enable Sniper Set 1 (All Perks)")]
        public bool SniperSet1Enabled { get; set; } = true;
        [ConfigField("Sniper Set 1: Reckless", "")] public bool SniperSet1_Reckless { get; set; } = true;
        [ConfigField("Sniper Set 1: Thief", "")] public bool SniperSet1_Thief { get; set; } = true;
        [ConfigField("Sniper Set 1: Strongman", "")] public bool SniperSet1_Strongman { get; set; } = true;
        [ConfigField("Sniper Set 1: Resourceful", "")] public bool SniperSet1_Resourceful { get; set; } = true;
        [ConfigField("Sniper Set 1: Trooper", "")] public bool SniperSet1_Trooper { get; set; } = true;
        [ConfigField("Sniper Set 1: Close Quarter Specialist", "")] public bool SniperSet1_CloseQuarters { get; set; } = true;
        [ConfigField("Sniper Set 1: Cautious", "")] public bool SniperSet1_Cautious { get; set; } = true;
        [ConfigField("Sniper Set 1: Biochemist", "")] public bool SniperSet1_Biochemist { get; set; } = true;
        [ConfigField("Sniper Set 1: Healer", "")] public bool SniperSet1_Healer { get; set; } = true;
        [ConfigField("Sniper Set 1: Quarterback", "")] public bool SniperSet1_Quarterback { get; set; } = true;
        [ConfigField("Sniper Set 1: Self Defense Specialist", "")] public bool SniperSet1_SelfDefense { get; set; } = true;
        [ConfigField("Sniper Set 1: Sniperist", "")] public bool SniperSet1_Sniperist { get; set; } = true;
        [ConfigField("Sniper Set 1: Farsighted", "")] public bool SniperSet1_Farsighted { get; set; } = true;
        [ConfigField("Sniper Set 1: Bombardier", "")] public bool SniperSet1_Bombardier { get; set; } = true;

        [ConfigField("Sniper Set 2 Enabled", "Enable Sniper Set 2 (Aggressive Sniper)")]
        public bool SniperSet2Enabled { get; set; } = true;
        [ConfigField("Sniper Set 2: Reckless", "")] public bool SniperSet2_Reckless { get; set; } = true;
        [ConfigField("Sniper Set 2: Thief", "")] public bool SniperSet2_Thief { get; set; } = true;
        [ConfigField("Sniper Set 2: Strongman", "")] public bool SniperSet2_Strongman { get; set; } = false;
        [ConfigField("Sniper Set 2: Resourceful", "")] public bool SniperSet2_Resourceful { get; set; } = false;
        [ConfigField("Sniper Set 2: Trooper", "")] public bool SniperSet2_Trooper { get; set; } = false;
        [ConfigField("Sniper Set 2: Close Quarter Specialist", "")] public bool SniperSet2_CloseQuarters { get; set; } = false;
        [ConfigField("Sniper Set 2: Cautious", "")] public bool SniperSet2_Cautious { get; set; } = false;
        [ConfigField("Sniper Set 2: Biochemist", "")] public bool SniperSet2_Biochemist { get; set; } = false;
        [ConfigField("Sniper Set 2: Healer", "")] public bool SniperSet2_Healer { get; set; } = false;
        [ConfigField("Sniper Set 2: Quarterback", "")] public bool SniperSet2_Quarterback { get; set; } = false;
        [ConfigField("Sniper Set 2: Self Defense Specialist", "")] public bool SniperSet2_SelfDefense { get; set; } = false;
        [ConfigField("Sniper Set 2: Sniperist", "")] public bool SniperSet2_Sniperist { get; set; } = true;
        [ConfigField("Sniper Set 2: Farsighted", "")] public bool SniperSet2_Farsighted { get; set; } = false;
        [ConfigField("Sniper Set 2: Bombardier", "")] public bool SniperSet2_Bombardier { get; set; } = false;

        // Helper properties for compatibility with existing PerkSetManager
        public List<int> AllowedPerkLevels
        {
            get
            {
                var levels = new List<int>();
                for (int i = AllowedPerkLevelMin; i <= AllowedPerkLevelMax; i++)
                {
                    levels.Add(i);
                }
                return levels;
            }
        }

        // Helper methods to get perk data in a structured way for the manager
        public List<int> GetEnabledSets(string className)
        {
            var enabled = new List<int>();
            switch (className?.ToLowerInvariant())
            {
                case "assault":
                    if (AssaultSet1Enabled) enabled.Add(1);
                    if (AssaultSet2Enabled) enabled.Add(2);
                    if (AssaultSet3Enabled) enabled.Add(3);
                    break;
                case "sniper":
                    if (SniperSet1Enabled) enabled.Add(1);
                    if (SniperSet2Enabled) enabled.Add(2);
                    break;
                // Add other classes as needed...
            }
            return enabled;
        }

        public List<string> GetPerksForSet(string className, int setNumber)
        {
            var perks = new List<string>();
            var prefix = $"{className}Set{setNumber}_";
            
            // Use reflection to get all properties that match the pattern
            var type = this.GetType();
            foreach (var prop in type.GetProperties())
            {
                if (prop.PropertyType == typeof(bool) && 
                    prop.Name.StartsWith(prefix, System.StringComparison.OrdinalIgnoreCase) &&
                    (bool)prop.GetValue(this))
                {
                    var perkName = prop.Name.Substring(prefix.Length);
                    perks.Add(ConvertToStandardPerkName(perkName));
                }
            }
            return perks;
        }

        private string ConvertToStandardPerkName(string propertyName)
        {
            return propertyName switch
            {
                "CloseQuarters" => "CLOSE_QUARTERS_SPECIALIST",
                "SelfDefense" => "SELF_DEFENSE_SPECIALIST",
                _ => propertyName.ToUpperInvariant()
            };
        }
    }
}