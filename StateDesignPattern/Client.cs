using System;
using StateDesignPattern.Context;

namespace StateDesignPattern
{
    internal class Client
    {
        private static void Main()
        {
            Account account = new Account();
            account.Deposit(1000);
            account.GetCurrentBenefits();

            account.Deposit(10000.0);
            account.GetCurrentBenefits();

            account.Withdraw(4000);
            account.GetCurrentBenefits();

            Console.ReadKey();
        }
    }
}