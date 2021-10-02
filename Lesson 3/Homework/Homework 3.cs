using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    class Program
    {
        static string getMouthSize(string animal)
        {
            if (animal == "аллигатор")
            {
                return "mouthSize = small";
            }
            else
            {
                return "mouthSize = wide";
            }
        }
        static void Main(string[] args)
        {
            //Упражнение 1.1
            Console.WriteLine("Упражнение 1.1");
            int number = int.Parse(Console.ReadLine());
            int[] module = { number, -number };
            for (int i = 0; i < module.Length; i++)
            {
                if (module[i] >= 0) ;
                {
                    Console.WriteLine("Абсолютная величина числа: " + module[i]);
                }
            }
            //Упражнение 1.2
            Console.WriteLine("Упражнение 1.2");
            Console.WriteLine("Введите 1-ое число: ");
            int number_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2-ое число: ");
            int number_2 = int.Parse(Console.ReadLine());
            if (Math.Abs(number_1) > Math.Abs(number_2))
            {
                Console.WriteLine("Число 1: " + ((double)number_1 / 2));
            }
            else
            {
                Console.WriteLine("Число 1: " + number_1);
            }
            //Упражнение 1.3
            Console.WriteLine("Упражнение 1.3");
            Console.WriteLine("Введите название животного: ");
            string animal = Console.ReadLine();
            Console.WriteLine(getMouthSize(animal));
            //Упражнение 1.4
            Console.WriteLine("Упражнение 1.4");
            string drink = Console.ReadLine();
            string lowerdrink = drink.ToLower();

            switch (lowerdrink)
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequila");
                    break;
                case "school counselor":
                    Console.WriteLine("Anything with Alcohol");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine");
                    break;
                case "politician":
                    Console.WriteLine("Your tax dollars");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("Beer");
                    break;
            }
            //Упражнение 1.5
            Console.WriteLine("Упражнение 1.5");
            Console.WriteLine("Введите строку:");
            string symbols = Console.ReadLine();
            string lower_symbols = symbols.ToLower();
            bool str_english = lower_symbols.Contains("english");
            Console.WriteLine("English в строке: " + str_english);
            //Упражнение 2.1
            Console.WriteLine("Упражнение 2.1");
            double sum_1 = 1;
            double summand = 3;
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 0; j <= i - 1; j++)
                    summand *= 3;
                sum_1 += 1 / summand;
                summand = 3;
            }
            Console.WriteLine(sum_1);
            //Упражнение 2.2
            Console.WriteLine("Упражнение 2.2");
            double n = 2;
            double distance_all = 1;
            double distance_home = 1;
            while (n <= 100)
            {
                double part_way = 1 / n;
                double new_distance = 1 / (n - 1);
                distance_all += part_way * new_distance;
                if (n % 2 == 0)
                {
                    distance_home -= part_way * new_distance;
                }
                else
                {
                    distance_home += part_way * new_distance;
                }
                n += 1;
            }
            Console.WriteLine(distance_home);
            Console.WriteLine(distance_all);
            //Упражнение 2.3
            Console.WriteLine("Упражнение 2.3");
            int[] january = new int[31];
            int[] march = new int[31];
            Random random = new Random();
            for (int i = 0; i < 31; i++)
            {
                january[i] = random.Next(1000);
            }
            for (int j = 0; j < 31; j++)
            {
                march[j] = random.Next(1000);
            }
            Console.WriteLine("Среднедневное количество осадков за январь: " + january.Sum() / january.Length);
            Console.WriteLine("Среднедневное количество осадков за март: " + march.Sum() / march.Length);
            //Упражнение 3.1
            Console.WriteLine("Упражнение 3.1");
            double numerator_1 = 1;
            double deminator_1 = 1;
            double numerator_2 = 2;
            double deminator_2 = 1;
            double rotate;
            while (Math.Abs((numerator_1 / deminator_1) - (numerator_2 / deminator_2)) > 0.001)
            {

                rotate = numerator_2;
                numerator_2 += numerator_1;
                numerator_1 = rotate;
                rotate = deminator_1;
                deminator_2 += deminator_1;
                deminator_1 = rotate;
            }
            Console.WriteLine(numerator_2 / deminator_2);
            Console.WriteLine(numerator_2 + " " + deminator_2);
            //Упражнение 3.2
            Console.WriteLine("Упражнение 3.2");
            Console.WriteLine("Введите число n:");
            n = int.Parse(Console.ReadLine());
            int member = 0;
            while (member * member <= n)
            {
                member += 1;
            }
            Console.WriteLine(member * member);
            //Упражнение 3.3
            Console.WriteLine("Упражнение 3.3");
            number = 100;
            //оператор с предусловием
            while (number != 79)
            {
                Console.WriteLine(number);
                number -= 1;
            }
            //оператор с постусловием
            number = 100;
            do
            {
                Console.WriteLine(number);
                number -= 1;
            }
            while (number != 79);
            //Упражнение 3.4
            Console.WriteLine("Упражнение 3.4");
            int num = 0;
            for (int i = 0; i <= 5000; i += 39)
            {
                num = i;
                if (5000 - i < 39)
                {
                    break;
                }
            }
            Console.WriteLine(num);
            //Упражнение 3.5
            Console.WriteLine("Упражнение 3.5");
            num = 5;
            for (int i = 1; i < 6; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            num = 1;
            for (int i = 1; i < 6; i++)
            {
                for (int j = 6; j > i; j--)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}