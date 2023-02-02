using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Account class
            Account myAccount = new Account();
            double currentAmount = 0.0;

            // Save money into the account
            currentAmount = myAccount.setAccountBalance(1000.00);
            Console.WriteLine("current amount: {0}", currentAmount);

            //withdraw
            currentAmount = myAccount.withdrawFromAccount(200.00);
            Console.WriteLine("current amount: {0}", currentAmount);

            //get balance
            currentAmount = myAccount.getAccountBalance();
            Console.WriteLine("current amount: {0}", currentAmount);
            Console.ReadLine();
        }
    }
}
