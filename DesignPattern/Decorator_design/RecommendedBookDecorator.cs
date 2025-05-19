using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator_design
{
    class RecommendedBookDecorator : BookDecorator
    {
        public RecommendedBookDecorator(IBook book) : base(book) { }

        public override string PrintBook(int num)
        {
            return book.PrintBook(num) + " (Recommended Book!)";
        }
    }
}
