using System.Collections.Generic;
using PhoenixPoint.Modding;

namespace SelectClassTraits
{
    /// <summary>
    /// Full config using proper Phoenix Point field-based pattern with ConfigField attributes
    /// </summary>
    public class SelectClassTraitsConfig : ModConfig
    {
        // ─────────────────────────── Global Options ───────────────────────────
        [ConfigField(text: "Debug Logging")]
        public bool DebugLogging = false;

        [ConfigField(text: "Randomize Perk Levels")]
        public bool RandomizePerkLevels = true;

        [ConfigField(text: "Allowed Perk Levels (comma-separated 2-7)")]
        public string AllowedPerkLevelsStr = "2,3,4,5,6,7";

        // ───────────────────────────── Assault ────────────────────────────────
        [ConfigField(text: "Assault Set 1 Enabled")] public bool AssaultSet1Enabled = true;
        [ConfigField(text: "Assault Set 1: Reckless")] public bool AssaultSet1_RECKLESS = true;
        [ConfigField(text: "Assault Set 1: Thief")] public bool AssaultSet1_THIEF = true;
        [ConfigField(text: "Assault Set 1: Strongman")] public bool AssaultSet1_STRONGMAN = true;
        [ConfigField(text: "Assault Set 1: Resourceful")] public bool AssaultSet1_RESOURCEFUL = true;
        [ConfigField(text: "Assault Set 1: Trooper")] public bool AssaultSet1_TROOPER = true;
        [ConfigField(text: "Assault Set 1: Close Quarter Specialist")] public bool AssaultSet1_CLOSE_QUARTERS_SPECIALIST = true;
        [ConfigField(text: "Assault Set 1: Cautious")] public bool AssaultSet1_CAUTIOUS = true;
        [ConfigField(text: "Assault Set 1: Biochemist")] public bool AssaultSet1_BIOCHEMIST = true;
        [ConfigField(text: "Assault Set 1: Healer")] public bool AssaultSet1_HEALER = true;
        [ConfigField(text: "Assault Set 1: Quarterback")] public bool AssaultSet1_QUARTERBACK = true;
        [ConfigField(text: "Assault Set 1: Self Defense Specialist")] public bool AssaultSet1_SELF_DEFENSE_SPECIALIST = true;
        [ConfigField(text: "Assault Set 1: Sniperist")] public bool AssaultSet1_SNIPERIST = true;
        [ConfigField(text: "Assault Set 1: Farsighted")] public bool AssaultSet1_FARSIGHTED = true;
        [ConfigField(text: "Assault Set 1: Bombardier")] public bool AssaultSet1_BOMBARDIER = true;

        [ConfigField(text: "Assault Set 2 Enabled")] public bool AssaultSet2Enabled = true;
        [ConfigField(text: "Assault Set 2: Reckless")] public bool AssaultSet2_RECKLESS = true;
        [ConfigField(text: "Assault Set 2: Thief")] public bool AssaultSet2_THIEF = false;
        [ConfigField(text: "Assault Set 2: Strongman")] public bool AssaultSet2_STRONGMAN = false;
        [ConfigField(text: "Assault Set 2: Resourceful")] public bool AssaultSet2_RESOURCEFUL = false;
        [ConfigField(text: "Assault Set 2: Trooper")] public bool AssaultSet2_TROOPER = true;
        [ConfigField(text: "Assault Set 2: Close Quarter Specialist")] public bool AssaultSet2_CLOSE_QUARTERS_SPECIALIST = true;
        [ConfigField(text: "Assault Set 2: Cautious")] public bool AssaultSet2_CAUTIOUS = false;
        [ConfigField(text: "Assault Set 2: Biochemist")] public bool AssaultSet2_BIOCHEMIST = false;
        [ConfigField(text: "Assault Set 2: Healer")] public bool AssaultSet2_HEALER = false;
        [ConfigField(text: "Assault Set 2: Quarterback")] public bool AssaultSet2_QUARTERBACK = false;
        [ConfigField(text: "Assault Set 2: Self Defense Specialist")] public bool AssaultSet2_SELF_DEFENSE_SPECIALIST = false;
        [ConfigField(text: "Assault Set 2: Sniperist")] public bool AssaultSet2_SNIPERIST = false;
        [ConfigField(text: "Assault Set 2: Farsighted")] public bool AssaultSet2_FARSIGHTED = false;
        [ConfigField(text: "Assault Set 2: Bombardier")] public bool AssaultSet2_BOMBARDIER = false;

        [ConfigField(text: "Assault Set 3 Enabled")] public bool AssaultSet3Enabled = true;
        [ConfigField(text: "Assault Set 3: Reckless")] public bool AssaultSet3_RECKLESS = true;
        [ConfigField(text: "Assault Set 3: Thief")] public bool AssaultSet3_THIEF = true;
        [ConfigField(text: "Assault Set 3: Strongman")] public bool AssaultSet3_STRONGMAN = false;
        [ConfigField(text: "Assault Set 3: Resourceful")] public bool AssaultSet3_RESOURCEFUL = false;
        [ConfigField(text: "Assault Set 3: Trooper")] public bool AssaultSet3_TROOPER = false;
        [ConfigField(text: "Assault Set 3: Close Quarter Specialist")] public bool AssaultSet3_CLOSE_QUARTERS_SPECIALIST = true;
        [ConfigField(text: "Assault Set 3: Cautious")] public bool AssaultSet3_CAUTIOUS = false;
        [ConfigField(text: "Assault Set 3: Biochemist")] public bool AssaultSet3_BIOCHEMIST = false;
        [ConfigField(text: "Assault Set 3: Healer")] public bool AssaultSet3_HEALER = false;
        [ConfigField(text: "Assault Set 3: Quarterback")] public bool AssaultSet3_QUARTERBACK = false;
        [ConfigField(text: "Assault Set 3: Self Defense Specialist")] public bool AssaultSet3_SELF_DEFENSE_SPECIALIST = false;
        [ConfigField(text: "Assault Set 3: Sniperist")] public bool AssaultSet3_SNIPERIST = false;
        [ConfigField(text: "Assault Set 3: Farsighted")] public bool AssaultSet3_FARSIGHTED = false;
        [ConfigField(text: "Assault Set 3: Bombardier")] public bool AssaultSet3_BOMBARDIER = false;

