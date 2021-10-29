using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_from_lab
{
    enum TypesAccounts
    {
        Saving = 1,
        Current = 2
    }
    class BankAccount
    {
        private int account_number;
        static int count_account_number = 0;
        private decimal balance;
        private TypesAccounts type_account;
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
            Console.WriteLine("Введите добавляемую сумму:");
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
        public void TransferMoney(ref BankAccount bank_account, decimal sum)
        {
            Console.WriteLine("Введите сумму перевода:");
            if (!Decimal.TryParse(Console.ReadLine(), out sum))
            {
                Console.WriteLine("Вы ввели неверный формат");
            }
            else
            {
                if (sum > 0)
                {
                    if (sum <= bank_account.balance)
                    {
                        bank_account.balance -= sum;
                        balance -= sum;
                        Console.WriteLine("Баланс после перевода: " + bank_account.balance);
                    }
                    else
                    {
                        Console.WriteLine("На балансе недостаточно средств");
                    }
                }
                else
                {
                    Console.WriteLine("Невозможно снять отрицательную сумму");
                }
            }
        }
    }
}