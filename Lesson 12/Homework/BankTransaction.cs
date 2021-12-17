using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class BankTransaction
    {
        private DateTime date { get; set; }
        private decimal balance { get; set; }
        public BankTransaction(decimal sum)
        {
            date = DateTime.Now;
            balance = sum;
        }
    }
}
