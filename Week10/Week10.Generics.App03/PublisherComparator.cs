namespace Week10.Generics.App03
{
    internal class PublisherComparator
    {
        public Publisher Max(Publisher a, Publisher b)
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