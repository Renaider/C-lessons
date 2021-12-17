using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class DeveloperInfoAttribute : Attribute
    {
        public string name { get; set; }
        public DateTime creature { get; set; }
        public DeveloperInfoAttribute(string name, byte day, byte month, int year)
        {
            this.name = name;
            this.creature = new DateTime(year, month, day);
        }
    }
}
