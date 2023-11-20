# ContactManager - ASP.NET Core Minimal API🚀

## Overview

Welcome to ContactManager, an awesome ASP.NET Core Minimal API built on .NET 8! 🎉
This application manages contacts efficiently while following the SOLID principles for a codebase. 💻

## Getting Started

1. **Clone the repository:**
   ```bash
   git clone https://github.com/zangassis/contact-manager-solid-chapter.git
   ```

2. **Navigate to the project folder:**
   ```bash
   cd ContactManager
   ```

3. **Install dependencies:**
   ```bash
   dotnet restore
   ```

4. **Set up MongoDB Atlas:**
   - Create a MongoDB Atlas account: [MongoDB Atlas](https://www.mongodb.com/cloud/atlas)
   - Obtain your connection string.

5. **Configure MongoDB Connection:**
   - Open `appsettings.json` and replace the placeholder in `"ContactDbSettings"` with your MongoDB connection string.

6. **Run the application:**
   ```bash
   dotnet run
   ```

## Features

✅ Minimal API Design\
✅ .NET 8 Excellence\
✅ MongoDB Atlas Integration\
✅ Contact Management System

## SOLID Principles

This project adheres to the SOLID principles:

1. **S - Single Responsibility Principle (SRP):**
   - Each class and method has a single responsibility.

2. **O - Open/Closed Principle (OCP):**
   - The code is open for extension but closed for modification.

3. **L - Liskov Substitution Principle (LSP):**
   - Subtypes can replace their base types without altering the correctness of the program.

4. **I - Interface Segregation Principle (ISP):**
   - Interfaces are client-specific, and no client should be forced to depend on methods it does not use.

5. **D - Dependency Inversion Principle (DIP):**
   - High-level modules should not depend on low-level modules; both should depend on abstractions.

Feel free to explore and contribute to ContactManager! Happy coding! 🚀👨‍💻👩‍💻