        [ConfigField(text: "Assault Set 4 Enabled")] public bool AssaultSet4Enabled = true;
        [ConfigField(text: "Assault Set 4: Reckless")] public bool AssaultSet4_RECKLESS = false;
        [ConfigField(text: "Assault Set 4: Thief")] public bool AssaultSet4_THIEF = false;
        [ConfigField(text: "Assault Set 4: Strongman")] public bool AssaultSet4_STRONGMAN = true;
        [ConfigField(text: "Assault Set 4: Resourceful")] public bool AssaultSet4_RESOURCEFUL = true;
        [ConfigField(text: "Assault Set 4: Trooper")] public bool AssaultSet4_TROOPER = true;
        [ConfigField(text: "Assault Set 4: Close Quarter Specialist")] public bool AssaultSet4_CLOSE_QUARTERS_SPECIALIST = false;
        [ConfigField(text: "Assault Set 4: Cautious")] public bool AssaultSet4_CAUTIOUS = false;
        [ConfigField(text: "Assault Set 4: Biochemist")] public bool AssaultSet4_BIOCHEMIST = false;
        [ConfigField(text: "Assault Set 4: Healer")] public bool AssaultSet4_HEALER = true;
        [ConfigField(text: "Assault Set 4: Quarterback")] public bool AssaultSet4_QUARTERBACK = true;
        [ConfigField(text: "Assault Set 4: Self Defense Specialist")] public bool AssaultSet4_SELF_DEFENSE_SPECIALIST = false;
        [ConfigField(text: "Assault Set 4: Sniperist")] public bool AssaultSet4_SNIPERIST = false;
        [ConfigField(text: "Assault Set 4: Farsighted")] public bool AssaultSet4_FARSIGHTED = false;
        [ConfigField(text: "Assault Set 4: Bombardier")] public bool AssaultSet4_BOMBARDIER = false;

        [ConfigField(text: "Assault Set 5 Enabled")] public bool AssaultSet5Enabled = true;
        [ConfigField(text: "Assault Set 5: Reckless")] public bool AssaultSet5_RECKLESS = false;
        [ConfigField(text: "Assault Set 5: Thief")] public bool AssaultSet5_THIEF = false;
        [ConfigField(text: "Assault Set 5: Strongman")] public bool AssaultSet5_STRONGMAN = false;
        [ConfigField(text: "Assault Set 5: Resourceful")] public bool AssaultSet5_RESOURCEFUL = true;
        [ConfigField(text: "Assault Set 5: Trooper")] public bool AssaultSet5_TROOPER = false;
        [ConfigField(text: "Assault Set 5: Close Quarter Specialist")] public bool AssaultSet5_CLOSE_QUARTERS_SPECIALIST = false;
        [ConfigField(text: "Assault Set 5: Cautious")] public bool AssaultSet5_CAUTIOUS = true;
        [ConfigField(text: "Assault Set 5: Biochemist")] public bool AssaultSet5_BIOCHEMIST = true;
        [ConfigField(text: "Assault Set 5: Healer")] public bool AssaultSet5_HEALER = true;
        [ConfigField(text: "Assault Set 5: Quarterback")] public bool AssaultSet5_QUARTERBACK = false;
        [ConfigField(text: "Assault Set 5: Self Defense Specialist")] public bool AssaultSet5_SELF_DEFENSE_SPECIALIST = true;
        [ConfigField(text: "Assault Set 5: Sniperist")] public bool AssaultSet5_SNIPERIST = false;
        [ConfigField(text: "Assault Set 5: Farsighted")] public bool AssaultSet5_FARSIGHTED = false;
        [ConfigField(text: "Assault Set 5: Bombardier")] public bool AssaultSet5_BOMBARDIER = true;

        // ───────────────────────────── Sniper ──────────────────────────────────
        [ConfigField(text: "Sniper Set 1 Enabled")] public bool SniperSet1Enabled = true;
        [ConfigField(text: "Sniper Set 1: Sniperist")] public bool SniperSet1_SNIPERIST = true;
        [ConfigField(text: "Sniper Set 1: Farsighted")] public bool SniperSet1_FARSIGHTED = true;
        [ConfigField(text: "Sniper Set 1: Cautious")] public bool SniperSet1_CAUTIOUS = true;
        [ConfigField(text: "Sniper Set 1: Reckless")] public bool SniperSet1_RECKLESS = true;
        [ConfigField(text: "Sniper Set 1: Thief")] public bool SniperSet1_THIEF = true;
        [ConfigField(text: "Sniper Set 1: Strongman")] public bool SniperSet1_STRONGMAN = true;
        [ConfigField(text: "Sniper Set 1: Resourceful")] public bool SniperSet1_RESOURCEFUL = true;
        [ConfigField(text: "Sniper Set 1: Quarterback")] public bool SniperSet1_QUARTERBACK = true;
        [ConfigField(text: "Sniper Set 1: Healer")] public bool SniperSet1_HEALER = true;
        [ConfigField(text: "Sniper Set 1: Biochemist")] public bool SniperSet1_BIOCHEMIST = true;
        [ConfigField(text: "Sniper Set 1: Self Defense Specialist")] public bool SniperSet1_SELF_DEFENSE_SPECIALIST = true;
        [ConfigField(text: "Sniper Set 1: Bombardier")] public bool SniperSet1_BOMBARDIER = true;
        [ConfigField(text: "Sniper Set 1: Close Quarter Specialist")] public bool SniperSet1_CLOSE_QUARTERS_SPECIALIST = true;
        [ConfigField(text: "Sniper Set 1: Trooper")] public bool SniperSet1_TROOPER = true;

        [ConfigField(text: "Sniper Set 2 Enabled")] public bool SniperSet2Enabled = true;
        [ConfigField(text: "Sniper Set 2: Sniperist")] public bool SniperSet2_SNIPERIST = true;
        [ConfigField(text: "Sniper Set 2: Farsighted")] public bool SniperSet2_FARSIGHTED = false;
        [ConfigField(text: "Sniper Set 2: Cautious")] public bool SniperSet2_CAUTIOUS = false;
        [ConfigField(text: "Sniper Set 2: Reckless")] public bool SniperSet2_RECKLESS = true;
        [ConfigField(text: "Sniper Set 2: Thief")] public bool SniperSet2_THIEF = true;
        [ConfigField(text: "Sniper Set 2: Strongman")] public bool SniperSet2_STRONGMAN = false;
        [ConfigField(text: "Sniper Set 2: Resourceful")] public bool SniperSet2_RESOURCEFUL = false;
        [ConfigField(text: "Sniper Set 2: Quarterback")] public bool SniperSet2_QUARTERBACK = false;
        [ConfigField(text: "Sniper Set 2: Healer")] public bool SniperSet2_HEALER = false;
        [ConfigField(text: "Sniper Set 2: Biochemist")] public bool SniperSet2_BIOCHEMIST = false;
        [ConfigField(text: "Sniper Set 2: Self Defense Specialist")] public bool SniperSet2_SELF_DEFENSE_SPECIALIST = false;
        [ConfigField(text: "Sniper Set 2: Bombardier")] public bool SniperSet2_BOMBARDIER = false;
        [ConfigField(text: "Sniper Set 2: Close Quarter Specialist")] public bool SniperSet2_CLOSE_QUARTERS_SPECIALIST = false;
        [ConfigField(text: "Sniper Set 2: Trooper")] public bool SniperSet2_TROOPER = false;

