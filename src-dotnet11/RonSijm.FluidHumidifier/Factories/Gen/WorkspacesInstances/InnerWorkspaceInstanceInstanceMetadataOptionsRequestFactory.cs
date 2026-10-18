// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkspacesInstances;

public class InnerWorkspaceInstanceInstanceMetadataOptionsRequestFactory(Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.InstanceMetadataOptionsRequest> factoryAction = null) : SubResourceFactory<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.InstanceMetadataOptionsRequest>
{

    protected override Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.InstanceMetadataOptionsRequest Create()
    {
        var instanceMetadataOptionsRequestResult = CreateInstanceMetadataOptionsRequest();
        factoryAction?.Invoke(instanceMetadataOptionsRequestResult);

        return instanceMetadataOptionsRequestResult;
    }

    private Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.InstanceMetadataOptionsRequest CreateInstanceMetadataOptionsRequest()
    {
        var instanceMetadataOptionsRequestResult = new Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.InstanceMetadataOptionsRequest();

        return instanceMetadataOptionsRequestResult;
    }

} // End Of Class

public static class InnerWorkspaceInstanceInstanceMetadataOptionsRequestFactoryExtensions
{
}
