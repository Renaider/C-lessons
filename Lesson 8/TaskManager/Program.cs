using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class Program
    {
        public static int GetNumber()
        {
            int number = 0;
            if (int.TryParse(Console.ReadLine(), out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Вы ввели неверный формат");
            }
            return number;
        }
        static void Main(string[] args)
        {
            List<Project> projects = new List<Project>();
            List<Task> tasks = new List<Task>();
            List<Report> reports = new List<Report>();
            List<Employee> workers = new List<Employee>();
            workers.Add(new Employee("Александр"));
            workers.Add(new Employee("Михаил"));
            workers.Add(new Employee("Руслан"));
            workers.Add(new Employee("Адель"));
            workers.Add(new Employee("Илья"));
            workers.Add(new Employee("Алексей"));
            workers.Add(new Employee("Иван"));
            workers.Add(new Employee("Виталий"));
            workers.Add(new Employee("Данил"));
            workers.Add(new Employee("Никита"));

            bool flag_1 = true;
            while (flag_1)
            {
                Console.WriteLine(("Создать проект|Отчёты по задачам|Выход из программы").ToUpper());
                Console.WriteLine(("(Введите '1' для создания проекта; Введите '2' для создания отчёта; Введите '3' для выхода)").ToUpper());
                int menu_1 = GetNumber();
                switch (menu_1)
                {
                    case 1:
                        Console.WriteLine("Напишите описание к проекту:");
                        string description = Console.ReadLine();
                        Console.WriteLine("Задайте сроки для проекта:");
                        string deadline = Console.ReadLine();
                        Console.WriteLine("Введите имя заказчика");
                        string initiator = Console.ReadLine();
                        Console.WriteLine("Выберите тимлида из списка работников(по номеру)");
                        for (int i = 0; i < workers.Count(); i++)
                        {
                            workers[i].GetEmployee();
                        }
                        int team_lead = GetNumber() - 1;
                        bool flag_2 = true;
                        while (flag_2)
                        {
                            Console.WriteLine("Создать задачу по проекту|Закончить создание задач");
                            Console.WriteLine(("(Введите '1' для создания; Введите '2' для выхода)").ToUpper());
                            int menu_2 = GetNumber();
                            switch (menu_2)
                            {
                                case 1:
                                    Console.WriteLine("Описание задачи: ");
                                    string details = Console.ReadLine();
                                    Console.WriteLine("Сроки выполнения задачи: ");
                                    deadline = Console.ReadLine();
                                    Console.WriteLine("Инициатор задачи(Введите номер работника):");
                                    for (int i = 0; i < workers.Count(); i++)
                                    {
                                        workers[i].GetEmployee();
                                    }
                                    int initiator_1 = GetNumber() - 1;
                                    Console.WriteLine("Исполнитель задачи:");
                                    for (int i = 0; i < workers.Count(); i++)
                                    {
                                        workers[i].GetEmployee();
                                    }
                                    int executor = GetNumber() - 1;
                                    bool flag_3 = true;
                                    while (flag_3)
                                    {
                                        Console.WriteLine(("Подтверждение работника|Отклонение работника|Делегирование другому сотруднику|Вывести подробности задачи").ToUpper());
                                        Console.WriteLine(("(Введите '1' для подтверждения; Введите '2' для отклонения; Введите '3' для передачи задачи; Введите '4' для просмотра задачи)").ToUpper());
                                        workers[executor].GetEmployee();
                                        Console.WriteLine("Выберете действие");
                                        int menu_3 = GetNumber();
                                        switch (menu_3)
                                        {
                                            case 1:
                                                Console.WriteLine("Подтверждено!");
                                                tasks.Add(new Task(details, deadline, workers[initiator_1], workers[executor]));
                                                flag_3 = false;
                                                break;
                                            case 2:
                                                Console.WriteLine("Отклонено!");
                                                flag_3 = false;
                                                break;
                                            case 3:
                                                Console.WriteLine("Выберете сотрудника из списка кому передать задачу:");
                                                for (int i = 0; i < workers.Count(); i++)
                                                {
                                                    workers[i].GetEmployee();
                                                }
                                                executor = GetNumber() - 1;
                                                break;
                                            case 4:
                                                Console.WriteLine(details);
                                                Console.WriteLine(deadline);
                                                workers[initiator_1].GetEmployee();
                                                break;
                                            default:
                                                Console.WriteLine("Вы ввели неверный формат");
                                                break;
                                        }
                                    }
                                    break;
                                case 2:
                                    flag_2 = false;
                                    break;
                                default:
                                    Console.WriteLine("Вы ввели неверный формат");
                                    break;
                            }
                        }
                        projects.Add(new Project(description, deadline, initiator, workers[team_lead], tasks));
                        break;
                    case 2:
                        bool flag_4 = true;
                        while (flag_4)
                        {
                            Console.WriteLine(("Написать отчёт|Проверить отчёт|Обратно").ToUpper());
                            Console.WriteLine(("(Введите '1' для создания отчёта; Введите '2' для проверки отчёта; Введите '3' для возращения)").ToUpper());
                            int menu_4 = GetNumber();
                            switch (menu_4)
                            {
                                case 1:
                                    Console.WriteLine("Введите id вашей задачи:");
                                    int id = GetNumber() - 1;
                                    Console.WriteLine("Введите описание отчёта:");
                                    string text = Console.ReadLine();
                                    Console.WriteLine("Введите дату выполнения:");
                                    string date = Console.ReadLine();
                                    Console.WriteLine("Введите номер исполнителя из списка:");
                                    for (int i = 0; i < workers.Count(); i++)
                                    {
                                        workers[i].GetEmployee();
                                    }
                                    int executor_1 = GetNumber() - 1;
                                    reports.Add(new Report(text, date, workers[executor_1]));
                                    break;
                                case 2:
                                    Console.WriteLine("Введите номер отчёта для просмотра:");
                                    int id_1 = GetNumber() - 1;
                                    reports[id_1].GetReport();
                                    workers[id_1].GetEmployee();
                                    bool flag_5 = true;
                                    Console.WriteLine(("Утвердить отчёт|Отклонить отчёт|Обратно").ToUpper());
                                    Console.WriteLine(("(Введите '1' для утвеждения; Введите '2' для отклонения)").ToUpper());
                                    int menu_5 = GetNumber();
                                    while (flag_5)
                                    {
                                        switch (menu_5)
                                        {
                                            case 1:
                                                Console.WriteLine("Утверждено");
                                                break;
                                            case 2:
                                                Console.WriteLine("Отклонено");
                                                break;
                                            case 3:
                                                flag_5 = false;
                                                break;
                                            default:
                                                Console.WriteLine("Вы ввели неверный формат");
                                                break;
                                        }
                                    }
                                    break;
                                case 3:
                                    flag_4 = false;
                                    break;
                                default:
                                    Console.WriteLine("Вы ввели неверный формат");
                                    break;
                            }
                        }
                        break;
                    case 3:
                        flag_1 = false;
                        break;
                    default:
                        Console.WriteLine("Неверный формат");
                        break;
                }
            }
        }
    }
}
