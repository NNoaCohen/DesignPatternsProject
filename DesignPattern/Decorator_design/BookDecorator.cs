using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator_design
{
    public abstract class BookDecorator 
    {
        protected IBook book;

        public BookDecorator(IBook book)
        {
            this.book = book;
        }


        public virtual bool Borrow()
        {
            return book.Borrow(); // שומר על ההתנהגות של השאלה
        }

        public virtual string PrintBook(int num)
        {
           return book.PrintBook(num);
        }

        public virtual bool Return()
        {
            return book.Return(); // שומר על ההתנהגות של החזרה
        }
   
    }

}
