using System;
using StateDesignPattern.Context;

namespace StateDesignPattern.State
{
    internal class InQAWorkItemState : IWorkItemState
    {

   
        public void PrintCurrentState()
        {
            Console.WriteLine("In QA state");
        }

        public void SetNextState(WorkItemContext workItemContext)
        {
            workItemContext.CurrentWorkItemState=new ClosedWorkItemState();
        }

        public void SetPreviousState(WorkItemContext workItemContext)
        {
            workItemContext.CurrentWorkItemState = new InProgressWorkItemState();

        }
    }
}