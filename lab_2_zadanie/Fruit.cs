using System;


namespace lab_2_zadanie
{
    class Fruit : Product
    {
        private int count;

        public int Count { get => count; }

        public Fruit(string name, int count) : base(name)
        {
            this.count = count;
        }
        public override void Print(string prefix = "\t")
        {
            Console.WriteLine(prefix + this.Name + " (" + this.count + " " + (this.count == 1 ? "fruit" : "fruits") + ")"); 
        }
    }
}
