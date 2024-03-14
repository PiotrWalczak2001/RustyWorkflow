using FlowSpell.Common.Types.Identifiers;

namespace FlowSpell.Common.Managers.Agents;

public abstract class AgentBase : IFlowAgent
{
    public AgentId Id { get; set; }
}