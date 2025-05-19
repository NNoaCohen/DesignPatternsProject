using DesignPattern.Composite_design;
using DesignPattern;

public class Library
{
    private List<Category> BooksInLibrary = new List<Category>();

    public void AddBook(Book b)
    {
        // מחפשים אם הקטגוריה כבר קיימת
        Category existingCategory = BooksInLibrary.FirstOrDefault(c => c.categoryName == b.baseBook.Category);

        if (existingCategory == null)
        {
            // אם הקטגוריה לא קיימת, ניצור קטגוריה חדשה
            existingCategory = new Category(b.baseBook.Category);
            BooksInLibrary.Add(existingCategory);
        }

        // הוספת הספר לקטגוריה המתאימה
       
        existingCategory.Books.Add(b);
    }

    public List<Book> GetBooksByCategory(BookCategory category)
    {
        Category foundCategory = BooksInLibrary.FirstOrDefault(c => c.categoryName == category);
        return foundCategory != null ? foundCategory.Books : new List<Book>();
    }

    public Book FindBookById(int bookId)
    {
        foreach (var category in BooksInLibrary)
        {
            Book foundBook = category.Books.FirstOrDefault(b => b.Id == bookId);
            if (foundBook != null)
                return foundBook;
        }
        return null;
    }

    public List<Book> GetAllBooks()
    {
        return BooksInLibrary.SelectMany(c => c.Books).ToList();
    }

}
