using System;

namespace lab_2_zadanie
{
    class Product : IThing
    {
        private string name;
        public string Name { get => name; }

        public Product(string name)
        {
            this.name = name;
        }

        public virtual void Print(string prefix = "\t")
        {
            Console.Write($"{prefix} {this.name}");
        }
    
        
    }
}
