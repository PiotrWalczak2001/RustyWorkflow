using FlowSpell.Common.Managers.Agents;
using FlowSpell.Common.Managers.Channels;
using FlowSpell.Common.Managers.Flows;
using FlowSpell.Common.Types;
using FlowSpell.Configurations;
using FlowSpell.Flows;

namespace FlowSpell.Managers.Flows;

public class FlowManager(IAgentManager agentManager, IChannelManager channelManager) : IFlowManager
{
    private readonly IChannelManager _channelManager = channelManager;

    public Flow Generate(Action<FlowConfiguration>? flowConfiguration = null)
    {
        var flow = Flow.Create(flowConfiguration);
        return flow;
    }

    public async Task<FlowResult> StartAsync(Flow flow)
    {
        var tcs = new TaskCompletionSource<FlowResult>();
        var flowResult = new FlowResult();
        var steps = flow.Use();
       // await _primeChannel.Writer.WriteAsync(steps.Peek());
        return await tcs.Task;
    }
    
    public FlowResult StartInBackground(Flow flow)
    {
        var flowResult = new FlowResult();
        var steps = flow.Use();
        return flowResult;
    }
    
    public FlowResult ScheduleStart(Flow flow)
    {
        var flowResult = new FlowResult();
        var steps = flow.Use();
        return flowResult;
    }
}