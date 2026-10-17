// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class WorkflowExecutionFactory(string resourceName = null, Action<Humidifier.ImageBuilder.WorkflowExecution> factoryAction = null) : ResourceFactory<Humidifier.ImageBuilder.WorkflowExecution>(resourceName)
{

    protected override Humidifier.ImageBuilder.WorkflowExecution Create()
    {
        var workflowExecutionResult = CreateWorkflowExecution();
        factoryAction?.Invoke(workflowExecutionResult);

        return workflowExecutionResult;
    }

    private Humidifier.ImageBuilder.WorkflowExecution CreateWorkflowExecution()
    {
        var workflowExecutionResult = new Humidifier.ImageBuilder.WorkflowExecution
        {
            GivenName = InputResourceName,
        };

        return workflowExecutionResult;
    }

} // End Of Class

public static class WorkflowExecutionFactoryExtensions
{
}
