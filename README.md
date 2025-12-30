# C# Object-Oriented Programming Examples

## Introduction
This repository demonstrates core **Object-Oriented Programming (OOP)** concepts in C#. OOP is a programming paradigm based on the concept of "objects," which can contain data (fields) and code (methods). These examples illustrate how classes relate to one another to build structured and reusable code.

## Included Problems

### 1. Polymorphism (Method Overriding)
* **File:** `Polymorphism.cs`
* **Description:** This program demonstrates **Runtime Polymorphism**. It defines a base class `Animal` with a virtual method `Eat()`. The derived class `Dog` overrides this method to provide its own specific implementation.
* **Key Concepts:** `virtual`, `override`, Base vs. Derived classes.

### 2. Single Inheritance
* **File:** `Inheritance.cs`
* **Description:** A demonstration of how a child class can acquire the properties of a parent class. Class `B` inherits from Class `A`, meaning object `b1` can access methods and fields defined in both classes (e.g., accessing `m1()` from the parent and `m2()` from the child).
* **Key Concepts:** Code Reusability, Parent/Child relationship (`: A`).

### 3. Abstraction
* **File:** `Abstraction.cs`
* **Description:** This example uses an **Abstract Class** to hide implementation details. The `Animal` class defines *what* an animal does (like `animalsound`) but leaves the *how* to the specific implementation in the `Cat` class.
* **Key Concepts:** `abstract` classes, `abstract` methods, partial implementation.

### 4. Multiple Interface Implementation
This example demonstrates how to implement **multiple inheritance** in C# using interfaces. Since C# classes cannot inherit from multiple parent classes, interfaces provide the standard solution to combine behaviors from distinct sources.
###  Description
The program defines two separate interfaces, `Animal` and `Animal1`. A single class, `AnimalClass`, implements both interfaces, proving that a class can adhere to multiple contracts simultaneously.
###  Key Features
* **Interface Definition:** Creation of lightweight contracts (`Animal`, `Animal1`).
* **Multiple Implementation:** Syntax usage `class AnimalClass : Animal, Animal1`.
* **Polymorphism:** The `AnimalClass` provides concrete logic for methods defined in completely separate interfaces.
# How to Run
To run any of these files, navigate to the folder in your terminal and use the .NET CLI:

```bash
dotnet run# 1st-repo
It's my first GitHub repo
