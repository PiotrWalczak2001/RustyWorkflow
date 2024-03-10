using FlowSpell.Common.Configurations.Behaviors;
using FlowSpell.Configurations.LifeTimes;

namespace FlowSpell.Configurations;

public class FlowConfiguration : BehaviorCollectionBase
{
    public FlowLifeTime LifeTime { get; private set; }

    #region Set_LifeTime

    public FlowConfiguration SetSingleUseLifeTime()
    {
        LifeTime = FlowLifeTime.Create(LifeTimeType.SingleUse, 1);
        return this;
    }

    public FlowConfiguration SetLimitedUseLifeTime(int useAmount)
    {
        LifeTime = FlowLifeTime.Create(LifeTimeType.Limited, useAmount);
        return this;
    }

    public FlowConfiguration SetInfiniteLifeTime()
    {
        LifeTime = FlowLifeTime.Create(LifeTimeType.Infinite);
        return this;
    }

    #endregion
}