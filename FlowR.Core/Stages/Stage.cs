using FlowR.Core.Stages.Activities;

namespace FlowR.Core.Stages;

public class Stage
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public int Index { get; set; }
    public IStageActivity Activity { get; set; }
    
    // flow configuration for stages
}