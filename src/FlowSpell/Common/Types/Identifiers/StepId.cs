namespace FlowSpell.Common.Types.Identifiers;

public record StepId(Guid Value)
{
    public static implicit operator Guid(StepId id) => id.Value;
    public static implicit operator StepId?(Guid id) => 
        id.Equals(Guid.Empty) ? null : new StepId(id);
}