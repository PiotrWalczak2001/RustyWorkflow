namespace WorkFlower.Workflows;

public interface IWorkflowManager
{
    Task StartWorkflowAsync(Workflow workflow);
}