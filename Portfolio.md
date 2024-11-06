# **9CT1B - Assessment Task 3 Part B**
# **By Levin Shao**
## **Section 1: Identifying and Defining**
### **Identifying a Need**
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
- The game will be able to process the user inputs and let them control the character, interact with objects and NPCs, attack enemies and bosses, and select and switch weapons
- Users will be able to control and move the character using the A and D keys, or the left and right arrow keys. When the user presses the A/left arrow key, the character will move left. When the user presses the D/right arrow key, the character will move right.
- Users make the character jump by pressing the W/spacebar/up arrow key.
- Users can interact with objects and NPCs by pressing the E key. When they press the E key on an object, depending on what the object is, the player can either collect it, or the object can deal effects on the player.
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
- Messages will pop up and notify the player upon completing significant actions (e.g. “Rare Item Unlocked!” when the player discovers a rare item)

**Level Progression:**
- Players will advance to the next level by reaching the exit point in the current level
- Upon level completion, the player will receive rewards such as upgraded items and new abilities
- With each new level, the game will increase difficulty by adding more challenging enemies and traps
- Some levels will feature boss encounters that the player must defeat to progress further. These encounters will have unique mechanics and will unlock special rewards upon victory

**Saving and Loading Data:**
- The game will autosave player progress after each level, including the player's health, items, score, and current level
- Saved data will be stored locally on the user's device
- Settings like audio volume and display settings will be saved and reloaded when the player restarts the game
- The game will save high scores locally, which will be displayed in the game's main menu
### **Non-Functional Requirements**
**Performance Requirements:**
- The game will load within 5 seconds on standard PCs
- Frame rate will be maintained at 60 FPS (frames per second) even during intense combat or with multiple enemies on screen
- The game will respond to user inputs instantly, with less than 80ms of ping to ensure responsive and fluid controls

**Usability Requirements:**
- The game will have a intuitive and simplistic UI with clear indicators for health, inventory, and abilities, allowing players to quickly understand game mechanics
- A tutorial level will be added to guide new players through the basic controls and mechanics
- The game will include tooltips or quick explanations for items, abilities, and status effects when hovered over or selected

**Compatibility Requirements:**
- The game must be compatible with Windows, macOS, and Linux
- The user interface and controls will adapt for keyboard/mouse setups on PC
- The game will be optimized for different screen resolutions and aspect ratios, maintaining visual clarity and functionality on both standard and widescreen displays
### **Consideration of Social and Ethical Issues**
#### **Definitions:**
**Equity:** Equity is the practice of ensuring fairness and justice by providing everyone with the resources or opportunities they need to succeed, accounting for individual differences and circumstances.

**Accessibility:** Accessibility is the practice of making information, activities, and environments sensible, meaningful, and usable for as many people as possible.
#### **Accessibility:**
The game should support players with diabilities by including features such as subtitles for all audio content and sound effects and colorblind modes for players with visual impairments. An easy mode that simplifies the gameplay or provides hints to assist users who find the game too difficult could also be added.
#### **Privacy and Data Protection:**
Personal information must be stored securely and can only be collected with the player's consent. The game must ensure that all saved data is stored locally on the player's device. No unnecessary personal data should be collected, and the collected data must not be used for malicious purposes.
#### **Fairness and Representation:**
The game should avoid bias or stereotypes by ensuring that the characters, enemies, and story elements are diverse and respectful of different genders, races, and cultures.
#### **Mental and Emotional Well-Being:**
The game should balance challenge with reward and offer difficulty settings to ensure that players do not feel excessively frustrated. The game should also avoid excessive violence or disturbing content to ensure that the game does not negatively affect the mental or emotional well-being of the players.
#### **Cultural Sensitivities:**
The game should avoid using any symbols, themes, or language that could be deemed inappropriate or offensive in various cultural contexts. The game should be free from any culturally specific content that might alienate or harm players from different backgrounds.

## **Section 2: Researching and Planning**
### **Exploration of Existing Ideas**
**2D Roguelike Game Examples**
- Dead Cells (2018) by Motion Twin, Evil Empire, and Playdigious
- Slay the Spire (2019) by Mega Crit
- The Binding of Isaac (2011) by Edmund McMillen and Florian Himsl

**PMI Tables**
| Game 1 | Plus | Minus | Interesting |
| --- | --- | --- | --- |
| **Dead Cells (2018)** | Satisfying combat system | High level of difficulty  | The levels are kept fresh and original thanks to procedural generation |
| **Dead Cells Cover** ![Dead Cells Cover Image](/images/dead-cells/dead-cells-cover.jpg) | Amazing pixel art with atmospheric environments | Lack of lore and narrative depth | Perma-death feature adds tension and excitement for the player |
| **Dead Cells Gameplay** ![Dead Cells Gameplay Image](/images/dead-cells/dead-cells-gameplay.jpg) | Very responsive controls | Repetitive grinding is required to unlock new weapons and upgrades | Weapons and abilities can radically change the player's playstyle |

| Game 2 | Plus | Minus | Interesting |
| --- | --- | --- | --- |
| **Slay the Spire (2019)** | Innovative card-based combat system | Becomes very boring and repetitive over time | Deck-building mechanic adds layers of strategy to the game |
| **Slay the Spire Cover** ![Slay the Spire Cover Image](/images/slay-the-spire/slay-the-spire-cover.jpg) | Requires deep thinking and problem solving skills | Lack of animation and graphics | Combines roguelike elements with card games |
| **Slay the Spire Gameplay** ![Slay the Spire Gameplay Image](/images/slay-the-spire/slay-the-spire-gameplay.jpg) | Every run feels different thanks to randomization | Some RNG can ruin good strategies in a single move | Powerful combos can be created by synergizing cards |

| Game 3 | Plus | Minus | Interesting |
| --- | --- | --- | --- |
| **The Binding of Isaac (2011)** | Endless replayability due to randomization | Contains dark and grotesque themes and imagery | Unpredictable combinations of items makes the game more thrilling |
| **The Binding of Isaac Cover** ![The Binding of Isaac Cover Image](/images/the-binding-of-isaac/the-binding-of-isaac-cover.jpg) | Challenging yet rewarding gameplay | Can feel overwhelming with its many items and enemies | Exciting and addictive due to procedurally generated rooms and item drops |
| **The Binding of Isaac Gameplay** ![The Binding of Isaac Gameplay Image](/images/the-binding-of-isaac/the-binding-of-isaac-gameplay.jpg) | Huge variety of items and power-ups available for the player to use | High level of difficulty and very complex | Story elements are delivered through cryptic clues and symbolism |

### **Flowchart and Pseudocode**