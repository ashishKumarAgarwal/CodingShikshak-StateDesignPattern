using StateDesignPattern.Context;
using System;

namespace StateDesignPattern.State
{
    internal class InProgressState : IState
    {
        public void PrintCurrentState()
        {
            Console.WriteLine("In Inprogress state");
        }

        public void SetNextState(WorkItemContext workItemContext)
        {
            workItemContext.TransitionState(new QAState());
        }

        public void SetPreviousState(WorkItemContext workItemContext)
        {
            workItemContext.TransitionState(new OpenState());
        }
    }
}