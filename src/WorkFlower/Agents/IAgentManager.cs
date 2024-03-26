using WorkFlower.Channels;

namespace WorkFlower.Agents;

public interface IAgentManager
{
    JobAgent GetNewAgent(WorkflowChannel workflowChannel);
}