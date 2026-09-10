# 2D RPG Game – Unity

This is a 2D pixel-art RPG game I built using **Unity and C#** as a personal project.

I started this project because I wanted to learn game development in a practical way. I already had experience programming in C and Java, but Unity and C# introduced me to a very different way of thinking about software — especially when working with game loops, physics, animations, components and interactions between different objects.

What originally started as a simple player that could move around a level gradually turned into a small playable game with combat, enemies, health, enemy spawning, a protection objective and a complete game-over/restart loop.

---

## 🎮 Gameplay

<img width="800" height="450" alt="Gameplay01GIF" src="https://github.com/user-attachments/assets/cd55cf20-7a5c-4e52-9dcd-1d62c0923ce5" />

The goal is simple: **survive and protect the object in the level.**

The player can move, jump and attack enemies. Enemies continuously spawn from different locations and move through the level, attacking when they detect a target.

As time passes, enemies begin spawning faster, making the game progressively more difficult.

The game ends when either the **player dies** or the **protected object is destroyed**. The player can then restart the level and try again.

### Gameplay Preview

<!-- Add the gameplay GIF here later -->

![Gameplay Preview](path-to-gameplay-gif.gif)

---

## ⚔️ Features

The finished version includes:

- Player movement and jumping
- Player attack system
- Enemy movement and attacks
- Enemy target detection
- Randomized enemy spawn locations
- Enemy respawn system
- Increasing spawn rate over time
- Health and damage system
- Visual damage feedback
- Character animations
- Animation events
- Ground and collision detection
- Kill counter
- Game timer
- Object protection mechanic
- Game-over screen
- Level restart system

---

## 🧠 What I Learned

This project was mainly about learning by building.

Instead of only following C# syntax and Unity tutorials, I tried to understand why each system was needed and how the different parts of the game communicate with each other.

One of the most useful parts of the project was getting more comfortable with **object-oriented programming** in an actual application. I worked with inheritance, method overriding and polymorphism to reuse behaviour between different game entities while still allowing them to behave differently.

I also gained practical experience with:

- C# and object-oriented programming
- Unity's `MonoBehaviour` lifecycle
- Rigidbody2D physics
- Colliders and LayerMasks
- Raycasts and overlap detection
- Prefabs
- Runtime object instantiation
- Coroutines
- Animator Controllers
- Animation Events
- TextMeshPro
- Scene management
- UI and game-state logic
- Debugging C# scripts and Unity components

A big part of the learning process was also debugging situations where the C# code itself was correct, but something was configured incorrectly inside Unity. That helped me better understand the connection between code and Unity's component-based system.

---

## 🛠️ Tools & Technologies

- **Unity**
- **C#**
- **Visual Studio**
- **Git & GitHub**
- **TextMeshPro**

---

## 🏗️ How the Game Works

The game is built around several small systems working together.

The player handles movement, jumping, attacks, health and animations. Enemies use shared gameplay behaviour while adding their own movement and attack logic.

An enemy respawner periodically creates enemies at different spawn points. The delay between spawns decreases over time, which gradually increases the difficulty.

The UI keeps track of the elapsed time and number of enemies defeated. When either the player or the protected object reaches zero health, the game-over interface is displayed and the level can be restarted.

This gave me experience thinking about a game as a collection of interacting systems rather than putting all of the logic into one large script.

---

## 📚 Why I Built This

Game development has been something I wanted to explore alongside my other programming and engineering projects.

I chose to build a 2D game first because it gave me the opportunity to focus on the programming behind the game — movement, combat, enemy behaviour, physics, UI and game logic — without immediately jumping into the complexity of a large 3D project.

The project also gave me a chance to apply concepts I had previously learned in C and Java in a completely different environment.

---

## ✅ Project Status

**Completed**

This project represents the first completed version of the game and the core gameplay systems I originally wanted to implement.

There are plenty of things that could be expanded in the future, but I consider this version complete and plan to use what I learned here in future game-development projects.




