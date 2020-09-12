using StateDesignPattern.Context;
using StateDesignPattern.State;
using System;

namespace StateDesignPattern
{
    internal class Client
    {
        private static void Main(string[] args)
        {
            WorkItemContext workItemContext = new WorkItemContext();
            workItemContext.TransitionState(new InProgressState());
            workItemContext.PrintCurrentState();

            workItemContext.TransitionState(new ClosedState());
            workItemContext.PrintCurrentState();
            workItemContext.TransitionState(new InProgressState());
            workItemContext.PrintCurrentState();
            //workItemContext.SetNextState();
            //workItemContext.PrintCurrentState();
            //workItemContext.SetNextState();
            //workItemContext.PrintCurrentState();
            //workItemContext.SetNextState();
            //workItemContext.PrintCurrentState();

            Console.ReadLine();
        }
    }
}