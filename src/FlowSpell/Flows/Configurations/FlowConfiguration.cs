using FlowSpell.Behaviors;
using FlowSpell.Flows.Configurations.LifeTimes;

namespace FlowSpell.Flows.Configurations;

public class FlowConfiguration
{
    public FlowConfiguration()
    {
        Behaviors = new List<IBehavior>();
    }
    public FlowLifeTime LifeTime { get; private set; }
    public IEnumerable<IBehavior> Behaviors { get; private set; }
}