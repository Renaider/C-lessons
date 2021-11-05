using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class Report
    {

        private string text;
        private string date;
        private Employee executor;
        public Report(string text, string date, Employee executor)
        {
            this.text = text;
            this.date = date;
            this.executor = executor;
        }
        public void GetReport()
        {
            Console.WriteLine(text);
            Console.WriteLine(date);
        }
    }
}
