using WorkFlower.Agents;
using WorkFlower.Channels;

namespace WorkFlower.Workflows;

public class WorkflowManager(IChannelManager channelManager, IAgentManager agentManager) : IWorkflowManager
{
    public Task StartWorkflowAsync(Workflow workflow)
    {
        var channel = channelManager.GetNewChannel();
        var agent = agentManager.GetNewAgent(channel);
        
        throw new NotImplementedException();
    }
}