using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary> Kate Molina
/// *Разработать рекурсивный метод, который считает сумму чисел от a до b.
/// </summary>

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 39;
            double b = 4;
            if (a > b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }
            Console.WriteLine(MyRec(a, b));
        }

        public static double MyRec(double a, double b) => (a < b) ? a + MyRec(a + 1, b) : b;
        
    }
}
