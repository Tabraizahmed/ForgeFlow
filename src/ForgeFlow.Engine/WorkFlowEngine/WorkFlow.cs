using ForgeFlow.Domain.Infrastructure;
using ForgeFlow.Domain.Workflow;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ForgeFlow.Engine.WorkFlowEngine
{
    public class WorkFlow : IWorkflow
    {
        public async Task StartWorkflowAsync(string workflowName, CancellationToken cancellationToken)
        {
            var workFlow = new WorkflowDefinition { Name= workflowName, State = WorkFlowState.Start, Step = new WorkFlowStep { WorkFlowStepName = WorkFlowStepEnum.LoadTemplate } };
            
            Console.WriteLine($"Workflow '{workFlow.Name}' started with state '{workFlow.State}' and step '{workFlow.Step.WorkFlowStepName}' started at {workFlow.StartedAt}.");

            
            workFlow.State = WorkFlowState.Running;
            workFlow.Step.WorkFlowStepName = WorkFlowStepEnum.ValidateTemplate;

            Console.WriteLine($"Workflow '{workFlow.Name}' started with state '{workFlow.State}' and step '{workFlow.Step.WorkFlowStepName}' ");


            await Task.Delay(500, cancellationToken); // Simulate some processing time
            // TODO: Implement the actual validation logic here. Something like, ValidateTemplateExecuteAsync(workFlow);

            workFlow.Step.WorkFlowStepName = WorkFlowStepEnum.FillTemplate;
            Console.WriteLine($"Workflow '{workFlow.Name}' started with state '{workFlow.State}' and step '{workFlow.Step.WorkFlowStepName}'.");

            await Task.Delay(500, cancellationToken); // Simulate some processing time
            // TODO: Implement the actual fill template logic here. Something like, FillTemplateExecuteAsync(workFlow);

            workFlow.Step.WorkFlowStepName = WorkFlowStepEnum.ConvertToPDF;
            Console.WriteLine($"Workflow '{workFlow.Name}' started with state '{workFlow.State}' and step '{workFlow.Step.WorkFlowStepName}'.");

            await Task.Delay(500, cancellationToken); // Simulate some processing time
            // TODO: Implement the actual convert to PDF logic here. Something like, ConvertToPDFExecuteAsync(workFlow);

            workFlow.Step.WorkFlowStepName = WorkFlowStepEnum.DownloadTemplate;
            Console.WriteLine($"Workflow '{workFlow.Name}' started with state '{workFlow.State}' and step '{workFlow.Step.WorkFlowStepName}'.");

            await Task.Delay(500, cancellationToken);
            // TODO: Implement the actual download template logic here. Something like, DownloadTemplateExecuteAsync(workFlow);

            workFlow.State = WorkFlowState.Completed;
            workFlow.CompeletedAt = DateTime.Now;
            Console.WriteLine($"Workflow '{workFlow.Name}' completed at {workFlow.CompeletedAt}.");
            Console.WriteLine("==================================================================");


        }
    }
}
