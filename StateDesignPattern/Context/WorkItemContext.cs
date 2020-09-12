using StateDesignPattern.State;

namespace StateDesignPattern.Context
{
    internal class WorkItemContext
    {
        public WorkItemContext()
        {
            CurrentWorkItemState=new OpenWorkItemState();
        }
        public IWorkItemState CurrentWorkItemState;

        public void PrintCurrentState()
        {
             CurrentWorkItemState.PrintCurrentState();
        }
        public void SetNextState()
        {
             CurrentWorkItemState.SetNextState(this);
        }
        public void SetPreviousState()
        {
             CurrentWorkItemState.SetPreviousState(this);
        }

    }
}