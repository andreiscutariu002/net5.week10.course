using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10.Generics.App04
{
    internal class GenericList<T>
    {
        private readonly T[] array;

        private readonly int size;

        private int currentElemIdx;

        public GenericList(int size)
        {
            this.currentElemIdx = 0;
            this.size = size;
            this.array = new T[size];
        }

        public void Add(T value)
        {
            if (this.currentElemIdx == this.size)
            {
                Console.WriteLine("Size full!");
                return;
            }

            this.array[this.currentElemIdx] = value;
            this.currentElemIdx++;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var stringList = new GenericList<string>(3);
            
            stringList.Add("123");
            stringList.Add("1234");
            stringList.Add("12345");
        }
    }
}
