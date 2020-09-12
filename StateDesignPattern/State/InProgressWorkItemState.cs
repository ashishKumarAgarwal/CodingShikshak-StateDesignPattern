using System;
using StateDesignPattern.Context;

namespace StateDesignPattern.State
{
    internal class InProgressWorkItemState : IWorkItemState
    {
      
     

        public void PrintCurrentState()
        {
            Console.WriteLine("In Inprogress state");
        }
        public void SetNextState(WorkItemContext workItemContext)
        {
            workItemContext.CurrentWorkItemState=new InQAWorkItemState();
        }

        public void SetPreviousState(WorkItemContext workItemContext)
        {
            workItemContext.CurrentWorkItemState = new OpenWorkItemState();

        }
    }
}