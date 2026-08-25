namespace ForgeFlow.Domain.Workflow
{
    public record WorkflowDefinition()
    {
        public string WorkFlowIdentifier { get; set; } = Guid.NewGuid().ToString();
        public required string Name { get; set; }
        public DateTime StartedAt { get; init; } = DateTime.MinValue;
        public DateTime CompeletedAt { get; init; } = DateTime.MinValue;
        public WorkFlowState State { get; set; }
        public required WorkFlowStep Step { get; set; }
    }
}
