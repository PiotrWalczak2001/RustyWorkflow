using FlowSpell.Common.Flows.Components;
using FlowSpell.Configurations;

namespace FlowSpell.Flows.Components;

public class Stage : IFlowComponent
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public IStageActivity Activity { get; set; }
    public StageConfiguration Configuration { get; set; }

    public Task RunAsync()
    {
        throw new NotImplementedException();
    }

    public static Stage Create()
    {
        throw new NotImplementedException();
    }
}