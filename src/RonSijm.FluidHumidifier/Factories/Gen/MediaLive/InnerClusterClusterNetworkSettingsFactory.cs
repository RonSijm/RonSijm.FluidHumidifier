// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerClusterClusterNetworkSettingsFactory(Action<Humidifier.MediaLive.ClusterTypes.ClusterNetworkSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ClusterTypes.ClusterNetworkSettings>
{

    protected override Humidifier.MediaLive.ClusterTypes.ClusterNetworkSettings Create()
    {
        var clusterNetworkSettingsResult = CreateClusterNetworkSettings();
        factoryAction?.Invoke(clusterNetworkSettingsResult);

        return clusterNetworkSettingsResult;
    }

    private Humidifier.MediaLive.ClusterTypes.ClusterNetworkSettings CreateClusterNetworkSettings()
    {
        var clusterNetworkSettingsResult = new Humidifier.MediaLive.ClusterTypes.ClusterNetworkSettings();

        return clusterNetworkSettingsResult;
    }

} // End Of Class

public static class InnerClusterClusterNetworkSettingsFactoryExtensions
{
}
