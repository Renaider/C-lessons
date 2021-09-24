using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Homework__2
{
    //Упражнение 3.1 тип данных(перечисление)
    enum bank_account
    {
        Saving, Current,
        Anothercard = 1
    }
    //Упражнение 3.2 структура данных
    struct credit //конструктор
    {
        public string number;
        public string type;
        public string balance;
        public void DisplayInfo()
        {
            Console.WriteLine($"Number:{number}, Type: {type}, Balance {balance}");
        }
    }
    //Упражнение 3.3 структура данных + тип данных(перечисление)
    enum university
    {
        КГУ, КХТИ, КАИ
    }
    struct work
    {
        public string name;
        public string university;
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, University: {university}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 3.1");
            bank_account num;
            num = bank_account.Anothercard;
            Console.WriteLine((int)num);
            Console.WriteLine("Упражнение 3.2");
            credit card;
            card.number = "67543215";
            card.type = "debit";
            card.balance = "1000";
            card.DisplayInfo();
            Console.WriteLine("Упражнение 3.3");
            work worker;
            worker.name = "Dmitriy"; ;
            worker.university = Convert.ToString(university.КХТИ);
            worker.DisplayInfo();
            work worker_2;
            worker_2.name = "Richard";
            worker_2.university = Convert.ToString(university.КГУ);
            worker_2.DisplayInfo();
        }
    }
}