using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class Employee
    {
        private int id;
        static int count_id;
        private string name;
        private Task task;
        public Employee(string name)
        {
            this.name = name;
            count_id += 1;
            id = count_id;
        }
        public void GetEmployee()
        {
            Console.WriteLine(id + ": " + name);
        }
    }
}
