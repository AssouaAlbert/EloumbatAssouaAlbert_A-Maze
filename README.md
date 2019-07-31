
# A Maze
Starter project for the Udacity [VR Developer Nanodegree](http://udacity.com/vr) program.

- Course: VR Software Development
- Project: A Maze
- Creator: Eloumbat Assoua Albert


## About
After going through the third phase of the course curriculum, the last part of the stage is implementing the course by building second  project (game) called `A Maze`.  The objectives of this project are:
- Understanding the Project Requirements
- Downloading and Opening the Starter Project
- Downloading and Opening the Starter Project
- Preparing the Scene for Interaction
- Making the Game Objects Interactive
- Making the UI Interactive
- Programming the Coin Behaviour
- Programming the Key Behaviour
- Programming the Door Behaviour
- Programming the SignPost Behaviour
- Creating the Gameplay Functionality
- Update the README file
- Improve, Deploy, Test, and Optimize
- 
## Objective of game
- Find you way across the maze.
- Collect coins.
- Make it into the temple.
- Reset the game to play again.
## How to Play
- At the start of the game, the player is placed in the start position of the game.
- The player uses the reticle to interact with the objects in the came.
- Interactions are created by placing the reticle on any interactable game object.
- The player moves from one position to the other by clicking on any of the blinking game objects(red cubes); they are called way-points. 
- The player can collect coins which have been scattered around the game. There are a total of 51 coins.
- The player collects coins by clicking on them (interacting with them).
- Some groups coins have been hidden for an extra bonus.
- The player moves to the temple from the start position to the temple by finding their way through the maze.
-  The door of the temple is locked by default and the user has to find they key. Which is somewhere near the temple.
- Ounce the user collects the key (by clicking on it) the user , the temple will be opened unlocked ( but not opened).
- The player is to return to the front of the temple and open the door by clicking it.
- **Congratulations you win!!!**
- To play again, simply click on the sign post on the world of the temple which say that ***YOU WIN*** 
- 
## Preparing the Scene for Interaction
The name of the main is called `Main`
## Making the Game Objects Interactive
The game is made three interactive game objects
### Coin
- which when clicked, a sound effect is played at the location of that Coin.
- When a Coin is clicked, that Coin is removed from the scene hierarchy.
### Key
- When the Key is clicked, a sound effect is played at the location of the Key.
- When the Key is clicked, the Key is removed from the scene hierarchy.
- When the Key is clicked, the Door becomes unlocked.
### Door
- When the game starts, the Door is locked and closed.
-   
- The Door cannot be opened when it is locked.
- The Door can only become unlocked by clicking the Key.
- When the Door is clicked and unlocked, the Door starts opening.
- When the Door starts opening, a sound effect is played at the location of the Door.
- The Door is animated to an open position by code only, i.e. not by using animation and animator controller.
### SignPost
- When the SignPost is clicked, the scene resets to its initial state so the game can be played again.
### Waypoints
Waypoints are placed throughout the Maze in such a way that the users can navigate from the start position to all the game objects that can be interacted with, i.e. all the Coins, the Key, the Door, and the SignPost.
## Improve, Deploy, Test, and Optimize
-   Replace the default Skybox (a Skybox material is provided in the Assets folder).
-   Add ambient sound (an audio clip is provided in the Assets folder).
-   Add lights to highlight important parts of the scene.
-   Adjust lights, materials, and lighting settings to reflect the atmosphere you want the game to convey.
-   Optimize game objects, lights, materials, lighting settings and quality settings for mobile VR.
- 
### Versions Used
- [Unity LTS Release 2017.4.15](https://unity3d.com/unity/qa/lts-releases?version=2017.4)
- [GVR SDK for Unity v1.170.0](https://github.com/googlevr/gvr-unity-sdk/releases/tag/v1.100.1)


### About the Starter Project
The included starter project represents a new Unity project where the following have been done:
- All assets needed to complete the project according to the project rubric have been imported.
- The imported models have been placed in the scene and organized in the scene hierarchy.
- Colliders have been added to the `Coin`, `Key`, `Left_Door`, `Right_Door`, and `The_Temple` game objects, and to the `Maze` game object's child game objects.


### Related Repositories
- [VR Software Development - Creating Scripts](https://github.com/udacity/VR-Software-Development_Creating-Scripts/releases)
- [VR Software Development - Controlling Objects Using Code](https://github.com/udacity/VR-Software-Development_Controlling-Objects-Using-Code/releases)
- [VR Software Development - VR Interaction](https://github.com/udacity/VR-Software-Development_VR-Interaction/releases)
- [VR Software Development - Programming Animations](https://github.com/udacity/VR-Software-Development_Programming-Animations/releases)
- [VR Software Development - Physics and Audio](https://github.com/udacity/VR-Software-Development_Physics-and-Audio/releases)
- [VR Software Development - Advanced VR Scripting](https://github.com/udacity/VR-Software-Development_Advanced-VR-Scripting/releases)
- VR Software Development - A Maze


> Written with [StackEdit](https://stackedit.io/).