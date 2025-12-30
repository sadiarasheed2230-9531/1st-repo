using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Account
    {
        int accountbalance = 3000;
        public void Setbalance(int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("You cannot pass negative value");
            }
            else
            {
                accountbalance = amount;
            }
        }
        public void GetBalance()
        {
            Console.WriteLine("Your Account Balance Is = " + accountbalance);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account();
            myAccount.Setbalance(-1000);
            myAccount.GetBalance();
        }
    }
}
