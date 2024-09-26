// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class InnerAutomationRuleWorkflowUpdateFactory(Action<Humidifier.SecurityHub.AutomationRuleTypes.WorkflowUpdate> factoryAction = null) : SubResourceFactory<Humidifier.SecurityHub.AutomationRuleTypes.WorkflowUpdate>
{

    protected override Humidifier.SecurityHub.AutomationRuleTypes.WorkflowUpdate Create()
    {
        var workflowUpdateResult = CreateWorkflowUpdate();
        factoryAction?.Invoke(workflowUpdateResult);

        return workflowUpdateResult;
    }

    private Humidifier.SecurityHub.AutomationRuleTypes.WorkflowUpdate CreateWorkflowUpdate()
    {
        var workflowUpdateResult = new Humidifier.SecurityHub.AutomationRuleTypes.WorkflowUpdate();

        return workflowUpdateResult;
    }

} // End Of Class

public static class InnerAutomationRuleWorkflowUpdateFactoryExtensions
{
}
