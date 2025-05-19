# 📚 Design Patterns Library Project
(פרויקט ספריית עיצוב תבניות תכנות)

This project demonstrates the use of several classic software design patterns in a simulated library system, written in C#.  
הפרויקט מדגים שימוש במספר תבניות עיצוב מוכרות במערכת ספרייה כתובה בשפת C#.

---

## 🎯 Design Patterns Implemented | תבניות עיצוב בשימוש

1. 🔌 Bridge  
   Separate abstraction (`DisplayColor`) from implementation (`ConsoleColor`).

2. 🔄 Adapter  
   Adapts book categories to console color styling.

3. 🧩 Composite  
   Models category-subcategory relationships.

4. 🎭 Decorator  
   Adds behavior to books (e.g., RareBook, RecommendedBook).

5. 🪟 Facade  
   Simplifies book lending operations.

6. 🪶 Flyweight  
   Reuses shared `BaseBook` instances to save memory.

7. 🧳 Proxy  
   Controls access to book operations via a `ProxyBookService`.

---

## 📦 Structure | מבנה הפרויקט

- `Book`: Represents a physical book using shared `BaseBook` data.
- `BookFactory`: Flyweight factory for managing base books.
- `Adapter`: Maps book categories to console output styling.
- `DisplayColor`: Implements Bridge for console styling.
- `CompositeCategory`: Supports recursive category structure.
- `BookDecorator`: Base class for adding behaviors to books.
- `LibraryFacade`: Facade for borrowing and returning books.
- `ProxyBookService`: Controls and logs access to the library.

---

## ▶️ How to Run | איך להריץ

1. Open the solution in Visual Studio.
2. Set the `DesignPatterns2` project as Startup Project.
3. Run the program (`F5` or Ctrl+F5).
4. Console output will demonstrate the design patterns.

---

## 🧪 Example Output | פלט לדוגמה

Welcome to the Design Patterns Library!
The book 'The Hobbit' has been added to the category 'YoungAdult'.
...
BaseBook of b1 == BaseBook of b3? True
Borrowing 'The Hobbit': True
Returning 'The Hobbit': True
Finished demonstration.

yaml
Copy
Edit



---

## 📁 Notes | הערות

- The project uses C# 8.0+ and .NET Core.
- All logic is organized into folders by design pattern.
- צבעים מודגשים בקונסול באמצעות דפוס Bridge + Adapter.
- ניתן להרחיב את הפרויקט עם תבניות נוספות או ממשק גרפי.

---

Created by: Noa Cohen 

