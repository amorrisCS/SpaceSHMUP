# Space Shmup
**Author:** Austin Morris__
**Student ID:** 800737964__
**Course:** CS382 – Game Design, Development, and Technology
**Project:** Project 3

---

## Overview

A space shooter (shoot 'em up) game built in Unity following the Space SHMUP tutorial from *Introduction to Game Design, Prototyping, and Development* by Jeremy Gibson Bond (Chapters 31–32). The player controls a hero ship that must survive waves of incoming enemies while accumulating the highest score possible.

---

## How to Play

- **Move:** Arrow keys or WASD
- **Shoot:** Spacebar
- Destroy enemies to earn points
- Collect power-ups dropped by enemies to upgrade your weapon or restore shields
- The game restarts automatically if your ship is destroyed

---

## Project Requirements

- **5 Enemy Types (Ch. 32):** All five enemy variants (Enemy_0 through Enemy_4) are included and spawn randomly during gameplay.
- **Enemies Damage the Player:** Enemies that collide with the hero ship reduce the player's shield level. When shields are depleted, the ship is destroyed.
- **Shooting:** The hero ship fires projectiles that deal damage to enemies based on the active weapon type.
- **Scrolling Starfield Background (Ch. 32):** A parallax scrolling starfield is present in the scene, providing a sense of motion through space.

---

## Enhancement: Scoring System

A scoring system was implemented as the "make it cooler" enhancement:

- **Live Score Display:** The score is shown on screen and updates in real time as enemies are destroyed. Each enemy type has its own point value.
- **Persistent High Score:** The best score is tracked across sessions using Unity's `PlayerPrefs`, so the high score survives game restarts.
- **HUD Display:** The UI shows both the current score and the all-time best score simultaneously during play.

Relevant scripts: `ScoreCounter.cs`, `Enemy.cs`
