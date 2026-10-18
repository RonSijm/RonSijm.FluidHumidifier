// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class WorkflowStepExecutionFactory(string resourceName = null, Action<Humidifier.ImageBuilder.WorkflowStepExecution> factoryAction = null) : ResourceFactory<Humidifier.ImageBuilder.WorkflowStepExecution>(resourceName)
{

    protected override Humidifier.ImageBuilder.WorkflowStepExecution Create()
    {
        var workflowStepExecutionResult = CreateWorkflowStepExecution();
        factoryAction?.Invoke(workflowStepExecutionResult);

        return workflowStepExecutionResult;
    }

    private Humidifier.ImageBuilder.WorkflowStepExecution CreateWorkflowStepExecution()
    {
        var workflowStepExecutionResult = new Humidifier.ImageBuilder.WorkflowStepExecution
        {
            GivenName = InputResourceName,
        };

        return workflowStepExecutionResult;
    }

} // End Of Class

public static class WorkflowStepExecutionFactoryExtensions
{
}
