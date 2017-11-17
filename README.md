# Complete Unity Developer 2.0 - Section 4 - Argon Assault.

This is the long-awaited sequel to the Complete Unity Developer - one of the most successful e-learning courses on the internet! Completely re-worked from scratch with brand-new projects, our latest teaching techniques,. You will benefit from the fact we have already taught over 250,000 students game development, many shipping commercial games as a result.

You're welcome to download, fork or do whatever else legal with all the files! The real value is in our huge, high-quality online tutorials that accompany this repo.

## By In This Section
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

### 21 Project Tidying Checklist ###
In this video (objectives)...
1. Organise Assets folder.
2. Check right game objects have prefabs.
3. Scan read code looking for major errors.
4. Discuss idea of running the game from any scene.

After watching (learning outcomes)...

When returning to a project, or switching modes from designer to coder, you should be able to tidy your project, and feel ready to dive back into the code.
