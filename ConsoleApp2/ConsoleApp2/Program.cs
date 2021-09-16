using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Число 1:");
            string c = Console.ReadLine();
            int d = Convert.ToInt32(c);
            Console.WriteLine("Число 2:");
            string b = Console.ReadLine();
            int a = Convert.ToInt32(b);
            Console.WriteLine("Среднее арифметическое: " + (double)(d+a)/2 );
            Console.WriteLine("Среднее геометрическое: " + Math.Sqrt(d*a));
        }
    }
}