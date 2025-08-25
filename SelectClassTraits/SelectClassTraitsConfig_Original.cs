using System.Collections.Generic;
using System.ComponentModel;
using PhoenixPoint.Modding;

namespace SelectClassTraits
{
    /// <summary>
    /// Symmetric config: every class has Sets 1..5 and all perks exposed per set.
    /// Set 1 is enabled and selects ALL perks by default.
    /// Unspecified sets from the request are disabled by default (all perks false).
    /// </summary>
    public class SelectClassTraitsConfig : ModConfig
    {
        // ─────────────────────────── Global Options ───────────────────────────
        [DisplayName("Debug Logging")]
        public bool DebugLogging { get; set; } = false;

        [DisplayName("Randomize Perk Levels")]
        public bool RandomizePerkLevels { get; set; } = true;

        [DisplayName("Allowed Perk Levels (2–7)")]
        public List<int> AllowedPerkLevels { get; set; } = new List<int> { 2, 3, 4, 5, 6, 7 };

        // Perk IDs used in field names:
        // RECKLESS, THIEF, STRONGMAN, RESOURCEFUL, TROOPER, CLOSE_QUARTERS_SPECIALIST,
        // CAUTIOUS, BIOCHEMIST, HEALER, QUARTERBACK, SELF_DEFENSE_SPECIALIST,
        // SNIPERIST, FARSIGHTED, BOMBARDIER

        // Helper to avoid mistakes: when setting “true”/“false”, double-check against your request.

        // ───────────────────────────── Assault ────────────────────────────────
        [DisplayName("Assault Set 1 Enabled")] public bool AssaultSet1Enabled { get; set; } = true;
        [DisplayName("Assault Set 1: Reckless")] public bool AssaultSet1_RECKLESS { get; set; } = true;
        [DisplayName("Assault Set 1: Thief")] public bool AssaultSet1_THIEF { get; set; } = true;
        [DisplayName("Assault Set 1: Strongman")] public bool AssaultSet1_STRONGMAN { get; set; } = true;
        [DisplayName("Assault Set 1: Resourceful")] public bool AssaultSet1_RESOURCEFUL { get; set; } = true;
        [DisplayName("Assault Set 1: Trooper")] public bool AssaultSet1_TROOPER { get; set; } = true;
        [DisplayName("Assault Set 1: Close Quarter Specialist")] public bool AssaultSet1_CLOSE_QUARTERS_SPECIALIST { get; set; } = true;
        [DisplayName("Assault Set 1: Cautious")] public bool AssaultSet1_CAUTIOUS { get; set; } = true;
        [DisplayName("Assault Set 1: Biochemist")] public bool AssaultSet1_BIOCHEMIST { get; set; } = true;
        [DisplayName("Assault Set 1: Healer")] public bool AssaultSet1_HEALER { get; set; } = true;
        [DisplayName("Assault Set 1: Quarterback")] public bool AssaultSet1_QUARTERBACK { get; set; } = true;
        [DisplayName("Assault Set 1: Self Defense Specialist")] public bool AssaultSet1_SELF_DEFENSE_SPECIALIST { get; set; } = true;
        [DisplayName("Assault Set 1: Sniperist")] public bool AssaultSet1_SNIPERIST { get; set; } = true;
        [DisplayName("Assault Set 1: Farsighted")] public bool AssaultSet1_FARSIGHTED { get; set; } = true;
        [DisplayName("Assault Set 1: Bombardier")] public bool AssaultSet1_BOMBARDIER { get; set; } = true;

        // Assault 2: Trooper, Reckless, Close Quarter Specialist
        [DisplayName("Assault Set 2 Enabled")] public bool AssaultSet2Enabled { get; set; } = true;
        [DisplayName("Assault Set 2: Reckless")] public bool AssaultSet2_RECKLESS { get; set; } = true;
        [DisplayName("Assault Set 2: Thief")] public bool AssaultSet2_THIEF { get; set; } = false;
        [DisplayName("Assault Set 2: Strongman")] public bool AssaultSet2_STRONGMAN { get; set; } = false;
        [DisplayName("Assault Set 2: Resourceful")] public bool AssaultSet2_RESOURCEFUL { get; set; } = false;
        [DisplayName("Assault Set 2: Trooper")] public bool AssaultSet2_TROOPER { get; set; } = true;
        [DisplayName("Assault Set 2: Close Quarter Specialist")] public bool AssaultSet2_CLOSE_QUARTERS_SPECIALIST { get; set; } = true;
        [DisplayName("Assault Set 2: Cautious")] public bool AssaultSet2_CAUTIOUS { get; set; } = false;
        [DisplayName("Assault Set 2: Biochemist")] public bool AssaultSet2_BIOCHEMIST { get; set; } = false;
        [DisplayName("Assault Set 2: Healer")] public bool AssaultSet2_HEALER { get; set; } = false;
        [DisplayName("Assault Set 2: Quarterback")] public bool AssaultSet2_QUARTERBACK { get; set; } = false;
        [DisplayName("Assault Set 2: Self Defense Specialist")] public bool AssaultSet2_SELF_DEFENSE_SPECIALIST { get; set; } = false;
        [DisplayName("Assault Set 2: Sniperist")] public bool AssaultSet2_SNIPERIST { get; set; } = false;
        [DisplayName("Assault Set 2: Farsighted")] public bool AssaultSet2_FARSIGHTED { get; set; } = false;
        [DisplayName("Assault Set 2: Bombardier")] public bool AssaultSet2_BOMBARDIER { get; set; } = false;

        // Assault 3: Close Quarter Specialist, Reckless, Thief
        [DisplayName("Assault Set 3 Enabled")] public bool AssaultSet3Enabled { get; set; } = true;
        [DisplayName("Assault Set 3: Reckless")] public bool AssaultSet3_RECKLESS { get; set; } = true;
        [DisplayName("Assault Set 3: Thief")] public bool AssaultSet3_THIEF { get; set; } = true;
        [DisplayName("Assault Set 3: Strongman")] public bool AssaultSet3_STRONGMAN { get; set; } = false;
        [DisplayName("Assault Set 3: Resourceful")] public bool AssaultSet3_RESOURCEFUL { get; set; } = false;
        [DisplayName("Assault Set 3: Trooper")] public bool AssaultSet3_TROOPER { get; set; } = false;
        [DisplayName("Assault Set 3: Close Quarter Specialist")] public bool AssaultSet3_CLOSE_QUARTERS_SPECIALIST { get; set; } = true;
        [DisplayName("Assault Set 3: Cautious")] public bool AssaultSet3_CAUTIOUS { get; set; } = false;
        [DisplayName("Assault Set 3: Biochemist")] public bool AssaultSet3_BIOCHEMIST { get; set; } = false;
        [DisplayName("Assault Set 3: Healer")] public bool AssaultSet3_HEALER { get; set; } = false;
        [DisplayName("Assault Set 3: Quarterback")] public bool AssaultSet3_QUARTERBACK { get; set; } = false;
        [DisplayName("Assault Set 3: Self Defense Specialist")] public bool AssaultSet3_SELF_DEFENSE_SPECIALIST { get; set; } = false;
        [DisplayName("Assault Set 3: Sniperist")] public bool AssaultSet3_SNIPERIST { get; set; } = false;
        [DisplayName("Assault Set 3: Farsighted")] public bool AssaultSet3_FARSIGHTED { get; set; } = false;
        [DisplayName("Assault Set 3: Bombardier")] public bool AssaultSet3_BOMBARDIER { get; set; } = false;

        // Assault 4: Strongman, Reckless, Thief
        [DisplayName("Assault Set 4 Enabled")] public bool AssaultSet4Enabled { get; set; } = true;
        [DisplayName("Assault Set 4: Reckless")] public bool AssaultSet4_RECKLESS { get; set; } = true;
        [DisplayName("Assault Set 4: Thief")] public bool AssaultSet4_THIEF { get; set; } = true;
        [DisplayName("Assault Set 4: Strongman")] public bool AssaultSet4_STRONGMAN { get; set; } = true;
        [DisplayName("Assault Set 4: Resourceful")] public bool AssaultSet4_RESOURCEFUL { get; set; } = false;
        [DisplayName("Assault Set 4: Trooper")] public bool AssaultSet4_TROOPER { get; set; } = false;
        [DisplayName("Assault Set 4: Close Quarter Specialist")] public bool AssaultSet4_CLOSE_QUARTERS_SPECIALIST { get; set; } = false;
        [DisplayName("Assault Set 4: Cautious")] public bool AssaultSet4_CAUTIOUS { get; set; } = false;
        [DisplayName("Assault Set 4: Biochemist")] public bool AssaultSet4_BIOCHEMIST { get; set; } = false;
        [DisplayName("Assault Set 4: Healer")] public bool AssaultSet4_HEALER { get; set; } = false;
        [DisplayName("Assault Set 4: Quarterback")] public bool AssaultSet4_QUARTERBACK { get; set; } = false;
        [DisplayName("Assault Set 4: Self Defense Specialist")] public bool AssaultSet4_SELF_DEFENSE_SPECIALIST { get; set; } = false;
        [DisplayName("Assault Set 4: Sniperist")] public bool AssaultSet4_SNIPERIST { get; set; } = false;
        [DisplayName("Assault Set 4: Farsighted")] public bool AssaultSet4_FARSIGHTED { get; set; } = false;
        [DisplayName("Assault Set 4: Bombardier")] public bool AssaultSet4_BOMBARDIER { get; set; } = false;

