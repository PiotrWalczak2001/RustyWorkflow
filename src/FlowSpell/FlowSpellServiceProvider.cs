using FlowSpell.Common.Managers.Agents;
using FlowSpell.Common.Managers.Channels;
using FlowSpell.Common.Managers.Flows;
using FlowSpell.Managers.Agents;
using FlowSpell.Managers.Channels;
using FlowSpell.Managers.Flows;
using Microsoft.Extensions.DependencyInjection;

namespace FlowSpell;

public static class FlowSpellServiceProvider
{
    public static IServiceCollection AddFlowSpell(this IServiceCollection services)
    {
        services.AddSingleton<IAgentManager, AgentManager>();
        services.AddSingleton<IFlowManager, FlowManager>();
        services.AddSingleton<IChannelManager, ChannelManager>();
        return services;
    }
}