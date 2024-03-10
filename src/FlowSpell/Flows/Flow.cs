using FlowSpell.Flows.Components.Gateways;
using FlowSpell.Flows.Components.Stages;
using FlowSpell.Flows.Configurations;
using FlowSpell.Flows.Types;
using FlowSpell.Flows.Types.Identifiers;

namespace FlowSpell.Flows;

public class Flow
{
    private Flow()
    {
    }
    public FlowId Id { get; private set; }
    public FlowConfiguration Configuration { get; private set; }
    public FlowStatus Status { get; set; }

    internal static Flow Create(Action<FlowConfiguration>? flowConfiguration = null)
    {
        var flow = new Flow();
        var config = new FlowConfiguration();
        flowConfiguration?.Invoke(config);
        flow.Configuration = config;
        flow.Status = FlowStatus.Inactive;
        return flow;
    }
    public Flow AddStage(Action<Stage> stageConfiguration)
    {
        var stage = new Stage();
        stageConfiguration(stage);
        return this;
    }
    
    public Flow AddGateway(Action<Gateway> gatewayConfiguration)
    {
        var gateway = Gateway.Create();
        gatewayConfiguration(gateway);
        return this;
    }
    
    internal async Task<FlowResult> RunAsync()
    {
        var flowResult = new FlowResult();
        return flowResult;
    }
}