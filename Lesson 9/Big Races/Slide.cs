using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Races
{
    class Slide : IGames
    {
        public void PlayGame(string[] teams)
        {
            Console.WriteLine("Название игры 'Скользкая горка'");
            Console.WriteLine("Участники должны преодолеть полосу препятствий на склоне");
            Random random = new Random();
            string winner = teams[random.Next(0, 3)];
            Console.WriteLine("Командой - победителем становится " + winner);
        }
    }
}
