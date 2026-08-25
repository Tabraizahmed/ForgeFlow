namespace ForgeFlow.Domain.Workflow
{
    public class WorkFlowStep
    {
        public WorkFlowStepEnum WorkFlowStepName { get; set; }

        public DateTime? StartDateTime { get; init; } = DateTime.Now;

        public DateTime? EndDateTime { get; init; } = DateTime.Now;

        public WorkFlowStepState State { get; set; }
    }
}
