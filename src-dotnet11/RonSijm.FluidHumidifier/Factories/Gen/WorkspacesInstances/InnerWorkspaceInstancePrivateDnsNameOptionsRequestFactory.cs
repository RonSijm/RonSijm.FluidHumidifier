// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkspacesInstances;

public class InnerWorkspaceInstancePrivateDnsNameOptionsRequestFactory(Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.PrivateDnsNameOptionsRequest> factoryAction = null) : SubResourceFactory<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.PrivateDnsNameOptionsRequest>
{

    protected override Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.PrivateDnsNameOptionsRequest Create()
    {
        var privateDnsNameOptionsRequestResult = CreatePrivateDnsNameOptionsRequest();
        factoryAction?.Invoke(privateDnsNameOptionsRequestResult);

        return privateDnsNameOptionsRequestResult;
    }

    private Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.PrivateDnsNameOptionsRequest CreatePrivateDnsNameOptionsRequest()
    {
        var privateDnsNameOptionsRequestResult = new Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.PrivateDnsNameOptionsRequest();

        return privateDnsNameOptionsRequestResult;
    }

} // End Of Class

public static class InnerWorkspaceInstancePrivateDnsNameOptionsRequestFactoryExtensions
{
}
