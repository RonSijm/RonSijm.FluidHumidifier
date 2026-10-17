// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NovaAct;

public class WorkflowRunFactory(string resourceName = null, Action<Humidifier.NovaAct.WorkflowRun> factoryAction = null) : ResourceFactory<Humidifier.NovaAct.WorkflowRun>(resourceName)
{

    protected override Humidifier.NovaAct.WorkflowRun Create()
    {
        var workflowRunResult = CreateWorkflowRun();
        factoryAction?.Invoke(workflowRunResult);

        return workflowRunResult;
    }

    private Humidifier.NovaAct.WorkflowRun CreateWorkflowRun()
    {
        var workflowRunResult = new Humidifier.NovaAct.WorkflowRun
        {
            GivenName = InputResourceName,
        };

        return workflowRunResult;
    }

} // End Of Class

public static class WorkflowRunFactoryExtensions
{
}
