namespace FlowSpell.Common.Types.Identifiers;

public record FlowId(Guid Value)
{
    public static implicit operator Guid(FlowId id) => id.Value;
    public static implicit operator FlowId?(Guid id) => 
        id.Equals(Guid.Empty) ? null : new FlowId(id);
}