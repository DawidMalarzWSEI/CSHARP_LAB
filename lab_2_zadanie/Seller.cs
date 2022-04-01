using System;

namespace lab_2_zadanie
{
    class Seller : Person
    {
        public Seller(string name, int age) : base(name, age) {;}
        public override void Print(string prefix = "\t")
        {
            Console.WriteLine(prefix + "Seller: " + this.Name + " (" + this.Age.ToString() + " y.o.)");
        }
    }
}
