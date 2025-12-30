using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Animal is Eating");
        }
    }
    class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Dog is Eating");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Eat();
            Dog dog = new Dog();
            dog.Eat();
            Console.ReadLine();
        }
    }
}
