using FlowSpell.Common.Types;

namespace FlowSpell.Common.Flows.Steps;

public interface IStageActivity
{
    Task<FlowResult> ExecuteAsync();
}