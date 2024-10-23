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
* Process input directions to move the player character across the grid-based roguelike map
* Implement collision detection with obstacles, walls, and enemies
* Determine if enemies are hit, calculate damage, and check if enemies are defeated based on player attacks
* Calculate if enemies hit the player and reduce player health accordingly
* Implement pathfinding logic where enemies move towards the player, avoid obstacles, and attack when in range
* Procedurally generate each level’s layout, including rooms, walls, traps, enemies, and loot
* Manage transitions between different game states: playing, paused, game over, and level completion
* Process interactions when the player picks up items and apply the corresponding effects

**Output:**

My 2D Roguelike Game will display:
- The player's score
- The enemies
- Any obstacles in the player's POV

### **Functional Requirements**
- The game uses random dungeon generation to increase replayability.
- The game uses permadeath, meaning that once a character dies, the player must begin a new game which will regenerate the game's levels anew due to procedural generation.
- The game is turn-based, giving the player as much time as needed to make a decision.
- The game is non-modal, in that every action should be available to the player regardless of where they are in the game.
- The game has a degree of complexity due to the number of different game systems in place that allow the player to complete certain goals in multiple ways, creating emergent gameplay.
- The player must use resource management to survive.
- The game is focused on hack and slash-based gameplay, where the goal is to kill many monsters, and where other peaceful options do not exist.
- The game requires the player to explore the world, and discover the purpose of unidentified items.