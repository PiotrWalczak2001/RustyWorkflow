namespace WorkFlower.Channels;

public interface IChannelManager
{
    WorkflowChannel GetNewChannel();
}