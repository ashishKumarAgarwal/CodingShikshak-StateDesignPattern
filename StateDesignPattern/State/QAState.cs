using StateDesignPattern.Context;
using System;

namespace StateDesignPattern.State
{
    internal class QAState : IState
    {
        public void PrintCurrentState()
        {
            Console.WriteLine("In QA state");
        }

        public void SetNextState(WorkItemContext workItemContext)
        {
            workItemContext.TransitionState(new ClosedState());
        }

        public void SetPreviousState(WorkItemContext workItemContext)
        {
            workItemContext.TransitionState(new InProgressState());
        }
    }
}