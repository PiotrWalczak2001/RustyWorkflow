using FlowSpell.Common.Types;

namespace FlowSpell.Common.Flows.Components;

public interface IStageActivity
{
    Task<FlowResult> ExecuteAsync();
}