using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Races
{
    class MouseTrap : IGames
    {
        public void PlayGame(string[] array)
        {
            Console.WriteLine("Название игры 'Мышка в ловушке'");
            Console.WriteLine("Участникам необходимо с помощью сыра завести мышей на ловушку\nКоманда, которая первая заведёт мышь в ловушку становится победителем");
            Random random = new Random();
            string winner = array[random.Next(0, 3)];
            Console.WriteLine("Победителем становится " + winner);
        }
    }
}
