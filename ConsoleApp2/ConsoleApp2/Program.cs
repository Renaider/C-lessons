using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string b = Console.ReadLine();
            int a = Convert.ToInt32(b);
            int x = 12 * a * a + 7 * a + 12;
            Console.WriteLine(x);
        }
    }
}