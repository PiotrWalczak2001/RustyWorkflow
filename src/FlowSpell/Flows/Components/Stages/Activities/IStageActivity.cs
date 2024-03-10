using FlowSpell.Flows.Types;

namespace FlowSpell.Flows.Components.Stages.Activities;

public interface IStageActivity
{
    Task<FlowResult> ExecuteAsync();
}