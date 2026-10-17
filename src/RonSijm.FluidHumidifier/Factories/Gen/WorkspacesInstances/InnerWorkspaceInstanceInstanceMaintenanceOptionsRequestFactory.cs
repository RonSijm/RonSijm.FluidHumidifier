// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkspacesInstances;

public class InnerWorkspaceInstanceInstanceMaintenanceOptionsRequestFactory(Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.InstanceMaintenanceOptionsRequest> factoryAction = null) : SubResourceFactory<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.InstanceMaintenanceOptionsRequest>
{

    protected override Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.InstanceMaintenanceOptionsRequest Create()
    {
        var instanceMaintenanceOptionsRequestResult = CreateInstanceMaintenanceOptionsRequest();
        factoryAction?.Invoke(instanceMaintenanceOptionsRequestResult);

        return instanceMaintenanceOptionsRequestResult;
    }

    private Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.InstanceMaintenanceOptionsRequest CreateInstanceMaintenanceOptionsRequest()
    {
        var instanceMaintenanceOptionsRequestResult = new Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.InstanceMaintenanceOptionsRequest();

        return instanceMaintenanceOptionsRequestResult;
    }

} // End Of Class

public static class InnerWorkspaceInstanceInstanceMaintenanceOptionsRequestFactoryExtensions
{
}
