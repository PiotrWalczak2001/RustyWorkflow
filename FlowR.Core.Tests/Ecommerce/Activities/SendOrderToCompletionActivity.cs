using FlowR.Core.Stages.Activities;
using FlowR.Core.Types;

namespace FlowR.Core.Tests.Ecommerce.Activities;

public class SendOrderToCompletionActivity : IStageActivity
{
    public FlowResult Execute()
    {
        return new FlowResult
        {
            IsSuccess = true,
        };
    }
}