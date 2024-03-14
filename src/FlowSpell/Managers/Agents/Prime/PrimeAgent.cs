using System.Threading.Channels;
using FlowSpell.Common.Flows.Components;
using FlowSpell.Common.Managers.Agents;

namespace FlowSpell.Managers.Agents.Prime;

public class PrimeAgent : AgentBase
{
    private readonly ChannelReader<IFlowStep> _primeChannelReader;

    public PrimeAgent(ChannelReader<IFlowStep> primeChannelReader)
    {
        _primeChannelReader = primeChannelReader;
    }
    
    public async Task ProcessTasksAsync()
    {
        await foreach (var step in _primeChannelReader.ReadAllAsync())
        {
        }
    }
}