using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_from_lab
{
    class Book
    {
        internal string name;
        internal string author;
        internal string publishing_house;
        public Book(string name, string author, string publishing_house)
        {
            this.name = name;
            this.author = author;
            this.publishing_house = publishing_house;
        }

    }
}
