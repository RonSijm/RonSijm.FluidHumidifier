// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerConnectionWorkflowsMwaaPropertiesInputFactory(Action<Humidifier.DataZone.ConnectionTypes.WorkflowsMwaaPropertiesInput> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.ConnectionTypes.WorkflowsMwaaPropertiesInput>
{

    protected override Humidifier.DataZone.ConnectionTypes.WorkflowsMwaaPropertiesInput Create()
    {
        var workflowsMwaaPropertiesInputResult = CreateWorkflowsMwaaPropertiesInput();
        factoryAction?.Invoke(workflowsMwaaPropertiesInputResult);

        return workflowsMwaaPropertiesInputResult;
    }

    private Humidifier.DataZone.ConnectionTypes.WorkflowsMwaaPropertiesInput CreateWorkflowsMwaaPropertiesInput()
    {
        var workflowsMwaaPropertiesInputResult = new Humidifier.DataZone.ConnectionTypes.WorkflowsMwaaPropertiesInput();

        return workflowsMwaaPropertiesInputResult;
    }

} // End Of Class

public static class InnerConnectionWorkflowsMwaaPropertiesInputFactoryExtensions
{
}
