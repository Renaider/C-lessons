using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int x = Convert.ToInt32(a);
            int y = 7 * x * x + 3 * x + 6;
            Console.WriteLine(y);
        }
    }
}