        [ConfigField(text: "Sniper Set 3 Enabled")] public bool SniperSet3Enabled = true;
        [ConfigField(text: "Sniper Set 3: Sniperist")] public bool SniperSet3_SNIPERIST = true;
        [ConfigField(text: "Sniper Set 3: Farsighted")] public bool SniperSet3_FARSIGHTED = true;
        [ConfigField(text: "Sniper Set 3: Cautious")] public bool SniperSet3_CAUTIOUS = true;
        [ConfigField(text: "Sniper Set 3: Reckless")] public bool SniperSet3_RECKLESS = false;
        [ConfigField(text: "Sniper Set 3: Thief")] public bool SniperSet3_THIEF = false;
        [ConfigField(text: "Sniper Set 3: Strongman")] public bool SniperSet3_STRONGMAN = false;
        [ConfigField(text: "Sniper Set 3: Resourceful")] public bool SniperSet3_RESOURCEFUL = false;
        [ConfigField(text: "Sniper Set 3: Quarterback")] public bool SniperSet3_QUARTERBACK = true;
        [ConfigField(text: "Sniper Set 3: Healer")] public bool SniperSet3_HEALER = false;
        [ConfigField(text: "Sniper Set 3: Biochemist")] public bool SniperSet3_BIOCHEMIST = false;
        [ConfigField(text: "Sniper Set 3: Self Defense Specialist")] public bool SniperSet3_SELF_DEFENSE_SPECIALIST = false;
        [ConfigField(text: "Sniper Set 3: Bombardier")] public bool SniperSet3_BOMBARDIER = true;
        [ConfigField(text: "Sniper Set 3: Close Quarter Specialist")] public bool SniperSet3_CLOSE_QUARTERS_SPECIALIST = false;
        [ConfigField(text: "Sniper Set 3: Trooper")] public bool SniperSet3_TROOPER = false;

        [ConfigField(text: "Sniper Set 4 Enabled")] public bool SniperSet4Enabled = true;
        [ConfigField(text: "Sniper Set 4: Sniperist")] public bool SniperSet4_SNIPERIST = true;
        [ConfigField(text: "Sniper Set 4: Farsighted")] public bool SniperSet4_FARSIGHTED = false;
        [ConfigField(text: "Sniper Set 4: Cautious")] public bool SniperSet4_CAUTIOUS = false;
        [ConfigField(text: "Sniper Set 4: Reckless")] public bool SniperSet4_RECKLESS = true;
        [ConfigField(text: "Sniper Set 4: Thief")] public bool SniperSet4_THIEF = true;
        [ConfigField(text: "Sniper Set 4: Strongman")] public bool SniperSet4_STRONGMAN = false;
        [ConfigField(text: "Sniper Set 4: Resourceful")] public bool SniperSet4_RESOURCEFUL = true;
        [ConfigField(text: "Sniper Set 4: Quarterback")] public bool SniperSet4_QUARTERBACK = false;
        [ConfigField(text: "Sniper Set 4: Healer")] public bool SniperSet4_HEALER = false;
        [ConfigField(text: "Sniper Set 4: Biochemist")] public bool SniperSet4_BIOCHEMIST = false;
        [ConfigField(text: "Sniper Set 4: Self Defense Specialist")] public bool SniperSet4_SELF_DEFENSE_SPECIALIST = true;
        [ConfigField(text: "Sniper Set 4: Bombardier")] public bool SniperSet4_BOMBARDIER = false;
        [ConfigField(text: "Sniper Set 4: Close Quarter Specialist")] public bool SniperSet4_CLOSE_QUARTERS_SPECIALIST = false;
        [ConfigField(text: "Sniper Set 4: Trooper")] public bool SniperSet4_TROOPER = false;

        [ConfigField(text: "Sniper Set 5 Enabled")] public bool SniperSet5Enabled = true;
        [ConfigField(text: "Sniper Set 5: Sniperist")] public bool SniperSet5_SNIPERIST = false;
        [ConfigField(text: "Sniper Set 5: Farsighted")] public bool SniperSet5_FARSIGHTED = false;
        [ConfigField(text: "Sniper Set 5: Cautious")] public bool SniperSet5_CAUTIOUS = false;
        [ConfigField(text: "Sniper Set 5: Reckless")] public bool SniperSet5_RECKLESS = false;
        [ConfigField(text: "Sniper Set 5: Thief")] public bool SniperSet5_THIEF = false;
        [ConfigField(text: "Sniper Set 5: Strongman")] public bool SniperSet5_STRONGMAN = true;
        [ConfigField(text: "Sniper Set 5: Resourceful")] public bool SniperSet5_RESOURCEFUL = true;
        [ConfigField(text: "Sniper Set 5: Quarterback")] public bool SniperSet5_QUARTERBACK = false;
        [ConfigField(text: "Sniper Set 5: Healer")] public bool SniperSet5_HEALER = true;
        [ConfigField(text: "Sniper Set 5: Biochemist")] public bool SniperSet5_BIOCHEMIST = true;
        [ConfigField(text: "Sniper Set 5: Self Defense Specialist")] public bool SniperSet5_SELF_DEFENSE_SPECIALIST = false;
        [ConfigField(text: "Sniper Set 5: Bombardier")] public bool SniperSet5_BOMBARDIER = false;
        [ConfigField(text: "Sniper Set 5: Close Quarter Specialist")] public bool SniperSet5_CLOSE_QUARTERS_SPECIALIST = false;
        [ConfigField(text: "Sniper Set 5: Trooper")] public bool SniperSet5_TROOPER = false;

        // ───────────────────────────── Heavy ───────────────────────────────────
        [ConfigField(text: "Heavy Set 1 Enabled")] public bool HeavySet1Enabled = true;
        [ConfigField(text: "Heavy Set 1: Strongman")] public bool HeavySet1_STRONGMAN = true;
        [ConfigField(text: "Heavy Set 1: Cautious")] public bool HeavySet1_CAUTIOUS = true;
        [ConfigField(text: "Heavy Set 1: Biochemist")] public bool HeavySet1_BIOCHEMIST = true;
        [ConfigField(text: "Heavy Set 1: Reckless")] public bool HeavySet1_RECKLESS = true;
        [ConfigField(text: "Heavy Set 1: Thief")] public bool HeavySet1_THIEF = true;
        [ConfigField(text: "Heavy Set 1: Resourceful")] public bool HeavySet1_RESOURCEFUL = true;
        [ConfigField(text: "Heavy Set 1: Trooper")] public bool HeavySet1_TROOPER = true;
        [ConfigField(text: "Heavy Set 1: Close Quarter Specialist")] public bool HeavySet1_CLOSE_QUARTERS_SPECIALIST = true;
        [ConfigField(text: "Heavy Set 1: Healer")] public bool HeavySet1_HEALER = true;
        [ConfigField(text: "Heavy Set 1: Quarterback")] public bool HeavySet1_QUARTERBACK = true;
        [ConfigField(text: "Heavy Set 1: Self Defense Specialist")] public bool HeavySet1_SELF_DEFENSE_SPECIALIST = true;
        [ConfigField(text: "Heavy Set 1: Sniperist")] public bool HeavySet1_SNIPERIST = true;
        [ConfigField(text: "Heavy Set 1: Farsighted")] public bool HeavySet1_FARSIGHTED = true;
        [ConfigField(text: "Heavy Set 1: Bombardier")] public bool HeavySet1_BOMBARDIER = true;

