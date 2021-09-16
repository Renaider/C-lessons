using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Масса (кг):");
            string a = Console.ReadLine();
            int m = Convert.ToInt32(a);
            Console.WriteLine("Объём (м^3):");
            string b = Console.ReadLine();
            int v = Convert.ToInt32(b);
            Console.WriteLine("Плотность (кг/м^3): " + (double)m/v);
        }
    }
}