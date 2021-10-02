using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_3
{
    enum cards //пространство имён для упражнение 4
    {
        Шестёрка = 6,
        Семёрка = 7,
        Восьмёрка = 8,
        Девятка = 9,
        Десятка = 10,
        Валет = 11,
        Дама = 12,
        Король = 13,
        Туз = 14
    }
    class Classwork
    {
        static void Main(string[] args)
        {
            //Упражнение 1
            Console.WriteLine("Упражнение 1");
            Console.WriteLine("Введите трёхзначное число:");
            int number = int.Parse(Console.ReadLine());
            int hundreds = number / 100;
            int units = number % 10;
            if (units == hundreds)
            {
                Console.WriteLine(number + " - является полиндромом");
            }
            else
            {
                Console.WriteLine(number + " - не является полиндромом");
            }
            //Упражнение 2
            Console.WriteLine("Упражнение 2");
            Console.WriteLine("Введите ширину форточки:");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину форточки:");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите диаметр головы Васи:");
            int diameter = int.Parse(Console.ReadLine());
            if ((width - diameter >= 1) & (length - diameter >= 1))
            {
                Console.WriteLine("Голова Васи влезет");
            }
            else
            {
                Console.WriteLine("Голова Васи не влезет");
            }
            //Упражнение 3
            Console.WriteLine("Упражнение 3");
            string[] week = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
            int numberday = int.Parse(Console.ReadLine());
            Console.WriteLine(week[numberday - 1]);
            //Упражнение 4
            Console.WriteLine("Упражнение 4");
            Console.WriteLine("Введите число от 6 до 14 включительно:");
            try
            {
                number = int.Parse(Console.ReadLine());
                cards card;
                card = (cards)number;
                Console.WriteLine(card);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Возникло исключение");
            }
            //Упражнение 5
            int radius = 6370;
            Console.WriteLine("Введите высоту от 1 до 10 км:");
            byte height = byte.Parse(Console.ReadLine());
            double horizon = Math.Sqrt((radius + height) * (radius + height) - radius * radius);
            Console.WriteLine("Расстояние до линии горизонта: " + Math.Round(horizon, 2));
            //Упражнение 6
            Console.WriteLine("Упражнение 6");
            Console.WriteLine("Введите число от 1 до 9:");
            number = int.Parse(Console.ReadLine());
            int[] tab_numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < tab_numbers.Length; i++)
            {
                Console.Write(number * tab_numbers[i] + " ");
            }
            //Упражнение 7
            Console.WriteLine("\nУпражнение 7");
            int[] sequence = { 8, 5, 2, 7, 9, 3, 6, -1 };
            int[] positive_sequence = Array.FindAll(sequence, i => i >= 0);
            Console.WriteLine("Среднее арифметическое всех чисел последовательности: " + positive_sequence.Sum() / positive_sequence.Length);
            //Упражнение 8
            Console.WriteLine("Упражнение 8");
            Console.WriteLine("Введите значения последовательности: ");
            int[] sequence1 = new int[10];
            for (int i = 0; i < sequence1.Length; i++)
            {
                sequence1[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 1; ; j++)
            {
                if (sequence1[j - 1] >= sequence1[j])
                {
                    Console.WriteLine("Неупорядоченная последовательность; порядковый номер числа, нарушающего последовательность:  " + (j + 1));
                    break;
                }
                if (j == 9)
                {
                    Console.WriteLine("Упорядочная последовательность");
                    break;
                }
            }
            //Упражнение 9
            Console.WriteLine("Упражнение 9");
            Console.WriteLine("Введите количество элементов в последовательности: ");
            int elements = int.Parse(Console.ReadLine());
            sequence = new int[elements];
            sequence[elements - 1] = 0;
            for (int i = 0; i < (elements - 1); i++)
            {
                sequence[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int j = 0; j < elements; j++)
            {
                if (!(j % 3 == 2))
                    continue;
                sum += sequence[j];
            }
            Console.WriteLine("Сумма элементов индексы, которых кратных 3: " + sum);
            //Упражнение 10
            Console.WriteLine("Упражнение 10");
            sum = 0;
            for (int i = 0; i < (elements - 1); i++)
            {
                while (sequence[i] != sequence[elements - 1])
                {
                    goto sum;
                }
            sum:
                sum += sequence[i];
            }
            Console.WriteLine("Сумма элементов последовательности " + sum);
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