        [ConfigField(text: "Heavy Set 2 Enabled")] public bool HeavySet2Enabled = true;
        [ConfigField(text: "Heavy Set 2: Strongman")] public bool HeavySet2_STRONGMAN = true;
        [ConfigField(text: "Heavy Set 2: Cautious")] public bool HeavySet2_CAUTIOUS = false;
        [ConfigField(text: "Heavy Set 2: Biochemist")] public bool HeavySet2_BIOCHEMIST = false;
        [ConfigField(text: "Heavy Set 2: Reckless")] public bool HeavySet2_RECKLESS = true;
        [ConfigField(text: "Heavy Set 2: Thief")] public bool HeavySet2_THIEF = false;
        [ConfigField(text: "Heavy Set 2: Resourceful")] public bool HeavySet2_RESOURCEFUL = false;
        [ConfigField(text: "Heavy Set 2: Trooper")] public bool HeavySet2_TROOPER = false;
        [ConfigField(text: "Heavy Set 2: Close Quarter Specialist")] public bool HeavySet2_CLOSE_QUARTERS_SPECIALIST = false;
        [ConfigField(text: "Heavy Set 2: Healer")] public bool HeavySet2_HEALER = false;
        [ConfigField(text: "Heavy Set 2: Quarterback")] public bool HeavySet2_QUARTERBACK = false;
        [ConfigField(text: "Heavy Set 2: Self Defense Specialist")] public bool HeavySet2_SELF_DEFENSE_SPECIALIST = false;
        [ConfigField(text: "Heavy Set 2: Sniperist")] public bool HeavySet2_SNIPERIST = false;
        [ConfigField(text: "Heavy Set 2: Farsighted")] public bool HeavySet2_FARSIGHTED = false;
        [ConfigField(text: "Heavy Set 2: Bombardier")] public bool HeavySet2_BOMBARDIER = true;

        [ConfigField(text: "Heavy Set 3 Enabled")] public bool HeavySet3Enabled = true;
        [ConfigField(text: "Heavy Set 3: Strongman")] public bool HeavySet3_STRONGMAN = true;
        [ConfigField(text: "Heavy Set 3: Cautious")] public bool HeavySet3_CAUTIOUS = true;
        [ConfigField(text: "Heavy Set 3: Biochemist")] public bool HeavySet3_BIOCHEMIST = false;
        [ConfigField(text: "Heavy Set 3: Reckless")] public bool HeavySet3_RECKLESS = true;
        [ConfigField(text: "Heavy Set 3: Thief")] public bool HeavySet3_THIEF = false;
        [ConfigField(text: "Heavy Set 3: Resourceful")] public bool HeavySet3_RESOURCEFUL = false;
        [ConfigField(text: "Heavy Set 3: Trooper")] public bool HeavySet3_TROOPER = false;
        [ConfigField(text: "Heavy Set 3: Close Quarter Specialist")] public bool HeavySet3_CLOSE_QUARTERS_SPECIALIST = false;
        [ConfigField(text: "Heavy Set 3: Healer")] public bool HeavySet3_HEALER = false;
        [ConfigField(text: "Heavy Set 3: Quarterback")] public bool HeavySet3_QUARTERBACK = false;
        [ConfigField(text: "Heavy Set 3: Self Defense Specialist")] public bool HeavySet3_SELF_DEFENSE_SPECIALIST = false;
        [ConfigField(text: "Heavy Set 3: Sniperist")] public bool HeavySet3_SNIPERIST = false;
        [ConfigField(text: "Heavy Set 3: Farsighted")] public bool HeavySet3_FARSIGHTED = false;
        [ConfigField(text: "Heavy Set 3: Bombardier")] public bool HeavySet3_BOMBARDIER = false;

        // ─────────────────────────── Berserker ────────────────────────────────
        [ConfigField(text: "Berserker Set 1 Enabled")] public bool BerserkerSet1Enabled = true;
        [ConfigField(text: "Berserker Set 1: Strongman")] public bool BerserkerSet1_STRONGMAN = true;
        [ConfigField(text: "Berserker Set 1: Reckless")] public bool BerserkerSet1_RECKLESS = true;
        [ConfigField(text: "Berserker Set 1: Thief")] public bool BerserkerSet1_THIEF = true;
        [ConfigField(text: "Berserker Set 1: Resourceful")] public bool BerserkerSet1_RESOURCEFUL = true;
        [ConfigField(text: "Berserker Set 1: Self Defense Specialist")] public bool BerserkerSet1_SELF_DEFENSE_SPECIALIST = true;
        [ConfigField(text: "Berserker Set 1: Trooper")] public bool BerserkerSet1_TROOPER = true;
        [ConfigField(text: "Berserker Set 1: Close Quarter Specialist")] public bool BerserkerSet1_CLOSE_QUARTERS_SPECIALIST = true;
        [ConfigField(text: "Berserker Set 1: Cautious")] public bool BerserkerSet1_CAUTIOUS = true;
        [ConfigField(text: "Berserker Set 1: Biochemist")] public bool BerserkerSet1_BIOCHEMIST = true;
        [ConfigField(text: "Berserker Set 1: Healer")] public bool BerserkerSet1_HEALER = true;
        [ConfigField(text: "Berserker Set 1: Quarterback")] public bool BerserkerSet1_QUARTERBACK = true;
        [ConfigField(text: "Berserker Set 1: Sniperist")] public bool BerserkerSet1_SNIPERIST = true;
        [ConfigField(text: "Berserker Set 1: Farsighted")] public bool BerserkerSet1_FARSIGHTED = true;
        [ConfigField(text: "Berserker Set 1: Bombardier")] public bool BerserkerSet1_BOMBARDIER = true;

