using System.Runtime.CompilerServices;
using System.Threading.Channels;
using WorkFlower.Jobs;

namespace WorkFlower.Channels;

public class WorkflowChannel
{
    private WorkflowChannel()
    {
        JobChannel = Channel.CreateUnbounded<IJob>();
    }
    public Channel<IJob> JobChannel { get; private set; }
    public static WorkflowChannel Create()
    {
        return new WorkflowChannel();
    }
    
    public async Task AddJobAsync(IJob job, CancellationToken cancellationToken = default)
    {
        await JobChannel.Writer.WriteAsync(job, cancellationToken);
    }

    public async IAsyncEnumerable<IJob> ReadAllJobsAsync([EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        await foreach (var job in JobChannel.Reader.ReadAllAsync(cancellationToken))
        {
            yield return job;
        }
    }
}