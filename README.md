# dotnet-pre-trainee-calculator

A simple console calculator built with C# and .NET as part of the .NET Pre-Trainee course (Innowise).

## About

This is a console application that performs basic arithmetic operations on decimal numbers. The user enters an operation, then two numbers, and the app prints the result. The program runs in a loop until the user decides to exit, and it handles invalid input gracefully without crashing.

## Features

- Four basic arithmetic operations: addition, subtraction, multiplication, division
- Input validation for operations and numbers
- Division by zero handling
- Ability to exit at any input stage by typing `exit`
- Calculation history for the current session (command `history`)
- Prompt to continue or finish after each calculation
- Uses `decimal` for accurate arithmetic
- Calculator logic is separated into a dedicated `Calculator` class, while `Program` only serves as the entry point

## How to Run

### Steps

1. Clone the repository:
   ```bash
   git clone https://github.com/staskon315/dotnet-pre-trainee-calculator.git
   ```

2. Navigate to the project folder:
   ```bash
   cd dotnet-pre-trainee-calculator/ConsoleCalculator
   ```

3. Run the application:
   ```bash
   dotnet run
   ```