using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_from_lab
{
    class Program
    {
        static int GetNumber()
        {
            int n = 0;
            if (int.TryParse(Console.ReadLine(), out n)) { }
            else { Console.WriteLine("Вы ввели неверный формат"); }
            return n;

        }
        public static void Output_Circle(Circle c)
        {
            Console.WriteLine("Введите цвет окружности");
            string colour = Console.ReadLine();
            Console.WriteLine("Введите число на которое сдвинется окружность по горизонтали и вертикали");
            int x = GetNumber();
            int y = GetNumber();
            Console.WriteLine("Введите радиус круга");
            int radius = GetNumber();
            c.Colour(colour);
            c.Move(x, y);
            c.Get_Square(radius);
        }
        public static void Output_Point(Point p)
        {
            Console.WriteLine("Введите цвет точки");
            string colour = Console.ReadLine();
            Console.WriteLine("Введите число на которое сдвинется точка по горизонтали и вертикали");
            p.Move(GetNumber(), GetNumber());
            p.Colour(colour);
        }
        public static void Output_Rectangle(Rectangle r)
        {
            Console.WriteLine("Введите цвет прямоугольника");
            string colour = Console.ReadLine();
            Console.WriteLine("Введите число на которое сдвинется фигура по горизонтали:");
            int x = GetNumber();
            Console.WriteLine("Введите число на которое сдвинется фигура по вертикали");
            int y = GetNumber();
            Console.WriteLine("Введите стороны прямоугольника");
            int side_1 = GetNumber();
            int side_2 = GetNumber();
            r.Colour(colour);
            r.Move(x, y);
            r.Get_Square(side_1, side_2);
        }
        static void Main(string[] args)
        {
            //Упражнение 10.1
            Console.WriteLine("Упражнение 10.1");
            ICipher cipher = new BCipher();
            string text = Console.ReadLine();
            string enc_text = cipher.Encode(text);
            Console.WriteLine(enc_text);
            Console.WriteLine(cipher.Decode(text));
            //Упражнение 10.2
            Console.WriteLine("Упражнение 10.2");
            Console.WriteLine("Выберите фигуру: окружность|точка|прямоугольник");
            Console.WriteLine("(Введите 1 для выбора окружность|Введите 2 для выбора точка|Введите 3 для выбора прямоугольника)");
            int menu_1 = GetNumber();
            switch (menu_1)
            {
                case 1:
                    Circle c = new Circle();
                    Output_Circle(c);
                    break;
                case 2:
                    Point point = new Point();
                    Output_Point(point);
                    break;
                case 3:
                    Rectangle r = new Rectangle();
                    Output_Rectangle(r);
                    break;
                default:
                    Console.WriteLine("Вы ввели неверный формат");
                    break;
            }
        }
    }
}