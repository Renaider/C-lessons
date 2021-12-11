using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_from_lab_13
{
    class Builds
    {
        internal Building[] builds = new Building[10];
        public Building this[int index]
        {
            get { return builds[index]; }
            set { builds[index] = value; }
        }
    }
}
