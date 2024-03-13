using FlowSpell.Common.Manager.Agents;

namespace FlowSpell.Manager.Agents;

public class AgentManager : IAgentManager
{
    private readonly Dictionary<AgentType, List<IFlowAgent>> _agents;
    public AgentManager()
    {
        _agents = new Dictionary<AgentType, List<IFlowAgent>>()
        {
            { AgentType.Prime , new List<IFlowAgent>()},
            { AgentType.Background , new List<IFlowAgent>()},
            { AgentType.Schedule , new List<IFlowAgent>()},
        };
    }
}