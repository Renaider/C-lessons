using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_from_lab
{
    class CreatorBankAccount
    {
        public int CreateAccount(decimal balance)
        {
            BankAccount account = new BankAccount(balance);
            return account.GetAccountNumber();
        }
        public int CreateAccount(TypesAccounts type_account)
        {
            BankAccount account = new BankAccount(type_account);
            return account.GetAccountNumber();
        }
        public int CreateAccount(decimal balance, TypesAccounts type_account)
        {
            BankAccount account = new BankAccount(balance, type_account);
            return account.GetAccountNumber();
        }
        public void DeleteAccount(int account_number)
        {

        }
    }
}
