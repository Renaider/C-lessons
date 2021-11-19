using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Races
{
    class Sea : IGames
    {
        public void PlayGame(string[] teams)
        {
            Console.WriteLine("Мы попадаем в глубины Средиземного моря");
            Console.WriteLine("На дне моря спрятаны ракушки с жемчугом и без\nВыиграет та команда, которая соберёт наибольшее количество ракушок с жемчугом");
            Random random = new Random();
            string winner = teams[random.Next(0, 3)];
            Console.WriteLine("Морский лидером становится команда " + winner);
        }
    }
}