        // Assault 5: Self Defense Specialist, Reckless, Quarterback
        [DisplayName("Assault Set 5 Enabled")] public bool AssaultSet5Enabled { get; set; } = true;
        [DisplayName("Assault Set 5: Reckless")] public bool AssaultSet5_RECKLESS { get; set; } = true;
        [DisplayName("Assault Set 5: Thief")] public bool AssaultSet5_THIEF { get; set; } = false;
        [DisplayName("Assault Set 5: Strongman")] public bool AssaultSet5_STRONGMAN { get; set; } = false;
        [DisplayName("Assault Set 5: Resourceful")] public bool AssaultSet5_RESOURCEFUL { get; set; } = false;
        [DisplayName("Assault Set 5: Trooper")] public bool AssaultSet5_TROOPER { get; set; } = false;
        [DisplayName("Assault Set 5: Close Quarter Specialist")] public bool AssaultSet5_CLOSE_QUARTERS_SPECIALIST { get; set; } = false;
        [DisplayName("Assault Set 5: Cautious")] public bool AssaultSet5_CAUTIOUS { get; set; } = false;
        [DisplayName("Assault Set 5: Biochemist")] public bool AssaultSet5_BIOCHEMIST { get; set; } = false;
        [DisplayName("Assault Set 5: Healer")] public bool AssaultSet5_HEALER { get; set; } = false;
        [DisplayName("Assault Set 5: Quarterback")] public bool AssaultSet5_QUARTERBACK { get; set; } = true;
        [DisplayName("Assault Set 5: Self Defense Specialist")] public bool AssaultSet5_SELF_DEFENSE_SPECIALIST { get; set; } = true;
        [DisplayName("Assault Set 5: Sniperist")] public bool AssaultSet5_SNIPERIST { get; set; } = false;
        [DisplayName("Assault Set 5: Farsighted")] public bool AssaultSet5_FARSIGHTED { get; set; } = false;
        [DisplayName("Assault Set 5: Bombardier")] public bool AssaultSet5_BOMBARDIER { get; set; } = false;

        // ───────────────────────────── Sniper ──────────────────────────────────
        [DisplayName("Sniper Set 1 Enabled")] public bool SniperSet1Enabled { get; set; } = true;
        [DisplayName("Sniper Set 1: Sniperist")] public bool SniperSet1_SNIPERIST { get; set; } = true;
        [DisplayName("Sniper Set 1: Farsighted")] public bool SniperSet1_FARSIGHTED { get; set; } = true;
        [DisplayName("Sniper Set 1: Cautious")] public bool SniperSet1_CAUTIOUS { get; set; } = true;
        [DisplayName("Sniper Set 1: Reckless")] public bool SniperSet1_RECKLESS { get; set; } = true;
        [DisplayName("Sniper Set 1: Thief")] public bool SniperSet1_THIEF { get; set; } = true;
        [DisplayName("Sniper Set 1: Strongman")] public bool SniperSet1_STRONGMAN { get; set; } = true;
        [DisplayName("Sniper Set 1: Resourceful")] public bool SniperSet1_RESOURCEFUL { get; set; } = true;
        [DisplayName("Sniper Set 1: Quarterback")] public bool SniperSet1_QUARTERBACK { get; set; } = true;
        [DisplayName("Sniper Set 1: Healer")] public bool SniperSet1_HEALER { get; set; } = true;
        [DisplayName("Sniper Set 1: Biochemist")] public bool SniperSet1_BIOCHEMIST { get; set; } = true;
        [DisplayName("Sniper Set 1: Self Defense Specialist")] public bool SniperSet1_SELF_DEFENSE_SPECIALIST { get; set; } = true;
        [DisplayName("Sniper Set 1: Bombardier")] public bool SniperSet1_BOMBARDIER { get; set; } = true;
        [DisplayName("Sniper Set 1: Close Quarter Specialist")] public bool SniperSet1_CLOSE_QUARTERS_SPECIALIST { get; set; } = true;
        [DisplayName("Sniper Set 1: Trooper")] public bool SniperSet1_TROOPER { get; set; } = true;

        // Sniper 2: Sniperist, Reckless, Thief
        [DisplayName("Sniper Set 2 Enabled")] public bool SniperSet2Enabled { get; set; } = true;
        [DisplayName("Sniper Set 2: Sniperist")] public bool SniperSet2_SNIPERIST { get; set; } = true;
        [DisplayName("Sniper Set 2: Farsighted")] public bool SniperSet2_FARSIGHTED { get; set; } = false;
        [DisplayName("Sniper Set 2: Cautious")] public bool SniperSet2_CAUTIOUS { get; set; } = false;
        [DisplayName("Sniper Set 2: Reckless")] public bool SniperSet2_RECKLESS { get; set; } = true;
        [DisplayName("Sniper Set 2: Thief")] public bool SniperSet2_THIEF { get; set; } = true;
        [DisplayName("Sniper Set 2: Strongman")] public bool SniperSet2_STRONGMAN { get; set; } = false;
        [DisplayName("Sniper Set 2: Resourceful")] public bool SniperSet2_RESOURCEFUL { get; set; } = false;
        [DisplayName("Sniper Set 2: Quarterback")] public bool SniperSet2_QUARTERBACK { get; set; } = false;
        [DisplayName("Sniper Set 2: Healer")] public bool SniperSet2_HEALER { get; set; } = false;
        [DisplayName("Sniper Set 2: Biochemist")] public bool SniperSet2_BIOCHEMIST { get; set; } = false;
        [DisplayName("Sniper Set 2: Self Defense Specialist")] public bool SniperSet2_SELF_DEFENSE_SPECIALIST { get; set; } = false;
        [DisplayName("Sniper Set 2: Bombardier")] public bool SniperSet2_BOMBARDIER { get; set; } = false;
        [DisplayName("Sniper Set 2: Close Quarter Specialist")] public bool SniperSet2_CLOSE_QUARTERS_SPECIALIST { get; set; } = false;
        [DisplayName("Sniper Set 2: Trooper")] public bool SniperSet2_TROOPER { get; set; } = false;

        // Sniper 3: Sniperist, Cautious, Thief
        [DisplayName("Sniper Set 3 Enabled")] public bool SniperSet3Enabled { get; set; } = true;
        [DisplayName("Sniper Set 3: Sniperist")] public bool SniperSet3_SNIPERIST { get; set; } = true;
        [DisplayName("Sniper Set 3: Farsighted")] public bool SniperSet3_FARSIGHTED { get; set; } = false;
        [DisplayName("Sniper Set 3: Cautious")] public bool SniperSet3_CAUTIOUS { get; set; } = true;
        [DisplayName("Sniper Set 3: Reckless")] public bool SniperSet3_RECKLESS { get; set; } = false;
        [DisplayName("Sniper Set 3: Thief")] public bool SniperSet3_THIEF { get; set; } = true;
        [DisplayName("Sniper Set 3: Strongman")] public bool SniperSet3_STRONGMAN { get; set; } = false;
        [DisplayName("Sniper Set 3: Resourceful")] public bool SniperSet3_RESOURCEFUL { get; set; } = false;
        [DisplayName("Sniper Set 3: Quarterback")] public bool SniperSet3_QUARTERBACK { get; set; } = false;
        [DisplayName("Sniper Set 3: Healer")] public bool SniperSet3_HEALER { get; set; } = false;
        [DisplayName("Sniper Set 3: Biochemist")] public bool SniperSet3_BIOCHEMIST { get; set; } = false;
        [DisplayName("Sniper Set 3: Self Defense Specialist")] public bool SniperSet3_SELF_DEFENSE_SPECIALIST { get; set; } = false;
        [DisplayName("Sniper Set 3: Bombardier")] public bool SniperSet3_BOMBARDIER { get; set; } = false;
        [DisplayName("Sniper Set 3: Close Quarter Specialist")] public bool SniperSet3_CLOSE_QUARTERS_SPECIALIST { get; set; } = false;
        [DisplayName("Sniper Set 3: Trooper")] public bool SniperSet3_TROOPER { get; set; } = false;

