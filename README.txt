Select Class Traits Mod v2.0
=================================

This mod allows you to configure up to 5 sets of personal perks per class with randomizable order/level and toggleable sets.

FEATURES:
- Configure up to 5 different perk sets for each class (Assault, Heavy, Sniper, Infiltrator, Technician, Berserker, Priest)
- Toggle individual perk sets on/off via mod configuration
- Randomize perk order and/or levels
- Graceful failure handling when insufficient perks are available
- Debug logging for troubleshooting

CONFIGURATION:
- Access mod settings from the main menu
- Enable/disable individual perk sets for each class
- Toggle randomization of perk order and levels
- Enable debug logging to see which perks are selected

PERK SETS:
Each class has 5 predefined perk sets with 3 perks each:

Assault:
- Set 1: Reckless, Trooper, Thief
- Set 2: Reckless, Thief, Close Quarters Specialist
- Set 3: Reckless, Thief, Strongman
- Set 4: Trooper, Reckless, Close Quarters Specialist
- Set 5: Self Defense Specialist, Healer, Pitcher

Heavy:
- Set 1: Reckless, Bombardier, Strongman
- Set 2: Reckless, Cautious, Strongman
- Set 3: Cautious, Strongman, Biochemist
- Set 4: Bombardier, Strongman, Biochemist
- Set 5: Reckless, Bombardier, Cautious

Sniper:
- Set 1: Focused, Reckless, Thief
- Set 2: Focused, Reckless, Farsighted
- Set 3: Focused, Farsighted, Cautious
- Set 4: Focused, Cautious, Thief
- Set 5: Farsighted, Cautious, Thief

Infiltrator:
- Set 1: Reckless, Self Defense Specialist, Thief
- Set 2: Reckless, Thief, Close Quarters Specialist
- Set 3: Reckless, Thief, Pitcher
- Set 4: Self Defense Specialist, Thief, Close Quarters Specialist
- Set 5: Thief, Close Quarters Specialist, Pitcher

Technician:
- Set 1: Healer, Farsighted, Pitcher
- Set 2: Reckless, Self Defense Specialist, Healer
- Set 3: Resourceful, Healer, Pitcher
- Set 4: Farsighted, Pitcher, Biochemist
- Set 5: Resourceful, Self Defense Specialist, Biochemist

Berserker:
- Set 1: Reckless, Thief, Strongman
- Set 2: Thief, Close Quarters Specialist, Strongman
- Set 3: Resourceful, Trooper, Focused
- Set 4: Reckless, Close Quarters Specialist, Strongman
- Set 5: Trooper, Thief, Bombardier

Priest:
- Set 1: Healer, Farsighted, Pitcher
- Set 2: Healer, Bombardier, Pitcher
- Set 3: Farsighted, Thief, Pitcher
- Set 4: Healer, Farsighted, Biochemist
- Set 5: Bombardier, Pitcher, Biochemist

BEHAVIOR:
- **No sets enabled**: Uses default game behavior (allows all perks)
- **One set enabled**: All soldiers of that class use the specified perk set
- **Multiple sets enabled**: Randomly selects from enabled sets for each soldier
- **Insufficient perks in set**: Automatically adds fallback perks to ensure 3 perks total

INSTALLATION:
1. Extract the mod files to your Phoenix Point mods directory
2. Enable the mod in the Workshop Tool or mod manager
3. Configure settings in the main menu
4. Start a new game to see the effects

VERSION HISTORY:
v2.0 - Complete rewrite for Workshop Tool environment
     - Added configurable perk sets
     - Added randomization options
     - Added graceful failure handling
     - Improved logging and debugging