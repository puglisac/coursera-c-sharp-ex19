# Exercise 19: Spawn and Explode

This is an exercise for the coursera course [Introduction to C# Programming and Unity](https://www.coursera.org/learn/introduction-programming-unity)

### Problem 1 - Setting up the mouse button processer

Drag the MouseButtonProcessor script from the scripts folder in the Project window onto the Main Camera in the Hierarchy window. Left click the Main Camera in the Hierarchy window to select it.

Expand the prefabs folder in the Project window and drag the Explosion prefab onto the Prefab Explosion field in the Mouse Button Processor (Script) component in the Inspector. Drag the TeddyBear prefab onto the Prefab Teddy Bear field in the Mouse Button Processor (Script) component in the Inspector.

### Problem 2 - Spawn teddy bear on left mouse button

Open the Input Manager, expand the Axes area if necessary, and add 1 to the value next to Size. Expand the bottom input axis (the one you just added) and change the Name to SpawnTeddyBear. Change the Positive Button to mouse 0 and delete the Alt Positive Button.

Open the MouseButtonProcessor script in your IDE.

Add code to the **Update** method to instantiate the teddy bear prefab at the mouse location when there's input on the SpawnTeddyBear axis. The Mouse Button Processing Revisited lecture discusses how to only respond on the first frame of input on an axis; you should use that approach here to make sure you only spawn a single teddy bear when the player presses the left mouse button. The Mouse Location Processing lecture shows how to determine the location of the mouse in world coordinates. 

Test your code to make sure it works properly and debug as necessary.

### Problem 3 - Explode a teddy bear on right mouse button

Open the Input Manager, expand the Axes area if necessary, and add 1 to the value next to Size. Expand the bottom input axis (the one you just added) and change the Name to ExplodeTeddyBear. Change the Positive Button to mouse 1 and delete the Alt Positive Button.

Open the MouseButtonProcessor script in your IDE.

Add code to the **Update** method to explode one of the teddy bears in the game. The Mouse Button Processing Revisited lecture discusses how to only respond on the first frame of input on an axis; you should use that approach here to make sure you only explode a single teddy bear when the player presses the right mouse button. I already tagged the TeddyBear prefab with a TeddyBear tag, so you can get one of the teddy bears in the game using the **GameObject.FindWithTag** method. Because that method can return null (if there are no teddy bears in the game), check for null before trying to blow up the teddy bear. If the teddy bear isn't null, instantiate the explosion prefab at the teddy bear's position and destroy the teddy bear.

Test your code to make sure it works properly and debug as necessary.

## Installation
To install, follow these steps:

Via Downloading from GitHub:

Download this repository onto your machine by clicking the "Clone or Download" button or Fork the repo into your own Github account
Download and extract the zip file to a directory of your choice.  

Via command line:

`$ git clone https://github.com/puglisac/coursera-c-sharp-ex19.git`  

add folder to [Unity](https://unity.com/) with [Unity Hub](https://unity3d.com/get-unity/download).
