using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Student : Person
    {
        protected string group;
        protected List<Task> tasks = new List<Task>();

        public string Group { get => group; }


        public Student(string name, int age, string group) : base(name, age)
        {
            this.group = group;
        }

        public Student(string name, int age, string group, List<Task> tasks) : base(name, age)
        {
            this.group = group;
            this.tasks = tasks;
        }

        public void AddTask(string taskName, TaskStatus taskStatus) {
            Task task = new Task(taskName, taskStatus);
            tasks.Add(task);
        }
        public void RemoveTask(int index) {
            tasks.RemoveAt(index);
        }
        public void UpdateTask(int index, TaskStatus taskStatus) {
            tasks[index].Status = taskStatus;
        }
        public void RenderTasks(string prefix = "\t")
        {
            int counter = 1;
            foreach (Task task in tasks)
            {
                Console.WriteLine($"{prefix}{counter}. {task}");
                counter += 1;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public bool Equals(Student other)
        {
            if (other == null)
            {
                return false;
            }
            if (name == other.name && age == other.age)
                return true;
            return false;
        }

        private bool SequenceEqual(List<Task> a, List<Task> b)
        {
            return a.SequenceEqual(b);
        }
    }
}
