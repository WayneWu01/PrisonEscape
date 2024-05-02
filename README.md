# Prison-Escape

**Sprints:** [Sprint 1](#sprint-1) | [Sprint 2](#sprint-2) | [Sprint 3](#sprint-3) | [Sprint 4](#sprint-4) | [Sprint 5](#sprint-5) 

---

## Sprint 5

Our primary goal for this sprint was to complete the puzzles, and connect them together. We also wanted to finalize the start and end screens, and connect all of them together. We also wanted to fix some issues with our implementation of the Normcore system.

### How to find our modifications

Our modifications can be found in the `main` branch.

The start menu and lobby system modifications can be seen in `Scenes/Start Menu` and `Scenes/Lobby`. If building, make sure these scenes are checked and in that order under Build Settings > Scenes in Build. Through the leftmost door, there is a button to create a new game, sending the player to a new lobby and generating a unique game code. The middle door has a keypad where players can use the left trigger button to enter a code to join a friend's existing game. The final door has settings which can be toggled with the left trigger button.

Additional puzzles have been added to `Scenes/Cell` and `Scenes/warden`. To find these modifications directly, build only the scene you want to inspect.

### Team Members and Contributions

***Olivia:*** Created the following Warden's office puzzles: the fire turns on for a number of seconds in a cycle. When players type this number code in the remote, the TV turns on and shows pictures from Canada. Players must then view Canada on the map, which is blue, and exit the game with the blue key. Also created the capability for the number pad in the cells as well as the completed chess puzzle.

***Rachel:*** Merged the `Braille` branch into `main` and fixed merge conflicts. Created the end screen. Added a clue for the bishop transfer puzzle.

***Nicole:*** Made it so new start room is generated for each player. Fixed game code generation and added keypad system so players can enter an existing game. Redesigned lobby scene. Added sound effects to interactable items in start room and waiting lobby. Added settings like toggleable background music. Fixed how players are automatically moved to separate cells. Adjusted spatialized audio source generated by Normcore to allow players to hear each other from the other cell.

***Charlotte:***  Added decorations to warden's office (objects unrelated to clues).

***Wayne:*** Searched and added background music to the warden's office and cells. Added a phonograph in warden's office for playing the music. Created and added the video for playing on the TV in the warden's office. By doing so, it will remind the players for the key color of Canada (the map ab obove TV) so that the player can choose the right lock.

### Videos

[Click here](https://drive.google.com/drive/folders/1WAXRjpW_Uh1sW_HspYOPxsSWJpkLzWDY?usp=sharing) for a link to a google drive folder containing our videos for this sprint.


---


## Sprint 4

Our primary goal for this sprint was to create interactions for most of the puzzles. After feeling more practiced with Unity designs, scripts, and interactions, we have now jumped into creating as many puzzles as possible out of our original 5 ideas. We also wanted to implement a key and lock mechanism because this is an important component to the escape game.

### How to find our modifications
One major modification is a puzzle that incorporates both cells. The player in Cell A must find a hidden key and use it to unlock a fusebox. Once opened, they will find switches and must flip them according to a code in the other room to reveal a hidden clue in the lights. The incorrect code only causes the lights to change color. This puzzle can be found on the main branch. The XR origin will automatically place the player into Cell A, so to see the Cell B component, set the XR Origin in Cell B instead (the random assignment of players into separate cells has been developed but is not yet in the main branch for testing purposes). Another modification on the toilet-portal branch is the toilet portal. After breaking the tallied wall with the hammer, the user can place the chess piece in the toilet and flush it to send it to the other cell. This puzzle is on a separate branch because there is still a bug, but is near completion. (EDIT: the toilet portal bug has been fixed and is now pushed to main. It can be seen with the tallies puzzle in Cell B).

The Braille puzzle modifications can be found on the `braille` branch in the `Cell` scene.

The start menu modifications can be seen in the `lobby-system` branch. (Changes aren't merged to `main` to make it easier to test the puzzles). To test the start menu, make sure that `Scenes/Start Menu`, `Scenes/Lobby`, and `Scenes/Cell` are checked and in that order under Build Settings > Scenes in Build. Then build the project for the Quest 2 as described in class. After launching the game, pick up the keys on the crate and use them to open the leftmost door. Navigate using the joysticks or by teleporting with the left controller. Hit the button with your right hand. This should load the waiting lobby. Then hit this next red button to be transported to a prison cell.

### Design

The first thing the user sees is the start screen, which is a dimly lit jail cell with three cell doors that will lead to the different game options: create a game, join a game, and settings. Ominous music and jail noises will accompany this screen to communicate an eery and dangerous feeling. We chose teleporation for ease of movement around the spaces and in order for the user to correctly place themselves in front of/around clues. 

### Team Members and Contributions

***Olivia:*** 
Created the fusebox/spotlight puzzle incorporating both cells. Also put together our puzzle ideas into one cohesive flow. Through this process, discovered how to create hinge joints, how to open a door, and how to touch objects with the hands. Also gained useful knowledge about Rigidbodys and triggers. Began creation of a numeric keypad for the next puzzle. Also created the toilet portal.

***Rachel:*** Made the Braille puzzle more interactable. Now, when the correct code is clicked on a braille letter, the tiles will be replaced by the latin letter. When all three letters are typed correctly, the exit doorway opens.

***Nicole:*** Added functionality to create a new game from the immersive start menu. Added XR Socket Interactor to doors so players can insert keys. Added Animator system to project and animated door opening when key is inserted. Added system to create new Normcore rooms with randomly-generated names. Improved code behind changing scenes.

***Charlotte:***  Designed and created start screen. Also completed design choices section of sprint.

***Wayne:***  Finished the flashlight puzzle; made the numbers on the wall only when the flashlight shone on the numbers; made the click sound and applied a key on keyboard to control whether the light is on or not.

### Videos

[Click here](https://drive.google.com/drive/folders/1bbSiEvfpM85IKH2Cs0GjJvP6iNIeWgSu?usp=sharing) for a link to a google drive folder containing our videos for this sprint.


---



## Sprint 3

Our primary goal for this sprint was to begin implementing the puzzles in the prison cells. By the end of the sprint, we aimed to have 2 separate cells, finish placing the assets in each cell, make significant progress on at least 2 puzzles, and create a start screen where players can be randomly assigned to each cell. Starting on these complex puzzles was important as they are a key feature of our gameplay experience. They also posed many challenges including needing custom assets, grabbable objects, collisions, and scripts. Now that we have learned how to add these features, we are prepared to continue implementing puzzles in the next sprint. Our additional goal for this sprint was to solve our first multiplayer challenge—automatically dividing players between the two prison cells. Now that these tasks are complete, our game is beginning to take shape.

### How to find our modifications

The lobby modifications can be seen in the `lobby-system` branch. (Changes aren't merged to `main` to make it easier to test the puzzles) To test the lobby, make sure that `Scenes/Lobby` and `Scenes/Cell` are checked and in that order under Build Settings > Scenes in Build. Then build the project for the Quest 2 as described in class. Navigate to the red button using the joysticks or teleporting with the left controller. Hit the button with your right hand.

The tally puzzle can be found in the branch olivia-tallyPuzzle. To see this puzzle, ensure that the XR origin is set inside Cell B. You will be able to pick up the hammer and smash the wall at the locations where the tallies are marked with an X. Then, grabbable chess pieces are found inside the wall.

Changes to the braille puzzle can be seen in the `braille` branch. To test this, view the `Cell` scene.

The flashlight puzzle can be found on the main branch. Pick up the flashlight and shine it on the wall as shown in the video.

### Team Members and Contributions

***Olivia:*** Completed MVP for puzzle 1: tallies on wall, wall breaks on contact with hammer, and chess pieces found inside. This puzzle was important to complete because it includes many different types of interactions, like grabbable objects, collisions, teleportation, and modification of the brick material. Now, I better understand how to create these capabilities for new puzzles moving forward. *Note: this change is still in a separate branch from main called olivia-talliesPuzzle because it has merge conflicts with the main branch that we would like to resolve with the TA.* 
Also created capability for grabbable objects with the right hand and teleportation with the left hand. 

***Rachel:*** Created the video for our sprint. Worked on creating new tiles (Changed the size and aesthetic because the tiles were difficult to look at and it was not clear they were buttons) for the Braille puzzle and making them interactable. These changes exist on the `braille` branch rather than `main` because they are still in development and are not fully tested and functional.

***Nicole:*** Created lobby where players wait for everyone to join before hitting button to begin game. Text automatically updates to reflect number of players currently in room. Upon beginning game, players are randomly placed with half in one prison cell and half in the other. *Note: currently allows playing with one player to make testing easier.* Created singleton game manager for data persistence.

***Charlotte:***  Continued asset management, populated cells A and B and warden's office with non-clue assets. Added to list of puzzles for warden's office.

***Wayne:*** Began puzzle 5 and finished making the painting/codes only visible under the flashlight. Added all related puzzle's assets and scripts. There is a flashlight in the cell and it can be moved to make the painting on the wall visible. By making this work, I can change the painting to password or something else that is needed in the future.

### Video

Below is a video showing the changes to our lobby tally puzzle, braille puzzle, and flashlight puzzle.

https://youtu.be/KgZ3RI9YdGk

---


## Sprint 2

Our primary goal for this sprint was to design the main puzzles for our game. This was important to do first because the puzzles dictate the assets needed, interaction and locomotion systems, and the overall gameplay flow. We all brainstormed ideas and then worked collaboratively to piece them together. The following image shows the floor plan for each cell including our ideas for the puzzle layout. In order to keep the puzzles a surprise for the class, we will not give details in this readme file about our current plans for how they will work.

![cell1](https://user-images.githubusercontent.com/65799482/194463047-ea3bcc6d-16c1-4050-a9df-9ff1f8112972.jpg)
![cell2](https://user-images.githubusercontent.com/65799482/194463059-65755a10-b7b5-428f-9bd3-b586bb3f9e41.jpg)

After this planning phase, we began working on basic setup tasks so that we can fully implement these puzzles in future sprints.


### Team Members and Contributions

In addition to the listed roles, all team members designed a puzzle to be placed into the rooms.

***Olivia:*** Added lighting and a ceiling to the prison cells and warden’s office. In a separate Unity project, created an XR socket interaction where only one particular key fits into and opens a lock, which then triggers a script to open a door. This capability will be used as the unlocking mechanism for the puzzles in our unity project, and defines the interaction for locking items into place. Link to demo: https://drive.google.com/file/d/1hO3sKoHqRzYjWD8WyCw_9Hth_eS4ZyMV/view?usp=sharing 

***Rachel:*** Located premade assets and built custom assets required for puzzles such as braille tiles. Created and recorded the video for our sprint and committed the readme file.

***Nicole:*** Researched pros and cons of locomotion systems then decided to implement both continuous movement (left joystick to move, right to turn) and teleportation. Custom script (will attach to a menu in the future) to disable teleportation if player chooses. Added basic networking and planned more complex features with Olivia.

***Charlotte:*** Designed floor plan for prison cells, hallway, and warden’s office. Added assets including a flashlight and a lock and key. 

***Wayne:*** Created first cell for Sprint 1. For Sprint 2, created a new scene for the warden's office and built the room. Added non-puzzle assets.

### Video

Below is a video showing off our environments—the prison cells and the warden’s office. In the video, we also demonstrate locomotion and multiplayer features. More of our changes can be seen in the Assets folder where we have gathered resources that we will use to implement the puzzles we designed.

https://user-images.githubusercontent.com/65799482/194461093-a4a63efa-c7ef-4d55-b889-ccea26af96cb.MOV

---

## Sprint 1

### Team Members and Overall Roles
***Charlotte:*** Assets Manager

***Rachel:*** Video and documentation

***Wayne:*** Cell setup

***Olivia:*** GitHub master

***Nicole:*** Locomotion system

#### We have all successfully cloned this project
