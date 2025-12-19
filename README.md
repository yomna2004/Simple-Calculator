# 🧮 Simple Calculator (Windows Forms)

A simple calculator application built using **C# Windows Forms**.  
The project focuses on understanding **events, user input handling, and basic program flow**, rather than advanced frameworks.

---

## 📌 Features

- Numeric buttons (0–9) for number input
- Supports basic operations:
  - Addition (+)
  - Subtraction (−)
  - Multiplication (×)
  - Division (÷)
- Handles multi-digit numbers (e.g. 778)
- Clear button to reset the calculator
- Error handling for division by zero
- Clean and simple UI

---

## 🛠 Technologies Used

- C#
- Windows Forms (.NET)
- Visual Studio

---

## 🧠 How It Works

1. Numbers are entered using buttons and displayed in a `TextBox`.
2. The first number is stored once an operation is selected.
3. The calculator waits for the second number input.
4. When the **Equals (=)** button is clicked:
   - The selected operation is applied.
   - The result is displayed.
5. The result can be reused in the next calculation.

---

## 📂 Project Structure

- `Form1.cs`  
  Contains:
  - UI logic
  - Event handling
  - Calculator logic (operations and result handling)

---

## 🎯 Learning Objectives

This project was built to practice:

- Handling button click events
- Using `enum` to manage operations
- Managing application state (first number, second number, operation)
- Converting text input to numeric values
- Writing clean and readable logic for a real UI application

---
## 📸 Screenshot

<img width="388" height="468" alt="calculator png" src="https://github.com/user-attachments/assets/8267b200-9782-40f7-9f68-4740e1721842" />




