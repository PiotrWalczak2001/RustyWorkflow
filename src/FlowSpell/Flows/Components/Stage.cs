using FlowSpell.Common.Flows.Components;
using FlowSpell.Common.Types.Identifiers;
using FlowSpell.Configurations;

namespace FlowSpell.Flows.Components;

public class Stage : IFlowStep
{
    public StepId Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public IStageActivity Activity { get; set; }
    public StageConfiguration Configuration { get; set; }
    public StepId NextStepId { get; set; }
    public AgentId AgentId { get; set; }

    public Task RunAsync()
    {
        throw new NotImplementedException();
    }

    public static Stage Create()
    {
        throw new NotImplementedException();
    }
}