        // Sniper 4: Sniperist, Cautious, Farsighted
        [DisplayName("Sniper Set 4 Enabled")] public bool SniperSet4Enabled { get; set; } = true;
        [DisplayName("Sniper Set 4: Sniperist")] public bool SniperSet4_SNIPERIST { get; set; } = true;
        [DisplayName("Sniper Set 4: Farsighted")] public bool SniperSet4_FARSIGHTED { get; set; } = true;
        [DisplayName("Sniper Set 4: Cautious")] public bool SniperSet4_CAUTIOUS { get; set; } = true;
        [DisplayName("Sniper Set 4: Reckless")] public bool SniperSet4_RECKLESS { get; set; } = false;
        [DisplayName("Sniper Set 4: Thief")] public bool SniperSet4_THIEF { get; set; } = false;
        [DisplayName("Sniper Set 4: Strongman")] public bool SniperSet4_STRONGMAN { get; set; } = false;
        [DisplayName("Sniper Set 4: Resourceful")] public bool SniperSet4_RESOURCEFUL { get; set; } = false;
        [DisplayName("Sniper Set 4: Quarterback")] public bool SniperSet4_QUARTERBACK { get; set; } = false;
        [DisplayName("Sniper Set 4: Healer")] public bool SniperSet4_HEALER { get; set; } = false;
        [DisplayName("Sniper Set 4: Biochemist")] public bool SniperSet4_BIOCHEMIST { get; set; } = false;
        [DisplayName("Sniper Set 4: Self Defense Specialist")] public bool SniperSet4_SELF_DEFENSE_SPECIALIST { get; set; } = false;
        [DisplayName("Sniper Set 4: Bombardier")] public bool SniperSet4_BOMBARDIER { get; set; } = false;
        [DisplayName("Sniper Set 4: Close Quarter Specialist")] public bool SniperSet4_CLOSE_QUARTERS_SPECIALIST { get; set; } = false;
        [DisplayName("Sniper Set 4: Trooper")] public bool SniperSet4_TROOPER { get; set; } = false;

        // Sniper 5: Sniperist, Reckless, Cautious
        [DisplayName("Sniper Set 5 Enabled")] public bool SniperSet5Enabled { get; set; } = true;
        [DisplayName("Sniper Set 5: Sniperist")] public bool SniperSet5_SNIPERIST { get; set; } = true;
        [DisplayName("Sniper Set 5: Farsighted")] public bool SniperSet5_FARSIGHTED { get; set; } = false;
        [DisplayName("Sniper Set 5: Cautious")] public bool SniperSet5_CAUTIOUS { get; set; } = true;
        [DisplayName("Sniper Set 5: Reckless")] public bool SniperSet5_RECKLESS { get; set; } = true;
        [DisplayName("Sniper Set 5: Thief")] public bool SniperSet5_THIEF { get; set; } = false;
        [DisplayName("Sniper Set 5: Strongman")] public bool SniperSet5_STRONGMAN { get; set; } = false;
        [DisplayName("Sniper Set 5: Resourceful")] public bool SniperSet5_RESOURCEFUL { get; set; } = false;
        [DisplayName("Sniper Set 5: Quarterback")] public bool SniperSet5_QUARTERBACK { get; set; } = false;
        [DisplayName("Sniper Set 5: Healer")] public bool SniperSet5_HEALER { get; set; } = false;
        [DisplayName("Sniper Set 5: Biochemist")] public bool SniperSet5_BIOCHEMIST { get; set; } = false;
        [DisplayName("Sniper Set 5: Self Defense Specialist")] public bool SniperSet5_SELF_DEFENSE_SPECIALIST { get; set; } = false;
        [DisplayName("Sniper Set 5: Bombardier")] public bool SniperSet5_BOMBARDIER { get; set; } = false;
        [DisplayName("Sniper Set 5: Close Quarter Specialist")] public bool SniperSet5_CLOSE_QUARTERS_SPECIALIST { get; set; } = false;
        [DisplayName("Sniper Set 5: Trooper")] public bool SniperSet5_TROOPER { get; set; } = false;

        // ───────────────────────────── Heavy ───────────────────────────────────
        [DisplayName("Heavy Set 1 Enabled")] public bool HeavySet1Enabled { get; set; } = true;
        [DisplayName("Heavy Set 1: Strongman")] public bool HeavySet1_STRONGMAN { get; set; } = true;
        [DisplayName("Heavy Set 1: Cautious")] public bool HeavySet1_CAUTIOUS { get; set; } = true;
        [DisplayName("Heavy Set 1: Biochemist")] public bool HeavySet1_BIOCHEMIST { get; set; } = true;
        [DisplayName("Heavy Set 1: Reckless")] public bool HeavySet1_RECKLESS { get; set; } = true;
        [DisplayName("Heavy Set 1: Thief")] public bool HeavySet1_THIEF { get; set; } = true;
        [DisplayName("Heavy Set 1: Resourceful")] public bool HeavySet1_RESOURCEFUL { get; set; } = true;
        [DisplayName("Heavy Set 1: Trooper")] public bool HeavySet1_TROOPER { get; set; } = true;
        [DisplayName("Heavy Set 1: Close Quarter Specialist")] public bool HeavySet1_CLOSE_QUARTERS_SPECIALIST { get; set; } = true;
        [DisplayName("Heavy Set 1: Healer")] public bool HeavySet1_HEALER { get; set; } = true;
        [DisplayName("Heavy Set 1: Quarterback")] public bool HeavySet1_QUARTERBACK { get; set; } = true;
        [DisplayName("Heavy Set 1: Self Defense Specialist")] public bool HeavySet1_SELF_DEFENSE_SPECIALIST { get; set; } = true;
        [DisplayName("Heavy Set 1: Sniperist")] public bool HeavySet1_SNIPERIST { get; set; } = true;
        [DisplayName("Heavy Set 1: Farsighted")] public bool HeavySet1_FARSIGHTED { get; set; } = true;
        [DisplayName("Heavy Set 1: Bombardier")] public bool HeavySet1_BOMBARDIER { get; set; } = true;

        // Heavy 2: Strongman, Bombardier, Reckless
        [DisplayName("Heavy Set 2 Enabled")] public bool HeavySet2Enabled { get; set; } = true;
        [DisplayName("Heavy Set 2: Strongman")] public bool HeavySet2_STRONGMAN { get; set; } = true;
        [DisplayName("Heavy Set 2: Cautious")] public bool HeavySet2_CAUTIOUS { get; set; } = false;
        [DisplayName("Heavy Set 2: Biochemist")] public bool HeavySet2_BIOCHEMIST { get; set; } = false;
        [DisplayName("Heavy Set 2: Reckless")] public bool HeavySet2_RECKLESS { get; set; } = true;
        [DisplayName("Heavy Set 2: Thief")] public bool HeavySet2_THIEF { get; set; } = false;
        [DisplayName("Heavy Set 2: Resourceful")] public bool HeavySet2_RESOURCEFUL { get; set; } = false;
        [DisplayName("Heavy Set 2: Trooper")] public bool HeavySet2_TROOPER { get; set; } = false;
        [DisplayName("Heavy Set 2: Close Quarter Specialist")] public bool HeavySet2_CLOSE_QUARTERS_SPECIALIST { get; set; } = false;
        [DisplayName("Heavy Set 2: Healer")] public bool HeavySet2_HEALER { get; set; } = false;
        [DisplayName("Heavy Set 2: Quarterback")] public bool HeavySet2_QUARTERBACK { get; set; } = false;
        [DisplayName("Heavy Set 2: Self Defense Specialist")] public bool HeavySet2_SELF_DEFENSE_SPECIALIST { get; set; } = false;
        [DisplayName("Heavy Set 2: Sniperist")] public bool HeavySet2_SNIPERIST { get; set; } = false;
        [DisplayName("Heavy Set 2: Farsighted")] public bool HeavySet2_FARSIGHTED { get; set; } = false;
        [DisplayName("Heavy Set 2: Bombardier")] public bool HeavySet2_BOMBARDIER { get; set; } = true;

        // Heavy 3: Strongman, Cautious, Reckless
        [DisplayName("Heavy Set 3 Enabled")] public bool HeavySet3Enabled { get; set; } = true;
        [DisplayName("Heavy Set 3: Strongman")] public bool HeavySet3_STRONGMAN { get; set; } = true;
        [DisplayName("Heavy Set 3: Cautious")] public bool HeavySet3_CAUTIOUS { get; set; } = true;
        [DisplayName("Heavy Set 3: Biochemist")] public bool HeavySet3_BIOCHEMIST { get; set; } = false;
        [DisplayName("Heavy Set 3: Reckless")] public bool HeavySet3_RECKLESS { get; set; } = true;
        [DisplayName("Heavy Set 3: Thief")] public bool HeavySet3_THIEF { get; set; } = false;
        [DisplayName("Heavy Set 3: Resourceful")] public bool HeavySet3_RESOURCEFUL { get; set; } = false;
        [DisplayName("Heavy Set 3: Trooper")] public bool HeavySet3_TROOPER { get; set; } = false;
        [DisplayName("Heavy Set 3: Close Quarter Specialist")] public bool HeavySet3_CLOSE_QUARTERS_SPECIALIST { get; set; } = false;
        [DisplayName("Heavy Set 3: Healer")] public bool HeavySet3_HEALER { get; set; } = false;
        [DisplayName("Heavy Set 3: Quarterback")] public bool HeavySet3_QUARTERBACK { get; set; } = false;
        [DisplayName("Heavy Set 3: Self Defense Specialist")] public bool HeavySet3_SELF_DEFENSE_SPECIALIST { get; set; } = false;
        [DisplayName("Heavy Set 3: Sniperist")] public bool HeavySet3_SNIPERIST { get; set; } = false;
        [DisplayName("Heavy Set 3: Farsighted")] public bool HeavySet3_FARSIGHTED { get; set; } = false;
        [DisplayName("Heavy Set 3: Bombardier")] public bool HeavySet3_BOMBARDIER { get; set; } = false; // not requested

