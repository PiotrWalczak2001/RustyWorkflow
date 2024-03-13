using FlowSpell.Common.Flows.Components;
using FlowSpell.Common.Types.Identifiers;

namespace FlowSpell.Flows.Components;

public class Gateway : IFlowStep
{
    public StepId Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    
    public IEnumerable<Stage> GetNextStages()
    {
        throw new NotImplementedException();
    }

    public static Gateway Create()
    {
        return new Gateway();
    }
}