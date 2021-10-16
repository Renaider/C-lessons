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
        static void ComparePointsTeams(ref int[] team_1, ref int[] team_2)
        {
            int count_team_1 = 0;
            int count_team_2 = 0;
            for (int i = 0; i < team_1.Length; i++)
            {
                if (team_1[i] == 5)
                {
                    count_team_1 += 1;
                }
                if (team_2[i] == 5)
                {
                    count_team_2 += 1;
                }
            }
            if (count_team_1 == count_team_2)
            {
                Console.WriteLine("Drinks All Round! Free Beers on Bjorg!");
            }
            else
            {
                Console.WriteLine("Ой, Бьорг - пончик! Ни для кого пива!");
            }
        }
        struct Student
        {
            public string name;
            public string surname;
            public int year_birth;
            public string subject;
            public int score;
        }
        static void Swap(List<string> pictures, int i, int exchange, string value1, string value2)
        {
            pictures[i] = value2;
            pictures[exchange] = value1;
        }
        static void AddNewStudent(string file, Dictionary<string, Student> students)
        {
            Console.WriteLine("Впишите данные студента в строчку через пробел в формате\n(фамилия, имя, год рождения, предмет для поступления, количество баллов):");
            string data = Console.ReadLine();
            Student student;
            student.name = data.Split()[0];
            student.surname = data.Split()[1];
            student.year_birth = int.Parse(data.Split()[2]);
            student.subject = data.Split()[3];
            student.score = int.Parse(data.Split()[4]);
            students.Add(student.name + " " + student.surname, student);
            File.AppendAllText(file, Environment.NewLine);
            File.AppendAllText(file, student.name + " " + student.surname + " " + student.year_birth + " " + student.subject + " " + student.score);
            Console.WriteLine("Студент добавлен в список");
        }
        static void DeleteStudent(string file, Dictionary<string, Student> students)
        {
            Console.WriteLine("Введите имя студента для удаления:");
            string student_name = Console.ReadLine().ToLower();
            string tempFile = Path.GetTempFileName();
            using (var sr = new StreamReader(file))
            using (var sw = new StreamWriter(tempFile))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (!line.Equals(students[student_name].surname + " "+ students[student_name].name + " " + students[student_name].year_birth + " " + students[student_name].subject + " " + students[student_name].score))
                        sw.WriteLine(line);
                }
            }
            File.Delete(file);
            File.Move(tempFile, file);
            Console.WriteLine("Студент удалён из списка");
        }
        static void Sort(string file, int quantity_lines, List<int> scores)
        {
            Console.WriteLine("Сортировка по возрастанию:");
            scores.Sort();
            for (int i = 0; i < quantity_lines; i++)
            {
                foreach (string line in File.ReadLines(file))
                {
                    string surname = line.Split()[0];
                    string name = line.Split()[1];
                    int score = int.Parse(line.Split()[4]);
                    if (score == scores[i])
                    {
                        Console.WriteLine(surname + " " + name + " " + score);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //Упражнение 1
            Console.WriteLine("Упражнение 1");
            int[] team_1 = new int[5];
            int[] team_2 = new int[5];
            Console.WriteLine("Введите значения 1-ой команды:");
            for (int i = 0; i < 5; i++)
            {
                if (!Int32.TryParse(Console.ReadLine(), out int point) | !(point <= 9) | !(point >= 0))
                {
                    Console.WriteLine("Неверный формат");
                    i--;
                }
                else
                {
                    team_1[i] = point;
                    Console.WriteLine(team_1[i]);
                }
            }
            Console.WriteLine("Введите значения 2-ой команды:");
            for (int i = 0; i < 5; i++)
            {
                if ((!Int32.TryParse(Console.ReadLine(), out int point)) | !(point <= 9) | !(point >= 0))
                {
                    Console.WriteLine("Неверный формат");
                    i--;
                }
                else
                {
                    team_2[i] = point;
                    Console.WriteLine(team_2[i]);
                }
            }
            ComparePointsTeams(ref team_1, ref team_2);
            //Упражнение 2
            Console.WriteLine("Упражнение 2");
            List<string> pictures = new List<string>()
            {
            @"pictures\pic0.jpg",
            @"pictures\копия.pic0",
            @"pictures\pic1",
            @"pictures\копия.pic1",
            @"pictures\pic2",
            @"pictures\копия.pic2",
            @"pictures\pic3",
            @"pictures\копия.pic3",
            @"pictures\pic4",
            @"pictures\копия.pic4",
            @"pictures\pic5",
            @"pictures\копия.pic5",
            @"pictures\pic6",
            @"pictures\копия.pic6",
            @"pictures\pic7",
            @"pictures\копия.pic7",
            @"pictures\pic8",
            @"pictures\копия.pic8",
            @"pictures\pic9",
            @"pictures\копия.pic9",
            @"pictures\pic10",
            @"pictures\копия.pic10",
            @"pictures\pic11",
            @"pictures\копия.pic11",
            @"pictures\pic12",
            @"pictures\копия.pic12",
            @"pictures\pic13",
            @"pictures\копия.pic13",
            @"pictures\pic14",
            @"pictures\копия.pic14",
            @"pictures\pic15",
            @"pictures\копия.pic15",
            @"pictures\pic16",
            @"pictures\копия.pic16",
            @"pictures\pic17",
            @"pictures\копия.pic17",
            @"pictures\pic18",
            @"pictures\копия.pic18",
            @"pictures\pic19",
            @"pictures\копия.pic19",
            @"pictures\pic20",
            @"pictures\копия.pic20",
            @"pictures\pic21",
            @"pictures\копия.pic21",
            @"pictures\pic22",
            @"pictures\копия.pic22",
            @"pictures\pic23",
            @"pictures\копия.pic23",
            @"pictures\pic24",
            @"pictures\копия.pic24",
            @"pictures\pic25",
            @"pictures\копия.pic25",
            @"pictures\pic26",
            @"pictures\копия.pic26",
            @"pictures\pic27",
            @"pictures\копия.pic27",
            @"pictures\pic28",
            @"pictures\копия.pic28",
            @"pictures\pic29",
            @"pictures\копия.pic29",
            @"pictures\pic30",
            @"pictures\копия.pic30",
            @"pictures\pic31",
            @"pictures\копия.pic31" ,
            };
            Console.WriteLine("Неперемешанный");
            foreach (string item in pictures)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
            for (int i = 0; i < pictures.Count(); i++)
            {
                Random random = new Random();
                int exchange = random.Next(pictures.Count());
                Swap(pictures, i, exchange, pictures[i], pictures[exchange]);
            }
            Console.WriteLine("Перемешанный");
            foreach (string item in pictures)
            {
                Console.WriteLine(item);
            }
            //Упражнение 3
            Console.WriteLine("Упражнение 3");
            string file = ("C:\\Users\\Kpaq\\Desktop\\VS Projects\\Lesson 5\\Students.txt");
            int quantity_lines = 0;
            List<int> scores = new List<int>();
            Dictionary<string, Student> students = new Dictionary<string, Student>();
            foreach (string line in File.ReadLines(file))
            {
                quantity_lines += 1;
                Student student;
                student.surname = line.Split()[0];
                student.name = line.Split()[1];
                student.year_birth = int.Parse(line.Split()[2]);
                student.subject = line.Split()[3];
                student.score = int.Parse(line.Split()[4]);
                scores.Add(int.Parse(line.Split()[4]));
                students.Add(student.surname + " " + student.name, student);
            }
            Console.WriteLine(students["игуменов илья"]);
            Console.WriteLine("Введите 'Новый студент|Удалить|Сортировать':");
            string function = Console.ReadLine().ToLower();
            switch (function)
            {
                case "новый студент":
                    AddNewStudent(file, students);
                    break;
                case "удалить":
                    DeleteStudent(file, students);
                    break;
                case "сортировать":
                    Sort(file, quantity_lines, scores);
                    break;
            }
        }
    }
}
