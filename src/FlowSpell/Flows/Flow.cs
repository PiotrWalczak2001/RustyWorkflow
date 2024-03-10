using FlowSpell.Common.Flows.Components;
using FlowSpell.Common.Types.Identifiers;
using FlowSpell.Configurations;
using FlowSpell.Flows.Components;

namespace FlowSpell.Flows;

public class Flow
{
    private Flow(FlowConfiguration configuration, Queue<IFlowComponent> components)
    {
        Configuration = configuration;
        Components = components;
    }

    public FlowId Id { get; }
    public FlowConfiguration Configuration { get; private set; }
    private Queue<IFlowComponent> Components { get; }

    internal static Flow Create(Action<FlowConfiguration>? flowConfiguration = null)
    {
        var config = new FlowConfiguration();
        flowConfiguration?.Invoke(config);
        var flow = new Flow(config, new Queue<IFlowComponent>());
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

    public Queue<IFlowComponent> UseFlow()
    {
        Configuration.LifeTime.Use();
        return new Queue<IFlowComponent>(Components);
    }
}