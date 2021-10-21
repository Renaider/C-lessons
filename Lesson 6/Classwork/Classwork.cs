using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Classwork
{
    class Program
    {
        class Person
        {
            private int id;
            static int id_num = 0;
            private string name;
            private string surname;
            private int tech_scores;
            private int cre_scores;
            private int soc_scores;
            public void GetDataFromFile(string[] workers)
            {
                id = int.Parse(workers[id_num].Split()[0]);
                name = workers[id_num].Split()[1];
                surname = workers[id_num].Split()[2];
                tech_scores = int.Parse(workers[id_num].Split()[3]);
                cre_scores = int.Parse(workers[id_num].Split()[4]);
                soc_scores = int.Parse(workers[id_num].Split()[5]);
                id_num += 1;
            }
            public void SetData()
            {
                Console.WriteLine("id: " + id);
                Console.WriteLine("Имя: " + name);
                Console.WriteLine("Фамилия: " + surname);
                Console.WriteLine("Технические навыки: " + tech_scores);
                Console.WriteLine("Творческие навыки: " + cre_scores);
                Console.WriteLine("Социальные навыки: " + soc_scores);
            }
            public int GetTechScore()
            {
                return tech_scores;
            }
            public int GetSocScore()
            {
                return soc_scores;
            }
            public int GetCreScore()
            {
                return cre_scores;
            }
        }
        abstract class Work
        {
            public abstract bool ToFitValue();
            public abstract void GetSettled(int scores);
            public abstract void ViewWorkingConditions();
        }
        class Engineer : Work
        {
            private bool engineer;
            public Engineer()
            {
                
            }
            override public bool ToFitValue()
            {
                return engineer;
            }
            override public void GetSettled(int tech_scores)
            {
                if (tech_scores > 80)
                {
                    Console.WriteLine("Вам хватает навыков, чтобы устроиться на работу инженером\n");
                }
                else
                {
                    Console.WriteLine("Вы гуманитарий(Вам не хватает навыков для работы инженером)\n");
                    engineer = false;
                }
            }
            public override void ViewWorkingConditions()
            {
                Console.WriteLine("Инженер работает с 8.00 до 20.00, 2/2");
            }
        }
        class MarketingSpecialist : Work
        {
            private bool marketing_specialist;
            public MarketingSpecialist()
            {

            }
            override public bool ToFitValue()
            {
                return marketing_specialist;
            }
            override public void GetSettled(int soc_scores)
            {
                if (soc_scores > 80)
                {
                    Console.WriteLine("Вам хватает навыком, чтобы устроиться на работу маркетологом\n");
                }
                else
                {
                    Console.WriteLine("Ваши знания о работе с общественностью и рекламе как у потока ПМ об математическом анализе(Вам не хватает навыков для работы маркетологом)\n");
                    marketing_specialist = false;
                }
            }
            public override void ViewWorkingConditions()
            {
                Console.WriteLine("Маркетолог работает с 8.00 до 16.00, 5/2");
            }
        }
        class Actor : Work
        {
            private bool actor;
            public Actor()
            {

            }
            override public bool ToFitValue()
            {
                return actor;
            }
            override public void GetSettled(int cre_scores)
            {
                if (cre_scores > 80)
                {
                    Console.WriteLine("Вам хватает навыков, чтобы устроиться на работу актёром\n");
                }
                else
                {
                    Console.WriteLine("Если бы вы были актёром, то ваша лучшая роль бы была сказочник(Вам не хватает навыков для работы актёром)\n");
                    actor = false;
                }
            }
            public override void ViewWorkingConditions()
            {
                Console.WriteLine("Актёр работает с 8.00 до 18.00, 5/2");
            }
        }
        static void Main(string[] args)
        {
            string file = @"C:\Users\Kpaq\Desktop\VS Projects\Lesson 6\students.txt";
            string[] workers = File.ReadAllLines(file);
            Person person = new Person();
            person.GetDataFromFile(workers);
            person.SetData();
            Engineer work_1 = new Engineer();
            work_1.ViewWorkingConditions();
            work_1.GetSettled(person.GetTechScore());
            MarketingSpecialist work_2 = new MarketingSpecialist();
            work_2.ViewWorkingConditions();
            work_2.GetSettled(person.GetSocScore());
            Actor work_3 = new Actor();
            work_3.ViewWorkingConditions();
            work_3.GetSettled(person.GetCreScore());
            if (work_1.ToFitValue() | work_2.ToFitValue() | work_3.ToFitValue() == false)
            {
                Console.WriteLine("Вы стали дворником, как предвещал ваш классный руководитель в школе");
            }
        }
    }
}
