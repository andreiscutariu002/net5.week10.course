namespace Week10.Generics.App03
{
    using System;

    public class Publisher : BaseLibEntity, IComparable<Publisher>
    {
        public string Name { get; set; }

        public static bool operator <(Publisher b1, Publisher b2)
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

        public static bool operator >(Publisher b1, Publisher b2)
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

        public int CompareTo(Publisher other)
        {
            if (this.Id < other.Id)
            {
                return -1;
            }
            else if (this.Id > other.Id)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}