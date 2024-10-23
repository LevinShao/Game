# **9CT1B - Assessment Task 3 Part B**
# **By Levin Shao**
## **Section 1: Identifying and Defining**
### **Identifying a Need**
**2D Roguelike Game Examples**
- Dead Cells (2018)
- Slay the Spire (2019)
- The Binding of Isaac (2011)

**Dead Cells: PMI Table**
| Plus | Minus | Interesting |
| --- | --- | --- |
| Fluid and satisfying combat system | High difficulty which may frustrate some players | The levels are kept fresh and original thanks to procedural generation |
| Amazing pixel art with atmospheric environments | Lack of story lore and traditional narrative depth | Tension and excitement is added to the game through the usage of the perma-death feature |
| Responsive controls and tight platforming | Repetitive grinding is required to unlock new weapons and upgrades | Weapons and abilities can radically change the player's playstyle |

**Slay the Spire: PMI Table**
| Plus | Minus | Interesting |
| --- | --- | --- |
| Innovative card-based combat system | Can feel very boring and repetitive over time | Deck-building mechanic adds layers of strategy to the game |
| Highly strategic and requires deep thinking and problem solving | Lack of animation and graphical excitement | Combines roguelike elements with card games |
| Every run feels different, thanks to randomization | Some RNG can ruin good strategies in a single move | Powerful combos can be created by synergizing cards |

**The Binding of Isaac: PMI Table**
| Plus | Minus | Interesting |
| --- | --- | --- |
| Endless replayability due to randomization | Contains dark and grotesque themes and imagery, which may not appeal to everyone | Unpredictable combinations of items create unique experiences for the player |
| Challenging and diffcult yet rewarding gameplay | Can feel overwhelming with its many items and enemies | Exciting and addictive for the player due to procedurally generated rooms and item drops |
| Huge variety of items and power-ups available for the player to use | High level of difficulty and very complex, which makes it difficult for newcomers to learn the game | Story elements are delivered through cryptic clues and symbolism |

**Possible Game Ideas & User Needs**
- **Procedural Generation:** Randomized levels with different themes and dynamic layouts
- **Combat Mechanics:** Huge variety of weapons and special abilities available for the players to choose from; responsive controls
- **Lore:** A good and consistent storyline involving mystery plots, hidden secrets, and narrative hints
- **Replayability:** Unlockable characters; multiple endings including some being secret; random events for more rewards, making the game more fun and replayable
- **User Interface:** Simple and minimalist UI design with a clear HUD and easily-accessible options
- **Character Progression:** Skill levels which the player can increase in; upgradeable weapons and unlockable abilities
- **Enemy AI:** Challenging enemies and bosses (for boss fights) with adaptive behavior
- **Sound Design:** Atmospheric music and unique sound effects with dynamic audio cues throughout the gameplay

**Need:** To provide players with an exciting and challenging 2D gaming experience that improves their skills at strategic thinking, adaptability, and quick decision-making through procedurally generated levels and increasingly difficult enemies in a 2D Roguelike game.

**Problem Statement:** Many players often seek games that offer both replayability and a dynamic challenge. A 2D Roguelike game that features procedurally generated environments, unique and challenging enemies, as well as randomized loot can satisfy this demand by requiring players to think strategically and adapt quickly to unpredictable situations. This game will offer a satisfying progression of difficulty, which will push players to refine their skills and develop new tactics with each playthrough.

**Skill Development:** To develop the necessary skills for making the game in Unity, I will need to study and complete the 2D Roguelike tutorial available on Unity Learn. I will also have to do a lot of background research and watch a lot of YouTube tutorials in order to build the perfect 2D Roguelike game
### **Requirements Outline**
**Inputs:**
##### Keyboard Inputs:
- Arrow keys and WASD for basic player movement (W - going up by using items such as ladders; A - going left; S - sneaking; D - going right)
- Spacebar for jumping
- “E” for interaction with objects
- Escape key for opening pause menu or quitting the game
##### Mouse Inputs:
- Clicking buttons in the UI (e.g. start game, restart, quit)

**Processing:**

