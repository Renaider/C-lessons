using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Упражнение 1
            Console.WriteLine("Упражнение 1");
            Console.WriteLine("min значение типа sbyte " + sbyte.MinValue);
            Console.WriteLine("max значение типа sbyte " + sbyte.MaxValue);
            Console.WriteLine("min значение типа byte " + byte.MinValue);
            Console.WriteLine("max значение типа byte " + byte.MaxValue);
            Console.WriteLine("max значение типа short " + short.MaxValue);
            Console.WriteLine("min значение типа short " + short.MinValue);
            Console.WriteLine("min значение типа ushort " + ushort.MinValue);
            Console.WriteLine("max значение типа ushort " + ushort.MaxValue);
            Console.WriteLine("min значение типа int " + int.MinValue);
            Console.WriteLine("max значение типа int " + int.MaxValue);
            Console.WriteLine("min значение типа uint" + uint.MinValue);
            Console.WriteLine("max значение типа uint " + uint.MaxValue);
            Console.WriteLine("min значение типа long " + long.MinValue);
            Console.WriteLine("max значение типа long " + long.MaxValue);
            Console.WriteLine("max значение типа ulong " + ulong.MaxValue);
            Console.WriteLine("min значение типа ulong " + ulong.MinValue);
            Console.WriteLine("min значение типа float " + float.MinValue);
            Console.WriteLine("max значение типа float " + float.MaxValue);
            Console.WriteLine("max значение типа double " + double.MaxValue);
            Console.WriteLine("min значение типа double " + double.MinValue);
            Console.WriteLine("max значение типа decimal " + decimal.MaxValue);
            Console.WriteLine("min значение типа decimal " + decimal.MinValue);
            //Упржанение 2
            Console.WriteLine("Упражнение 2");
            string name = Console.ReadLine();
            string town = Console.ReadLine();
            string age = Console.ReadLine();
            string PIN = Console.ReadLine();
            Console.WriteLine("Имя " + name + "\n" + "Город " + town + "\n" + "Возраст " + age + "\n" + "ПИН-КОД " + PIN + "\n");
            //Упражнение 3
            Console.WriteLine("Упражнение 3");
            Console.WriteLine("Введите строчные буквы");
            string letter = Console.ReadLine();
            string letterup = letter.ToUpper();
            Console.WriteLine(letterup);
            Console.WriteLine("Введите прописные буквы ");
            string letterlow = Console.ReadLine();
            string letter_low = letterlow.ToLower();
            Console.WriteLine(letter_low);
            //Упражнение 4
            Console.WriteLine("Упражнение 4");
            Console.WriteLine("3)\n");
            Console.WriteLine("Введите строку\n");
            string str = Console.ReadLine();
            string new_str = "";
            foreach (var ind in str)
            {
                if (char.IsUpper(ind))
                {
                    new_str += char.ToLower(ind);
                }
                else
                {
                    new_str += char.ToUpper(ind);
                }
            }
            Console.WriteLine(new_str + "\n");
            //Упражнение 5
            Console.WriteLine("Упражнение 5");
            double speed1 = double.Parse(Console.ReadLine()); // км/ч
            double speed2 = Math.Floor(speed1 / 3.6 * 100); // округление вних к бесконечности
            Console.WriteLine("скорость в метрах в сек " + speed2);
            //Упражнение 6
            Console.WriteLine("Упражнение 6");
            Console.WriteLine("Введите возраст отца");
            int age1 = int.Parse(Console.ReadLine()); //возраст отца
            Console.WriteLine("Введите возраст сына");
            int age2 = int.Parse(Console.ReadLine()); //возраст сына
            int sum = Math.Abs(age1 - age2 * 2);
            int t = 0;
            int p = 0;
            if (age1 > age2 * 2)
            {
                for (int i = 0; age2 * 2 < age1; i++)
                {
                    age1++;
                    age2++;
                    t++;
                }
                Console.WriteLine("Отец будет старше в два раза сына через " + t);
            }
            else
            {
                for (int h = 0; age2 * 2 > age1; h++)
                {
                    age1--;
                    age2--;
                    p++;
                }
                Console.WriteLine("Отец был старше сына в два раза " + p + " лет назад");
            }
            //Упражнение 7
            Console.WriteLine("7");
            double standardPrice = int.Parse(Console.ReadLine());
            double salePrice = int.Parse(Console.ReadLine());
            double holidayPrice = int.Parse(Console.ReadLine());
            double sum1 = Math.Floor(holidayPrice / (standardPrice * 0.01 * salePrice));
            Console.WriteLine("Придется купить " + sum1 + " бутылок");
        }
    }
}
