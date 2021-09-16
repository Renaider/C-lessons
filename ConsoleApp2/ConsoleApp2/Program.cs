using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сторона 1:");
            string c = Console.ReadLine();
            int a = Convert.ToInt32(c);
            Console.WriteLine("Сторона 2:");
            string d = Console.ReadLine();
            int b = Convert.ToInt32(d);
            Console.WriteLine("Периметр прямоугольника: " + (2*a+2*b));
            Console.WriteLine("Длина диагонали прямоугольника: " + Math.Sqrt(a*a+b*b));
        }
    }
}