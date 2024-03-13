using FlowSpell.Common.Types.Identifiers;

namespace FlowSpell.Common.Flows.Components;

public interface IFlowStep
{
    StepId Id { get; set; }
}