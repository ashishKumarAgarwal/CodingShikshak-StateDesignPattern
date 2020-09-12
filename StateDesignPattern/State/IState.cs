using StateDesignPattern.Context;

namespace StateDesignPattern.State
{
    internal interface IState
    {
        void SetNextState(WorkItemContext workItemContext);

        void PrintCurrentState();

        void SetPreviousState(WorkItemContext workItemContext);
    }
}