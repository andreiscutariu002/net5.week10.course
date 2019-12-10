namespace Week10.Generics.App03
{
    internal class BookComparator
    {
        public Book Max(Book a, Book b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}