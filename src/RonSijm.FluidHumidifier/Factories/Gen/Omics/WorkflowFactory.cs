// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Omics;

public class WorkflowFactory(string resourceName = null, Action<Humidifier.Omics.Workflow> factoryAction = null) : ResourceFactory<Humidifier.Omics.Workflow>(resourceName)
{

    protected override Humidifier.Omics.Workflow Create()
    {
        var workflowResult = CreateWorkflow();
        factoryAction?.Invoke(workflowResult);

        return workflowResult;
    }

    private Humidifier.Omics.Workflow CreateWorkflow()
    {
        var workflowResult = new Humidifier.Omics.Workflow
        {
            GivenName = InputResourceName,
        };

        return workflowResult;
    }

} // End Of Class

public static class WorkflowFactoryExtensions
{
}
