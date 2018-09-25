using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>Kate Molina
///  Написать метод подсчета количества цифр числа.
/// </summary>

namespace SumCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number: ");
            int a = int.Parse(Console.ReadLine());
        
            Quantity(a);

        }
        public static int Quantity(int a)
        {
            int s = 0;
            do
            {
                
                a = a / 10;
                s++;

            } while (a != 0);
            Console.WriteLine("The number consists of " + s + " digits");
            return s;
            
        }
    }
}
