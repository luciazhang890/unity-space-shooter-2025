# Unity Space Shooter 2D (2025)

A beginner-friendly 2D space shooter game built with Unity 6.  


## 🎮 How to Run

Open the project in Unity 2022+ or Unity 6.

1. Clone the repository  
2. Open it in Unity Hub  
3. Hit ▶️ Play in the Unity Editor

## 🧠 What I’ve Practiced

- Scene organization in Unity
- Using C# scripts with `MonoBehaviour`
- Managing assets (sprites, scripts, components)


## ✅ Features Completed

### 🧱 Feature 1: Infinite Parallax Scrolling Background
This feature implements a multi-layered scrolling background to simulate depth using the parallax effect.

What I did:
	•	Added multiple background image layers (e.g. stars, planets, distant space).
	•	Each layer is assigned a different movement speed to create a depth illusion.
	•	Created a ParallaxBackground.cs script attached to background layers.
	•	Calculated background width using sprite.texture.width / pixelsPerUnit for seamless loop.
	•	Repositioned backgrounds when they move off-screen to simulate infinite scrolling.

What I learned:
	•	How to access and manipulate SpriteRenderer in Unity.
	•	Using Time.deltaTime and transform.position to implement smooth movement.
	•	Structuring reusable MonoBehaviour scripts for environmental effects.


## 📚 Tutorial Source
This project follows the [Unity 2D for Beginners: Build a Complete Game (2025)](https://www.youtube.com/watch?v=P377cNMG4lg&t=1347s)) and demonstrates core gameplay mechanics including movement, parallax background, collisions, and more.
