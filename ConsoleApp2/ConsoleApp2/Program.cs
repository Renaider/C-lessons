using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сторона 1:");
            string f = Console.ReadLine();
            int a = Convert.ToInt32(f);
            Console.WriteLine("Сторона 2:");
            string d = Console.ReadLine();
            int b = Convert.ToInt32(d);
            Console.WriteLine("Сторона 3:");
            string g = Console.ReadLine();
            int c = Convert.ToInt32(g);
            Console.WriteLine("Объём параллелепипеда: " + (a*b*c));
            Console.WriteLine("Площадь боковой поверхности: " + (2*a*c+2*b*c));
        }
    }
}