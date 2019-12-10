namespace Week10.Generics.App03
{
    using System;

    public class DictV2<TKey, TValue>
    {
    }

    public class CompV2
    {
        public T Max<T>(T a, T b)
        {
            throw new NotImplementedException();
        }

        public T Min<T>(T a, T b)
        {
            throw new NotImplementedException();
        }
    }

    public class Comparator<T> where T: BaseLibEntity, IComparable<T>, new()
    {
        public T Max(T a, T b)
        {
            var x = a.Id;
            var y = a.Ceva2;

            if (a.CompareTo(b) > 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        public T EmptyInstance()
        {
            return new T();
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            //var comp1 = new Comparator<Book>();

            var comp2 = new Comparator<Publisher>();

            var maxP = comp2.Max(new Publisher {Id = 1}, new Publisher { Id = 2 } );

            var dict = new DictV2<string, int>();
        }
    }
}
