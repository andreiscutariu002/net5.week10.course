namespace Week10.Generics.App01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IBookRepository bookRepo1;

            IPublisherRepository pubRepo1;

            IRepository<Book> bookRepo2;

            IRepository<Publisher> pubRepo2;
        }
    }

    public interface IRepository<T>
    {
        T SelectById(int a);

        int Insert(T value);
    }

    public interface IBookRepository
    {
        Book SelectById(int id);

        int Insert(Book value);
    }

    public interface IPublisherRepository
    {
        Publisher SelectById(int id);

        int Insert(Publisher value);
    }
}
