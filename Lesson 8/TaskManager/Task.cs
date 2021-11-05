using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    enum Statuses_Task
    {
        Назначена = 0,
        Работа = 1,
        Проверка = 2,
        Выполнена = 3
    }
    class Task
    {
        private int id;
        private static int count_id = 0;
        private string details;
        private string deadline;
        private Employee initiator;
        private Employee executor;
        private Statuses_Task status;
        private Report report;
        public Task(string details, string deadline, Employee initiator)
        {
            count_id += 1;
            id = count_id;
            this.details = details;
            this.deadline = deadline;
            this.initiator = initiator;
            status = 0;
        }
        public Task(string details, string deadline, Employee initiator, Employee executor)
        {
            count_id += 1;
            id = count_id;
            this.details = details;
            this.deadline = deadline;
            this.initiator = initiator;
            this.executor = executor;
            status = (Statuses_Task)1;
        }
        public void ChangeStatus()
        {
            status +=1;
        }
        public void GetTask()
        {
            Console.WriteLine("ID задачи" + id);
            Console.WriteLine("Описание задачи: " + details);
            Console.WriteLine("Сроки выполнения задачи: " + deadline);
            Console.WriteLine("Инициатор задачи: " + initiator);
            Console.WriteLine("Исполнителей задачи: " + executor);
        }
    }
}
