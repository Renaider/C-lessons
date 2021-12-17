#define DEBUG_ACCOUNT
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Homework
{
    enum TypesAccounts
    {
        Saving = 1,
        Current = 2
    }
    class BankAccount
    {
        private int account_number { get; }
        private decimal balance { get; set; }
        private TypesAccounts type_account { get; }
        private List<BankTransaction> transactions;
        public BankTransaction this[int index]
        {
            get
            {
                return transactions[index];
            }
            set
            {
                transactions[index] = value;
            }
        }

        private string holder_account { get; set; }
        public BankAccount()
        {

        }
        public BankAccount(int account_number)
        {
            this.account_number = account_number;
            this.account_number = NewAccountNumber();
            transactions = new List<BankTransaction>();
        }
        public BankAccount(decimal balance)
        {
            this.balance = balance;
            account_number = NewAccountNumber();
            transactions = new List<BankTransaction>();
        }
        public BankAccount(TypesAccounts type_account)
        {
            this.type_account = type_account;
            account_number = NewAccountNumber();
            transactions = new List<BankTransaction>();
        }
        public BankAccount(decimal balance, TypesAccounts type_account)
        {
            this.balance = balance;
            this.type_account = type_account;
            account_number = NewAccountNumber();
            transactions = new List<BankTransaction>();
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
        public int NewAccountNumber() //Упражнение 7.2
        {
            return account_number + 1;
        }
        public void WithdrawBalance() //Упражнение 7.3
        {
            Console.WriteLine("Введите желаемую сумму снятия:");
            int remove = DoVerification();
            if (balance > remove)
            {
                balance -= remove;
                transactions.Add(new BankTransaction(remove));
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
            transactions.Add(new BankTransaction(add));
            Console.WriteLine("Баланс после добавления: " + balance);
        }
        public void TransferMoney(BankAccount bank_account)
        {
            Console.WriteLine("Введите сумму перевода:");
            decimal sum = DoVerification_1();
            if ((sum > 0) && (bank_account.balance >= sum))
            {
                bank_account.balance -= sum;
                balance += sum;
                transactions.Add(new BankTransaction(sum));
            }
            else
            {
                Console.WriteLine("Недостаточно средств на счёте");
            }
        }
        public static bool operator ==(BankAccount bankAccount_1, BankAccount bankAccount_2)
        {
            if ((bankAccount_1.balance == bankAccount_2.balance) && (bankAccount_1.type_account == bankAccount_2.type_account))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(BankAccount bankAccount_1, BankAccount bankAccount_2)
        {
            if ((bankAccount_1.balance != bankAccount_2.balance) || (bankAccount_1.type_account != bankAccount_2.type_account))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public override bool Equals(object obj)
        {
            if (obj is BankAccount)
            {
                return balance == (obj as BankAccount).balance && type_account == (obj as BankAccount).type_account;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return "Account: " + account_number + ", " + balance + ", " + type_account;
        }
        [Conditional("DEBUG")]
        public void DumpToScreen()
        {
            Console.WriteLine("ID: " + account_number);
            Console.WriteLine("Balance: " + account_number);
            Console.WriteLine("Type: " + type_account);
        }
    }
}