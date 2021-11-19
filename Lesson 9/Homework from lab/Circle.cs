using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_from_lab
{
    class Circle : Point
    {
        public override void Move(int x, int y)
        {
            Console.WriteLine("Центра окружности сместится по горизонтали: " + x + " по вертикали: " + y);
        }
    }
}
