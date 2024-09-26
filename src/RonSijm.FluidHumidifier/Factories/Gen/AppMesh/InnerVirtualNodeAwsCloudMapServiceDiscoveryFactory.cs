// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerVirtualNodeAwsCloudMapServiceDiscoveryFactory(Action<Humidifier.AppMesh.VirtualNodeTypes.AwsCloudMapServiceDiscovery> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.VirtualNodeTypes.AwsCloudMapServiceDiscovery>
{

    protected override Humidifier.AppMesh.VirtualNodeTypes.AwsCloudMapServiceDiscovery Create()
    {
        var awsCloudMapServiceDiscoveryResult = CreateAwsCloudMapServiceDiscovery();
        factoryAction?.Invoke(awsCloudMapServiceDiscoveryResult);

        return awsCloudMapServiceDiscoveryResult;
    }

    private Humidifier.AppMesh.VirtualNodeTypes.AwsCloudMapServiceDiscovery CreateAwsCloudMapServiceDiscovery()
    {
        var awsCloudMapServiceDiscoveryResult = new Humidifier.AppMesh.VirtualNodeTypes.AwsCloudMapServiceDiscovery();

        return awsCloudMapServiceDiscoveryResult;
    }

} // End Of Class

public static class InnerVirtualNodeAwsCloudMapServiceDiscoveryFactoryExtensions
{
}
