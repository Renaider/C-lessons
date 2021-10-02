using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Упражнение 2.1
            Console.WriteLine("Упражнение 2.1");
            string name_user = Console.ReadLine();
            Console.WriteLine("Здравствуйте, " + name_user);
            Console.WriteLine();
            //Упражнение 2.2
            Console.WriteLine("Упражнение 2.2");
            Console.WriteLine("Число 1:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Число 2:");
            int b = Convert.ToInt32(Console.ReadLine());
            if (b == 0)
            {
                Console.WriteLine("Невозможно поделить на 0");
            }
            else
            {
                Console.WriteLine("Результат деления: " + (double)a / b);
            }
            //Домашнее задание 2.1
            Console.WriteLine("Домашнее задание 2.1");
            string[] alphabet = new string[26] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            Console.WriteLine("Введите букву английского алфавита: ");
            string letter = Console.ReadLine();
            if (letter == "z")
            {
                Console.WriteLine("Z - последняя буква алфавита");
            }
            else
            {
                for (int i = 0; i <= 26; i++)
                {
                    if (letter == alphabet[i])
                    {
                        Console.WriteLine(alphabet[i + 1]);
                        break;
                    }
                }
            }
            //Домашнее задание 2.2
            Console.WriteLine("Домашнее задание 2.2");
            Console.WriteLine("Коэффициент a:");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Коэффициент b:");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Коэффициент c:");
            double c1 = Convert.ToDouble(Console.ReadLine());
            double d = b1 * b1 - 4 * a1 * c1;
            if (d > 0)
            {
                Console.WriteLine("Корень 1: " + (double)(-b1 + Math.Sqrt(d)) / (2 * a1));
                Console.WriteLine("Корень 2: " + (double)(-b1 - Math.Sqrt(d)) / (2 * a1));
            }
            else if (d == 0)
            {
                Console.WriteLine("Корень: " + (double)-b1 / 2 * a1);
            }
            else
            {
                Console.WriteLine("Корней нет");
            }

        }
    }
}