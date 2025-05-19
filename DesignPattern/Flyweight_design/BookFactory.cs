using System;
using System.Collections.Generic;

namespace DesignPattern.Flyweight_design
{
    public class BookFactory
    {
        private static BookFactory _instance;
        private static readonly object _lock = new object();
        private Dictionary<string, BaseBook> _books;

        private BookFactory()
        {
            _books = new Dictionary<string, BaseBook>();
        }

        public static BookFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new BookFactory();
                        }
                    }
                }
                return _instance;
            }
        }

        public BaseBook GetBook(string name, string author, BookCategory category)
        {
            string key = $"{name}_{author}_{category}";

            if (!_books.ContainsKey(key))
            {
                _books[key] = new BaseBook(name, author, category)
                {
                    copies = 1
                };
            }
            else
            {
                _books[key].copies++;
            }

            return _books[key];
        }
    }
}
