// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class InnerServerWorkflowDetailsFactory(Action<Humidifier.Transfer.ServerTypes.WorkflowDetails> factoryAction = null) : SubResourceFactory<Humidifier.Transfer.ServerTypes.WorkflowDetails>
{

    protected override Humidifier.Transfer.ServerTypes.WorkflowDetails Create()
    {
        var workflowDetailsResult = CreateWorkflowDetails();
        factoryAction?.Invoke(workflowDetailsResult);

        return workflowDetailsResult;
    }

    private Humidifier.Transfer.ServerTypes.WorkflowDetails CreateWorkflowDetails()
    {
        var workflowDetailsResult = new Humidifier.Transfer.ServerTypes.WorkflowDetails();

        return workflowDetailsResult;
    }

} // End Of Class

public static class InnerServerWorkflowDetailsFactoryExtensions
{
}
