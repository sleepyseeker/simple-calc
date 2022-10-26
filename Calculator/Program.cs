using System;
using System.Diagnostics;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double firstValue, secondValue;
                string action;

                Console.WriteLine("Bвед1ть число 1");
                firstValue = double.Parse(Console.ReadLine());

                Console.WriteLine("Bвед1ть число 2");
                secondValue = double.Parse(Console.ReadLine());

                Console.WriteLine("Обер1ть опц1ю: '+' '-' '*' '/'");
                action = Console.ReadLine();

                switch (action)
                {
                    case "+":
                        Console.WriteLine(firstValue + secondValue);
                        break;
                    case "-":
                        Console.WriteLine(firstValue - secondValue);
                        break;
                    case "*":
                        Console.WriteLine(firstValue * secondValue);
                        break;
                    case "/":
                        if (secondValue == 0)
                        {
                            Console.WriteLine(0);
                        }
                        else
                        {
                            Console.WriteLine(firstValue / secondValue);
                        }
                        break;

                    default:
                        Console.WriteLine("Сробуйте ввести 1ншу д1ю");
                        break;

                }
                Console.ReadLine();
            }

        }

    }

}