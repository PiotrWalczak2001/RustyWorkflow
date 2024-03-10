using FlowSpell.Flows.Components.Stages.Activities;
using FlowSpell.Flows.Types.Identifiers;

namespace FlowSpell.Flows.Components.Stages;

public class Stage : IFlowComponent
{
    public ComponentId Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public IStageActivity Activity { get; set; }
    
    public Stage Create()
    {
        throw new NotImplementedException();
    }
}