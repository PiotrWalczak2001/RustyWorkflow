using FlowSpell.Common.Flows.Components;
using FlowSpell.Common.Types.Identifiers;
using FlowSpell.Configurations;
using FlowSpell.Flows.Components;

namespace FlowSpell.Flows;

public class Flow
{
    private Flow(FlowId flowId, FlowConfiguration configuration, Queue<IFlowComponent> components, uint version)
    {
        Id = flowId;
        Configuration = configuration;
        Components = components;
        Version = version;
    }

    public FlowId Id { get; }
    public FlowConfiguration Configuration { get; }
    private Queue<IFlowComponent> Components { get; }
    private uint Version { get; }

    internal static Flow Create(Action<FlowConfiguration>? flowConfiguration = null)
    {
        var config = new FlowConfiguration();
        flowConfiguration?.Invoke(config);
        var flow = new Flow(new FlowId(Guid.NewGuid()),config, new Queue<IFlowComponent>(), 0);
        return flow;
    }

    public Flow AddStage(Action<Stage> stageConfiguration)
    {
        var stage = new Stage();
        stageConfiguration(stage);
        Components.Enqueue(stage);
        return this;
    }

    public Flow AddGateway(Action<Gateway> gatewayConfiguration)
    {
        var gateway = Gateway.Create();
        gatewayConfiguration(gateway);
        Components.Enqueue(gateway);
        return this;
    }

    public Queue<IFlowComponent> Use()
    {
        Configuration.LifeTime.Use();
        return new Queue<IFlowComponent>(Components);
    }
}