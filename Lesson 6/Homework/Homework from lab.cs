using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static int DoVerification()
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
        enum TypesAccounts
        {
            Saving = 1,
            Current = 2
        }
        class BankAccount
        {
            private int account_number;
            static int count_account_number = 0;
            private int balance;
            private TypesAccounts type_account;
            public int NewAccountNumber() //Упражнение 7.2
            {
                count_account_number += 1;
                account_number = count_account_number;
                return account_number;
            }
            public void WithdrawBalance() //Упражнение 7.3
            {
                Console.WriteLine("Введите желаемую сумму:");
                int remove = DoVerification();
                if (balance > remove)
                {
                    balance -= remove;
                    Console.WriteLine("Баланс после снятия денег: " + balance);
                }
                else
                {
                    Console.WriteLine("На балансе недостаточно средств");
                }
            }
            public void PutBalance() //Упражнение 7.3
            {
                Console.WriteLine("Введите добавляемую сумму");
                int add = DoVerification();
                balance += add;
                Console.WriteLine("Баланс после добавления: " + balance);
            }
            public void ToFill()
            {
                Console.WriteLine("Номер счёта:");
                Console.WriteLine(NewAccountNumber());
                Console.WriteLine("Баланс счёта:");
                balance = DoVerification();
                Console.WriteLine("Вид банковского счёта:");
                Console.WriteLine("Введите '1' - для сберегательного счёта");
                Console.WriteLine("Введите '2' - для текущего счёта");
                int n = DoVerification();
                type_account = (TypesAccounts)n;
            }
            public void ToRead()
            {
                Console.WriteLine("Номер счёта: " + account_number);
                Console.WriteLine("Баланс счёта: " + balance);
                Console.WriteLine("Вид банковского счёта: " + type_account);
            }
        }
        static void Main(string[] args)
        {
            //Упражнение 7.1
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
        }
    }
}
