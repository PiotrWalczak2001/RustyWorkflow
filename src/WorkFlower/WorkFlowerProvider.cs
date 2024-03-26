using Microsoft.Extensions.DependencyInjection;
using WorkFlower.Agents;
using WorkFlower.Channels;
using WorkFlower.Workflows;

namespace WorkFlower;

public static class WorkFlowerProvider
{
    public static IServiceCollection AddWorkFlower(this IServiceCollection services)
    {
        services.AddSingleton<IAgentManager, AgentManager>();
        services.AddSingleton<IWorkflowManager, WorkflowManager>();
        services.AddSingleton<IChannelManager, ChannelManager>();

        return services;
    }
}