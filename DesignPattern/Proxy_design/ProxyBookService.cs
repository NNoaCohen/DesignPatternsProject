using DesignPattern.Decorator_design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Proxy_design
{
    public class ProxyBookService : IBookService
    {
        private RealBookService _realBookService;

        public ProxyBookService(Library library)
        {
            _realBookService = new RealBookService(library);
        }

        public void DisplayBookInfo(int bookId)
        {
            _realBookService.DisplayBookInfo(bookId);
        }

        public bool BorrowBook(int bookId, User user)
        {
            var book = _realBookService._library.FindBookById(bookId);
            if (book == null)
            {
                Console.WriteLine("Book not found");
                return false;
            }

            // בדיקה אם הספר הוא נדיר ולמשתמש אין הרשאות
            if (book is RareBookDecorator && !user.HasPermission)
            {
                Console.WriteLine("You are not allowed to lend rare books!");
                return false;
            }

            return _realBookService.BorrowBook(bookId,user);
        }
    }

}
