using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework_from_lab
{
    class Program
    {
        public static string ReverseString(string line)
        {
            Console.WriteLine("Перевёрнутая строка:");
            return new string(line.Reverse().ToArray());
        }
        public static int DoVerification()
        {
            int data = 0;
            if (Int32.TryParse(Console.ReadLine(), out data))
            {

            }
            else
            {
                Console.WriteLine("Вы ввели неверный формат");
            }
            return data;
        }
        public static void WriteToFile(string file)
        {
            if (File.Exists(file))
            {
                Console.WriteLine("Файл найден и изменён");
                File.WriteAllText(file, File.ReadAllText(file).ToUpper());
            }
            else
            {
                Console.WriteLine("Данный файл не найден");
            }
        }
        public static bool IsRealezatingIFormatable(Object obj)
        {
            if (obj is IFormattable)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            //Класс Банковский счёт Упр. 7.1, 7.2, 7.3, 8.1
            Console.WriteLine("Упражнение 7.1");
            BankAccount user = new BankAccount();
            Console.WriteLine();
            Console.WriteLine("Заполните данные о пользователе банка");
            user.ToFill();
            Console.WriteLine("Данные о пользователе:");
            user.ToRead();
            Console.WriteLine("Упражнение 7.3");
            user.WithdrawBalance();
            user.PutBalance();
            user.TransferMoney(ref user, 5000);
            //Упражнение 8.2
            Console.WriteLine("Упражнение 8.2");
            Console.WriteLine("Введите строку:");
            string line = Console.ReadLine();
            Console.WriteLine(ReverseString(line));
            //Упражнение 8.3
            Console.WriteLine("Упражнение 8.3");
            string file = "file.txt";
            WriteToFile(file);
            //Упражнение 8.4
            Console.WriteLine("Упражнение 8.4");
            if (IsRealezatingIFormatable(new Test()))
            {
                Console.WriteLine("Наследуется");
            }
            else
            {
                Console.WriteLine("Не наследуется");
            }
        }
    }
}
