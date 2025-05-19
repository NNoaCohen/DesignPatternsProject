using DesignPattern.Bridge_design;
using System;

namespace DesignPattern.Adapter_design
{
    public class Adapter
    {
        private readonly DisplayColor _displayColor;

        public Adapter()
        {
            _displayColor = new DisplayColor();
        }

        public void Print(Book book, int num)
        {
            // קביעת צבע לפי קטגוריה
            string color = GetColorByCategory(book.baseBook.Category);

            // החלת הצבע
            if (num == 1)
                _displayColor.ApplyColorBackGround(color);
            else if (num == 2)
                _displayColor.ApplyColorText(color);

            // הדפסת הספר
            Console.WriteLine($"Book: {book.baseBook.Name} by {book.baseBook.Author}");

            // החזרת צבעי הקונסולה למצב המקורי
            Console.ResetColor();
        }

        private string GetColorByCategory(BookCategory bookCategory)
        {
            switch (bookCategory)
            {
                case BookCategory.Adult:
                    return "Blue";
                case BookCategory.Children:
                    return "Red";
                case BookCategory.YoungAdult:
                    return "Green";
                default:
                    return "White"; // צבע ברירת מחדל
            }
        }
    }
}
