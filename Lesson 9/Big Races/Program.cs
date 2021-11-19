using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Races
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
        static void Main(string[] args)
        {
            string[] teams = { "Россия", "Франция", " Китай", "Украина" };
            int i = 0;

            while (i < 7)
            {
                i++;
                Console.WriteLine("Введите игру:пляж|море|рыбалка|почтальоны|мышеловка|горка|горные лыжи");
                Console.WriteLine("(Введите 1 для выбора пляжного тенниса |Введите 2 для выбора мышеловки |Введите 3 для выбора море|Введите 4 для выбора рыбалки\n| Введите 5 для выбора почтальона|Введите 6 для выбора горки|Введите 7 для выбора горных лыж");
                int change = GetNumber();
                switch (change)
                {
                    case 1:
                        Console.WriteLine("Начинаем игру <Пляж>");
                        BeachTennis beach = new BeachTennis();
                        beach.PlayGame(teams);
                        break;
                    case 2:
                        Console.WriteLine("Начинаем игру <Мышеловка>");
                        MouseTrap mouse = new MouseTrap();
                        mouse.PlayGame(teams);
                        break;
                    case 3:
                        Console.WriteLine("Начинаем игру <Море>");
                        Sea sea = new Sea();
                        sea.PlayGame(teams);
                        break;
                    case 4:
                        Console.WriteLine("Начинаем игру <Рыбалка>");
                        Fishing fishing = new Fishing();
                        fishing.PlayGame(teams);
                        break;
                    case 5:
                        Console.WriteLine("Начинаем игру почтальоны");
                        Postman postman = new Postman();
                        postman.PlayGame(teams);
                        break;
                    case 6:
                        Console.WriteLine("Начинаем игру горку");
                        Slide slide = new Slide();
                        slide.PlayGame(teams);
                        break;
                    case 7:
                        Console.WriteLine("Начинаем игру горные лыжи");
                        AlpineSkiing ski = new AlpineSkiing();
                        ski.PlayGame(teams);
                        break;
                    default:
                        Console.WriteLine("Вы ввели не ту игру");
                        break;
                }
                Console.WriteLine("");
            }
        }
    }
}
