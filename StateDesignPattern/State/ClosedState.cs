using StateDesignPattern.Context;
using System;

namespace StateDesignPattern.State
{
    internal class ClosedState : IState
    {
        public void SetNextState(WorkItemContext workItemContext)
        {
            Console.WriteLine("Invalid Action - Work Item is Closed");
        }

        public void PrintCurrentState()
        {
            Console.WriteLine("In Closed State");
        }

        public void SetPreviousState(WorkItemContext workItemContext)
        {
            Console.WriteLine("Invalid Action -Work Item is Closed, You don't have permission to go to reopen it");
        }
    }
}