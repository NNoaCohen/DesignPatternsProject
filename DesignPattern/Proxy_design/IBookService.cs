using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Proxy_design
{
    public interface IBookService
    {
        void DisplayBookInfo(int bookId);
        bool BorrowBook(int bookId, User user);
    }

}