        [DisplayName("Heavy Set 4 Enabled")] public bool HeavySet4Enabled { get; set; } = false;
        [DisplayName("Heavy Set 4: Strongman")] public bool HeavySet4_STRONGMAN { get; set; } = false;
        [DisplayName("Heavy Set 4: Cautious")] public bool HeavySet4_CAUTIOUS { get; set; } = false;
        [DisplayName("Heavy Set 4: Biochemist")] public bool HeavySet4_BIOCHEMIST { get; set; } = false;
        [DisplayName("Heavy Set 4: Reckless")] public bool HeavySet4_RECKLESS { get; set; } = false;
        [DisplayName("Heavy Set 4: Thief")] public bool HeavySet4_THIEF { get; set; } = false;
        [DisplayName("Heavy Set 4: Resourceful")] public bool HeavySet4_RESOURCEFUL { get; set; } = false;
        [DisplayName("Heavy Set 4: Trooper")] public bool HeavySet4_TROOPER { get; set; } = false;
        [DisplayName("Heavy Set 4: Close Quarter Specialist")] public bool HeavySet4_CLOSE_QUARTERS_SPECIALIST { get; set; } = false;
        [DisplayName("Heavy Set 4: Healer")] public bool HeavySet4_HEALER { get; set; } = false;
        [DisplayName("Heavy Set 4: Quarterback")] public bool HeavySet4_QUARTERBACK { get; set; } = false;
        [DisplayName("Heavy Set 4: Self Defense Specialist")] public bool HeavySet4_SELF_DEFENSE_SPECIALIST { get; set; } = false;
        [DisplayName("Heavy Set 4: Sniperist")] public bool HeavySet4_SNIPERIST { get; set; } = false;
        [DisplayName("Heavy Set 4: Farsighted")] public bool HeavySet4_FARSIGHTED { get; set; } = false;
        [DisplayName("Heavy Set 4: Bombardier")] public bool HeavySet4_BOMBARDIER { get; set; } = false;

        [DisplayName("Heavy Set 5 Enabled")] public bool HeavySet5Enabled { get; set; } = false;
        [DisplayName("Heavy Set 5: Strongman")] public bool HeavySet5_STRONGMAN { get; set; } = false;
        [DisplayName("Heavy Set 5: Cautious")] public bool HeavySet5_CAUTIOUS { get; set; } = false;
        [DisplayName("Heavy Set 5: Biochemist")] public bool HeavySet5_BIOCHEMIST { get; set; } = false;
        [DisplayName("Heavy Set 5: Reckless")] public bool HeavySet5_RECKLESS { get; set; } = false;
        [DisplayName("Heavy Set 5: Thief")] public bool HeavySet5_THIEF { get; set; } = false;
        [DisplayName("Heavy Set 5: Resourceful")] public bool HeavySet5_RESOURCEFUL { get; set; } = false;
        [DisplayName("Heavy Set 5: Trooper")] public bool HeavySet5_TROOPER { get; set; } = false;
        [DisplayName("Heavy Set 5: Close Quarter Specialist")] public bool HeavySet5_CLOSE_QUARTERS_SPECIALIST { get; set; } = false;
        [DisplayName("Heavy Set 5: Healer")] public bool HeavySet5_HEALER { get; set; } = false;
        [DisplayName("Heavy Set 5: Quarterback")] public bool HeavySet5_QUARTERBACK { get; set; } = false;
        [DisplayName("Heavy Set 5: Self Defense Specialist")] public bool HeavySet5_SELF_DEFENSE_SPECIALIST { get; set; } = false;
        [DisplayName("Heavy Set 5: Sniperist")] public bool HeavySet5_SNIPERIST { get; set; } = false;
        [DisplayName("Heavy Set 5: Farsighted")] public bool HeavySet5_FARSIGHTED { get; set; } = false;
        [DisplayName("Heavy Set 5: Bombardier")] public bool HeavySet5_BOMBARDIER { get; set; } = false;

        // ─────────────────────────── Berserker ────────────────────────────────
        [DisplayName("Berserker Set 1 Enabled")] public bool BerserkerSet1Enabled { get; set; } = true;
        [DisplayName("Berserker Set 1: Strongman")] public bool BerserkerSet1_STRONGMAN { get; set; } = true;
        [DisplayName("Berserker Set 1: Reckless")] public bool BerserkerSet1_RECKLESS { get; set; } = true;
        [DisplayName("Berserker Set 1: Thief")] public bool BerserkerSet1_THIEF { get; set; } = true;
        [DisplayName("Berserker Set 1: Resourceful")] public bool BerserkerSet1_RESOURCEFUL { get; set; } = true;
        [DisplayName("Berserker Set 1: Self Defense Specialist")] public bool BerserkerSet1_SELF_DEFENSE_SPECIALIST { get; set; } = true;
        [DisplayName("Berserker Set 1: Trooper")] public bool BerserkerSet1_TROOPER { get; set; } = true;
        [DisplayName("Berserker Set 1: Close Quarter Specialist")] public bool BerserkerSet1_CLOSE_QUARTERS_SPECIALIST { get; set; } = true;
        [DisplayName("Berserker Set 1: Cautious")] public bool BerserkerSet1_CAUTIOUS { get; set; } = true;
        [DisplayName("Berserker Set 1: Biochemist")] public bool BerserkerSet1_BIOCHEMIST { get; set; } = true;
        [DisplayName("Berserker Set 1: Healer")] public bool BerserkerSet1_HEALER { get; set; } = true;
        [DisplayName("Berserker Set 1: Quarterback")] public bool BerserkerSet1_QUARTERBACK { get; set; } = true;
        [DisplayName("Berserker Set 1: Sniperist")] public bool BerserkerSet1_SNIPERIST { get; set; } = true;
        [DisplayName("Berserker Set 1: Farsighted")] public bool BerserkerSet1_FARSIGHTED { get; set; } = true;
        [DisplayName("Berserker Set 1: Bombardier")] public bool BerserkerSet1_BOMBARDIER { get; set; } = true;

        // Berserker 2: Close Quarter Specialist, Reckless, Quarterback
        [DisplayName("Berserker Set 2 Enabled")] public bool BerserkerSet2Enabled { get; set; } = true;
        [DisplayName("Berserker Set 2: Strongman")] public bool BerserkerSet2_STRONGMAN { get; set; } = false;
        [DisplayName("Berserker Set 2: Reckless")] public bool BerserkerSet2_RECKLESS { get; set; } = true;
        [DisplayName("Berserker Set 2: Thief")] public bool BerserkerSet2_THIEF { get; set; } = false;
        [DisplayName("Berserker Set 2: Resourceful")] public bool BerserkerSet2_RESOURCEFUL { get; set; } = false;
        [DisplayName("Berserker Set 2: Self Defense Specialist")] public bool BerserkerSet2_SELF_DEFENSE_SPECIALIST { get; set; } = false;
        [DisplayName("Berserker Set 2: Trooper")] public bool BerserkerSet2_TROOPER { get; set; } = false;
        [DisplayName("Berserker Set 2: Close Quarter Specialist")] public bool BerserkerSet2_CLOSE_QUARTERS_SPECIALIST { get; set; } = true;
        [DisplayName("Berserker Set 2: Cautious")] public bool BerserkerSet2_CAUTIOUS { get; set; } = false;
        [DisplayName("Berserker Set 2: Biochemist")] public bool BerserkerSet2_BIOCHEMIST { get; set; } = false;
        [DisplayName("Berserker Set 2: Healer")] public bool BerserkerSet2_HEALER { get; set; } = false;
        [DisplayName("Berserker Set 2: Quarterback")] public bool BerserkerSet2_QUARTERBACK { get; set; } = true;
        [DisplayName("Berserker Set 2: Sniperist")] public bool BerserkerSet2_SNIPERIST { get; set; } = false;
        [DisplayName("Berserker Set 2: Farsighted")] public bool BerserkerSet2_FARSIGHTED { get; set; } = false;
        [DisplayName("Berserker Set 2: Bombardier")] public bool BerserkerSet2_BOMBARDIER { get; set; } = false;

