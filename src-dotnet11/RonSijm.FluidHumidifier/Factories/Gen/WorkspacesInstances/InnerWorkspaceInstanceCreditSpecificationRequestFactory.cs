// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkspacesInstances;

public class InnerWorkspaceInstanceCreditSpecificationRequestFactory(Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CreditSpecificationRequest> factoryAction = null) : SubResourceFactory<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CreditSpecificationRequest>
{

    protected override Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CreditSpecificationRequest Create()
    {
        var creditSpecificationRequestResult = CreateCreditSpecificationRequest();
        factoryAction?.Invoke(creditSpecificationRequestResult);

        return creditSpecificationRequestResult;
    }

    private Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CreditSpecificationRequest CreateCreditSpecificationRequest()
    {
        var creditSpecificationRequestResult = new Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CreditSpecificationRequest();

        return creditSpecificationRequestResult;
    }

} // End Of Class

public static class InnerWorkspaceInstanceCreditSpecificationRequestFactoryExtensions
{
}
