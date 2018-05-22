# Complete Unity Developer 2.0 - Section 4 - Argon Assault.

This is the [Complete Unity C# Developer 3D](http://gdev.tv/cu2github), the long-awaited sequel to the [Complete Unity C# Developer 2D](http://gdev.tv/cudgithub) - one of the most successful e-learning courses on the internet! Completely re-worked from scratch with brand-new projects, our latest teaching techniques,. You will benefit from the fact we have already taught over 250,000 students game development, many shipping commercial games as a result.

You're welcome to download, fork or do whatever else legal with all the files! The real value is in our huge, high-quality online tutorials that accompany this repo. You can check out the course here: [Complete Unity C# Developer 3D](http://gdev.tv/cu2github)

## In This Section
Instantiating At Runtime, Make Components Communicate, Create Detailed 2D UI, Use BitBucket, Using Virtual Controls, Craft C# Classes, Customise Particle Effects, Player Power Ups & More (REF: AA_CU2)

## How To Build / Compile
This is a Unity project. If you're familiar with source control, then "clone this repo". Otherwise download the contents, and navigate to `Assets > Levels` then open any `.unity` file.

This branch is the course branch, each commit corresponds to a lecture in the course. The current state is our latest progress.

## Lecture List
Here are the lectures of the course for this section...

### 1 Welcome To Section 4 ###
1. This game is based on classics like Star Fox and Panzer Dragoon.
2. We will be using Unity 2017's brand-new Timeline facility.
3. This will be fast-paced fun rail-shooter.

### 2 Argon Assault Game Design ###
1. A quick look at an example of a Rail Shooter.
2. What are our core game features and priorities?
3. Creating a prototype to answer key questions.

### 3 Update Unity & Create Project ###
1. Update to at least Unity 2017.2.
2. Create a new 3D project.
3. Set up your repo.

### 4 Create Terrain ###
1. Add terrain to your level.
2. Use the raise and lower terrain tool to make mountains.
3. Resize and reposition the terrain.

### 5 Texture The Terrain ###
1. Find texture assets on the Unity Asset Store.
2. Add terrain texture, change scaling, change metallic and smoothness.
3. Bump Maps versus Height Maps versus Normal Maps.

### 6 Add A Skybox ###
1. Procedural versus 6-sided skyboxes.
2. Applying skybox asset to your scene.

### 7 Add Player Ship ###
1. Some performance tweaks to help avoid slowdowns.
2. Downloading asset pack for space ship.
3. Building modular spaceship.

### 8 Setup A Splash Screen ###
1. What a splash screen is.
2. Make first game scene load after delay.
3. Choose background music for your game.

### 9 Playing Music Between Scenes ###
1. About game objects getting destroyed by scene load.
2. Ben's injection pattern for persistent music.
3. Using `DontDestroyOnLoad()`.

### 10 Unity’s Waypoint Utility Scripts ###
1. Import Standard Assets > Utility.
2. Setup a waypoint circuit using `WaypointCircuit.cs`.
3. Use the `WaypointProgressTracker.cs` script.
4. Make the camera follow a fixed path.

### 10b Instructor Hangout 4.1 ###
1. Considerations for Waypoint system versus Timeline.
2. Q&A answers and responses.
3. Good tips from students.

### 11 Using Cross Platform Input ###
1. About using virtual controls.
2. Introducing `CrossPlatformInputManager`.
3. Understanding control throw for keyboard and gamepad.

### 12 Input Sensitivity & Gravity ###
1. How input sensitivity & gravity work.
2. Using `[Tooltip("Handy tip")]` attribute for inspector tips.
3. Understanding throw and movement speed.

### 13 Mathf.Clamp() To Restrict Movement ###
1. Using `transform.localPosition`
2. How to use `Mathf.Clamp()`
3. Constrain our player movement to the screen.

### 14 Understanding Roll, Pitch & Yaw ###
1. Getting clamped vertical movement working.
2. Defining Roll, Pitch and Yaw.
3. How to rotate to aim at the right place.

### 15 How To Set Local Rotation ###
1. Experience order sensitivity in rotations.
2. Using `Quaternion.Euler()`.
3. Setting `localRotation` from code.

### 16 Rotate Ship With Position & Throw ###
1. Set pitch based on screen position.
2. Set pitch based also on control throw.
3. Set yaw based on screen position.
4. Set roll based on control throw.

### 17 Time To Tweak And Tune ###
1. Tune rail speed and camera FOV.
2. Tune ship speed, rolls, clamps.
3. Note about 16:9 aspect ratio in game window.
4. Tweak the rail position to give the feeling of speed.

### 18 Create Bullet Particles ###
1. Use particles to visualise where our ship is shooting.
2. Introduction to Unity's particle systems.
3. Create particle system that looks like bullets or lasers.

### 19 Explosion Particles & SFX ###
1. Create explosion particle effect.
2. Attach SFX component to explosion particle.
3. Use more of the particle system modules.

### 20 Dodge And Shoot ###
1. Create obstacles to avoid.
2. Create placeholder enemies for the player to aim at and shoot.
3. Create 10-20 seconds of gameplay setup, ready for our functionality.

### 20b Instructor Hangout 4.2 ###
1. Deep dive into the player movement including understanding why we have created xOffset, what exactly Time.deltaTime is calculating and why we clamp our movement.
2. Q&A answers and responses.
3. Good tips from students.

### 21 Project Tidying Checklist ###
In this video (objectives)...
1. Organise Assets folder.
2. Check right game objects have prefabs.
3. Scan read code looking for major errors.
4. Discuss idea of running the game from any scene.

After watching (learning outcomes)...

When returning to a project, or switching modes from designer to coder, you should be able to tidy your project, and feel ready to dive back into the code.

### 22 Triggers & Collisions In Unity ###
In this video (objectives)...
1. Attempt to detect collisions with the terrain.
2. Explore Unity (and Ben's) collision matrix.
3. Discuss static, rigidbody and kinematic rigidbody colliders.
4. Use `OnTriggerEnter()` to detect player hitting things.

After watching (learning outcomes)...

Determine what sort of colliders to add to in order to raise collision and trigger messages.

### 23 SendMessage() Between Components ###
In this video (objectives)...
1. Correct an error in Unity's `WaypointCircuit.cs`
2. How NOT to use "Manager" in the name of your scripts.
3. Create a new `CollisionHandler` component.
4. Rename our `Player` to `PlayerController`.
5. Use `SendMessage()` to communicate between components.

After watching (learning outcomes)...

Create a new well-named component to prevent your existing component code from getting too large.

### 24 Enable A Gameobject From C# ###
In this video (objectives)...
1. Attached our bundled VFX and SFX prefab to the player.
2. Show consequence of disabling in the Inspector.
3. Use `.SetActive(true)` to enable a game object during play.

After watching (learning outcomes)...

Enable a game object from C#, useful for combined special effects (FX) prefabs.

### 25 Singleton Pattern Without Statics ###
In this video (objectives)...
1. Over the singleton pattern as it applies to the Music Player.
2. Pseudocode the logic.
3. Use `FindObjectsOfType()`.

After watching (learning outcomes)...

Setup a singleton pattern for self-destroying objects in Unity, without using the concepts of static variables.

### 26 Detecting Particle Collisions ###
**In this video (objectives)…**

1. Turn on World collisions on our particle system.
2. Ensure our enemies have **non-trigger** colliders.
3. Use 'OnParticleCollision()' to detect collision.

**After watching (learning outcomes)…**

Use particle systems as bullet streams, and detect the collisions with game objects (e.g. enemies)


### 27 Making Scripts Add Components ###
**In this video (objectives)…**

1. Remove colliders from asset pack prefabs, returning to vanilla state.
2. Arrange for enemies to add their own colliders on start.


**After watching (learning outcomes)…**

Arrange for game objects to add their own required components at run time, reducing their dependency on assets being setup a particular way.


### 28 Instantiating At Runtime ###
**In this video (objectives)…**

1. Discuss how to recreate our explosion prefab.
2. Why we use prefabs differently for the enemies.
3. Instantiate an explosion on enemy death.
4. Make the explosion FX self-destruct.


**After watching (learning outcomes)…**

Instantiate game objects at run time, parent them to in the hierarchy, and chose their position in world space.


### 29 Add Simple Score UI ###
**In this video (objectives)…**

1. Add a UI text element to our game.
2. Overview the new Canvas object.
3. Add a score and customise the font.

**After watching (learning outcomes)…**

Add UI text elements to the game, and position and scale them. Also find and use free custom fonts.


### 30 A ScoreBoard Class ###
**In this video (objectives)…**

1. Overview what a class is in programming.
2. Add `ScoreBoard.cs` to our UI text.
3. Write our first `public` method.


**After watching (learning outcomes)…**

Describe in basic terms what a class is in Object Oriented Programming (OOP).


### 30b Instructor Hangout 4.3 ###
**In this video (objectives)…**

1. Deep discussion regarding Component.SendMessage.
2. Some tips from students.
3. Some questions from students.

**After watching (learning outcomes)…**

Have greater clarity on how Messages are used.

### 31 Introducing Encapsulation ###
**In this video (objectives)…**

1. Ensure our Canvas Scaler is set correctly.
2. Use `FindObjectOfType()` to find the `scoreBoard`.
3. Communicate between enemy and scoreboard.

**After watching (learning outcomes)…**

Separate a script into two, and arrange for them to find and and communicate with one another in a basic way.


### 32 Back-pedalling With Version Control ###
**In this video (objectives)…**

1. Use `git stash` to safely discard our changes.
2. Use branch and reset to discard multiple commits.

**After watching (learning outcomes)…**

Restore a project that has been tracked under version control to a previous commit safely.


### 33 Iterating With foreach ###
**In this video (objectives)…**

1. Setup an input Button for "Fire"
2. Expose an array of game objects to the Inspector.
3. Automatically iterate over the array using `foreach`
4. Give player ability to start and stop guns.


**After watching (learning outcomes)…**

Use a `foreach` loop to iterate over an entire collection automatically.


### 34 Enemy Health System ###
**In this video (objectives)…**

1. Create a system for storing enemy hitpoints.
2. Decrement enemy hitpoints when hit by player bullet.
3. Kill enemy when hitpoints are below 1.


**After watching (learning outcomes)…**

Set up a simple health system that decrements when hit by player bullets.


### 35 Level Design Beat Chart ###
**In this video (objectives)…**

1. Introduction to the concept of the level design beat chart.
2. See how the ups and downs of a level can be mapped / charted.
3. Consider the beats of your game in relation to the story you are wanting to tell.


**After watching (learning outcomes)…**

Set up a level design beat chart for your level.


### 36 Level Design Iteration ###
**In this video (objectives)…**

1. Discuss the most important considerations for our level.
2. Create good spawn points for our enemies.
3. Match our level design to our beat chart.


**After watching (learning outcomes)…**

Created a level which is ready for the final player flight path to be created.


### 37 Introduction To Unity Timeline ###
**In this video (objectives)…**

1. Set up a Playable Director on one of our enemy ships.
2. Create a simple animation using timeline for our enemy.
3. Tweak the position of the enemy so that we can shoot and destroy it.


**After watching (learning outcomes)…**

Use Unity Timeline to animate one enemy ship to fly in front of the player.


### 38 Unity Timeline For Player Path ###
**In this video (objectives)…**

1. Create a master timeline to drive all other timelines.
2. Add player rig to master timline.
3. Move the player rig through the scene to create the flight path.


**After watching (learning outcomes)…**

Use Unity Timeline to create the player flight path.


### 39 Unity Timeline Enemy Waves ###
**In this video (objectives)…**

1. Create a new timeline for an enemy wave.
2. Add enemy wave to the master timeline through a control track.
3. Duplicate enemy wave for re-use.


**After watching (learning outcomes)…**

Use Unity Timeline to create re-usable enemy waves consisting of multiple enemy animations.


### 40 Adding Flavour With Timeline ###
**In this video (objectives)…**

1. Set up timeline track groups.
2. Brainstorm creative ways to use timeline for your project.
3. Add something new with timeline - for us it will be a character image with audio during key moments in the level.


**After watching (learning outcomes)…**

Use Unity Timeline to create UI popup with audio dialogue.


### 41 Stop Particle Emission In C# ###
**In this video (objectives)…**

1. Refactor our gun enabling code.
2. Find the particle system emission module.
3. Stop bullet stream disappearing when we cease fire.

**After watching (learning outcomes)…**

Turn a particle system emission on and off in C#.


### 42 Visual Polish ###
**In this video (objectives)…**

1. Create an visual atmosphere in our level which matches our intention.
2. Add particle effects as rocket boosters to ships.
3. Add fog to our scene to soften the look.

**After watching (learning outcomes)…**

Use lighting, fog and particles to create a visual atmosphere in the level.


### 43 Section 4 Wrap-Up ###
**In this video (objectives)…**

1. Re-iterate some of the core things we have learned in this section of the course.

**After watching (learning outcomes)…**

Ready to take on the next section!
