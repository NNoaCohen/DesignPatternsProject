using System;
using DesignPattern.Adapter_design;
using DesignPattern.Flyweight_design;

namespace DesignPattern
{
    public class Book : IBook
    {
        public BaseBook baseBook { get; set; }
        public static int IdCode = 0;
        public int Id { get; set; }
        public bool IsItBorrowed { get; set; }
        public DateTime BorrowingDate { get; set; }

        public Book(string name, string author, BookCategory category)
        {
            Id = ++IdCode;
            IsItBorrowed = false;
            baseBook = BookFactory.Instance.GetBook(name, author, category);
        }

        public string PrintBook(int num)
        {
            Adapter a = new Adapter();
            a.Print(this, num);
            return $"Name is:{baseBook.Name}\nAuthor is:{baseBook.Author}\nCategory is:{baseBook.Category}\nId is:{Id}\nIsItBorrowed is:{IsItBorrowed}\nBorrowingDate is:{BorrowingDate}\n";
        }

        public bool Borrow()
        {
            if (IsItBorrowed)
                return false;
            IsItBorrowed = true;
            BorrowingDate = DateTime.Now;
            return true;
        }

        public bool Return()
        {
            if (!IsItBorrowed)
                return false;
            IsItBorrowed = false;
            return true;
        }
    }
}
