// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class InnerWorkflowTagStepDetailsFactory(Action<Humidifier.Transfer.WorkflowTypes.TagStepDetails> factoryAction = null) : SubResourceFactory<Humidifier.Transfer.WorkflowTypes.TagStepDetails>
{

    protected override Humidifier.Transfer.WorkflowTypes.TagStepDetails Create()
    {
        var tagStepDetailsResult = CreateTagStepDetails();
        factoryAction?.Invoke(tagStepDetailsResult);

        return tagStepDetailsResult;
    }

    private Humidifier.Transfer.WorkflowTypes.TagStepDetails CreateTagStepDetails()
    {
        var tagStepDetailsResult = new Humidifier.Transfer.WorkflowTypes.TagStepDetails();

        return tagStepDetailsResult;
    }

} // End Of Class

public static class InnerWorkflowTagStepDetailsFactoryExtensions
{
}
