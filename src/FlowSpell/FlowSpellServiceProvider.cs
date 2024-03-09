using FlowSpell.Manager;
using Microsoft.Extensions.DependencyInjection;

namespace FlowSpell;

public static class FlowSpellServiceProvider
{
    public static IServiceCollection AddFlowSpell(this IServiceCollection services)
    {
        services.AddSingleton<IFlowManager, FlowManager>();
        return services;
    }
}