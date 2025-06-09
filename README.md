# Single Responsibility Principle (SRP) in C#

This project demonstrates the **Single Responsibility Principle (SRP)** — the **"S"** in the **SOLID** principles — using a basic example in C#.

## 💡 What is the Single Responsibility Principle?

> **SRP** states that _a class should have only one reason to change_.

In other words, each class should focus on **one specific task or responsibility**. If a class takes on multiple roles, it's more likely to become fragile, harder to maintain, and harder to test.

## 🛠 Project Structure

This project is structured to follow SRP by clearly separating responsibilities across different classes:

```

SingleResponsibilityPrinciple/
│
├── Customer.cs              // Holds customer data
├── CustomerRepository.cs    // Handles customer data persistence
└── FileLogger.cs            // Handles logging errors to a file

````

---

## 📄 Code Overview

### ✅ `Customer` Class

Responsible **only** for storing customer data.

```csharp
public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Family { get; set; }
}
````

---

### ✅ `CustomerRepository` Class

Responsible **only** for database operations (simulated here). It does **not** handle logging by itself.

```csharp
public class CustomerRepository
{
    public void Add(Customer customer)
    {
        try
        {
            // Add customer to Database 
        }
        catch (Exception e)
        {
            FileLogger.Log(e.ToString());
        }
    }
}
```

---

### ✅ `FileLogger` Class

Dedicated **only** to logging errors to a file. This keeps the logging logic separated from the business logic.

```csharp
public class FileLogger
{
    public static void Log(string content)
    {
        System.IO.File.WriteAllText("D:\\errors.txt", content);
    }
}
```

> **Note:** There was a small bug in the original logger — `content()` should be `content`. The corrected version is shown above.

---

## ✅ How This Demonstrates SRP

Each class has **exactly one responsibility**:

* `Customer` → holds data
* `CustomerRepository` → manages data storage
* `FileLogger` → logs errors

This separation ensures that:

* If logging logic changes, only `FileLogger` needs updating.
* If database logic changes, only `CustomerRepository` is affected.
* Each class has a **single reason to change**.

---

## 🚀 Future Enhancements

* Simulate actual database operations
* Add unit tests to verify SRP enforcement
* Use dependency injection for better decoupling

---

## 👁️ GitHub Page Views

![Visitor Badge](https://visitor-badge.laobi.icu/badge?page_id=YourGitHubUsername.SRPProjectName)

> Replace `YourGitHubUsername.SRPProjectName` with your actual GitHub repo path.

---

## 📚 Related SOLID Principles

Coming soon as separate projects:

* \[O] Open/Closed Principle
* \[L] Liskov Substitution Principle
* \[I] Interface Segregation Principle
* \[D] Dependency Inversion Principle

---

Thanks for reading! ⭐ Star the repo if you found it helpful.
