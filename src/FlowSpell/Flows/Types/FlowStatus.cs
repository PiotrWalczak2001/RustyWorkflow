namespace FlowSpell.Flows.Types;

public enum FlowStatus
{
    Inactive = 0, // occurs when the flow has not yet been started
    InProgress = 1, // occurs when the flow has not yet been completed but already stared
    CompletedSuccessfully = 2, // occurs when flow is completed without errors
    CompletedWithErrors = 3, // occurs when flow is completed with errors
    Paused = 4, // occurs when the flow is stopped with the possibility of return
    Cancelled = 5, // occurs when the flow is interrupted without any possibility of return
}