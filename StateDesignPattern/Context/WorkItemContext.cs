using StateDesignPattern.State;
using System;

namespace StateDesignPattern.Context
{
    internal class WorkItemContext
    {
        private IState _currentWorkItemState;

        public WorkItemContext()
        {
            _currentWorkItemState = new OpenState();
        }

        public void PrintCurrentState()
        {
            _currentWorkItemState.PrintCurrentState();
        }

        public void TransitionState(IState state)
        {
            if (ValidateState(state))
            {
                _currentWorkItemState = state;
            }
            else
            {
                Console.WriteLine("Invalid state selection");
            }
        }

        public void SetNextState()
        {
            _currentWorkItemState.SetNextState(this);
        }

        public void SetPreviousState()
        {
            _currentWorkItemState.SetPreviousState(this);
        }

        private bool ValidateState(IState workItemState)
        {
            var currentStateType = _currentWorkItemState.GetType();
            var nextStateType = workItemState.GetType();

            if (currentStateType == typeof(OpenState))
            {
                return nextStateType == typeof(InProgressState) ||
                       nextStateType == typeof(ClosedState);
            }
            if (currentStateType == typeof(ClosedState))
            {
                return false;
            }
            if (currentStateType == typeof(InProgressState))
            {
                return nextStateType == typeof(OpenState) ||
                       nextStateType == typeof(ClosedState) ||
                       nextStateType == typeof(QAState);
            }
            if (currentStateType == typeof(QAState))
            {
                return nextStateType == typeof(InProgressState) ||
                       nextStateType == typeof(ClosedState);
            }

            return false;
        }
    }
}