using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Flyweight_design
{
   
    public class BaseBook 
    {
      

        public int copies { get; set; }
        public string Name { get; }
        public string Author { get; }
        public BookCategory Category { get; }

        public BaseBook(string name, string author, BookCategory category)
        {
            Name = name;
            Author = author;
            Category = category;


        }
        public void DisplayCopies()
        {
            Console.WriteLine($"Copies: {copies}");
        }
    }

}
