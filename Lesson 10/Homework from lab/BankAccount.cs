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
        private Queue<BankTransaction> transactions;
        internal BankAccount(decimal balance)
        {
            this.balance = balance;
            account_number = NewAccountNumber();
            transactions = new Queue<BankTransaction>();
        }
        internal BankAccount(TypesAccounts type_account)
        {
            this.type_account = type_account;
            account_number = NewAccountNumber();
            transactions = new Queue<BankTransaction>();
        }
        internal BankAccount(decimal balance, TypesAccounts type_account)
        {
            this.balance = balance;
            this.type_account = type_account;
            account_number = NewAccountNumber();
            transactions = new Queue<BankTransaction>();
        }
        private int NewAccountNumber()
        {
            count_account_number += 1;
            account_number = count_account_number;
            return account_number;
        }
        public int GetAccountNumber()
        {
            return account_number;
        }
        public void PutBalance()
        {
            Console.WriteLine("Введите добавляемую сумму:");
            int add = DoVerification();
            balance += add;
            transactions.Enqueue(new BankTransaction(add));
            Console.WriteLine("Баланс после добавления: " + balance);
        }
        public void WithdrawBalance() //Упражнение 7.3
        {
            Console.WriteLine("Введите желаемую сумму снятия:");
            int remove = DoVerification();
            if (balance > remove)
            {
                balance -= remove;
                transactions.Enqueue(new BankTransaction(remove));
                Console.WriteLine("Баланс после снятия денег: " + balance);
            }
            else
            {
                Console.WriteLine("На балансе недостаточно средств");
            }
        }
        public void SetAccount()
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
            transactions = new Queue<BankTransaction>();
        }
        public void GetAccount()
        {
            Console.WriteLine("Номер счёта: " + account_number);
            Console.WriteLine("Баланс счёта: " + balance);
            Console.WriteLine("Вид банковского счёта: " + type_account);
            foreach (BankTransaction data in transactions)
            {
                data.GetHistory();
            }
        }
        public void TransferMoney(BankAccount bank_account)
        {
            Console.WriteLine("Введите сумму перевода:");
            decimal sum = DoVerification_1();
            if ((sum > 0) && (bank_account.balance >= sum))
            {
                bank_account.balance -= sum;
                balance += sum;
                transactions.Enqueue(new BankTransaction(sum));
            }
            else
            {
                Console.WriteLine("Недостаточно средств на счёте");
            }
        }
        static decimal DoVerification_1()
        {
            decimal sum = 0;
            if (Decimal.TryParse(Console.ReadLine(), out sum))
            {

            }
            else
            {
                Console.WriteLine("Вы ввели неверный формат");
            }
            return sum;
        }
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
    }
}
