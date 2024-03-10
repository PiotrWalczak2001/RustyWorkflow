using FlowSpell.Configurations;
using FlowSpell.Flows;

namespace FlowSpell.Common.Manager;

public interface IFlowManager
{
    Flow Generate(Action<FlowConfiguration>? flowConfiguration = null);
}