namespace FlowR.Core.Types;

public class FlowResult
{
    public FlowResult()
    {
        ChildResults = new List<FlowResult>();
    }
    public object Data { get; set; }
    public bool IsSuccess { get; set; }
    
    public ICollection<FlowResult> ChildResults { get; set; }
}