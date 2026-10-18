// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class WorkflowFactory(string resourceName = null, Action<Humidifier.Glue.Workflow> factoryAction = null) : ResourceFactory<Humidifier.Glue.Workflow>(resourceName)
{

    protected override Humidifier.Glue.Workflow Create()
    {
        var workflowResult = CreateWorkflow();
        factoryAction?.Invoke(workflowResult);

        return workflowResult;
    }

    private Humidifier.Glue.Workflow CreateWorkflow()
    {
        var workflowResult = new Humidifier.Glue.Workflow
        {
            GivenName = InputResourceName,
        };

        return workflowResult;
    }

} // End Of Class

public static class WorkflowFactoryExtensions
{
}