        [ConfigField(text: "Berserker Set 2 Enabled")] public bool BerserkerSet2Enabled = true;
        [ConfigField(text: "Berserker Set 2: Strongman")] public bool BerserkerSet2_STRONGMAN = false;
        [ConfigField(text: "Berserker Set 2: Reckless")] public bool BerserkerSet2_RECKLESS = true;
        [ConfigField(text: "Berserker Set 2: Thief")] public bool BerserkerSet2_THIEF = false;
        [ConfigField(text: "Berserker Set 2: Resourceful")] public bool BerserkerSet2_RESOURCEFUL = false;
        [ConfigField(text: "Berserker Set 2: Self Defense Specialist")] public bool BerserkerSet2_SELF_DEFENSE_SPECIALIST = false;
        [ConfigField(text: "Berserker Set 2: Trooper")] public bool BerserkerSet2_TROOPER = false;
        [ConfigField(text: "Berserker Set 2: Close Quarter Specialist")] public bool BerserkerSet2_CLOSE_QUARTERS_SPECIALIST = true;
        [ConfigField(text: "Berserker Set 2: Cautious")] public bool BerserkerSet2_CAUTIOUS = false;
        [ConfigField(text: "Berserker Set 2: Biochemist")] public bool BerserkerSet2_BIOCHEMIST = false;
        [ConfigField(text: "Berserker Set 2: Healer")] public bool BerserkerSet2_HEALER = false;
        [ConfigField(text: "Berserker Set 2: Quarterback")] public bool BerserkerSet2_QUARTERBACK = true;
        [ConfigField(text: "Berserker Set 2: Sniperist")] public bool BerserkerSet2_SNIPERIST = false;
        [ConfigField(text: "Berserker Set 2: Farsighted")] public bool BerserkerSet2_FARSIGHTED = false;
        [ConfigField(text: "Berserker Set 2: Bombardier")] public bool BerserkerSet2_BOMBARDIER = false;

        [ConfigField(text: "Berserker Set 3 Enabled")] public bool BerserkerSet3Enabled = true;
        [ConfigField(text: "Berserker Set 3: Strongman")] public bool BerserkerSet3_STRONGMAN = false;
        [ConfigField(text: "Berserker Set 3: Reckless")] public bool BerserkerSet3_RECKLESS = true;
        [ConfigField(text: "Berserker Set 3: Thief")] public bool BerserkerSet3_THIEF = false;
        [ConfigField(text: "Berserker Set 3: Resourceful")] public bool BerserkerSet3_RESOURCEFUL = false;
        [ConfigField(text: "Berserker Set 3: Self Defense Specialist")] public bool BerserkerSet3_SELF_DEFENSE_SPECIALIST = false;
        [ConfigField(text: "Berserker Set 3: Trooper")] public bool BerserkerSet3_TROOPER = false;
        [ConfigField(text: "Berserker Set 3: Close Quarter Specialist")] public bool BerserkerSet3_CLOSE_QUARTERS_SPECIALIST = false;
        [ConfigField(text: "Berserker Set 3: Cautious")] public bool BerserkerSet3_CAUTIOUS = false;
        [ConfigField(text: "Berserker Set 3: Biochemist")] public bool BerserkerSet3_BIOCHEMIST = false;
        [ConfigField(text: "Berserker Set 3: Healer")] public bool BerserkerSet3_HEALER = false;
        [ConfigField(text: "Berserker Set 3: Quarterback")] public bool BerserkerSet3_QUARTERBACK = false;
        [ConfigField(text: "Berserker Set 3: Sniperist")] public bool BerserkerSet3_SNIPERIST = true;
        [ConfigField(text: "Berserker Set 3: Farsighted")] public bool BerserkerSet3_FARSIGHTED = true;
        [ConfigField(text: "Berserker Set 3: Bombardier")] public bool BerserkerSet3_BOMBARDIER = false;

        // ─────────────────────────── Technician ───────────────────────────────
        [ConfigField(text: "Technician Set 1 Enabled")] public bool TechnicianSet1Enabled = true;
        [ConfigField(text: "Technician Set 1: Resourceful")] public bool TechnicianSet1_RESOURCEFUL = true;
        [ConfigField(text: "Technician Set 1: Quarterback")] public bool TechnicianSet1_QUARTERBACK = true;
        [ConfigField(text: "Technician Set 1: Healer")] public bool TechnicianSet1_HEALER = true;
        [ConfigField(text: "Technician Set 1: Reckless")] public bool TechnicianSet1_RECKLESS = true;
        [ConfigField(text: "Technician Set 1: Thief")] public bool TechnicianSet1_THIEF = true;
        [ConfigField(text: "Technician Set 1: Strongman")] public bool TechnicianSet1_STRONGMAN = true;
        [ConfigField(text: "Technician Set 1: Close Quarter Specialist")] public bool TechnicianSet1_CLOSE_QUARTERS_SPECIALIST = true;
        [ConfigField(text: "Technician Set 1: Cautious")] public bool TechnicianSet1_CAUTIOUS = true;
        [ConfigField(text: "Technician Set 1: Biochemist")] public bool TechnicianSet1_BIOCHEMIST = true;
        [ConfigField(text: "Technician Set 1: Self Defense Specialist")] public bool TechnicianSet1_SELF_DEFENSE_SPECIALIST = true;
        [ConfigField(text: "Technician Set 1: Sniperist")] public bool TechnicianSet1_SNIPERIST = true;
        [ConfigField(text: "Technician Set 1: Farsighted")] public bool TechnicianSet1_FARSIGHTED = true;
        [ConfigField(text: "Technician Set 1: Bombardier")] public bool TechnicianSet1_BOMBARDIER = true;
        [ConfigField(text: "Technician Set 1: Trooper")] public bool TechnicianSet1_TROOPER = true;

        [ConfigField(text: "Technician Set 2 Enabled")] public bool TechnicianSet2Enabled = true;
        [ConfigField(text: "Technician Set 2: Resourceful")] public bool TechnicianSet2_RESOURCEFUL = false;
        [ConfigField(text: "Technician Set 2: Quarterback")] public bool TechnicianSet2_QUARTERBACK = true;
        [ConfigField(text: "Technician Set 2: Healer")] public bool TechnicianSet2_HEALER = true;
        [ConfigField(text: "Technician Set 2: Reckless")] public bool TechnicianSet2_RECKLESS = false;
        [ConfigField(text: "Technician Set 2: Thief")] public bool TechnicianSet2_THIEF = false;
        [ConfigField(text: "Technician Set 2: Strongman")] public bool TechnicianSet2_STRONGMAN = false;
        [ConfigField(text: "Technician Set 2: Close Quarter Specialist")] public bool TechnicianSet2_CLOSE_QUARTERS_SPECIALIST = false;
        [ConfigField(text: "Technician Set 2: Cautious")] public bool TechnicianSet2_CAUTIOUS = false;
        [ConfigField(text: "Technician Set 2: Biochemist")] public bool TechnicianSet2_BIOCHEMIST = false;
        [ConfigField(text: "Technician Set 2: Self Defense Specialist")] public bool TechnicianSet2_SELF_DEFENSE_SPECIALIST = false;
        [ConfigField(text: "Technician Set 2: Sniperist")] public bool TechnicianSet2_SNIPERIST = false;
        [ConfigField(text: "Technician Set 2: Farsighted")] public bool TechnicianSet2_FARSIGHTED = true;
        [ConfigField(text: "Technician Set 2: Bombardier")] public bool TechnicianSet2_BOMBARDIER = false;
        [ConfigField(text: "Technician Set 2: Trooper")] public bool TechnicianSet2_TROOPER = false;

