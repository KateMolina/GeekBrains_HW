using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary> Kate Molina
/// Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе истина, если прошел авторизацию, 
/// и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: 
/// пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
/// </summary>
namespace LoginPassword_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            Validation();
        }

        public static void Validation()
        {
            int count = 0;
            string pass = "GeekBrains";
            string login = "root";
            string l;
            string p;
            
            do
            {
                Console.WriteLine("Enter your login here: ");
                l = Console.ReadLine();
                Console.WriteLine("Enter your password here: ");
                p = Console.ReadLine();
                if(l == login && p == pass)
                {
                    Console.WriteLine("Login successful!");
                    break;
                }
                Console.WriteLine("Login failed. Try again.");
                
                count++;
            }
            while (count < 3);
            Console.WriteLine("Trials made: " + count);
        }
    }
}
