using ForgeFlow.Domain.Infrastructure;
using ForgeFlow.Domain.Workflow;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ForgeFlow.Engine.WorkFlowEngine
{
    internal class WorkFlow : IWorkflow
    {
        public async Task StartWorkflowAsync(string workflowName)
        {
            var workFlow = new WorkflowDefinition { Name= workflowName, State = WorkFlowState.Start, Step = new WorkFlowStep { WorkFlowStepName = WorkFlowStepEnum.LoadTemplate } };
            
            Debug.WriteLine($"Workflow '{workFlow.Name}' started with state '{workFlow.State}' and step '{workFlow.Step.WorkFlowStepName}'.");

            // Simulate workflow processing
            Thread.Sleep(1000); 

            workFlow.State = WorkFlowState.Running;
            workFlow.Step.WorkFlowStepName = WorkFlowStepEnum.ValidateTemplate;

            // Simulate workflow processing
            Thread.Sleep(1000);

            workFlow.Step.WorkFlowStepName = WorkFlowStepEnum.FillTemplate;



        }
    }
}
