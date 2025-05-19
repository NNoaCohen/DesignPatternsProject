namespace DesignPattern
{
    public interface IBook
    {

        bool Borrow();
        bool Return();

        string PrintBook(int num);
    }

}