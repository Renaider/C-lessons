using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_from_lab
{
    class ContainsBooks
    {
        public static List<Book> books = new List<Book>();
        public delegate void SortingType();
        public void Sort(SortingType Sorting)
        {
            Sorting();
        }
        public static SortingType byName = SortingByName;
        public static SortingType byAuthor = SortingByAuthor;
        public static SortingType byPublishingHouse = SortingByPiblisher;
        private static void SortingByName()
        {
            var sorted = ContainsBooks.books.OrderBy(Book => Book.name);
            Console.WriteLine("Sorted by names:");
            foreach (Book book in sorted)
            {
                Console.WriteLine($" {book.name}, {book.author}, {book.publishing_house}");
            }

        }
        private static void SortingByAuthor()
        {

            var sorted = ContainsBooks.books.OrderBy(Book => Book.author);
            Console.WriteLine("Sorted by authors:");
            foreach (Book book in sorted)
            {
                Console.WriteLine($" {book.name}, {book.author}, {book.publishing_house}");
            }

        }
        private static void SortingByPiblisher()
        {
            var sorted = ContainsBooks.books.OrderBy(Book => Book.publishing_house);
            Console.WriteLine("Sorted by publishers:");
            foreach (Book book in sorted)
            {
                Console.WriteLine($" {book.name}, {book.author}, {book.publishing_house}");
            }
        }
    }
}
