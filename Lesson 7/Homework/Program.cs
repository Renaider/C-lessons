using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework
{
    class Program
    {
        static void GetMails(ref string emails)
        {
            emails = emails.Split('#').Last();
        }
        static void Main(string[] args)
        {
            //Упражнение 8.1
            Console.WriteLine("Упражнение 8.1");
            string[] mails_names = File.ReadAllLines("mails.txt");
            for (int i = 0; i < mails_names.Length; i++)
            {
                Console.WriteLine(mails_names[i]);
                GetMails(ref mails_names[i]);
            }
            File.WriteAllLines("mails.txt", mails_names);
            Console.WriteLine(File.ReadAllText("mails.txt"));
            //Упражнение 8.2
            Console.WriteLine("Упражнение 8.2");
            List<Song> songs = new List<Song>();
            songs.Add(new Song("Москва Любит...", "Скриптонит", null));
            songs.Add(new Song("Компромисс", "БИ-2", songs[0]));
            songs.Add(new Song("Шуг", "Скриптонит", songs[1]));
            songs.Add(new Song("Привычка", "Скриптонит", songs[2]));
            foreach (Song line in songs)
            {
                Console.WriteLine(line.Title());
            }
            Console.WriteLine(songs[0].Equals(songs[1]));
        }
    }
}