        // Berserker 3: Reckless, Farsighted, Sniperist
        [DisplayName("Berserker Set 3 Enabled")] public bool BerserkerSet3Enabled { get; set; } = true;
        [DisplayName("Berserker Set 3: Strongman")] public bool BerserkerSet3_STRONGMAN { get; set; } = false;
        [DisplayName("Berserker Set 3: Reckless")] public bool BerserkerSet3_RECKLESS { get; set; } = true;
        [DisplayName("Berserker Set 3: Thief")] public bool BerserkerSet3_THIEF { get; set; } = false;
        [DisplayName("Berserker Set 3: Resourceful")] public bool BerserkerSet3_RESOURCEFUL { get; set; } = false;
        [DisplayName("Berserker Set 3: Self Defense Specialist")] public bool BerserkerSet3_SELF_DEFENSE_SPECIALIST { get; set; } = false;
        [DisplayName("Berserker Set 3: Trooper")] public bool BerserkerSet3_TROOPER { get; set; } = false;
        [DisplayName("Berserker Set 3: Close Quarter Specialist")] public bool BerserkerSet3_CLOSE_QUARTERS_SPECIALIST { get; set; } = false;
        [DisplayName("Berserker Set 3: Cautious")] public bool BerserkerSet3_CAUTIOUS { get; set; } = false;
        [DisplayName("Berserker Set 3: Biochemist")] public bool BerserkerSet3_BIOCHEMIST { get; set; } = false;
        [DisplayName("Berserker Set 3: Healer")] public bool BerserkerSet3_HEALER { get; set; } = false;
        [DisplayName("Berserker Set 3: Quarterback")] public bool BerserkerSet3_QUARTERBACK { get; set; } = false;
        [DisplayName("Berserker Set 3: Sniperist")] public bool BerserkerSet3_SNIPERIST { get; set; } = true;
        [DisplayName("Berserker Set 3: Farsighted")] public bool BerserkerSet3_FARSIGHTED { get; set; } = true;
        [DisplayName("Berserker Set 3: Bombardier")] public bool BerserkerSet3_BOMBARDIER { get; set; } = false;

        [DisplayName("Berserker Set 4 Enabled")] public bool BerserkerSet4Enabled { get; set; } = false;
        [DisplayName("Berserker Set 4: Strongman")] public bool BerserkerSet4_STRONGMAN { get; set; } = false;
        [DisplayName("Berserker Set 4: Reckless")] public bool BerserkerSet4_RECKLESS { get; set; } = false;
        [DisplayName("Berserker Set 4: Thief")] public bool BerserkerSet4_THIEF { get; set; } = false;
        [DisplayName("Berserker Set 4: Resourceful")] public bool BerserkerSet4_RESOURCEFUL { get; set; } = false;
        [DisplayName("Berserker Set 4: Self Defense Specialist")] public bool BerserkerSet4_SELF_DEFENSE_SPECIALIST { get; set; } = false;
        [DisplayName("Berserker Set 4: Trooper")] public bool BerserkerSet4_TROOPER { get; set; } = false;
        [DisplayName("Berserker Set 4: Close Quarter Specialist")] public bool BerserkerSet4_CLOSE_QUARTERS_SPECIALIST { get; set; } = false;
        [DisplayName("Berserker Set 4: Cautious")] public bool BerserkerSet4_CAUTIOUS { get; set; } = false;
        [DisplayName("Berserker Set 4: Biochemist")] public bool BerserkerSet4_BIOCHEMIST { get; set; } = false;
        [DisplayName("Berserker Set 4: Healer")] public bool BerserkerSet4_HEALER { get; set; } = false;
        [DisplayName("Berserker Set 4: Quarterback")] public bool BerserkerSet4_QUARTERBACK { get; set; } = false;
        [DisplayName("Berserker Set 4: Sniperist")] public bool BerserkerSet4_SNIPERIST { get; set; } = false;
        [DisplayName("Berserker Set 4: Farsighted")] public bool BerserkerSet4_FARSIGHTED { get; set; } = false;
        [DisplayName("Berserker Set 4: Bombardier")] public bool BerserkerSet4_BOMBARDIER { get; set; } = false;

        [DisplayName("Berserker Set 5 Enabled")] public bool BerserkerSet5Enabled { get; set; } = false;
        [DisplayName("Berserker Set 5: Strongman")] public bool BerserkerSet5_STRONGMAN { get; set; } = false;
        [DisplayName("Berserker Set 5: Reckless")] public bool BerserkerSet5_RECKLESS { get; set; } = false;
        [DisplayName("Berserker Set 5: Thief")] public bool BerserkerSet5_THIEF { get; set; } = false;
        [DisplayName("Berserker Set 5: Resourceful")] public bool BerserkerSet5_RESOURCEFUL { get; set; } = false;
        [DisplayName("Berserker Set 5: Self Defense Specialist")] public bool BerserkerSet5_SELF_DEFENSE_SPECIALIST { get; set; } = false;
        [DisplayName("Berserker Set 5: Trooper")] public bool BerserkerSet5_TROOPER { get; set; } = false;
        [DisplayName("Berserker Set 5: Close Quarter Specialist")] public bool BerserkerSet5_CLOSE_QUARTERS_SPECIALIST { get; set; } = false;
        [DisplayName("Berserker Set 5: Cautious")] public bool BerserkerSet5_CAUTIOUS { get; set; } = false;
        [DisplayName("Berserker Set 5: Biochemist")] public bool BerserkerSet5_BIOCHEMIST { get; set; } = false;
        [DisplayName("Berserker Set 5: Healer")] public bool BerserkerSet5_HEALER { get; set; } = false;
        [DisplayName("Berserker Set 5: Quarterback")] public bool BerserkerSet5_QUARTERBACK { get; set; } = false;
        [DisplayName("Berserker Set 5: Sniperist")] public bool BerserkerSet5_SNIPERIST { get; set; } = false;
        [DisplayName("Berserker Set 5: Farsighted")] public bool BerserkerSet5_FARSIGHTED { get; set; } = false;
        [DisplayName("Berserker Set 5: Bombardier")] public bool BerserkerSet5_BOMBARDIER { get; set; } = false;

        // ─────────────────────────── Technician ───────────────────────────────
        [DisplayName("Technician Set 1 Enabled")] public bool TechnicianSet1Enabled { get; set; } = true;
        [DisplayName("Technician Set 1: Resourceful")] public bool TechnicianSet1_RESOURCEFUL { get; set; } = true;
        [DisplayName("Technician Set 1: Quarterback")] public bool TechnicianSet1_QUARTERBACK { get; set; } = true;
        [DisplayName("Technician Set 1: Healer")] public bool TechnicianSet1_HEALER { get; set; } = true;
        [DisplayName("Technician Set 1: Reckless")] public bool TechnicianSet1_RECKLESS { get; set; } = true;
        [DisplayName("Technician Set 1: Thief")] public bool TechnicianSet1_THIEF { get; set; } = true;
        [DisplayName("Technician Set 1: Strongman")] public bool TechnicianSet1_STRONGMAN { get; set; } = true;
        [DisplayName("Technician Set 1: Close Quarter Specialist")] public bool TechnicianSet1_CLOSE_QUARTERS_SPECIALIST { get; set; } = true;
        [DisplayName("Technician Set 1: Cautious")] public bool TechnicianSet1_CAUTIOUS { get; set; } = true;
        [DisplayName("Technician Set 1: Biochemist")] public bool TechnicianSet1_BIOCHEMIST { get; set; } = true;
        [DisplayName("Technician Set 1: Self Defense Specialist")] public bool TechnicianSet1_SELF_DEFENSE_SPECIALIST { get; set; } = true;
        [DisplayName("Technician Set 1: Sniperist")] public bool TechnicianSet1_SNIPERIST { get; set; } = true;
        [DisplayName("Technician Set 1: Farsighted")] public bool TechnicianSet1_FARSIGHTED { get; set; } = true;
        [DisplayName("Technician Set 1: Bombardier")] public bool TechnicianSet1_BOMBARDIER { get; set; } = true;
        [DisplayName("Technician Set 1: Trooper")] public bool TechnicianSet1_TROOPER { get; set; } = true;

        // Technician 2: Healer, Farsighted, Quarterback
        [DisplayName("Technician Set 2 Enabled")] public bool TechnicianSet2Enabled { get; set; } = true;
        [DisplayName("Technician Set 2: Resourceful")] public bool TechnicianSet2_RESOURCEFUL { get; set; } = false;
        [DisplayName("Technician Set 2: Quarterback")] public bool TechnicianSet2_QUARTERBACK { get; set; } = true;
        [DisplayName("Technician Set 2: Healer")] public bool TechnicianSet2_HEALER { get; set; } = true;
        [DisplayName("Technician Set 2: Reckless")] public bool TechnicianSet2_RECKLESS { get; set; } = false;
        [DisplayName("Technician Set 2: Thief")] public bool TechnicianSet2_THIEF { get; set; } = false;
        [DisplayName("Technician Set 2: Strongman")] public bool TechnicianSet2_STRONGMAN { get; set; } = false;
        [DisplayName("Technician Set 2: Close Quarter Specialist")] public bool TechnicianSet2_CLOSE_QUARTERS_SPECIALIST { get; set; } = false;
        [DisplayName("Technician Set 2: Cautious")] public bool TechnicianSet2_CAUTIOUS { get; set; } = false;
        [DisplayName("Technician Set 2: Biochemist")] public bool TechnicianSet2_BIOCHEMIST { get; set; } = false;
        [DisplayName("Technician Set 2: Self Defense Specialist")] public bool TechnicianSet2_SELF_DEFENSE_SPECIALIST { get; set; } = false;
        [DisplayName("Technician Set 2: Sniperist")] public bool TechnicianSet2_SNIPERIST { get; set; } = false;
        [DisplayName("Technician Set 2: Farsighted")] public bool TechnicianSet2_FARSIGHTED { get; set; } = true;
        [DisplayName("Technician Set 2: Bombardier")] public bool TechnicianSet2_BOMBARDIER { get; set; } = false;
        [DisplayName("Technician Set 2: Trooper")] public bool TechnicianSet2_TROOPER { get; set; } = false;

