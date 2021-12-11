using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_from_lab_13
{
    class Building
    {
        public int number { get; set; }
        static int count_number = 0;
        public int height { get; set; }
        public int floors { get; set; }
        public int apartments { get; set; }
        public int entrances { get; set; }
        public Building(int height, int floors, int apartments, int entrances)
        {
            this.number = NewNumber();
            this.height = height;
            this.floors = floors;
            this.apartments = apartments;
            this.entrances = entrances;
        }
        public Building()
        {

        }
        public int NewNumber()
        {
            count_number += 1;
            number = count_number;
            return number;
        }
        public double GetHeightFloor()
        {
            return height / floors;
        }
        public double GetApartsEntr()
        {
            return apartments / entrances;
        }
        public double GetApartsFloor()
        {
            return apartments / entrances / floors;
        }
    }
}
