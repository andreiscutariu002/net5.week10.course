namespace Week10.Generics.App03
{
    public abstract class BaseLibEntity
    {
        public int Id { get; set; }

        public int Ceva2 { get; set; }
    }

    public class Book : BaseLibEntity
    {
        public string Name { get; set; }

        public Publisher Publisher { get; set; }

        public static bool operator <(Book b1, Book b2)
        {
            if (b1.Id > b2.Id)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool operator >(Book b1, Book b2)
        {
            if (b1.Id < b2.Id)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}