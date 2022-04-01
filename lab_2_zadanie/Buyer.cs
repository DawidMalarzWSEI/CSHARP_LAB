using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    class Buyer : Person
    {
        protected new List<Product> tasks = new List<Product>();
        public Buyer(string name, int age) : base(name, age) {; }
        public void AddProduct(Product product) {
            tasks.Add(product);
        }
        public void RemoveProduct(int index)
        {
            tasks.RemoveAt(index);
        }
        public override void Print(string prefix = "\t")
        {
            Console.WriteLine(prefix + "Buyer: " + this.Name + " (" + this.Age.ToString() + " y.o.)");

            if (tasks.Count > 0)
            {
                Console.WriteLine($"{prefix}{prefix}-- Products: --");
                foreach (Product product in tasks)
                {
                    Console.Write(prefix);
                    product.Print();
                }
            }
           
        }
    }
}
