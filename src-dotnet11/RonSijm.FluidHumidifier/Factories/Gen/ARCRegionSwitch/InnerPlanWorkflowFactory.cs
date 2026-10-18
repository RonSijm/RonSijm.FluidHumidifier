// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ARCRegionSwitch;

public class InnerPlanWorkflowFactory(Action<Humidifier.ARCRegionSwitch.PlanTypes.Workflow> factoryAction = null) : SubResourceFactory<Humidifier.ARCRegionSwitch.PlanTypes.Workflow>
{

    protected override Humidifier.ARCRegionSwitch.PlanTypes.Workflow Create()
    {
        var workflowResult = CreateWorkflow();
        factoryAction?.Invoke(workflowResult);

        return workflowResult;
    }

    private Humidifier.ARCRegionSwitch.PlanTypes.Workflow CreateWorkflow()
    {
        var workflowResult = new Humidifier.ARCRegionSwitch.PlanTypes.Workflow();

        return workflowResult;
    }

} // End Of Class

public static class InnerPlanWorkflowFactoryExtensions
{
}
