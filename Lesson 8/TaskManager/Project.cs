using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    enum Statuses_Project
    {
        Проект = 0,
        Исполнение = 1,
        Закрыт = 2
    }
    class Project
    {
        private string description;
        private string deadline;
        private string initiator;
        private Employee team_lead;
        private List<Task> tasks;
        private Statuses_Project status;
        public Project(string description, string deadline, string initiator, Employee team_lead, List<Task> tasks)
        {
            this.description = description;
            this.deadline = deadline;
            this.initiator = initiator;
            this.team_lead = team_lead;
            this.tasks = tasks;
            status = 0;
        }
        public void ChangeStatus()
        {
            status += 1;
        }
    }
}
