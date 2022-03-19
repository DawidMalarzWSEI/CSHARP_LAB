using System;

namespace Lab2
{
    class Person : IEquatable<Person>
    {
        protected string name;
        protected int age;

        public string Name { get => name; }
        public int Age { get => age; }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public bool Equals(Person other)
        {
            if (other == null)
            {
                return false;
            }
            if (this.name == other.name && this.age == other.age)
                return true;
            return false;
        }
        public override string ToString()
        {
            return $"Name: {this.name} Age: {this.age}";
        }
    }

}
