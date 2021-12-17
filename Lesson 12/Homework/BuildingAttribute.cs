using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class BuildingAttribute : Attribute
    {
        public string name { get; set; }
        public string name_company { get; set; }
        public BuildingAttribute(string name, string name_company)
        {
            this.name = name;
            this.name_company = name_company;
        }
    }
}
