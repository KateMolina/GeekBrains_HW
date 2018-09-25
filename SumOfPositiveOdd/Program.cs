using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>Kate Molina
/// С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
/// </summary>

namespace SumOfPositiveOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc();
        }
        public static void Calc()
        {
            int sum = 0;
            int a;

            do
            {
                Console.WriteLine("Enter your num: ");
                a = int.Parse(Console.ReadLine());
                if (a > 0 && a % 2 != 0) {
                    sum += a;
                }
                Console.WriteLine("Result: " + sum);
                
                
            } while (a != 0);
            Console.WriteLine( "Total: " + sum);
        }
        
    }
}
