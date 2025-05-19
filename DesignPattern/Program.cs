using System;
using DesignPattern;
using DesignPattern.Flyweight_design;
using DesignPattern.Composite_design;
using DesignPattern.Adapter_design;
using DesignPattern.Composite_design;
using DesignPattern;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("📚 Welcome to the Design Patterns Library!");

            // Flyweight + Singleton: יצירת ספרים דרך BookFactory
            Book b1 = new Book("The Hobbit", "J.R.R. Tolkien", BookCategory.YoungAdult);
            Book b2 = new Book("Harry Potter", "J.K. Rowling", BookCategory.Children);
            Book b3 = new Book("The Hobbit", "J.R.R. Tolkien", BookCategory.YoungAdult); // אמור להשתמש באותו BaseBook כמו b1

            // Composite: יצירת קטגוריות ותתי־קטגוריות
            Category fantasyCategory = new Category(BookCategory.YoungAdult);
            Category childrenCategory = new Category(BookCategory.Children);

            fantasyCategory.AddBook(b1);
            fantasyCategory.AddBook(b3); // אותו baseBook

            childrenCategory.AddBook(b2);

            Category mainCategory = new Category(BookCategory.Adult);
            mainCategory.AddSubCategory(fantasyCategory);
            mainCategory.AddSubCategory(childrenCategory);

            // הצגת היררכיה
            mainCategory.DisplaySubCategories();
            fantasyCategory.DisplayBooks();
            childrenCategory.DisplayBooks();

            // Adapter + Bridge: הדפסת ספרים עם צבעים לפי קטגוריה
            Console.WriteLine("\n🎨 Printing books using Adapter & Bridge:");
            b1.PrintBook(1); // צבע רקע
            b2.PrintBook(2); // צבע טקסט
            b3.PrintBook(1); // אותו BaseBook כמו b1

            // בדיקת השאלה אם זה אכן אותו baseBook
            Console.WriteLine($"\nBaseBook of b1 == BaseBook of b3? {ReferenceEquals(b1.baseBook, b3.baseBook)}");

            // Borrow & Return
            Console.WriteLine($"\n📖 Borrowing '{b1.baseBook.Name}': {b1.Borrow()}");
            Console.WriteLine($"Returning '{b1.baseBook.Name}': {b1.Return()}");

            Console.WriteLine("\n✅ Finished demonstration.");
        }
    }
}
