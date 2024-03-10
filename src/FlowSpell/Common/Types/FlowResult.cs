namespace FlowSpell.Common.Types;

public class FlowResult
{
    public object? Data { get; set; }
    public IEnumerable<FlowError> Errors { get; set; }
    public FlowStatus Status { get; }
}