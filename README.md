# Single Responsibility Principle

<!-- ## <a href="https://www.linkedin.com/in/soheilsadeghii/"><img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Telegram-Animated-Emojis/main/Symbols/Exclamation%20Question%20Mark.webp" alt="Exclamation Question Mark" width="35" height="35" /></a> What is SRP? -->

**SRP (Single Responsibility Principle)** is the first principle of SOLID.  
It states that:  
> *A class should have one and only one reason to change.*

In other words, every class should handle only **one responsibility** or **one specific functionality** of the application.  
This makes your code **easier to understand, maintain, and extend**.

---

## <a href="https://www.linkedin.com/in/soheilsadeghii/"><img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Telegram-Animated-Emojis/main/Symbols/Check%20Mark%20Button.webp" alt="Check Mark Button" width="35" height="35" /></a> How This Project Applies SRP

In this example, the system deals with two separate responsibilities:

1. **Managing customer data**
2. **Logging errors to a file**

To respect SRP, these concerns are separated into **two different classes**:

- `CustomerRepository`  
  Responsible only for **adding customers** to the database.

- `FileLogger`  
  Responsible only for **logging errors** to a file.

This separation means that if we need to change the logging logic (e.g., switch to a database logger), we won’t need to touch the customer logic — and vice versa.  
This is exactly what SRP aims to achieve!

---

## <a href="https://www.linkedin.com/in/soheilsadeghii/"><img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Telegram-Animated-Emojis/main/Travel%20and%20Places/Rocket.webp" alt="Rocket" width="25" height="25" /></a> Summary

| Class            | Responsibility                       |
|------------------|----------------------------------------|
| `Customer`        | Holds customer data (model)            |
| `CustomerRepository` | Adds customer to storage (logic layer) |
| `FileLogger`      | Logs error messages to file (utility)  |

Each class has a **clear and focused purpose**, following SRP best practices.

---

## <a href="https://www.linkedin.com/in/soheilsadeghii/"><img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Telegram-Animated-Emojis/main/Objects/File%20Folder.webp" alt="File Folder" width="35" height="35" /></a> Project Structure

```text
SingleResponsibilityPrinciple/
│
├── Program.cs              // Entry point
├── Customer.cs             // Data model
├── CustomerRepository.cs   // Customer logic
└── FileLogger.cs           // Logging utility
```
## <a href="https://www.linkedin.com/in/soheilsadeghii/"><img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Telegram-Animated-Emojis/main/People/Eyes.webp" alt="Eyes" width="35" height="35" /></a> Views
![Visitor Badge](https://visitor-badge.laobi.icu/badge?page_id=SoheilSadeghii.SingleResponsibilityPrinciple)
---
Thanks for checking out this project!  
If you found it helpful, feel free to <a href="https://www.linkedin.com/in/soheilsadeghii/"><img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Telegram-Animated-Emojis/main/Animals%20and%20Nature/Star.webp" alt="Star" width="15" height="15" /></a> the repo or share it with others.  
Contributions, feedback, and suggestions are always welcome!
