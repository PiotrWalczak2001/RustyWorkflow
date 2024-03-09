using FlowSpell.Flows;
using FlowSpell.Flows.Configurations;

namespace FlowSpell.Manager;

public class FlowManager : IFlowManager
{
    public Flow Generate(Action<FlowConfiguration>? flowConfiguration = null)
    {
        var flow = Flow.Create(flowConfiguration);
        return flow;
    }
}