        [ConfigField(text: "Technician Set 3 Enabled")] public bool TechnicianSet3Enabled = true;
        [ConfigField(text: "Technician Set 3: Resourceful")] public bool TechnicianSet3_RESOURCEFUL = true;
        [ConfigField(text: "Technician Set 3: Quarterback")] public bool TechnicianSet3_QUARTERBACK = false;
        [ConfigField(text: "Technician Set 3: Healer")] public bool TechnicianSet3_HEALER = true;
        [ConfigField(text: "Technician Set 3: Reckless")] public bool TechnicianSet3_RECKLESS = true;
        [ConfigField(text: "Technician Set 3: Thief")] public bool TechnicianSet3_THIEF = false;
        [ConfigField(text: "Technician Set 3: Strongman")] public bool TechnicianSet3_STRONGMAN = false;
        [ConfigField(text: "Technician Set 3: Close Quarter Specialist")] public bool TechnicianSet3_CLOSE_QUARTERS_SPECIALIST = false;
        [ConfigField(text: "Technician Set 3: Cautious")] public bool TechnicianSet3_CAUTIOUS = false;
        [ConfigField(text: "Technician Set 3: Biochemist")] public bool TechnicianSet3_BIOCHEMIST = false;
        [ConfigField(text: "Technician Set 3: Self Defense Specialist")] public bool TechnicianSet3_SELF_DEFENSE_SPECIALIST = false;
        [ConfigField(text: "Technician Set 3: Sniperist")] public bool TechnicianSet3_SNIPERIST = false;
        [ConfigField(text: "Technician Set 3: Farsighted")] public bool TechnicianSet3_FARSIGHTED = false;
        [ConfigField(text: "Technician Set 3: Bombardier")] public bool TechnicianSet3_BOMBARDIER = false;
        [ConfigField(text: "Technician Set 3: Trooper")] public bool TechnicianSet3_TROOPER = false;

        [ConfigField(text: "Technician Set 4 Enabled")] public bool TechnicianSet4Enabled = true;
        [ConfigField(text: "Technician Set 4: Resourceful")] public bool TechnicianSet4_RESOURCEFUL = false;
        [ConfigField(text: "Technician Set 4: Quarterback")] public bool TechnicianSet4_QUARTERBACK = false;
        [ConfigField(text: "Technician Set 4: Healer")] public bool TechnicianSet4_HEALER = true;
        [ConfigField(text: "Technician Set 4: Reckless")] public bool TechnicianSet4_RECKLESS = true;
        [ConfigField(text: "Technician Set 4: Thief")] public bool TechnicianSet4_THIEF = false;
        [ConfigField(text: "Technician Set 4: Strongman")] public bool TechnicianSet4_STRONGMAN = false;
        [ConfigField(text: "Technician Set 4: Close Quarter Specialist")] public bool TechnicianSet4_CLOSE_QUARTERS_SPECIALIST = false;
        [ConfigField(text: "Technician Set 4: Cautious")] public bool TechnicianSet4_CAUTIOUS = false;
        [ConfigField(text: "Technician Set 4: Biochemist")] public bool TechnicianSet4_BIOCHEMIST = false;
        [ConfigField(text: "Technician Set 4: Self Defense Specialist")] public bool TechnicianSet4_SELF_DEFENSE_SPECIALIST = true;
        [ConfigField(text: "Technician Set 4: Sniperist")] public bool TechnicianSet4_SNIPERIST = false;
        [ConfigField(text: "Technician Set 4: Farsighted")] public bool TechnicianSet4_FARSIGHTED = false;
        [ConfigField(text: "Technician Set 4: Bombardier")] public bool TechnicianSet4_BOMBARDIER = false;
        [ConfigField(text: "Technician Set 4: Trooper")] public bool TechnicianSet4_TROOPER = false;

        [ConfigField(text: "Technician Set 5 Enabled")] public bool TechnicianSet5Enabled = true;
        [ConfigField(text: "Technician Set 5: Resourceful")] public bool TechnicianSet5_RESOURCEFUL = true;
        [ConfigField(text: "Technician Set 5: Quarterback")] public bool TechnicianSet5_QUARTERBACK = true;
        [ConfigField(text: "Technician Set 5: Healer")] public bool TechnicianSet5_HEALER = true;
        [ConfigField(text: "Technician Set 5: Reckless")] public bool TechnicianSet5_RECKLESS = false;
        [ConfigField(text: "Technician Set 5: Thief")] public bool TechnicianSet5_THIEF = false;
        [ConfigField(text: "Technician Set 5: Strongman")] public bool TechnicianSet5_STRONGMAN = false;
        [ConfigField(text: "Technician Set 5: Close Quarter Specialist")] public bool TechnicianSet5_CLOSE_QUARTERS_SPECIALIST = false;
        [ConfigField(text: "Technician Set 5: Cautious")] public bool TechnicianSet5_CAUTIOUS = false;
        [ConfigField(text: "Technician Set 5: Biochemist")] public bool TechnicianSet5_BIOCHEMIST = false;
        [ConfigField(text: "Technician Set 5: Self Defense Specialist")] public bool TechnicianSet5_SELF_DEFENSE_SPECIALIST = false;
        [ConfigField(text: "Technician Set 5: Sniperist")] public bool TechnicianSet5_SNIPERIST = false;
        [ConfigField(text: "Technician Set 5: Farsighted")] public bool TechnicianSet5_FARSIGHTED = false;
        [ConfigField(text: "Technician Set 5: Bombardier")] public bool TechnicianSet5_BOMBARDIER = false;
        [ConfigField(text: "Technician Set 5: Trooper")] public bool TechnicianSet5_TROOPER = false;

        // ─────────────────────────── Infiltrator ──────────────────────────────
        [ConfigField(text: "Infiltrator Set 1 Enabled")] public bool InfiltratorSet1Enabled = true;
        [ConfigField(text: "Infiltrator Set 1: Thief")] public bool InfiltratorSet1_THIEF = true;
        [ConfigField(text: "Infiltrator Set 1: Cautious")] public bool InfiltratorSet1_CAUTIOUS = true;
        [ConfigField(text: "Infiltrator Set 1: Resourceful")] public bool InfiltratorSet1_RESOURCEFUL = true;
        [ConfigField(text: "Infiltrator Set 1: Reckless")] public bool InfiltratorSet1_RECKLESS = true;
        [ConfigField(text: "Infiltrator Set 1: Strongman")] public bool InfiltratorSet1_STRONGMAN = true;
        [ConfigField(text: "Infiltrator Set 1: Trooper")] public bool InfiltratorSet1_TROOPER = true;
        [ConfigField(text: "Infiltrator Set 1: Close Quarter Specialist")] public bool InfiltratorSet1_CLOSE_QUARTERS_SPECIALIST = true;
        [ConfigField(text: "Infiltrator Set 1: Biochemist")] public bool InfiltratorSet1_BIOCHEMIST = true;
        [ConfigField(text: "Infiltrator Set 1: Healer")] public bool InfiltratorSet1_HEALER = true;
        [ConfigField(text: "Infiltrator Set 1: Quarterback")] public bool InfiltratorSet1_QUARTERBACK = true;
        [ConfigField(text: "Infiltrator Set 1: Self Defense Specialist")] public bool InfiltratorSet1_SELF_DEFENSE_SPECIALIST = true;
        [ConfigField(text: "Infiltrator Set 1: Sniperist")] public bool InfiltratorSet1_SNIPERIST = true;
        [ConfigField(text: "Infiltrator Set 1: Farsighted")] public bool InfiltratorSet1_FARSIGHTED = true;
        [ConfigField(text: "Infiltrator Set 1: Bombardier")] public bool InfiltratorSet1_BOMBARDIER = true;

