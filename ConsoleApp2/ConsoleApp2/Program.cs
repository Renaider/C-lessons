using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Основание 1:");
            string c = Console.ReadLine();
            int a = Convert.ToInt32(c);
            Console.WriteLine("Основание 2:");
            string d = Console.ReadLine();
            int b = Convert.ToInt32(d);
            Console.WriteLine("Высота:");
            string f = Console.ReadLine();
            int h = Convert.ToInt32(f);
            double side = Math.Sqrt(Math.Abs(a - b) * Math.Abs(a - b) + h * h);
            Console.WriteLine("Периметр трапеции: " + (2 * side + a + b));
        }
    }
}