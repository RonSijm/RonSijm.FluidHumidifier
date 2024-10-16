// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class InnerWorkflowDeleteStepDetailsFactory(Action<Humidifier.Transfer.WorkflowTypes.DeleteStepDetails> factoryAction = null) : SubResourceFactory<Humidifier.Transfer.WorkflowTypes.DeleteStepDetails>
{

    protected override Humidifier.Transfer.WorkflowTypes.DeleteStepDetails Create()
    {
        var deleteStepDetailsResult = CreateDeleteStepDetails();
        factoryAction?.Invoke(deleteStepDetailsResult);

        return deleteStepDetailsResult;
    }

    private Humidifier.Transfer.WorkflowTypes.DeleteStepDetails CreateDeleteStepDetails()
    {
        var deleteStepDetailsResult = new Humidifier.Transfer.WorkflowTypes.DeleteStepDetails();

        return deleteStepDetailsResult;
    }

} // End Of Class

public static class InnerWorkflowDeleteStepDetailsFactoryExtensions
{
}