        // Technician 3: Healer, Reckless, Resourceful
        [DisplayName("Technician Set 3 Enabled")] public bool TechnicianSet3Enabled { get; set; } = true;
        [DisplayName("Technician Set 3: Resourceful")] public bool TechnicianSet3_RESOURCEFUL { get; set; } = true;
        [DisplayName("Technician Set 3: Quarterback")] public bool TechnicianSet3_QUARTERBACK { get; set; } = false;
        [DisplayName("Technician Set 3: Healer")] public bool TechnicianSet3_HEALER { get; set; } = true;
        [DisplayName("Technician Set 3: Reckless")] public bool TechnicianSet3_RECKLESS { get; set; } = true;
        [DisplayName("Technician Set 3: Thief")] public bool TechnicianSet3_THIEF { get; set; } = false;
        [DisplayName("Technician Set 3: Strongman")] public bool TechnicianSet3_STRONGMAN { get; set; } = false;
        [DisplayName("Technician Set 3: Close Quarter Specialist")] public bool TechnicianSet3_CLOSE_QUARTERS_SPECIALIST { get; set; } = false;
        [DisplayName("Technician Set 3: Cautious")] public bool TechnicianSet3_CAUTIOUS { get; set; } = false;
        [DisplayName("Technician Set 3: Biochemist")] public bool TechnicianSet3_BIOCHEMIST { get; set; } = false;
        [DisplayName("Technician Set 3: Self Defense Specialist")] public bool TechnicianSet3_SELF_DEFENSE_SPECIALIST { get; set; } = false;
        [DisplayName("Technician Set 3: Sniperist")] public bool TechnicianSet3_SNIPERIST { get; set; } = false;
        [DisplayName("Technician Set 3: Farsighted")] public bool TechnicianSet3_FARSIGHTED { get; set; } = false;
        [DisplayName("Technician Set 3: Bombardier")] public bool TechnicianSet3_BOMBARDIER { get; set; } = false;
        [DisplayName("Technician Set 3: Trooper")] public bool TechnicianSet3_TROOPER { get; set; } = false;

        // Technician 4: Self Defense Specialist, Reckless, Healer
        [DisplayName("Technician Set 4 Enabled")] public bool TechnicianSet4Enabled { get; set; } = true;
        [DisplayName("Technician Set 4: Resourceful")] public bool TechnicianSet4_RESOURCEFUL { get; set; } = false;
        [DisplayName("Technician Set 4: Quarterback")] public bool TechnicianSet4_QUARTERBACK { get; set; } = false;
        [DisplayName("Technician Set 4: Healer")] public bool TechnicianSet4_HEALER { get; set; } = true;
        [DisplayName("Technician Set 4: Reckless")] public bool TechnicianSet4_RECKLESS { get; set; } = true;
        [DisplayName("Technician Set 4: Thief")] public bool TechnicianSet4_THIEF { get; set; } = false;
        [DisplayName("Technician Set 4: Strongman")] public bool TechnicianSet4_STRONGMAN { get; set; } = false;
        [DisplayName("Technician Set 4: Close Quarter Specialist")] public bool TechnicianSet4_CLOSE_QUARTERS_SPECIALIST { get; set; } = false;
        [DisplayName("Technician Set 4: Cautious")] public bool TechnicianSet4_CAUTIOUS { get; set; } = false;
        [DisplayName("Technician Set 4: Biochemist")] public bool TechnicianSet4_BIOCHEMIST { get; set; } = false;
        [DisplayName("Technician Set 4: Self Defense Specialist")] public bool TechnicianSet4_SELF_DEFENSE_SPECIALIST { get; set; } = true;
        [DisplayName("Technician Set 4: Sniperist")] public bool TechnicianSet4_SNIPERIST { get; set; } = false;
        [DisplayName("Technician Set 4: Farsighted")] public bool TechnicianSet4_FARSIGHTED { get; set; } = false;
        [DisplayName("Technician Set 4: Bombardier")] public bool TechnicianSet4_BOMBARDIER { get; set; } = false;
        [DisplayName("Technician Set 4: Trooper")] public bool TechnicianSet4_TROOPER { get; set; } = false;

        // Technician 5: Resourceful, Healer, Quarterback
        [DisplayName("Technician Set 5 Enabled")] public bool TechnicianSet5Enabled { get; set; } = true;
        [DisplayName("Technician Set 5: Resourceful")] public bool TechnicianSet5_RESOURCEFUL { get; set; } = true;
        [DisplayName("Technician Set 5: Quarterback")] public bool TechnicianSet5_QUARTERBACK { get; set; } = true;
        [DisplayName("Technician Set 5: Healer")] public bool TechnicianSet5_HEALER { get; set; } = true;
        [DisplayName("Technician Set 5: Reckless")] public bool TechnicianSet5_RECKLESS { get; set; } = false;
        [DisplayName("Technician Set 5: Thief")] public bool TechnicianSet5_THIEF { get; set; } = false;
        [DisplayName("Technician Set 5: Strongman")] public bool TechnicianSet5_STRONGMAN { get; set; } = false;
        [DisplayName("Technician Set 5: Close Quarter Specialist")] public bool TechnicianSet5_CLOSE_QUARTERS_SPECIALIST { get; set; } = false;
        [DisplayName("Technician Set 5: Cautious")] public bool TechnicianSet5_CAUTIOUS { get; set; } = false;
        [DisplayName("Technician Set 5: Biochemist")] public bool TechnicianSet5_BIOCHEMIST { get; set; } = false;
        [DisplayName("Technician Set 5: Self Defense Specialist")] public bool TechnicianSet5_SELF_DEFENSE_SPECIALIST { get; set; } = false;
        [DisplayName("Technician Set 5: Sniperist")] public bool TechnicianSet5_SNIPERIST { get; set; } = false;
        [DisplayName("Technician Set 5: Farsighted")] public bool TechnicianSet5_FARSIGHTED { get; set; } = false;
        [DisplayName("Technician Set 5: Bombardier")] public bool TechnicianSet5_BOMBARDIER { get; set; } = false;
        [DisplayName("Technician Set 5: Trooper")] public bool TechnicianSet5_TROOPER { get; set; } = false;

        // ─────────────────────────── Infiltrator ──────────────────────────────
        [DisplayName("Infiltrator Set 1 Enabled")] public bool InfiltratorSet1Enabled { get; set; } = true;
        [DisplayName("Infiltrator Set 1: Thief")] public bool InfiltratorSet1_THIEF { get; set; } = true;
        [DisplayName("Infiltrator Set 1: Cautious")] public bool InfiltratorSet1_CAUTIOUS { get; set; } = true;
        [DisplayName("Infiltrator Set 1: Resourceful")] public bool InfiltratorSet1_RESOURCEFUL { get; set; } = true;
        [DisplayName("Infiltrator Set 1: Reckless")] public bool InfiltratorSet1_RECKLESS { get; set; } = true;
        [DisplayName("Infiltrator Set 1: Strongman")] public bool InfiltratorSet1_STRONGMAN { get; set; } = true;
        [DisplayName("Infiltrator Set 1: Trooper")] public bool InfiltratorSet1_TROOPER { get; set; } = true;
        [DisplayName("Infiltrator Set 1: Close Quarter Specialist")] public bool InfiltratorSet1_CLOSE_QUARTERS_SPECIALIST { get; set; } = true;
        [DisplayName("Infiltrator Set 1: Biochemist")] public bool InfiltratorSet1_BIOCHEMIST { get; set; } = true;
        [DisplayName("Infiltrator Set 1: Healer")] public bool InfiltratorSet1_HEALER { get; set; } = true;
        [DisplayName("Infiltrator Set 1: Quarterback")] public bool InfiltratorSet1_QUARTERBACK { get; set; } = true;
        [DisplayName("Infiltrator Set 1: Self Defense Specialist")] public bool InfiltratorSet1_SELF_DEFENSE_SPECIALIST { get; set; } = true;
        [DisplayName("Infiltrator Set 1: Sniperist")] public bool InfiltratorSet1_SNIPERIST { get; set; } = true;
        [DisplayName("Infiltrator Set 1: Farsighted")] public bool InfiltratorSet1_FARSIGHTED { get; set; } = true;
        [DisplayName("Infiltrator Set 1: Bombardier")] public bool InfiltratorSet1_BOMBARDIER { get; set; } = true;

