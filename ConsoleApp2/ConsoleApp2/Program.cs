using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = 6350;
            Console.WriteLine("Высота: "); 
            string b = Console.ReadLine();
            int h = Convert.ToInt32(b);
            Console.WriteLine("Расстояние до горизонта: " + Math.Sqrt((r + h) * (r + h) - r*r));
        }
    }
}