using System;

namespace lab_2_zadanie
{
    class Meat : Product
    {
        private double weight;

        public double Weight { get => weight; }

        public Meat(string name, double weight) : base(name)
        {
            this.weight = weight;
        }

        public override void Print(string prefix = "\t")
        {
            Console.WriteLine(prefix + this.Name + " (" + this.weight + " kg)");
        }
    }
}
