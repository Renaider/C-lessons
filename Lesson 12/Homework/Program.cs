using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Упражнение 14.1
            BankAccount bankAccount = new BankAccount(5000, (TypesAccounts)2);
            bankAccount.DumpToScreen();
            //Упражнение 14.2
            RationalNumber rational = new RationalNumber(1, 2);
            Type t = typeof(RationalNumber);
            object[] attrs = t.GetCustomAttributes(false);
            foreach (DeveloperInfoAttribute attr in attrs)
            {
                Console.WriteLine(attr.creature);
                Console.WriteLine(attr.name);
            }
            //Домашнее задание 14.1
            Building build = new Building();
            Type t_1 = typeof(Building);
            object[] data = t_1.GetCustomAttributes(false);
            foreach (BuildingAttribute dat in data)
            {
                Console.WriteLine(dat.name);
                Console.WriteLine(dat.name_company);
            }
        }
    }
}
