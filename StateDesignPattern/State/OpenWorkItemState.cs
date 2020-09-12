using StateDesignPattern.Context;
using System;

namespace StateDesignPattern.State
{
    internal class OpenWorkItemState : IWorkItemState
    {
      
        public void PrintCurrentState()
        {
            Console.WriteLine("In Open state");
        }

        public void SetNextState(WorkItemContext workItemContext)
        {
            workItemContext.CurrentWorkItemState = new InProgressWorkItemState();
        }

        public void SetPreviousState(WorkItemContext workItemContext)
        {
            Console.WriteLine("This ticket is in open state");

        }
    }
}