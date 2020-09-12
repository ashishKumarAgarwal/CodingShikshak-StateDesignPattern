using System;
using System.Collections.Generic;
using System.Text;
using StateDesignPattern.Context;

namespace StateDesignPattern.State
{
    interface IWorkItemState
    {
       void SetNextState(WorkItemContext workItemContext);
       void PrintCurrentState();
       void SetPreviousState(WorkItemContext workItemContext);

    }
}
