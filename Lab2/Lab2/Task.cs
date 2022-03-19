using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    enum TaskStatus
    {
        Waiting,
        Progress,
        Done,
        Rejected
    }


    class Task
    {
        private string name;
        private TaskStatus status;
        public string Name { get => name; }
        public TaskStatus Status { get => status; set => status = value; }

        public Task(string name, TaskStatus status)
        {
            this.name = name;
            this.status = status;
        }

        public override string ToString()
        {
            return $"Tasks: {name} [{status}]";
        }
    }
}
