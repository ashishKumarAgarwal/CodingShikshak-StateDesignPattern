using StateDesignPattern.Context;
using System;

namespace StateDesignPattern.State
{
    internal class OpenState : IState
    {
        public void PrintCurrentState()
        {
            Console.WriteLine("In Open state");
        }

        public void SetNextState(WorkItemContext workItemContext)
        {
            workItemContext.TransitionState(new InProgressState());
        }

        public void SetPreviousState(WorkItemContext workItemContext)
        {
            Console.WriteLine("This ticket is in open state");
        }
    }
}