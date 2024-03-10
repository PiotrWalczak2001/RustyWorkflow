namespace FlowSpell.Common.Configurations.Behaviors;

public interface IBehaviorCollection
{
    void AddBehavior(IBehavior behavior);
    bool RemoveBehavior(IBehavior behavior);
    IEnumerable<IBehavior> GetBehaviors();
}