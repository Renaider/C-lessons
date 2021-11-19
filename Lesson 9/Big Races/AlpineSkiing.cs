using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Races
{
    class AlpineSkiing : IGames
    {
        public void PlayGame(string[] teams)
        {
            Console.WriteLine("Мы попадаем на знаменитые Альпийские горы");
            Console.WriteLine("Перед командой стоит задача пройти все препятствия достигнув финиша");
            Random random = new Random();
            string winner = teams[random.Next(0, 3)];
            Console.WriteLine("Победителем снежных гонок объявляется команда " + winner);
        }
    }
}
