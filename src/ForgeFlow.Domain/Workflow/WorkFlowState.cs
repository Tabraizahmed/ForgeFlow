using System;
using System.Collections.Generic;
using System.Text;

namespace ForgeFlow.Domain.Workflow
{
    public enum WorkFlowState
    {
      Start,
      Stopped,
      Running,
      InProcess,
      Completed
    }
}
