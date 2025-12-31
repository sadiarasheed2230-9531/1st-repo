using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            for (i = 9; i >= 1; i--)
            {
                // spaces
                for (k = 1; k <= 9 - i; k++)
                {
                    Console.Write(" ");
                }
                // stars
                for (j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                // new line after each row
                Console.WriteLine();
            }
        }
    }
}
