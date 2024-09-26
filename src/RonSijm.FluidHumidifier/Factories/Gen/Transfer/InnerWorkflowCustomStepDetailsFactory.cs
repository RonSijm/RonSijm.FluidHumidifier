// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class InnerWorkflowCustomStepDetailsFactory(Action<Humidifier.Transfer.WorkflowTypes.CustomStepDetails> factoryAction = null) : SubResourceFactory<Humidifier.Transfer.WorkflowTypes.CustomStepDetails>
{

    protected override Humidifier.Transfer.WorkflowTypes.CustomStepDetails Create()
    {
        var customStepDetailsResult = CreateCustomStepDetails();
        factoryAction?.Invoke(customStepDetailsResult);

        return customStepDetailsResult;
    }

    private Humidifier.Transfer.WorkflowTypes.CustomStepDetails CreateCustomStepDetails()
    {
        var customStepDetailsResult = new Humidifier.Transfer.WorkflowTypes.CustomStepDetails();

        return customStepDetailsResult;
    }

} // End Of Class

public static class InnerWorkflowCustomStepDetailsFactoryExtensions
{
}
