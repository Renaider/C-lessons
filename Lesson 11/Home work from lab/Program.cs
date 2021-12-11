using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_from_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Упражнение 12.1
            BankAccount account_1 = new BankAccount(5000, (TypesAccounts)2);
            BankAccount account_2 = new BankAccount(5000, (TypesAccounts)2);
            Console.WriteLine(account_1 == account_2);
            Console.WriteLine(account_1 != account_2);
            Console.WriteLine(account_1.Equals(account_2));
            //Упражнение 12.2
            RationalNumber num_1 = new RationalNumber(10,5);
            RationalNumber num_2 = new RationalNumber(33,10);
            Console.WriteLine(num_1 == num_2);
            Console.WriteLine(num_1 > num_2);
            Console.WriteLine(num_1 < num_2);
            Console.WriteLine(num_1 >= num_2);
            Console.WriteLine(num_1 <= num_2);
            Console.WriteLine(++num_1 + " " + ++num_2);
            Console.WriteLine(--num_1 + " " + --num_2);
            Console.WriteLine(num_1 + num_2);
            Console.WriteLine(num_1 - num_2);
            Console.WriteLine(num_1 % num_2);
            //Домашнее задание 12.1
            ComplexNumber complex_1 = new ComplexNumber(4, 5);
            ComplexNumber complex_2 = new ComplexNumber(2, 6);
            Console.WriteLine(complex_1.ToString());
            Console.WriteLine(complex_2.ToString());
            Console.WriteLine(complex_1 + complex_2);
            Console.WriteLine(complex_1 - complex_2);
            Console.WriteLine(complex_1 * complex_2);
            Console.WriteLine(complex_1 == complex_2);
            //Домашнее задание 12.2
            ContainsBooks.books.Add(new Book("Война и Мир", "Лев Толстой", "Азбука"));
            ContainsBooks.books.Add(new Book("Преступление и наказание", "Фёдор Достоевский", "АСТ"));
            ContainsBooks.byName();
            ContainsBooks.byAuthor();
            ContainsBooks.byPublishingHouse();
        }
    }
}
