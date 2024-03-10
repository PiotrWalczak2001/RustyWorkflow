namespace FlowSpell.Common.Configurations.Behaviors;

public abstract class BehaviorCollectionBase : IBehaviorCollection
{
    private readonly List<IBehavior> _behaviors = new();

    public virtual void AddBehavior(IBehavior behavior)
    {
        ArgumentNullException.ThrowIfNull(behavior);
        _behaviors.Add(behavior);
    }

    public virtual bool RemoveBehavior(IBehavior behavior)
    {
        return _behaviors.Remove(behavior);
    }

    public virtual IEnumerable<IBehavior> GetBehaviors()
    {
        return _behaviors.AsReadOnly();
    }
}