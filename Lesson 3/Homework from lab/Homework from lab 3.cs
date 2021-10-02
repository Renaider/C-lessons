using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_from_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Упражнение 4.1
            Console.WriteLine("Упражнение 4.1");
            Console.WriteLine("Введите число от 1 до 365:");
            int days = int.Parse(Console.ReadLine());
            int[] days_months = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] name_months = { "январь", "февраль", "март", "апрель", "май", "июнь", "июль", "август", "сентябрь", "октябрь", "ноябрь", "декабрь", };
            int count_mouths = 0;
            while (days - days_months[count_mouths] > 0)
            {
                days -= days_months[count_mouths];
                count_mouths++;
            }
            Console.WriteLine(days + " " + name_months[count_mouths]);
            //Упражнение 4.2
            Console.WriteLine("Упражнение 4.2");
            Console.WriteLine("Введите число от 1 до 365:");
            count_mouths = 0;
            days = int.Parse(Console.ReadLine());
            if ((days < 366) && (days > 0))
            {
                while (days - days_months[count_mouths] > 0)
                {
                    days -= days_months[count_mouths];
                    count_mouths++;
                }
                Console.WriteLine(days + " " + name_months[count_mouths]);
            }
            else
            {
                Console.WriteLine("Вы ввели неверное значение");
            }
            //Домашнее задание 4.1
            Console.WriteLine("Домашнее задание 4.1");
            Console.WriteLine("Введите год:");
            int year = int.Parse(Console.ReadLine());
            if ((days < 366) & (days > 0))
            {
                if ((year % 4 == 0 & year % 100 != 0) | (year % 400 == 0))
                {
                    days_months[1]++;
                    while (days - days_months[count_mouths] > 0)
                    {
                        days -= days_months[count_mouths];
                        count_mouths++;
                    }
                    Console.WriteLine(days + " " + name_months[count_mouths]);
                }
                else
                {
                    while (days - days_months[count_mouths] > 0)
                    {
                        days -= days_months[count_mouths];
                        count_mouths++;
                    }
                    Console.WriteLine(days + " " + name_months[count_mouths]);
                }
            }
            else
            {
                Console.WriteLine("Вы ввели неверное значение");
            }
        }
    }
}
