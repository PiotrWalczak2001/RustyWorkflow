using FlowSpell.Common.Flows.Steps;
using FlowSpell.Common.Types.Identifiers;
using FlowSpell.Configurations;
using FlowSpell.Flows.Steps;

namespace FlowSpell.Flows;

public class Flow
{
    private Flow(FlowId flowId, FlowConfiguration configuration, Queue<IFlowStep>? steps, uint version)
    {
        Id = flowId;
        Configuration = configuration;
        Steps = steps ?? new Queue<IFlowStep>();
        Version = version;
    }

    public FlowId Id { get; }
    public FlowConfiguration Configuration { get; }
    private Queue<IFlowStep> Steps { get; }
    private uint Version { get; }

    internal static Flow Create(Action<FlowConfiguration>? flowConfiguration = null)
    {
        var config = new FlowConfiguration();
        flowConfiguration?.Invoke(config);
        var flow = new Flow(new FlowId(Guid.NewGuid()),config, new Queue<IFlowStep>(), 0);
        return flow;
    }

    public Flow AddStage(Action<Stage> stageConfiguration)
    {
        var stage = new Stage();
        stageConfiguration(stage);
        SetNewStep(stage);
        return this;
    }

    public Flow AddGateway(Action<Gateway> gatewayConfiguration)
    {
        var gateway = Gateway.Create();
        gatewayConfiguration(gateway);
        SetNewStep(gateway);
        return this;
    }

    public Queue<IFlowStep> Use()
    {
        Configuration.LifeTime.Use();
        return new Queue<IFlowStep>(Steps);
    }

    private void SetNewStep(IFlowStep newStep)
    {
        var lastStep = Steps.LastOrDefault();
        if (lastStep is Stage lastStage)
        {
            lastStage.NextStepId = newStep.Id;
        }

        Steps.Enqueue(newStep);
    }
}