using FlowSpell.Common.Types.Identifiers;

namespace FlowSpell.Common.Flows.Steps;

public interface IFlowStep
{
    StepId Id { get; set; }
}