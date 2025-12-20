# 🧮 Simple Calculator (Windows Forms – C#)

A simple calculator desktop application built using **C# and Windows Forms**.  
This project applies core programming fundamentals such as event handling, state management, and basic arithmetic logic.

---

## 📌 Features

- Basic arithmetic operations:
  - ➕ Addition
  - ➖ Subtraction
  - ✖ Multiplication
  - ➗ Division
- Supports multi-digit numbers (e.g. 778)
- Displays the full calculation process:
  - First number
  - Selected operation
  - Second number
  - Final result
- Clear button to reset the calculator
- Handles division by zero safely

---

## 🧠 How It Works

1. The user enters the **first number** using the number buttons.
2. The user selects an **operation** (+, −, ×, ÷).
3. The user enters the **second number**.
4. When the **Equals (=)** button is pressed:
   - The calculation is performed.
   - The result is displayed on the screen.

⚠️ Note:  
The calculator separates **display logic** from **calculation logic**:
- `TextBox` is used only for displaying values.
- Internal variables (`num1`, `num2`) are used for calculations.

---

## 🖼 Screenshot
<img width="395" height="428" alt="Simple-Calculator" src="https://github.com/user-attachments/assets/958e9491-e93c-45a3-8cfd-87083b4ba891" />

