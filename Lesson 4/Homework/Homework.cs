using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Homework //
    {
        static double CompareNumbers(double number_1, double number_2) //метод для упражнения 5.1, определение большего числа
        {
            if (number_1 > number_2)
            {
                Console.WriteLine("1-ое число больше 2-ого");
                return 0;
            }
            else if (number_1 < number_2)
            {
                Console.WriteLine("2-ое число больше 1-ого");
                return 0;
            }
            else
            {
                Console.WriteLine("Числа равны");
                return 0;
            }
        }
        static void Swap(ref double number_1, ref double number_2) //метод для упражнения 5.2, обмен значений у параметров
        {
            double swap = number_1;
            number_1 = number_2;
            number_2 = swap;
        }
        static bool CountFactorial(int factorial, out int result) //метод для упражнение 5.3, вычисление факториала с учётом возможности переполнения
        {
            result = 1;
            for (int i = 2; i <= factorial; i++)
            {
                try
                {
                    checked
                    {
                        result *= i;
                    }
                }
                catch (OverflowException)
                {
                    result = 0;
                    return false;
                }
            }
            return true;
        }
        static int CountRecursionFactorial(int factorial) //метод для упражнение 5.4, вычисление факториала рекурсивным методом
        {
            if (factorial == 0)
            {
                return 1;
            }
            else
            {
                return factorial * CountRecursionFactorial(factorial - 1);
            }
        }
        static int getGCDTwoNum(int numberGCD_1, int numberGCD_2) //метод для упражнения 5.1, для нахождения НОД для 2 чисел по алгоритму Евклида
        {
            while ((numberGCD_1 != 0) & (numberGCD_2 != 0))
            {
                if (numberGCD_1 > numberGCD_2)
                {
                    numberGCD_1 %= numberGCD_2;
                }
                else
                {
                    numberGCD_2 %= numberGCD_1;
                }
            }
            return numberGCD_1 + numberGCD_2;
        }
        static int getGCDThreeNum(int numberGCD_1, int numberGCD_2, int numberGCD_3) //метод для упражнения 5.1, для нахождения НОД для 3 чисел по алгоритму Евклида
        {
            int gcd = getGCDTwoNum(numberGCD_1, numberGCD_2);
            return getGCDTwoNum(gcd, numberGCD_3);
        }
        static int CountFibonacciNumber(int ordinal_number) //метод для упражнение 5.2, вычисление заданного порядкого номера числа ряда Фибоначчи
        {
            if (ordinal_number == 0)
            {
                return 0;
            }
            else if (ordinal_number == 1)
            {
                return 1;
            }
            else
            {
                return CountFibonacciNumber(ordinal_number - 1) + CountFibonacciNumber(ordinal_number - 2);
            }
        }
        static void Main(string[] args)
        {
            //Упражнение 5.1
            Console.WriteLine("Упражнение 5.1");
            Console.WriteLine("Введите 1-ое число для сравнения:");
            double number_1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2-ое число для сравнения:");
            double number_2 = double.Parse(Console.ReadLine());
            CompareNumbers(number_1, number_2);
            //Упражнение 5.2
            Console.WriteLine("Упражнение 5.2");
            Console.WriteLine("Введите значение 1-ого параметра: ");
            number_1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение 2-ого параметра: ");
            number_2 = double.Parse(Console.ReadLine());
            Console.WriteLine("До обмена параметров: " + number_1 + ", " + number_2);
            Swap(ref number_1, ref number_2);
            Console.WriteLine("После обмена параметров: " + number_1 + ", " + number_2);
            //Упражнение 5.3
            Console.WriteLine("Упражнение 5.3");
            Console.WriteLine("Введите факториал числа:");
            int factorial = int.Parse(Console.ReadLine());
            int result;
            Console.WriteLine("Результат работы метода: " + CountFactorial(factorial, out result));
            Console.WriteLine("Факториал " + factorial + " равен: " + result);
            //Упражнение 5.4
            Console.WriteLine("Упражнение 5.4");
            Console.WriteLine("Введите факториал числа:");
            factorial = int.Parse(Console.ReadLine());
            Console.WriteLine("Факториал " + factorial + " равен: " + CountRecursionFactorial(factorial));
            //Упражнение 5.1
            Console.WriteLine("Упражнение 5.1");
            Console.WriteLine("Введите 1-ое число для определения НОД:");
            int numberGCD_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2-ое число для определения НОД:");
            int numberGCD_2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите 3-ие число для определения НОД:");
            int numberGCD_3 = int.Parse(Console.ReadLine());
            Console.WriteLine("НОД для 1-ого и 2-ого числа: " + getGCDTwoNum(numberGCD_1, numberGCD_2));
            Console.WriteLine("НОД для 1-ого, 2-ого и 3-ого числа: " + getGCDThreeNum(numberGCD_1, numberGCD_2, numberGCD_3));
            //Упражнение 5.2
            Console.WriteLine("Упражнение 5.2");
            Console.WriteLine("Введите порядковый номер числа ряда Фибоначчи:");
            int ordinal_number = int.Parse(Console.ReadLine());
            Console.WriteLine("Число ряда Фибоначчи порядкого номера " + ordinal_number + ": " + CountFibonacciNumber(ordinal_number));
        }
    }
}