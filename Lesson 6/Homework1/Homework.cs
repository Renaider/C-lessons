using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static int DoVerification()
        {
            int data = 0;
            if (Int32.TryParse(Console.ReadLine(), out data))
            {

            }
            else
            {
                Console.WriteLine("Вы ввели неверный формат");
            }
            return data;
        }
        class Building
        {
            private int number;
            static int count_number = 0;
            private int height;
            private int floors;
            private int apartments;
            private int entrances;
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
            public void ToFill()
            {
                Console.WriteLine("Номер здания:");
                Console.WriteLine(NewNumber());
                Console.WriteLine("Высота здания:");
                height = DoVerification();
                Console.WriteLine("Этажность:");
                floors = DoVerification();
                Console.WriteLine("Количество квартир в здании:");
                apartments = DoVerification();
                Console.WriteLine("Количество подъездов в здании:");
                entrances = DoVerification();
            }
            public void ToRead()
            {
                Console.WriteLine("Номер здания: " + number);
                Console.WriteLine("Высота: " + height);
                Console.WriteLine("Этажность: " + floors);
                Console.WriteLine("Количество квартир: " + apartments);
                Console.WriteLine("Количество подъездов: " + entrances);
            }
        }
        static void Main(string[] args)
        {
            //Упражнение 7.1
            Console.WriteLine("Упражнение 7.1");
            Building building = new Building();
            Console.WriteLine("Введите данные дома");
            building.ToFill();
            Console.WriteLine("Данные дома");
            building.ToRead();
            Console.WriteLine("Высота одного этажа: " + building.GetHeightFloor());
            Console.WriteLine("Количество квартир в 1-ом подъезде: " + building.GetApartsEntr());
            Console.WriteLine("Количество квартир на 1-ом этаже: " + building.GetApartsFloor());
        }
    }
}
