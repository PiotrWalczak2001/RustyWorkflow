using Microsoft.Extensions.Hosting;
using WorkFlower.Channels;
using WorkFlower.Jobs;

namespace WorkFlower.Agents;

public class JobAgent : BackgroundService
{
    private JobAgent(WorkflowChannel workflowChannel)
    {
        WorkflowChannel = workflowChannel;
    }
    public WorkflowChannel WorkflowChannel { get; set; }

    public static JobAgent Create(WorkflowChannel workflowChannel)
    {
        return new JobAgent(workflowChannel);
    }
    
    protected override async Task ExecuteAsync(CancellationToken cancellationToken)
    {
        await foreach (var job in WorkflowChannel.ReadAllJobsAsync(cancellationToken))
        {
            await ProcessJobAsync(job, cancellationToken);
        }
    }
    
    private async Task ProcessJobAsync(IJob job, CancellationToken cancellationToken)
    {
        await job.ExecuteAsync(cancellationToken);
    }
}