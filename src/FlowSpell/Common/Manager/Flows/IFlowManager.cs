using FlowSpell.Configurations;
using FlowSpell.Flows;

namespace FlowSpell.Common.Manager.Flows;

public interface IFlowManager
{
    Flow Generate(Action<FlowConfiguration>? flowConfiguration = null);
}