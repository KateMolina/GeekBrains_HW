using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>Kate Molina
/// Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, 
/// нужно ли человеку похудеть, набрать вес или все в норме;
/// б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
/// </summary>

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bmi();
        }

        static void Bmi()
        {
            Console.WriteLine("Enter your weight (in kg):");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your height (in meters):");
            double h = double.Parse(Console.ReadLine());
            double d = 21.7; //Normal BMI Avarage
            double i = m / (h * h);
            string new_i = i.ToString("#.##");
            if (i <= 18.5)
            {
                double d1 = d - i;
                string new_d = d1.ToString("#.##");
                Console.WriteLine("Your BMI is: " + new_i + "\nYou are underweight (To normalize it you should gain: " + new_d + ")");

            }else if( i >= 25 && i <= 29.9)
            {
                double d2 = i - d;
                string new_d2 = d2.ToString("#.##");
                Console.WriteLine("Your BMI is: " + new_i + "\nYou are overweight(To normalize your weight you should lose: " + new_d2 + ")");
            }else if( i >= 30)
            {
                double d3 = i - d;
                string new_d3 = d3.ToString("#.##");
                Console.WriteLine("Your BMI is: " + new_i + "\nYou are suffering from obesity(You have to go to a doctor!!! To normalize it you should lose: " + new_d3 + ")");
            }
            else
            {
                Console.WriteLine("Your BMI is: " + new_i + "\nNormal weight. You are good, dude ;)");
            }
            
        }
    }
}
