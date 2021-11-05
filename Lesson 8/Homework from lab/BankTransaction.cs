using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_from_lab
{
    class BankTransaction
    {
        private DateTime date;
        private decimal balance;
        public BankTransaction(decimal sum)
        {
            date = DateTime.Now;
            balance = sum;
        }
        public void GetHistory()
        {
            Console.WriteLine(date);
            Console.WriteLine("Баланс на счету: " + balance);
        }
    }

}
