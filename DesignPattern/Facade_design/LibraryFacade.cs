using DesignPattern.Composite_design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Facade_design
{
    public class LibraryFacade
    {
        private Library _library;

        public LibraryFacade()
        {
            _library = new Library();
        }

        //  השאלת ספר
        public bool BorrowBook(int bookId)
        {
            Book book = _library.FindBookById(bookId);
            if (book == null)
            {
                Console.WriteLine("❌ הספר לא נמצא.");
                return false;
            }

            if (book.Borrow())
            {
                Console.WriteLine($"✅ הספר '{book.baseBook.Name}' הושאל בהצלחה!");
                return true;
            }
            else
            {
                Console.WriteLine("❌ הספר כבר מושאל.");
                return false;
            }
        }

        // 2️⃣ החזרת ספר
        public bool ReturnBook(int bookId)
        {
            Book book = _library.FindBookById(bookId);
            if (book == null)
            {
                Console.WriteLine("❌ הספר לא נמצא.");
                return false;
            }

            if (book.Return())
            {
                Console.WriteLine($"✅ הספר '{book.baseBook.Name}' הוחזר בהצלחה!");
                return true;
            }
            else
            {
                Console.WriteLine("❌ הספר לא היה מושאל.");
                return false;
            }
        }

        // 3️⃣ בדיקת זמינות ספר
        public bool IsBookAvailable(int bookId)
        {
            Book book = _library.FindBookById(bookId);
            if (book == null)
            {
                Console.WriteLine("❌ הספר לא נמצא.");
                return false;
            }
            return !book.IsItBorrowed;
        }

        // 4️⃣ הדפסת ספר לפי ID
        public void PrintBookById(int bookId,int num)
        {
            Book book = _library.FindBookById(bookId);
            if (book == null)
            {
                Console.WriteLine("❌ הספר לא נמצא.");
                return;
            }
            Console.WriteLine(book.PrintBook(num));
        }

        // 5️⃣ הדפסת ספרים בקטגוריה מסוימת
        public void PrintBooksByCategory(BookCategory category,int num)
        {
            var books = _library.GetBooksByCategory(category);
            if (!books.Any())
            {
                Console.WriteLine($"❌ אין ספרים בקטגוריה {category}.");
                return;
            }

            Console.WriteLine($"📚 ספרים בקטגוריה {category}:");
            foreach (var book in books)
            {
                Console.WriteLine(book.PrintBook(num));
            }
        }
    }

}
