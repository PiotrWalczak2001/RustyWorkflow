namespace WorkFlower.Channels;

public class ChannelManager : IChannelManager
{
    public WorkflowChannel GetNewChannel()
    {
        return WorkflowChannel.Create();
    }
}