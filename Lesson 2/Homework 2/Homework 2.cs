using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2a
{
    class Program
    {
        static void Main(string[] args)
        {
            //A1.1
            Console.WriteLine("A1.1");
            Console.WriteLine("Введите число секунд: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n / 3600 + " полных часов прошло");
            int minutes = ((n % 3600) / 60);
            Console.WriteLine(minutes + " полных минут прошло");
            int second = ((n % 3600) % 60);
            Console.WriteLine(second + " полных секунд прошло");
            //A1.2
            Console.WriteLine("A1.1");
            double a = 543 / 130;
            Console.WriteLine(Math.Floor(a));
            //A1.3
            Console.WriteLine("A1.3");
            Console.WriteLine("Введите номер месяца: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 12 == 0)
            {
                n = 1;
            }
            else
            {
                n++;
            }
            Console.WriteLine(n);
            //A1.4
            Console.WriteLine("A1.4");
            Console.WriteLine("Введите число: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Кол-во десятков " + number / 10);
            Console.WriteLine("Кол-во единиц " + number % 10);
            Console.WriteLine("Сумма его цифр " + ((number / 10) + (number % 10)));
            Console.WriteLine("Кол-во десятков " + (number / 10) * (number % 10));
            //A1.5
            Console.WriteLine("A1.5");
            int d = int.Parse(Console.ReadLine());
            int u = d / 100;
            int h = d % 100 / 10;
            int q = d % 10;
            int kn = h * 100 + q * 10 + u;
            Console.WriteLine(kn);
            //A1.6
            Console.WriteLine("A1.6");
            int x = 237;
            int remainder = x / 100;
            x = x % 100;
            Console.WriteLine(x * 10 + remainder);
            //A1.7
            Console.WriteLine("A1.7");
            int a2a1 = Convert.ToInt16(Console.ReadLine());
            int b2b1 = Convert.ToInt16(Console.ReadLine());
            int a1 = a2a1 % 10;
            int a2 = a2a1 / 10;
            int b1 = b2b1 % 10;
            int b2 = b2b1 / 10;
            Console.WriteLine(a2 + b2 + ", " + (a1 + b1));
            //A1.8
            Console.WriteLine("A1.8");
            Console.WriteLine("Введите значение k: ");
            int k = int.Parse(Console.ReadLine());
            if (k % 3 == 0)
            {
                Console.WriteLine(k / 3 % 10);
            }
            if (k % 3 == 1)
            {
                Console.WriteLine("1");
            }
            if (k % 3 == 2)
            {
                Console.WriteLine((k + 2) / 30);
            }
            //A1.9
            Console.WriteLine("A1.9");
            bool A = true;
            bool B = false;
            bool C = false;
            Console.WriteLine("а)" + (A | B));
            Console.WriteLine("б) " + (A & B));
            Console.WriteLine("в) " + (B | C));
            //A1.10
            Console.WriteLine("A1.10");
            bool x1 = Convert.ToBoolean(Console.ReadLine());
            bool y1 = Convert.ToBoolean(Console.ReadLine());
            bool z1 = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("a) " + (!(x1 | y1) & (!x1 | !z1)));
            Console.WriteLine("б) " + (!(!x1 & y1) | (x1 & !z1)));
            Console.WriteLine("в) " + (x1 | !y1 & !(x1 | !z1)));
        }
    }
}