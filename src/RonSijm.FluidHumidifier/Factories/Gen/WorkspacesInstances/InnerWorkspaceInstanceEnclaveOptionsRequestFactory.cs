// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkspacesInstances;

public class InnerWorkspaceInstanceEnclaveOptionsRequestFactory(Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.EnclaveOptionsRequest> factoryAction = null) : SubResourceFactory<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.EnclaveOptionsRequest>
{

    protected override Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.EnclaveOptionsRequest Create()
    {
        var enclaveOptionsRequestResult = CreateEnclaveOptionsRequest();
        factoryAction?.Invoke(enclaveOptionsRequestResult);

        return enclaveOptionsRequestResult;
    }

    private Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.EnclaveOptionsRequest CreateEnclaveOptionsRequest()
    {
        var enclaveOptionsRequestResult = new Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.EnclaveOptionsRequest();

        return enclaveOptionsRequestResult;
    }

} // End Of Class

public static class InnerWorkspaceInstanceEnclaveOptionsRequestFactoryExtensions
{
}
