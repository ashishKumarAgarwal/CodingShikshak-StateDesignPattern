using System;

namespace StateDesignPattern.State
{
    internal class PlatinumState : IState
    {
        public void GetBenefits()
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Account is in Platinum state.Your Benefits are listed below :\n");
            Console.WriteLine("20% of on groceries with the use of debit card\n");
            Console.WriteLine("25% of on beauty products with the use of debit card\n");
            Console.WriteLine("--------------------------------------------------------\n");
        }
    }
}