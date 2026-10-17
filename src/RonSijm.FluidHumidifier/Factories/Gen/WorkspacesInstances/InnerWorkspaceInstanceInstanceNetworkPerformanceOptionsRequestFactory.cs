// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkspacesInstances;

public class InnerWorkspaceInstanceInstanceNetworkPerformanceOptionsRequestFactory(Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.InstanceNetworkPerformanceOptionsRequest> factoryAction = null) : SubResourceFactory<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.InstanceNetworkPerformanceOptionsRequest>
{

    protected override Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.InstanceNetworkPerformanceOptionsRequest Create()
    {
        var instanceNetworkPerformanceOptionsRequestResult = CreateInstanceNetworkPerformanceOptionsRequest();
        factoryAction?.Invoke(instanceNetworkPerformanceOptionsRequestResult);

        return instanceNetworkPerformanceOptionsRequestResult;
    }

    private Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.InstanceNetworkPerformanceOptionsRequest CreateInstanceNetworkPerformanceOptionsRequest()
    {
        var instanceNetworkPerformanceOptionsRequestResult = new Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.InstanceNetworkPerformanceOptionsRequest();

        return instanceNetworkPerformanceOptionsRequestResult;
    }

} // End Of Class

public static class InnerWorkspaceInstanceInstanceNetworkPerformanceOptionsRequestFactoryExtensions
{
}
