using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class A
   {
        public int i = 10; // field
        public void m1()   // method
        {
            Console.WriteLine("Sum of two numbers");
        }
   }
    class B: A
   {
    public int j = 40; // field
    public void m2() // method
     {
        Console.WriteLine(i + j);
     }
   } 
class Program
    {
        static void Main(string[] args)
        {
        B b1 = new B();
        b1.m1();
        b1.m2();
        Console.WriteLine();
        }
    }
}
