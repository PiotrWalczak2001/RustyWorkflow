using FlowSpell.Flows.Types.Identifiers;

namespace FlowSpell.Flows.Components.Gateways;

public class Gateway : IFlowComponent
{
    public ComponentId Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    
    public static Gateway Create()
    {
        return new Gateway();
    }
}