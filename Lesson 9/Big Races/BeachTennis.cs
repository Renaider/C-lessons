using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Races
{
    class BeachTennis : IGames
    {
        public void PlayGame(string[] teams)
        {
            Console.WriteLine("Пляжный теннис проводиться в Австралии");
            Random random = new Random();
            string winner = teams[random.Next(0, 3)];
            Console.WriteLine("Победителем в этой игре становится" + winner);
        }
    }
}
