using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Число 1:");
            string c = Console.ReadLine();
            int a = Convert.ToInt32(c);
            Console.WriteLine("Число 2:");
            string d = Console.ReadLine();
            int b = Convert.ToInt32(d);
            Console.WriteLine("Сумма чисел: " + (a+b));
            Console.WriteLine("Разность чисел: " + (a-b));
            Console.WriteLine("Произведение чисел: " + (a * b));
            Console.WriteLine("Частное от деления числа 1 на число 2: " + (double)a/b);
        }
    }
}