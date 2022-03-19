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


    class Task : IEquatable<Task>
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

        public bool Equals(Task other = null)
        {
            if (other == null)
            {
                return false;
            }
            if (name == other.name && status == other.status)
                return true;
            return false;
        }
        public override string ToString()
        {
            return $"Tasks: {name} [{status}]";
        }
    }
}
