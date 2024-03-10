using FlowSpell.Flows.Types.Identifiers;

namespace FlowSpell.Flows.Components;

public interface IFlowComponent
{
    ComponentId Id { get; set; }
}