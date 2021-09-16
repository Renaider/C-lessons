using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Координаты точки 1 по оси абсцисс:");
            string f = Console.ReadLine();
            int x1 = Convert.ToInt32(f);
            Console.WriteLine("Координаты точки 1 по оси ординат:");
            string d = Console.ReadLine();
            int y1 = Convert.ToInt32(d);
            Console.WriteLine("Координаты точки 2 по оси абсцисс:");
            string c = Console.ReadLine();
            int x2 = Convert.ToInt32(c);
            Console.WriteLine("Координаты точки 2 по оси ординат:");
            string g = Console.ReadLine();
            int y2 = Convert.ToInt32(g);
            Console.WriteLine("Расстояние между точками: " + Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));
        }
    }
}