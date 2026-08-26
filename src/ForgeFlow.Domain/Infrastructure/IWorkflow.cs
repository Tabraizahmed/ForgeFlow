using System;
using System.Collections.Generic;
using System.Text;

namespace ForgeFlow.Domain.Infrastructure
{
    public interface IWorkflow
    {
        Task StartWorkflowAsync(string workflowName, CancellationToken cancellationToken);
    }
}
