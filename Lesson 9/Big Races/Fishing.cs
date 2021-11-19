using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Races
{
    class Fishing : IGames
    {
        public void PlayGame(string[] teams)
        {
            Console.WriteLine("Участники должны за определённое время выловить как можно больше рыбы\nВыигрыш за тем кто наберёт большее количество килограмм");
            Random random = new Random();
            string winner = teams[random.Next(0, 3)];
            Console.WriteLine("Команда победителей - рыболовов становится " + winner);
        }
    }
}
