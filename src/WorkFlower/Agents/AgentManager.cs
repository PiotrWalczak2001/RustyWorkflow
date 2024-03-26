using WorkFlower.Channels;

namespace WorkFlower.Agents;

public class AgentManager : IAgentManager
{
    public JobAgent GetNewAgent(WorkflowChannel workflowChannel)
    {
        return JobAgent.Create(workflowChannel);
    }
}