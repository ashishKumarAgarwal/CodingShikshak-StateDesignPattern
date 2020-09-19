using System;

namespace StateDesignPattern.State
{
    internal class SilverState : IState
    {
        public void GetBenefits()
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Account is in Silver state.Your Benefits are listed below : \n");
            Console.WriteLine("10% of on groceries with the use of debit card\n");
            Console.WriteLine("15% of on beauty products with the use of debit card\n");
            Console.WriteLine("--------------------------------------------------------\n");
        }
    }
}