My 2D Roguelike game will:
- Process input directions to move the player character across the grid-based roguelike map
- Implement collision detection with obstacles, walls, and enemies
- Determine if enemies are hit, calculate damage, and check if enemies are defeated based on player attacks
- Implement pathfinding logic where enemies move towards the player, avoid obstacles, and attack when in range
- Procedurally generate each level's layout, including rooms, walls, traps, enemies, and loot
- Process interactions when the player picks up items and apply the corresponding effects

**Output:**

My 2D Roguelike game will display:
- The player's position, enemies, items, and terrain changes in real-time
- Sound effects for when the player attacks, picks up items, and kills enemies
- Damage to enemies or the player using visual feedback such as flashing or health bars reducing
- Special effects for abilities or power-ups such as explosions and lighting
- The player's health, collected items, abilities, and score
- On-screen notifications for achievements, level completion, or player death

**Transmission:**

Since I am planning the game to be **singleplayer** only, my game wouldn't need too many data transmission requirements.
However, even if the game is in singleplayer, some components may still require transmission. For examples, my 2D Roguelike game might need to:
- Transmit data between the player's device and a server in order to save progress and download new updates for the player
- Send player scores and achievements to a central server

**Storage:**

My 2D Roguelike game will store:
- The player's progress, including completed levels, unlocked items, and achievements.
- User preferences like sound levels, key bindings, and control settings will be saved locally.
- Random seed used for procedural generation, so players can revisit the same generated levels.
- High scores or other records to track the player's best runs locally or online.
### **Functional Requirements**
**User Interaction:**
- The game will be able to process the user inputs and let them control the character, interact with objects or NPCs, attack enemies and bosses, and select and switch weapons
- The player is able to open and navigate through the main menu, pause menu or settings
- The game will let some actions only trigger in appropriate contexts (e.g. can't attack during dialogue)

**Core Gameplay:**
- Each level will be randomly generated, featuring different room layouts, enemy spawns, and item placements
- Collision detection will prevent the player from walking through walls or obstacles
- When the player attacks, the game will process damage calculations based on the weapon type, enemy stats, and random factors
- Enemies will follow specific behavior patterns and adapt based on player actions
- Players are able to pick up items found in the environment, which will be added to their inventory
- Some items will have effects on the player character that trigger immediately or when used

**Scoring and Feedback:**
- The game will track the player's health, showing a health bar that decreases as the player takes damage
- Damage taken will trigger visual feedback and sound effects
- The game will track player score based on defeated enemies, completed levels, or collected items, and display them in real-time on the HUD
- Messages will notify the player upon completing significant actions (e.g. “Rare Item Unlocked!” when the player discovers a rare item)

**Level Progression:**
- Players will advance to the next level by reaching the exit point in the current level
- Upon level completion, the player may receive rewards, such as upgraded items or new abilities
- With each new level, the game will increase difficulty by adding more challenging enemies, traps, or environmental hazards
- Players may encounter random events (e.g., minibosses) that add variability to level progression
- Some levels will feature boss encounters that the player must defeat to progress further
- These encounters will have unique mechanics and may unlock special rewards upon victory

**Saving and Loading Data:**

- The game will autosave player progress after each level, including the player's health, items, score, and current level
- Saved data will be stored locally on the user's device
- Settings like audio volume, control schemes, and display settings will be saved and reloaded when the player restarts the game
- The game will save high scores locally, which will be displayed in the game's main menu or in a dedicated leaderboard section
- Optionally, the game could offer online scoreboards, transmitting score data to cloud storage for comparison with other players
### **Non-Functional Requirements**
**Performance Requirements:**
- The game will load within 5 seconds on standard PCs
- Frame rate will be maintained at 60 FPS even during intense combat or with multiple enemies on screen
- The game will respond to user inputs instantly, with less than 80ms of ping to ensure responsive and fluid controls

**Usability Requirements:**
- The game will have a intuitive and simplistic UI with clear indicators for health, inventory, and abilities, allowing players to quickly understand game mechanics
- A tutorial level will be added to guide new players through the basic controls and mechanics
- The game will include tooltips or quick explanations for items, abilities, and status effects when hovered over or selected

**Compatibility Requirements:**
- The game must be compatible with Windows, macOS, and Linux
- The user interface and controls will adapt for keyboard/mouse setups on PC
- The game will be optimized for different screen resolutions and aspect ratios, maintaining visual clarity and functionality on both standard and widescreen displays