using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.IsolatedStorage;
using System.Threading;

namespace Lesson_4
{
    class Classwork
    {
        static void SolveSquareEquation(double a, double b, double c) //метод для упражнение 1, решение квадратного уравнения
        {
            if (a == 0)
            {
                Console.WriteLine("Корень уравнения: " + -c/b);
            }
            else
            {
                double discriminant = b * b - 4 * a * c;
                if (discriminant > 0)
                {
                    Console.WriteLine("Корни уравнения: " + (-b + Math.Sqrt(discriminant)) / 2 * a + ", " + (-b - Math.Sqrt(discriminant)) / 2 * a);
                }
                else if (discriminant == 0)
                {
                    Console.WriteLine("Корень уравнения: " + -b / 2 * a);
                }
                else
                {
                    Console.WriteLine("Корней нет");
                }
            }
        }
        static void Sort(int[] array) //метод для упражнение 3, пузырьковая сортировка
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int reserve = array[i];
                        array[i] = array[j];
                        array[j] = reserve;
                    }
                }
            }
            Console.WriteLine("Массив с сортировкой:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        static double SumComAve(ref int com, out double average, params int[] numbers)
        {
            int sum = 0; 
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                com *= numbers[i];
            }
            average = sum / numbers.Length;
            return sum;
        }
        static void Main(string[] args)
        {
            //Упражнение 1
            try
            {
                Console.WriteLine("Упражнение 1");
                Console.WriteLine("Введите коэффициент 'a':");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите коэффициент 'b':");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите коэффициент 'c':");
                double c = double.Parse(Console.ReadLine());
                SolveSquareEquation(a, b, c);
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели не числа");
            }
            //Упражнение 2
            Console.WriteLine("Упражнение 2");
            int[] random_numbers = new int[20];
            Random random = new Random();
            for (int i = 0; i < random_numbers.Length; i++)
            {
                random_numbers[i] = random.Next(100);
                Console.Write(random_numbers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Введите первое число, которое нужно поменять местами:");
            int replace_number_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число, которое нужно поменять местами:");
            int replace_number_2 = int.Parse(Console.ReadLine());
            replace_number_1 -= 1;
            replace_number_2 -= 1;
            int reserve_number = random_numbers[replace_number_1];
            random_numbers[replace_number_1] = random_numbers[replace_number_2];
            random_numbers[replace_number_2] = reserve_number;
            for (int i = 0; i < random_numbers.Length; i++)
            {
                Console.Write(random_numbers[i] + " ");
            }
            Console.WriteLine();
            //Упражнение 3
            Console.WriteLine("Упражнение 3");
            Console.WriteLine("Введите количество элементов в массиве:");
            int elements = int.Parse(Console.ReadLine());
            int[] array = new int[elements];
            random = new Random();
            Console.WriteLine("Массив без сортировки:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Sort(array);
            //Упражнение 4
            Console.WriteLine("Упражнение 4");
            Console.WriteLine("Введите количество элементов в массиве:");
            elements = int.Parse(Console.ReadLine());
            int[] list = new int[elements];
            random = new Random();
            Console.WriteLine("Массив: ");
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = random.Next(100);
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
            int com = 1;
            double average = 0;
            Console.WriteLine("Сумма элементов в массиве: " + SumComAve(ref com, out average, list));
            Console.WriteLine("Произведение в массиве: " + com);
            Console.WriteLine("Среднее арифметическое в массиве: " + average);
            //Упражнение 5
            Console.WriteLine("Упражнение 5");
            try
            {
                Console.WriteLine("Введите число:");
                int number = int.Parse(Console.ReadLine());
                switch (number)
                {
                    case 0:
                        Console.WriteLine("###\n# #\n# #\n# #\n###");
                        break;
                    case 1:
                        Console.WriteLine("  #\n  #\n  #\n  #\n  #");
                        break;
                    case 2:
                        Console.WriteLine("###\n  #\n###\n#  \n###");
                        break;
                    case 3:
                        Console.WriteLine("###\n  #\n###\n  #\n###");
                        break;
                    case 4:
                        Console.WriteLine("# #\n# #\n###\n  #\n  #");
                        break;
                    case 5:
                        Console.WriteLine("###\n#  \n###\n  #\n###");
                        break;
                    case 6:
                        Console.WriteLine("###\n#  \n###\n# #\n###");
                        break;
                    case 7:
                        Console.WriteLine("###\n  #\n  #\n  #\n  #");
                        break;
                    case 8:
                        Console.WriteLine("###\n# #\n###\n# #\n###");
                        break;
                    case 9:
                        Console.WriteLine("###\n# #\n###\n  #\n###");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.WriteLine("ERROR");
                        Thread.Sleep(3000);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели недопустимый формат");
                Console.WriteLine("Для закрытия программы введите exit/закрыть:");
                string exit = Console.ReadLine();
                if ((exit == "exit") | (exit == "exit"))
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}