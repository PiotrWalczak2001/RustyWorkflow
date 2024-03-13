using FlowSpell.Common.Manager;
using FlowSpell.Common.Manager.Agents;
using FlowSpell.Common.Manager.Flows;
using FlowSpell.Manager;
using FlowSpell.Manager.Agents;
using FlowSpell.Manager.Flows;
using Microsoft.Extensions.DependencyInjection;

namespace FlowSpell;

public static class FlowSpellServiceProvider
{
    public static IServiceCollection AddFlowSpell(this IServiceCollection services)
    {
        services.AddSingleton<IAgentManager, AgentManager>();
        services.AddSingleton<IFlowManager, FlowManager>();
        return services;
    }
}