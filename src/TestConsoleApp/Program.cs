using ForgeFlow.Engine.WorkFlowEngine;

var listOfTasks = new List<Task>();
for (var i = 0; i < 10; i++)
{
    var workflow = new WorkFlow();
    var task = workflow.StartWorkflowAsync($"WorkFlow-{i}", new CancellationToken());
    listOfTasks.Add(task);
}

await Task.WhenAll(listOfTasks);

Console.ReadKey();