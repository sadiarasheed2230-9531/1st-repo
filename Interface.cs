using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multipleInterface
{
    interface Animal
    {
        void animalsound();
    }
    interface Animal1
    {
        void animalsound1();
    }
    class AnimalClass : Animal, Animal1
    {
        public void animalsound()
        {
            Console.WriteLine("Pig says Wee Wee");
        }
        public void animalsound1()
        {
            Console.WriteLine("Lion Roars");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalClass myclass = new AnimalClass();
            myclass.animalsound();
            myclass.animalsound1();
        }
    }
}
