using System;
using StateDesignPattern.Context;

namespace StateDesignPattern
{
    class Client
    {
        static void Main(string[] args)
        {
            WorkItemContext workItemContext=new WorkItemContext();

            workItemContext.PrintCurrentState();
            workItemContext.SetNextState();
            workItemContext.PrintCurrentState();
            workItemContext.SetNextState();
            workItemContext.PrintCurrentState(); 
            workItemContext.SetNextState();
            workItemContext.PrintCurrentState();
            workItemContext.SetNextState();
            workItemContext.PrintCurrentState();

            Console.ReadLine();

        }
    }
}
