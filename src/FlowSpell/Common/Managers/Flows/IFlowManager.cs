using FlowSpell.Configurations;
using FlowSpell.Flows;

namespace FlowSpell.Common.Managers.Flows;

public interface IFlowManager
{
    Flow Generate(Action<FlowConfiguration>? flowConfiguration = null);
}