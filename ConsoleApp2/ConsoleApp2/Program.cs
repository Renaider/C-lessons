using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Число 1:");
            string c = Console.ReadLine();
            int a = Convert.ToInt32(c);
            Console.WriteLine("Число 2:");
            string d = Console.ReadLine();
            int b = Convert.ToInt32(d);
            Console.WriteLine("Среднее арифметическое модулей: " + ((double)(Math.Abs(a)+Math.Abs(b))/2));
            Console.WriteLine("Среднее геометрическое модулей: " + Math.Sqrt(Math.Abs(a)*Math.Abs(b)));
        }
    }
}