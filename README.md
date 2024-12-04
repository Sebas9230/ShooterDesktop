# ShooterDesktop
3D Shooter Game for Desktop

## Unity Version:
2022.3.51f1 

## Game Objective:
You have 30 seconds to eliminate as many enemies (zombies) as possible. Achieve victory by taking down more than 10 enemies within the time limit. Be cautious not to hit your allies (soldiers), as doing so will cost you points. Good luck, and aim true!


## Player Instructions
- **Objective**: Shoot enemies while protecting allies. Achieve a score above **10** within **30 seconds** to win.  
- **Controls**:  
  - Move using your mouse.  
  - Click or press the **spacebar** to shoot.  
- **Gameplay**:  
  - Enemies give you **+1 point** when killed.  
  - Allies cause a **-1 point** penalty when killed.  
  - Enemies and allies will randomly appear and disappear in the environment.  

## Core Components
1. **Player**:  
   - The player controls the game using mouse input to look around and shoot.  
   - The game is experienced from the player's point of view.  

2. **Gun and Bullets**:  
   - The main tool for interacting with the environment.  
   - Bullets can hit enemies, allies, or bounce off certain surfaces.  

3. **Allies**:  
   - Randomly placed characters in the environment.  
   - Shooting an ally eliminates them but costs you points.  

4. **Enemies**:  
   - The primary targets in the game.  
   - Shooting an enemy earns you points.  

5. **Environment**:  
   - Provides the medieval theme and gameplay space.  
   - Adapted from a pre-existing template.  
   - Bullets can interact with certain surfaces, creating realistic dynamics.  

## Project Structure
### Game Scenes
1. **Intro Scene**:  
   - The initial screen when running the game.  
   - Allows the player to start or exit the game.  
   - Sets the tone with medieval visuals.  
    ![Medieval Environment](assets/Images/Pantalla_Inicio.png)

2. **Main Scene (Assignment1-1Scene)**:  
   - The primary gameplay environment.  
   - Most interactions, objects, and assets are found here.  
   ![Medieval Environment](assets/Images/Playable.png)

3. **End_Game Scene**:  
   - Triggered when the player scores less than 10 points.  
   - Displays a static "Game Over" screen with no further interaction.  
   ![Medieval Environment](assets/Images/Loose.png)

4. **Win_Game Scene**:  
   - Triggered when the player scores more than 10 points.  
   - Displays a static "You Win" screen with no further interaction.  
   ![Medieval Environment](assets/Images/You_Won.png)

## Logs Locations
- Windows: C:/Users/<Usuario>/AppData/LocalLow/<Project´s Name>/GameLogs.csv
- Android: /data/data/<Package´s Names>/files/GameLogs.csv