        [ConfigField(text: "Infiltrator Set 2 Enabled")] public bool InfiltratorSet2Enabled = true;
        [ConfigField(text: "Infiltrator Set 2: Thief")] public bool InfiltratorSet2_THIEF = true;
        [ConfigField(text: "Infiltrator Set 2: Cautious")] public bool InfiltratorSet2_CAUTIOUS = false;
        [ConfigField(text: "Infiltrator Set 2: Resourceful")] public bool InfiltratorSet2_RESOURCEFUL = false;
        [ConfigField(text: "Infiltrator Set 2: Reckless")] public bool InfiltratorSet2_RECKLESS = true;
        [ConfigField(text: "Infiltrator Set 2: Strongman")] public bool InfiltratorSet2_STRONGMAN = false;
        [ConfigField(text: "Infiltrator Set 2: Trooper")] public bool InfiltratorSet2_TROOPER = false;
        [ConfigField(text: "Infiltrator Set 2: Close Quarter Specialist")] public bool InfiltratorSet2_CLOSE_QUARTERS_SPECIALIST = false;
        [ConfigField(text: "Infiltrator Set 2: Biochemist")] public bool InfiltratorSet2_BIOCHEMIST = false;
        [ConfigField(text: "Infiltrator Set 2: Healer")] public bool InfiltratorSet2_HEALER = false;
        [ConfigField(text: "Infiltrator Set 2: Quarterback")] public bool InfiltratorSet2_QUARTERBACK = false;
        [ConfigField(text: "Infiltrator Set 2: Self Defense Specialist")] public bool InfiltratorSet2_SELF_DEFENSE_SPECIALIST = true;
        [ConfigField(text: "Infiltrator Set 2: Sniperist")] public bool InfiltratorSet2_SNIPERIST = false;
        [ConfigField(text: "Infiltrator Set 2: Farsighted")] public bool InfiltratorSet2_FARSIGHTED = false;
        [ConfigField(text: "Infiltrator Set 2: Bombardier")] public bool InfiltratorSet2_BOMBARDIER = false;

        [ConfigField(text: "Infiltrator Set 3 Enabled")] public bool InfiltratorSet3Enabled = true;
        [ConfigField(text: "Infiltrator Set 3: Thief")] public bool InfiltratorSet3_THIEF = true;
        [ConfigField(text: "Infiltrator Set 3: Cautious")] public bool InfiltratorSet3_CAUTIOUS = false;
        [ConfigField(text: "Infiltrator Set 3: Resourceful")] public bool InfiltratorSet3_RESOURCEFUL = false;
        [ConfigField(text: "Infiltrator Set 3: Reckless")] public bool InfiltratorSet3_RECKLESS = true;
        [ConfigField(text: "Infiltrator Set 3: Strongman")] public bool InfiltratorSet3_STRONGMAN = false;
        [ConfigField(text: "Infiltrator Set 3: Trooper")] public bool InfiltratorSet3_TROOPER = false;
        [ConfigField(text: "Infiltrator Set 3: Close Quarter Specialist")] public bool InfiltratorSet3_CLOSE_QUARTERS_SPECIALIST = true;
        [ConfigField(text: "Infiltrator Set 3: Biochemist")] public bool InfiltratorSet3_BIOCHEMIST = false;
        [ConfigField(text: "Infiltrator Set 3: Healer")] public bool InfiltratorSet3_HEALER = false;
        [ConfigField(text: "Infiltrator Set 3: Quarterback")] public bool InfiltratorSet3_QUARTERBACK = false;
        [ConfigField(text: "Infiltrator Set 3: Self Defense Specialist")] public bool InfiltratorSet3_SELF_DEFENSE_SPECIALIST = false;
        [ConfigField(text: "Infiltrator Set 3: Sniperist")] public bool InfiltratorSet3_SNIPERIST = false;
        [ConfigField(text: "Infiltrator Set 3: Farsighted")] public bool InfiltratorSet3_FARSIGHTED = false;
        [ConfigField(text: "Infiltrator Set 3: Bombardier")] public bool InfiltratorSet3_BOMBARDIER = false;

        // ───────────────────────────── Priest ─────────────────────────────────
        [ConfigField(text: "Priest Set 1 Enabled")] public bool PriestSet1Enabled = true;
        [ConfigField(text: "Priest Set 1: Healer")] public bool PriestSet1_HEALER = true;
        [ConfigField(text: "Priest Set 1: Resourceful")] public bool PriestSet1_RESOURCEFUL = true;
        [ConfigField(text: "Priest Set 1: Cautious")] public bool PriestSet1_CAUTIOUS = true;
        [ConfigField(text: "Priest Set 1: Farsighted")] public bool PriestSet1_FARSIGHTED = true;
        [ConfigField(text: "Priest Set 1: Reckless")] public bool PriestSet1_RECKLESS = true;
        [ConfigField(text: "Priest Set 1: Thief")] public bool PriestSet1_THIEF = true;
        [ConfigField(text: "Priest Set 1: Strongman")] public bool PriestSet1_STRONGMAN = true;
        [ConfigField(text: "Priest Set 1: Close Quarter Specialist")] public bool PriestSet1_CLOSE_QUARTERS_SPECIALIST = true;
        [ConfigField(text: "Priest Set 1: Biochemist")] public bool PriestSet1_BIOCHEMIST = true;
        [ConfigField(text: "Priest Set 1: Quarterback")] public bool PriestSet1_QUARTERBACK = true;
        [ConfigField(text: "Priest Set 1: Self Defense Specialist")] public bool PriestSet1_SELF_DEFENSE_SPECIALIST = true;
        [ConfigField(text: "Priest Set 1: Sniperist")] public bool PriestSet1_SNIPERIST = true;
        [ConfigField(text: "Priest Set 1: Bombardier")] public bool PriestSet1_BOMBARDIER = true;
        [ConfigField(text: "Priest Set 1: Trooper")] public bool PriestSet1_TROOPER = true;

