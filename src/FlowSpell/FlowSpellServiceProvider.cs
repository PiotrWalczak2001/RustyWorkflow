using FlowSpell.Common.Manager;
using FlowSpell.Common.Manager.Agents;
using FlowSpell.Manager;
using FlowSpell.Manager.Agents;
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