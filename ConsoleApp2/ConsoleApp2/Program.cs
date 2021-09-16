using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Количество жителей:");
            string a = Console.ReadLine();
            int m = Convert.ToInt32(a);
            Console.WriteLine("Площадь государства:");
            string b = Console.ReadLine();
            int s = Convert.ToInt32(b);
            Console.WriteLine("Плотность населения: " + (double)m/s);
        }
    }
}