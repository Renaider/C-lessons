using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_from_lab
{
    class Point : Figure, IMove, ISquare
    {
        public override void Colour(string colour)
        {
            Console.WriteLine("Цвет обЪекта: " + colour);
        }
        public void Get_Square(int r)
        {
            Console.WriteLine("Площадь окружности : " + Math.Round(Math.PI * r * r), 2);
        }
        public void Get_Square(int side_1, int side_2)
        {
            Console.WriteLine("Площадь прямоугольника : " + side_2 * side_1);
        }
        public virtual void Move(int x, int y)
        {
            Console.WriteLine("Координата точки изменилась по горизонтали на: " + x + " по вертикали: " + y);
        }
    }
}
