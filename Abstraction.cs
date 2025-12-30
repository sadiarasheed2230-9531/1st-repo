using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Animal
    {
        public abstract void animalsound();
        public void eat()
        {
            Console.WriteLine("Some animals eat meat");
        }
    }
    class Cat : Animal
    {
        public override void animalsound()
        {
            Console.WriteLine("Cat says: Meow Meow");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat myCat = new Cat();
            myCat.eat();
            myCat.animalsound();
        }
    }
}
