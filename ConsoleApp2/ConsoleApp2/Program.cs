using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Коэффициент a:");
            string c = Console.ReadLine();
            if (c != "0")
            {
                int a = Convert.ToInt32(c);
                Console.WriteLine("Свободный член b:");
                string d = Console.ReadLine();
                int b = Convert.ToInt32(d);
                Console.WriteLine("Решение уравнения ax+b=0: " + (double)-b / a);
            }
            else
            {
                Console.WriteLine("Коэффициент a не может быть равен 0, введите другое значение");
            }
        }
    }
}