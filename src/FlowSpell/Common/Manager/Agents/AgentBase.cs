using FlowSpell.Common.Types.Identifiers;

namespace FlowSpell.Common.Manager.Agents;

public abstract class AgentBase : IFlowAgent
{
    public AgentId Id { get; set; }
}