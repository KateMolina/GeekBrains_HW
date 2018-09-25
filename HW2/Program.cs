using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>Kate Molina
/// *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. 
/// Реализовать подсчет времени выполнения программы, используя структуру DateTime.
/// </summary>

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime start = DateTime.Now;
            System.Threading.Thread.Sleep(20);
            

            int c = 0;
            for (int i = 1; i <= 100; i++)    
            {
                int k = Counting(i);    
                if((i % k) == 0)
                {
                    c++;
                    Console.WriteLine("A 'good' figure: " + i + " its sum: " + k);
                }
               
                
            }
            Console.WriteLine("\tTotal: " + c);
            DateTime finish = DateTime.Now;
            Console.WriteLine(finish - start);
        }

       
        static int Counting(int a)
        {
           
            int s = 0;
            while (a != 0)
            {
                s = s + a % 10;
                a = a / 10;
             
            }return s;


        }
      
    }

}
