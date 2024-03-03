using FlowR.Core.Stages;
using FlowR.Core.Types;

namespace FlowR.Core.Flows;

public class Flow
{
    private readonly List<Stage> _stages;

    private Flow()
    {
        _stages = new List<Stage>();
    }
    public List<Stage> Stages => _stages;
    public FlowConfiguration Configuration { get; set; }

    public static Flow Initialize(Action<FlowConfiguration>? flowConfiguration = null)
    {
        var flow = new Flow();
        var config = new FlowConfiguration();
        flowConfiguration?.Invoke(config);
        flow.Configuration = config;
        return flow;
    }
    public Flow Stage(Action<Stage> stageConfiguration)
    {
        var stage = new Stage();
        stageConfiguration(stage);
        _stages.Add(stage);
        return this;
    }
    
    public FlowResult Run()
    {
        var mainResult = new FlowResult {IsSuccess = true};
        foreach (var stage in _stages)
        {
            var activityResult = stage.Activity.Execute();
            mainResult.ChildResults.Add(activityResult);
            if (!activityResult.IsSuccess)
            {
                mainResult.IsSuccess = false;
            }
        }

        return mainResult;
    }
}