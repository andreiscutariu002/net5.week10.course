using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10.Generics.App02
{
    class DecimalCalculator
    {
        decimal Add(decimal d1, decimal d2)
        {
            return d1 + d2;
        }

        decimal Sub(decimal d1, decimal d2)
        {
            return d1 - d2;
        }
    }

    class IntCalculator
    {
        int Add(int d1, int d2)
        {
            return d1 + d2;
        }

        int Sub(int d1, int d2)
        {
            return d1 - d2;
        }
    }

    class FloatCalculator
    {
        float Add(float d1, float d2)
        {
            return d1 + d2;
        }

        float Sub(float d1, float d2)
        {
            return d1 - d2;
        }
    }

    public class GenericCalculator<T>
    {
        public T Add(T a, T b)
        {
            return (dynamic)a + (dynamic)b;
        }

        public T Sub(T a, T b)
        {
            return (dynamic)a - (dynamic)b;
        }
    }

    class Program
    {
        // implement generic calculator
        static void Main(string[] args)
        {
            //var gc1 = new GenericCalculator<decimal>();
            //var gc2 = new GenericCalculator<float>();

            var floatCalc = new FloatCalculator();

            var floatGenericCalc = new GenericCalculator<float>();

            var studentCalc = new GenericCalculator<Student>();
        }
    }

    internal class Student
    {
    }
}
