using FlowR.Core.Types;

namespace FlowR.Core.Stages.Activities;

public interface IStageActivity
{
    FlowResult Execute();
}