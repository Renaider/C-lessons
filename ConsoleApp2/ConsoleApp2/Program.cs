﻿using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Катет 1:");
            string c = Console.ReadLine();
            int a = Convert.ToInt32(c);
            Console.WriteLine("Катет 2:");
            string d = Console.ReadLine();
            int b = Convert.ToInt32(d);
            double g = Math.Sqrt(a * a + b * b);
            Console.WriteLine("Периметр прямоугольного треугольника: " + (Math.Sqrt(a * a + b * b) + a + b));
        }
    }
}