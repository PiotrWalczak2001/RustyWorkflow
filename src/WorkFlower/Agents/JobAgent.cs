using Microsoft.Extensions.Hosting;
using WorkFlower.Channels;
using WorkFlower.Jobs;

namespace WorkFlower.Agents;

public class JobAgent : IHostedService
{
    public WorkflowChannel WorkflowChannel { get; set; }
    
    
    public Task StartAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
    
    private async Task ExecuteAsync(CancellationToken cancellationToken)
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