        [ConfigField(text: "Priest Set 2 Enabled")] public bool PriestSet2Enabled = true;
        [ConfigField(text: "Priest Set 2: Healer")] public bool PriestSet2_HEALER = false;
        [ConfigField(text: "Priest Set 2: Resourceful")] public bool PriestSet2_RESOURCEFUL = false;
        [ConfigField(text: "Priest Set 2: Cautious")] public bool PriestSet2_CAUTIOUS = false;
        [ConfigField(text: "Priest Set 2: Farsighted")] public bool PriestSet2_FARSIGHTED = true;
        [ConfigField(text: "Priest Set 2: Reckless")] public bool PriestSet2_RECKLESS = false;
        [ConfigField(text: "Priest Set 2: Thief")] public bool PriestSet2_THIEF = true;
        [ConfigField(text: "Priest Set 2: Strongman")] public bool PriestSet2_STRONGMAN = false;
        [ConfigField(text: "Priest Set 2: Close Quarter Specialist")] public bool PriestSet2_CLOSE_QUARTERS_SPECIALIST = false;
        [ConfigField(text: "Priest Set 2: Biochemist")] public bool PriestSet2_BIOCHEMIST = false;
        [ConfigField(text: "Priest Set 2: Quarterback")] public bool PriestSet2_QUARTERBACK = true;
        [ConfigField(text: "Priest Set 2: Self Defense Specialist")] public bool PriestSet2_SELF_DEFENSE_SPECIALIST = false;
        [ConfigField(text: "Priest Set 2: Sniperist")] public bool PriestSet2_SNIPERIST = false;
        [ConfigField(text: "Priest Set 2: Bombardier")] public bool PriestSet2_BOMBARDIER = false;
        [ConfigField(text: "Priest Set 2: Trooper")] public bool PriestSet2_TROOPER = false;

        [ConfigField(text: "Priest Set 3 Enabled")] public bool PriestSet3Enabled = true;
        [ConfigField(text: "Priest Set 3: Healer")] public bool PriestSet3_HEALER = true;
        [ConfigField(text: "Priest Set 3: Resourceful")] public bool PriestSet3_RESOURCEFUL = false;
        [ConfigField(text: "Priest Set 3: Cautious")] public bool PriestSet3_CAUTIOUS = false;
        [ConfigField(text: "Priest Set 3: Farsighted")] public bool PriestSet3_FARSIGHTED = false;
        [ConfigField(text: "Priest Set 3: Reckless")] public bool PriestSet3_RECKLESS = false;
        [ConfigField(text: "Priest Set 3: Thief")] public bool PriestSet3_THIEF = false;
        [ConfigField(text: "Priest Set 3: Strongman")] public bool PriestSet3_STRONGMAN = false;
        [ConfigField(text: "Priest Set 3: Close Quarter Specialist")] public bool PriestSet3_CLOSE_QUARTERS_SPECIALIST = false;
        [ConfigField(text: "Priest Set 3: Biochemist")] public bool PriestSet3_BIOCHEMIST = false;
        [ConfigField(text: "Priest Set 3: Quarterback")] public bool PriestSet3_QUARTERBACK = true;
        [ConfigField(text: "Priest Set 3: Self Defense Specialist")] public bool PriestSet3_SELF_DEFENSE_SPECIALIST = false;
        [ConfigField(text: "Priest Set 3: Sniperist")] public bool PriestSet3_SNIPERIST = false;
        [ConfigField(text: "Priest Set 3: Bombardier")] public bool PriestSet3_BOMBARDIER = true;
        [ConfigField(text: "Priest Set 3: Trooper")] public bool PriestSet3_TROOPER = false;

        [ConfigField(text: "Priest Set 4 Enabled")] public bool PriestSet4Enabled = true;
        [ConfigField(text: "Priest Set 4: Healer")] public bool PriestSet4_HEALER = false;
        [ConfigField(text: "Priest Set 4: Resourceful")] public bool PriestSet4_RESOURCEFUL = false;
        [ConfigField(text: "Priest Set 4: Cautious")] public bool PriestSet4_CAUTIOUS = false;
        [ConfigField(text: "Priest Set 4: Farsighted")] public bool PriestSet4_FARSIGHTED = true;
        [ConfigField(text: "Priest Set 4: Reckless")] public bool PriestSet4_RECKLESS = true;
        [ConfigField(text: "Priest Set 4: Thief")] public bool PriestSet4_THIEF = true;
        [ConfigField(text: "Priest Set 4: Strongman")] public bool PriestSet4_STRONGMAN = false;
        [ConfigField(text: "Priest Set 4: Close Quarter Specialist")] public bool PriestSet4_CLOSE_QUARTERS_SPECIALIST = false;
        [ConfigField(text: "Priest Set 4: Biochemist")] public bool PriestSet4_BIOCHEMIST = false;
        [ConfigField(text: "Priest Set 4: Quarterback")] public bool PriestSet4_QUARTERBACK = false;
        [ConfigField(text: "Priest Set 4: Self Defense Specialist")] public bool PriestSet4_SELF_DEFENSE_SPECIALIST = false;
        [ConfigField(text: "Priest Set 4: Sniperist")] public bool PriestSet4_SNIPERIST = false;
        [ConfigField(text: "Priest Set 4: Bombardier")] public bool PriestSet4_BOMBARDIER = false;
        [ConfigField(text: "Priest Set 4: Trooper")] public bool PriestSet4_TROOPER = false;

        [ConfigField(text: "Priest Set 5 Enabled")] public bool PriestSet5Enabled = true;
        [ConfigField(text: "Priest Set 5: Healer")] public bool PriestSet5_HEALER = true;
        [ConfigField(text: "Priest Set 5: Resourceful")] public bool PriestSet5_RESOURCEFUL = false;
        [ConfigField(text: "Priest Set 5: Cautious")] public bool PriestSet5_CAUTIOUS = false;
        [ConfigField(text: "Priest Set 5: Farsighted")] public bool PriestSet5_FARSIGHTED = true;
        [ConfigField(text: "Priest Set 5: Reckless")] public bool PriestSet5_RECKLESS = false;
        [ConfigField(text: "Priest Set 5: Thief")] public bool PriestSet5_THIEF = false;
        [ConfigField(text: "Priest Set 5: Strongman")] public bool PriestSet5_STRONGMAN = false;
        [ConfigField(text: "Priest Set 5: Close Quarter Specialist")] public bool PriestSet5_CLOSE_QUARTERS_SPECIALIST = false;
        [ConfigField(text: "Priest Set 5: Biochemist")] public bool PriestSet5_BIOCHEMIST = false;
        [ConfigField(text: "Priest Set 5: Quarterback")] public bool PriestSet5_QUARTERBACK = true;
        [ConfigField(text: "Priest Set 5: Self Defense Specialist")] public bool PriestSet5_SELF_DEFENSE_SPECIALIST = false;
        [ConfigField(text: "Priest Set 5: Sniperist")] public bool PriestSet5_SNIPERIST = false;
        [ConfigField(text: "Priest Set 5: Bombardier")] public bool PriestSet5_BOMBARDIER = false;
        [ConfigField(text: "Priest Set 5: Trooper")] public bool PriestSet5_TROOPER = false;

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