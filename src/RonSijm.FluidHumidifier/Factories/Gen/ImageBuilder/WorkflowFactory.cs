// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class WorkflowFactory(string resourceName = null, Action<Humidifier.ImageBuilder.Workflow> factoryAction = null) : ResourceFactory<Humidifier.ImageBuilder.Workflow>(resourceName)
{

    protected override Humidifier.ImageBuilder.Workflow Create()
    {
        var workflowResult = CreateWorkflow();
        factoryAction?.Invoke(workflowResult);

        return workflowResult;
    }

    private Humidifier.ImageBuilder.Workflow CreateWorkflow()
    {
        var workflowResult = new Humidifier.ImageBuilder.Workflow
        {
            GivenName = InputResourceName,
        };

        return workflowResult;
    }

} // End Of Class

public static class WorkflowFactoryExtensions
{
}
