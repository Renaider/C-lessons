using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Races
{
    class Postman : IGames
    {
        public void PlayGame(string[] teams)
        {
            Console.WriteLine("Игра 'Сильнейший шифр'");
            Console.WriteLine("Участники должны придумать шифр, с помощью которого должны успешно передать сообщение");
            Random random = new Random();
            string winner = teams[random.Next(0, 3)];
            Console.WriteLine("Сильнейшая команда криптологов" + winner);
        }
    }
}
