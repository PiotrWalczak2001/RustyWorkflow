using WorkFlower.Jobs;

namespace WorkFlower.Stages;

public class WorkflowStage
{
    public string Name { get; set; }
    public string Description { get; set; }
    public List<IJob> Jobs { get; set; }
}