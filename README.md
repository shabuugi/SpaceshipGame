# 🚀 Space Lander — Game Instructions

## 🎮 Objective
Pilot your spaceship safely onto the ground without crashing into obstacles or hitting the ground too hard.

## 🕹️ Controls
- **↑ Arrow** — Thrust forward (in the direction the spaceship is pointing)  
- **← Arrow** — Rotate left  
- **→ Arrow** — Rotate right  

## 📦 Obstacles
Avoid asteroids, Any collision will destroy the ship.

## 🛬 Landing
To successfully land:
- Approach the ground slowly  
- Touch down with low velocity

[itch.io](https://rs-co.itch.io/spaceship-game)

## Class Relationships & Responsibilities

### **Forces**
Controls the spaceship movement using the new Input System.  
Applies thrust and rotational torque based on player input to move the spaceship in the direction it is facing.

### **Collision**
Handles landing logic and collision detection.  
Determines whether the player has successfully landed or crashed based on impact speed and surface.

### **Follow**
Makes the camera follow the spaceship smoothly.  
Keeps the player centered on screen while the world moves around them.

### **Restart**
restart the game when the r key is pressed.



