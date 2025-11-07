# 🎲 Snake & Ladder Simulator

This project simulates the classic **Snake and Ladder** game step by step using multiple **Use Cases (UC1–UC7)**, each developed in a separate feature branch and merged progressively into the `dev` branch, and finally into the `main` branch.

---

## 📜 Problem Statement

The player starts from position **0**, rolls the die to get a number between **1 to 6**, and moves accordingly:
- Finds a **safe place**, **ladder**, or **snake**
- Keeps playing until reaching the winning position **100**

The game is enhanced step-by-step across multiple use cases.

---

## 🧩 Use Cases Overview

### **UC1 – Snake & Ladder Game Initialization**
- Player starts from position **0**.

### **UC2 – Random Option Check**
- Rolls a die to get a number between **1–6**.
- Implemented using **Random** to simulate dice rolls.

### **UC3 – Apply Options**
- Handles player movement based on the option.
- In case of:
- - Adds three options determined randomly:
  - `0` → No Play (stay in the same position)
  - `1` → Ladder (move forward)
  - `2` → Snake (move backward)

### **UC4 – Repeat Till Winning Position**
- Repeats the process until the player reaches **100**.
- If position goes below **0**, the player restarts from **0**.

### **UC5 – Exact Winning Position**
- Player must reach **exactly 100**.
- If a dice roll makes the position go above 100, the player stays at the previous position.

### **UC6 – Dice Count Report**
- Tracks:
  - Number of dice rolls made to win the game.

### **UC7 – Two Player Mode**
- Introduces two players.
- Players take turns rolling the dice.
- If a player gets a **Ladder**, they play again.
- The first player to reach **exactly 100** wins.

---

## 🧭 Project Workflow

Each use case (UC) is developed in its own feature branch:

| Branch Name | Description |
|--------------|-------------|
| `features/SnakeLadderGame_UC1` | Basic dice roll simulation |
| `features/Using_Random_Dice_UC2` | Adds random dice |
| `features/Player_Option_UC3` | Implements option handling (No Play, Ladder, Snake) |
| `features/RepeatTill100_UC4` | Repeats until player reaches 100 |
| `features/Exact_100_UC5` | Ensures exact 100 rule |
| `features/CountDice_UC6` | Adds dice count tracking |
| `features/2Player_UC7` | Adds 2-player gameplay |
| `features/Menu` | Optional menu system for selecting UC demo |

After implementing and testing each UC:
1. Merge the **feature branch → `dev` branch**
2. Merge the **`dev` branch → `main` branch**

---

## 🧮 Game Rules Summary
- Start at **position 0**
- Roll dice (`1–6`)
- Randomly choose an option:
  - `0` → No Play  
  - `1` → Ladder  
  - `2` → Snake
- If position < 0 → reset to 0  
- If position > 100 → stay in same position  
- First player to reach **exactly 100** wins  

---

## ⚙️ Tech Stack
- **Language:** C#  
- **Framework:** .NET Console Application  
- **IDE:** Visual Studio 

---

## 🧑‍💻 Developed By
**MD Dilshad Alam**  
Implemented Use Cases UC1–UC7 with clean branching and merge strategy.

---

## 🏁 Final Outcome
A complete **Snake and Ladder Simulator** built incrementally through multiple use cases demonstrating:
- Randomized logic  
- Control flow and conditions  
- Loops and arrays  
- Multi-player game mechanics  

---

## Guided By BridgeLabz 
