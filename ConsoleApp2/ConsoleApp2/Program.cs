using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Внешний радиус:");
            string c = Console.ReadLine();
            int a = Convert.ToInt32(c);
            Console.WriteLine("Внутренний радиус:");
            string d = Console.ReadLine();
            int b = Convert.ToInt32(d);
            Console.WriteLine("Площадь кольца: " + 3.14*(a*a-b*b));
        }
    }
}