        // Infiltrator 2: Self Defense Specialist, Reckless, Thief
        [DisplayName("Infiltrator Set 2 Enabled")] public bool InfiltratorSet2Enabled { get; set; } = true;
        [DisplayName("Infiltrator Set 2: Thief")] public bool InfiltratorSet2_THIEF { get; set; } = true;
        [DisplayName("Infiltrator Set 2: Cautious")] public bool InfiltratorSet2_CAUTIOUS { get; set; } = false;
        [DisplayName("Infiltrator Set 2: Resourceful")] public bool InfiltratorSet2_RESOURCEFUL { get; set; } = false;
        [DisplayName("Infiltrator Set 2: Reckless")] public bool InfiltratorSet2_RECKLESS { get; set; } = true;
        [DisplayName("Infiltrator Set 2: Strongman")] public bool InfiltratorSet2_STRONGMAN { get; set; } = false;
        [DisplayName("Infiltrator Set 2: Trooper")] public bool InfiltratorSet2_TROOPER { get; set; } = false;
        [DisplayName("Infiltrator Set 2: Close Quarter Specialist")] public bool InfiltratorSet2_CLOSE_QUARTERS_SPECIALIST { get; set; } = false;
        [DisplayName("Infiltrator Set 2: Biochemist")] public bool InfiltratorSet2_BIOCHEMIST { get; set; } = false;
        [DisplayName("Infiltrator Set 2: Healer")] public bool InfiltratorSet2_HEALER { get; set; } = false;
        [DisplayName("Infiltrator Set 2: Quarterback")] public bool InfiltratorSet2_QUARTERBACK { get; set; } = false;
        [DisplayName("Infiltrator Set 2: Self Defense Specialist")] public bool InfiltratorSet2_SELF_DEFENSE_SPECIALIST { get; set; } = true;
        [DisplayName("Infiltrator Set 2: Sniperist")] public bool InfiltratorSet2_SNIPERIST { get; set; } = false;
        [DisplayName("Infiltrator Set 2: Farsighted")] public bool InfiltratorSet2_FARSIGHTED { get; set; } = false;
        [DisplayName("Infiltrator Set 2: Bombardier")] public bool InfiltratorSet2_BOMBARDIER { get; set; } = false;

        // Infiltrator 3: Close Quarter Specialist, Reckless, Thief
        [DisplayName("Infiltrator Set 3 Enabled")] public bool InfiltratorSet3Enabled { get; set; } = true;
        [DisplayName("Infiltrator Set 3: Thief")] public bool InfiltratorSet3_THIEF { get; set; } = true;
        [DisplayName("Infiltrator Set 3: Cautious")] public bool InfiltratorSet3_CAUTIOUS { get; set; } = false;
        [DisplayName("Infiltrator Set 3: Resourceful")] public bool InfiltratorSet3_RESOURCEFUL { get; set; } = false;
        [DisplayName("Infiltrator Set 3: Reckless")] public bool InfiltratorSet3_RECKLESS { get; set; } = true;
        [DisplayName("Infiltrator Set 3: Strongman")] public bool InfiltratorSet3_STRONGMAN { get; set; } = false;
        [DisplayName("Infiltrator Set 3: Trooper")] public bool InfiltratorSet3_TROOPER { get; set; } = false;
        [DisplayName("Infiltrator Set 3: Close Quarter Specialist")] public bool InfiltratorSet3_CLOSE_QUARTERS_SPECIALIST { get; set; } = true;
        [DisplayName("Infiltrator Set 3: Biochemist")] public bool InfiltratorSet3_BIOCHEMIST { get; set; } = false;
        [DisplayName("Infiltrator Set 3: Healer")] public bool InfiltratorSet3_HEALER { get; set; } = false;
        [DisplayName("Infiltrator Set 3: Quarterback")] public bool InfiltratorSet3_QUARTERBACK { get; set; } = false;
        [DisplayName("Infiltrator Set 3: Self Defense Specialist")] public bool InfiltratorSet3_SELF_DEFENSE_SPECIALIST { get; set; } = false;
        [DisplayName("Infiltrator Set 3: Sniperist")] public bool InfiltratorSet3_SNIPERIST { get; set; } = false;
        [DisplayName("Infiltrator Set 3: Farsighted")] public bool InfiltratorSet3_FARSIGHTED { get; set; } = false;
        [DisplayName("Infiltrator Set 3: Bombardier")] public bool InfiltratorSet3_BOMBARDIER { get; set; } = false;

        [DisplayName("Infiltrator Set 4 Enabled")] public bool InfiltratorSet4Enabled { get; set; } = false;
        [DisplayName("Infiltrator Set 4: Thief")] public bool InfiltratorSet4_THIEF { get; set; } = false;
        [DisplayName("Infiltrator Set 4: Cautious")] public bool InfiltratorSet4_CAUTIOUS { get; set; } = false;
        [DisplayName("Infiltrator Set 4: Resourceful")] public bool InfiltratorSet4_RESOURCEFUL { get; set; } = false;
        [DisplayName("Infiltrator Set 4: Reckless")] public bool InfiltratorSet4_RECKLESS { get; set; } = false;
        [DisplayName("Infiltrator Set 4: Strongman")] public bool InfiltratorSet4_STRONGMAN { get; set; } = false;
        [DisplayName("Infiltrator Set 4: Trooper")] public bool InfiltratorSet4_TROOPER { get; set; } = false;
        [DisplayName("Infiltrator Set 4: Close Quarter Specialist")] public bool InfiltratorSet4_CLOSE_QUARTERS_SPECIALIST { get; set; } = false;
        [DisplayName("Infiltrator Set 4: Biochemist")] public bool InfiltratorSet4_BIOCHEMIST { get; set; } = false;
        [DisplayName("Infiltrator Set 4: Healer")] public bool InfiltratorSet4_HEALER { get; set; } = false;
        [DisplayName("Infiltrator Set 4: Quarterback")] public bool InfiltratorSet4_QUARTERBACK { get; set; } = false;
        [DisplayName("Infiltrator Set 4: Self Defense Specialist")] public bool InfiltratorSet4_SELF_DEFENSE_SPECIALIST { get; set; } = false;
        [DisplayName("Infiltrator Set 4: Sniperist")] public bool InfiltratorSet4_SNIPERIST { get; set; } = false;
        [DisplayName("Infiltrator Set 4: Farsighted")] public bool InfiltratorSet4_FARSIGHTED { get; set; } = false;
        [DisplayName("Infiltrator Set 4: Bombardier")] public bool InfiltratorSet4_BOMBARDIER { get; set; } = false;

        [DisplayName("Infiltrator Set 5 Enabled")] public bool InfiltratorSet5Enabled { get; set; } = false;
        [DisplayName("Infiltrator Set 5: Thief")] public bool InfiltratorSet5_THIEF { get; set; } = false;
        [DisplayName("Infiltrator Set 5: Cautious")] public bool InfiltratorSet5_CAUTIOUS { get; set; } = false;
        [DisplayName("Infiltrator Set 5: Resourceful")] public bool InfiltratorSet5_RESOURCEFUL { get; set; } = false;
        [DisplayName("Infiltrator Set 5: Reckless")] public bool InfiltratorSet5_RECKLESS { get; set; } = false;
        [DisplayName("Infiltrator Set 5: Strongman")] public bool InfiltratorSet5_STRONGMAN { get; set; } = false;
        [DisplayName("Infiltrator Set 5: Trooper")] public bool InfiltratorSet5_TROOPER { get; set; } = false;
        [DisplayName("Infiltrator Set 5: Close Quarter Specialist")] public bool InfiltratorSet5_CLOSE_QUARTERS_SPECIALIST { get; set; } = false;
        [DisplayName("Infiltrator Set 5: Biochemist")] public bool InfiltratorSet5_BIOCHEMIST { get; set; } = false;
        [DisplayName("Infiltrator Set 5: Healer")] public bool InfiltratorSet5_HEALER { get; set; } = false;
        [DisplayName("Infiltrator Set 5: Quarterback")] public bool InfiltratorSet5_QUARTERBACK { get; set; } = false;
        [DisplayName("Infiltrator Set 5: Self Defense Specialist")] public bool InfiltratorSet5_SELF_DEFENSE_SPECIALIST { get; set; } = false;
        [DisplayName("Infiltrator Set 5: Sniperist")] public bool InfiltratorSet5_SNIPERIST { get; set; } = false;
        [DisplayName("Infiltrator Set 5: Farsighted")] public bool InfiltratorSet5_FARSIGHTED { get; set; } = false;
        [DisplayName("Infiltrator Set 5: Bombardier")] public bool InfiltratorSet5_BOMBARDIER { get; set; } = false;

