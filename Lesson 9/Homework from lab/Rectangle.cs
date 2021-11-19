using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_from_lab
{
    class Rectangle : Point
    {
        public override void Move(int x, int y)
        {
            Console.WriteLine("Вершина прямоугольника сместится по горизонтали: " + x + " по вертикали: " + y);
        }
    }
}
