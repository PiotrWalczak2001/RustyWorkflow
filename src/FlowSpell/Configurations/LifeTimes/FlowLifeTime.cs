using FlowSpell.Common;
using FlowSpell.Common.Types;
using FlowSpell.Common.Types.Exceptions;

namespace FlowSpell.Configurations.LifeTimes;

public class FlowLifeTime
{
    private FlowLifeTime(LifeTimeType lifeTimeType, int? useAmount = null)
    {
        Type = lifeTimeType;
        UseAmount = useAmount;
    }

    public LifeTimeType Type { get; }
    public int? UseAmount { get; set; }

    internal static FlowLifeTime Create(LifeTimeType lifeTimeType, int? useAmount = null)
    {
        if (lifeTimeType != LifeTimeType.Infinite && useAmount == null) throw new NoDeclarationNumberOfUsesException();
        return new FlowLifeTime(lifeTimeType, useAmount);
    }

    internal FlowError? Use()
    {
        if (!CanUse())
            return new FlowError();

        UseAmount = UseAmount!.Value - 1;
        return null;
    }

    private bool CanUse()
    {
        if (Type == LifeTimeType.Infinite) return true;

        if (UseAmount is null) throw new NoDeclarationNumberOfUsesException();

        return UseAmount.Value > 0;
    }
}