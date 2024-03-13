namespace FlowSpell.Common.Types.Identifiers;

public record AgentId(Guid Value)
{
    public static implicit operator Guid(AgentId id) => id.Value;
    public static implicit operator AgentId?(Guid id) => 
        id.Equals(Guid.Empty) ? null : new AgentId(id);
}