        // ───────────────────────────── Priest ─────────────────────────────────
        [DisplayName("Priest Set 1 Enabled")] public bool PriestSet1Enabled { get; set; } = true;
        [DisplayName("Priest Set 1: Healer")] public bool PriestSet1_HEALER { get; set; } = true;
        [DisplayName("Priest Set 1: Resourceful")] public bool PriestSet1_RESOURCEFUL { get; set; } = true;
        [DisplayName("Priest Set 1: Cautious")] public bool PriestSet1_CAUTIOUS { get; set; } = true;
        [DisplayName("Priest Set 1: Farsighted")] public bool PriestSet1_FARSIGHTED { get; set; } = true;
        [DisplayName("Priest Set 1: Reckless")] public bool PriestSet1_RECKLESS { get; set; } = true;
        [DisplayName("Priest Set 1: Thief")] public bool PriestSet1_THIEF { get; set; } = true;
        [DisplayName("Priest Set 1: Strongman")] public bool PriestSet1_STRONGMAN { get; set; } = true;
        [DisplayName("Priest Set 1: Close Quarter Specialist")] public bool PriestSet1_CLOSE_QUARTERS_SPECIALIST { get; set; } = true;
        [DisplayName("Priest Set 1: Biochemist")] public bool PriestSet1_BIOCHEMIST { get; set; } = true;
        [DisplayName("Priest Set 1: Quarterback")] public bool PriestSet1_QUARTERBACK { get; set; } = true;
        [DisplayName("Priest Set 1: Self Defense Specialist")] public bool PriestSet1_SELF_DEFENSE_SPECIALIST { get; set; } = true;
        [DisplayName("Priest Set 1: Sniperist")] public bool PriestSet1_SNIPERIST { get; set; } = true;
        [DisplayName("Priest Set 1: Bombardier")] public bool PriestSet1_BOMBARDIER { get; set; } = true;
        [DisplayName("Priest Set 1: Trooper")] public bool PriestSet1_TROOPER { get; set; } = true;

        // Priest 2: Farsighted, Quarterback, Thief
        [DisplayName("Priest Set 2 Enabled")] public bool PriestSet2Enabled { get; set; } = true;
        [DisplayName("Priest Set 2: Healer")] public bool PriestSet2_HEALER { get; set; } = false;
        [DisplayName("Priest Set 2: Resourceful")] public bool PriestSet2_RESOURCEFUL { get; set; } = false;
        [DisplayName("Priest Set 2: Cautious")] public bool PriestSet2_CAUTIOUS { get; set; } = false;
        [DisplayName("Priest Set 2: Farsighted")] public bool PriestSet2_FARSIGHTED { get; set; } = true;
        [DisplayName("Priest Set 2: Reckless")] public bool PriestSet2_RECKLESS { get; set; } = false;
        [DisplayName("Priest Set 2: Thief")] public bool PriestSet2_THIEF { get; set; } = true;
        [DisplayName("Priest Set 2: Strongman")] public bool PriestSet2_STRONGMAN { get; set; } = false;
        [DisplayName("Priest Set 2: Close Quarter Specialist")] public bool PriestSet2_CLOSE_QUARTERS_SPECIALIST { get; set; } = false;
        [DisplayName("Priest Set 2: Biochemist")] public bool PriestSet2_BIOCHEMIST { get; set; } = false;
        [DisplayName("Priest Set 2: Quarterback")] public bool PriestSet2_QUARTERBACK { get; set; } = true;
        [DisplayName("Priest Set 2: Self Defense Specialist")] public bool PriestSet2_SELF_DEFENSE_SPECIALIST { get; set; } = false;
        [DisplayName("Priest Set 2: Sniperist")] public bool PriestSet2_SNIPERIST { get; set; } = false;
        [DisplayName("Priest Set 2: Bombardier")] public bool PriestSet2_BOMBARDIER { get; set; } = false;
        [DisplayName("Priest Set 2: Trooper")] public bool PriestSet2_TROOPER { get; set; } = false;

        // Priest 3: Healer, Bombardier, Quarterback
        [DisplayName("Priest Set 3 Enabled")] public bool PriestSet3Enabled { get; set; } = true;
        [DisplayName("Priest Set 3: Healer")] public bool PriestSet3_HEALER { get; set; } = true;
        [DisplayName("Priest Set 3: Resourceful")] public bool PriestSet3_RESOURCEFUL { get; set; } = false;
        [DisplayName("Priest Set 3: Cautious")] public bool PriestSet3_CAUTIOUS { get; set; } = false;
        [DisplayName("Priest Set 3: Farsighted")] public bool PriestSet3_FARSIGHTED { get; set; } = false;
        [DisplayName("Priest Set 3: Reckless")] public bool PriestSet3_RECKLESS { get; set; } = false;
        [DisplayName("Priest Set 3: Thief")] public bool PriestSet3_THIEF { get; set; } = false;
        [DisplayName("Priest Set 3: Strongman")] public bool PriestSet3_STRONGMAN { get; set; } = false;
        [DisplayName("Priest Set 3: Close Quarter Specialist")] public bool PriestSet3_CLOSE_QUARTERS_SPECIALIST { get; set; } = false;
        [DisplayName("Priest Set 3: Biochemist")] public bool PriestSet3_BIOCHEMIST { get; set; } = false;
        [DisplayName("Priest Set 3: Quarterback")] public bool PriestSet3_QUARTERBACK { get; set; } = true;
        [DisplayName("Priest Set 3: Self Defense Specialist")] public bool PriestSet3_SELF_DEFENSE_SPECIALIST { get; set; } = false;
        [DisplayName("Priest Set 3: Sniperist")] public bool PriestSet3_SNIPERIST { get; set; } = false;
        [DisplayName("Priest Set 3: Bombardier")] public bool PriestSet3_BOMBARDIER { get; set; } = true;
        [DisplayName("Priest Set 3: Trooper")] public bool PriestSet3_TROOPER { get; set; } = false;

        // Priest 4: Farsighted, Reckless, Thief
        [DisplayName("Priest Set 4 Enabled")] public bool PriestSet4Enabled { get; set; } = true;
        [DisplayName("Priest Set 4: Healer")] public bool PriestSet4_HEALER { get; set; } = false;
        [DisplayName("Priest Set 4: Resourceful")] public bool PriestSet4_RESOURCEFUL { get; set; } = false;
        [DisplayName("Priest Set 4: Cautious")] public bool PriestSet4_CAUTIOUS { get; set; } = false;
        [DisplayName("Priest Set 4: Farsighted")] public bool PriestSet4_FARSIGHTED { get; set; } = true;
        [DisplayName("Priest Set 4: Reckless")] public bool PriestSet4_RECKLESS { get; set; } = true;
        [DisplayName("Priest Set 4: Thief")] public bool PriestSet4_THIEF { get; set; } = true;
        [DisplayName("Priest Set 4: Strongman")] public bool PriestSet4_STRONGMAN { get; set; } = false;
        [DisplayName("Priest Set 4: Close Quarter Specialist")] public bool PriestSet4_CLOSE_QUARTERS_SPECIALIST { get; set; } = false;
        [DisplayName("Priest Set 4: Biochemist")] public bool PriestSet4_BIOCHEMIST { get; set; } = false;
        [DisplayName("Priest Set 4: Quarterback")] public bool PriestSet4_QUARTERBACK { get; set; } = false;
        [DisplayName("Priest Set 4: Self Defense Specialist")] public bool PriestSet4_SELF_DEFENSE_SPECIALIST { get; set; } = false;
        [DisplayName("Priest Set 4: Sniperist")] public bool PriestSet4_SNIPERIST { get; set; } = false;
        [DisplayName("Priest Set 4: Bombardier")] public bool PriestSet4_BOMBARDIER { get; set; } = false;
        [DisplayName("Priest Set 4: Trooper")] public bool PriestSet4_TROOPER { get; set; } = false;

        // Priest 5: Healer, Farsighted, Quarterback
        [DisplayName("Priest Set 5 Enabled")] public bool PriestSet5Enabled { get; set; } = true;
        [DisplayName("Priest Set 5: Healer")] public bool PriestSet5_HEALER { get; set; } = true;
        [DisplayName("Priest Set 5: Resourceful")] public bool PriestSet5_RESOURCEFUL { get; set; } = false;
        [DisplayName("Priest Set 5: Cautious")] public bool PriestSet5_CAUTIOUS { get; set; } = false;
        [DisplayName("Priest Set 5: Farsighted")] public bool PriestSet5_FARSIGHTED { get; set; } = true;
        [DisplayName("Priest Set 5: Reckless")] public bool PriestSet5_RECKLESS { get; set; } = false;
        [DisplayName("Priest Set 5: Thief")] public bool PriestSet5_THIEF { get; set; } = false;
        [DisplayName("Priest Set 5: Strongman")] public bool PriestSet5_STRONGMAN { get; set; } = false;
        [DisplayName("Priest Set 5: Close Quarter Specialist")] public bool PriestSet5_CLOSE_QUARTERS_SPECIALIST { get; set; } = false;
        [DisplayName("Priest Set 5: Biochemist")] public bool PriestSet5_BIOCHEMIST { get; set; } = false;
        [DisplayName("Priest Set 5: Quarterback")] public bool PriestSet5_QUARTERBACK { get; set; } = true;
        [DisplayName("Priest Set 5: Self Defense Specialist")] public bool PriestSet5_SELF_DEFENSE_SPECIALIST { get; set; } = false;
        [DisplayName("Priest Set 5: Sniperist")] public bool PriestSet5_SNIPERIST { get; set; } = false;
        [DisplayName("Priest Set 5: Bombardier")] public bool PriestSet5_BOMBARDIER { get; set; } = false;
        [DisplayName("Priest Set 5: Trooper")] public bool PriestSet5_TROOPER { get; set; } = false;
    }
}
