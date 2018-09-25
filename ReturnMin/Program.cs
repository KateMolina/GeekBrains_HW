using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary> Kate Molina
///  Написать метод, возвращающий минимальное из трех чисел.
/// </summary>
namespace ReturnMin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first value: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second value: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third value: ");
            int c = int.Parse(Console.ReadLine());
            MinOutOfThree(a, b, c);
        }
        static int MinOutOfThree(int a, int b, int c)
        {
            int min;
            if (a < b && a < c)
            {
                min = a;
            }
            else if (b < a && b < c)
            {
                min = b;
            }
            else min = c;
            Console.WriteLine("The minimal value is: " + min);
            return min;
            
        }
    }
}
