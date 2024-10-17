# **9CT1B - Assessment Task 3 Part B**
# **By Levin Shao**
## **Section 1: Identifying and Defining**
### **Identifying a Need**
**2D Roguelike Game Examples:**
- Dead Cells (2018)
- Slay the Spire (2019)
- The Binding of Isaac (2011)

**Dead Cells: PMI Table**
| Plus | Minus | Interesting |
| --- | --- | --- |
| Fluid and satisfying combat system | High difficulty which may frustrate some players | Procedural generation keeps levels fresh and original |
| Amazing pixel art with atmospheric environments | Lack of lore and traditional narrative depth | Perma-death feature adds tension and excitement to the game |
| Responsive controls and tight platforming | Repetitive grind for new weapons and upgrades | Weapons and abilities can radically change playstyle |

**Slay the Spire: PMI Table**
| Plus | Minus | Interesting |
| --- | --- | --- |
| Innovative card-based combat system | Can feel very boring and repetitive over time | Deck-building mechanic adds layers of strategy to the game |
| Highly strategic and requires deep thinking | Lack of animation and graphical excitement | Combines roguelike elements with card games |
| Every run feels different, thanks to randomization | Some RNG can ruin good strategies in a single move | Synergizing cards can create powerful combos |

**The Binding of Isaac: PMI Table**
| Plus | Minus | Interesting |
| --- | --- | --- |
| Endless replayability due to randomization | Dark and grotesque themes may not appeal to everyone | Unpredictable combinations of items create unique experiences for the player |
| Challenging and diffcult yet rewarding gameplay | Can feel overwhelming with its many items and enemies | Procedurally generated rooms and item drops keep it exciting and addictive |
| Huge variety of items and power-ups available for the player to use | High level of difficulty and very complex, making it difficult for newcomers to learn the game | Story elements are delivered through cryptic clues and symbolism |

**Possible Game Ideas & User Needs:**
- **Procedural Generation:** Randomized levels with different themes and dynamic layouts
- **Combat Mechanics:** Huge variety of weapons and special abilities available for the players to choose from; responsive controls
- **Lore:** A good storyline involving mystery plots, hidden secrets, and narrative hints
- **Replayability:** Unlockable items; multiple endings; random events for more rewards, making the game more fun and replayable
- **User Interface:** Simple and minimalist UI design with a clear HUD and easily-accessible options
- **Character Progression:** Skill levels which the player can grow; upgradeable weapons and unlockable abilities
- **Enemy AI:** Challenging enemies and bosses (for boss fights) with adaptive behavior
- **Sound Design:** Atmospheric music and unique sound effects with dynamic audio cues throughout

**Need:** To provide players with an exciting and challenging 2D gaming experience that improves their skills at strategic thinking, adaptability, and quick decision-making through procedurally generated levels and increasingly difficult enemies in a 2D Roguelike game.

**Problem Statement:** Many players often seek games that offer both replayability and a dynamic challenge. A 2D Roguelike game that features procedurally generated environments, unique and challenging enemies, as well as randomized loot can satisfy this demand by requiring players to think strategically and adapt quickly to unpredictable situations. This game will offer a satisfying progression of difficulty, which will push players to refine their skills and develop new tactics with each playthrough.

**Skill Development:** To develop the necessary skills for making the game in Unity, I will need to study and complete the 2D Roguelike tutorial available on Unity Learn.
### **Requirements Outline**
**Inputs:**
##### Keyboard Inputs:
- Arrow keys and WASD for basic player movement (up, down, left, right).
- Spacebar and “E” for interaction with objects.
- Escape key for opening pause menu or quitting the game.
##### Mouse Inputs:
- Clicking buttons in the UI (e.g. start game, restart, quit).
##### Game Controller Inputs:
- Analog stick or D-pad for movement.
- “A” button for interacting with objects.

**Processing:**

##### Player Movement Logic:
Input directions will be processed to move the player character across the grid-based roguelike map. Collision detection with obstacles, walls, and enemies should also be implemented.

##### Combat and Damage Calculation:
Based on player attacks, determine if enemies are hit, calculate damage, and check if enemies are defeated. Similarly, calculate if enemies hit the player and reduce player health accordingly.

##### Enemy AI:
Implement pathfinding logic where enemies move towards the player, avoid obstacles, and attack when in range.

##### Random Level Generation:
Procedurally generate each level’s layout, including rooms, walls, traps, enemies, and loot.

##### Game States:
Manage transitions between different game states: playing, paused, game over, and level completion.

##### Item Interaction:
Process interactions when the player picks up items (e.g., health potions, weapons) and apply the corresponding effects.