namespace FlowSpell.Flows.Events;

public class FlowEvent
{
    public Guid EventSourceId { get; set; }
    public DateTime EventDate { get; set; }
}