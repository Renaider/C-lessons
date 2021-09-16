using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Длина ребра куба:"); 
            string b = Console.ReadLine();
            int a = Convert.ToInt32(b);
            Console.WriteLine("Объём куба: " + a*a*a);
            Console.WriteLine("Площадь боковой поверхности: " + 4*a*a);
        }
    }
}