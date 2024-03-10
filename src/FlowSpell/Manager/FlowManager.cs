using FlowSpell.Common;
using FlowSpell.Common.Manager;
using FlowSpell.Common.Manager.Agents;
using FlowSpell.Common.Types;
using FlowSpell.Configurations;
using FlowSpell.Flows;

namespace FlowSpell.Manager;

public class FlowManager : IFlowManager
{
    private readonly IAgentManager _agentManager;

    public FlowManager(IAgentManager agentManager)
    {
        _agentManager = agentManager;
    }

    public Flow Generate(Action<FlowConfiguration>? flowConfiguration = null)
    {
        var flow = Flow.Create(flowConfiguration);
        return flow;
    }

    public async Task<FlowResult> RunFlowAsync(Flow flow)
    {
        var flowResult = new FlowResult();
        return flowResult;
    }
}