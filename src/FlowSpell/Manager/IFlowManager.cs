using FlowSpell.Flows;
using FlowSpell.Flows.Configurations;

namespace FlowSpell.Manager;

public interface IFlowManager
{
    Flow Generate(Action<FlowConfiguration>? flowConfiguration = null);
}