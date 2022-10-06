using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {

                Console.WriteLine("Введiть число: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введiть число: ");
                double num2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введiть символ: '+' '-' '*' '/' ");
                string symbole = Console.ReadLine();

                switch (symbole)
                {
                    case "+":
                        Console.WriteLine(num1 + num2);
                        break;
                    case "-":
                        Console.WriteLine(num1 - num2);
                        break;
                    case "*":
                        Console.WriteLine(num1 * num2);
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            Console.WriteLine(0);
                        }
                        else
                        {
                            Console.WriteLine(num1 / num2);
                        }
                        break;
                    default:
                        Console.WriteLine("Неправильно введене значення");
                        break;
                }
                Console.ReadLine();

                Console.Write("Продовжуємо роботу? (n/y)");
                value = Console.ReadLine();
            }
            while (value == "n" || value == "y");
        }
     }
}
