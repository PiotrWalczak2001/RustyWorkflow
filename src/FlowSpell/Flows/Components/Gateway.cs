using FlowSpell.Common.Flows.Components;

namespace FlowSpell.Flows.Components;

public class Gateway : IFlowComponent
{
    public string? Name { get; set; }
    public string? Description { get; set; }

    public Task RunAsync()
    {
        throw new NotImplementedException();
    }

    public static Gateway Create()
    {
        return new Gateway();
    }
}