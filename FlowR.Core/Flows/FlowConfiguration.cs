namespace FlowR.Core.Flows;

public class FlowConfiguration
{
    public int? DelayTime { get; private set; }
    // loop properties (condition and number of transitions)
    public FlowConfiguration Loop()
    {
        return this;
    }
    public FlowConfiguration Delay(int delayTime)
    {
        return this;
    }
    public FlowConfiguration RetryBehavior()
    {
        return this;
    }
    public FlowConfiguration RunBehavior()
    {
        return this;
    }
    public FlowConfiguration CompletionBehavior()
    {
        return this;
    }
    public FlowConfiguration LifeTimeBehavior()
    {
        return this;
    }
}