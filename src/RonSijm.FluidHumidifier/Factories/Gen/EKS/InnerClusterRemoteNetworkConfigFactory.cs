// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerClusterRemoteNetworkConfigFactory(Action<Humidifier.EKS.ClusterTypes.RemoteNetworkConfig> factoryAction = null) : SubResourceFactory<Humidifier.EKS.ClusterTypes.RemoteNetworkConfig>
{

    protected override Humidifier.EKS.ClusterTypes.RemoteNetworkConfig Create()
    {
        var remoteNetworkConfigResult = CreateRemoteNetworkConfig();
        factoryAction?.Invoke(remoteNetworkConfigResult);

        return remoteNetworkConfigResult;
    }

    private Humidifier.EKS.ClusterTypes.RemoteNetworkConfig CreateRemoteNetworkConfig()
    {
        var remoteNetworkConfigResult = new Humidifier.EKS.ClusterTypes.RemoteNetworkConfig();

        return remoteNetworkConfigResult;
    }

} // End Of Class

public static class InnerClusterRemoteNetworkConfigFactoryExtensions
{
}
