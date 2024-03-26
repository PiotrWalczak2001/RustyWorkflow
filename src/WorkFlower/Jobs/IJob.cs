namespace WorkFlower.Jobs;

public interface IJob
{
    Task ExecuteAsync(CancellationToken cancellationToken);
}