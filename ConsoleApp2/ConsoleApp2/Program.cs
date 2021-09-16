using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Радиус окружности:");
            string b = Console.ReadLine();
            int r = Convert.ToInt32(b);
            Console.WriteLine("Длина окружности: " + 2*r*3.14 );
            Console.WriteLine("Площадь круга: " + 3.14*r*r);
        }
    }
}