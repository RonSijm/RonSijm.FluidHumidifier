// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerClusterClusterSettingsFactory(Action<Humidifier.ECS.ClusterTypes.ClusterSettings> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ClusterTypes.ClusterSettings>
{

    protected override Humidifier.ECS.ClusterTypes.ClusterSettings Create()
    {
        var clusterSettingsResult = CreateClusterSettings();
        factoryAction?.Invoke(clusterSettingsResult);

        return clusterSettingsResult;
    }

    private Humidifier.ECS.ClusterTypes.ClusterSettings CreateClusterSettings()
    {
        var clusterSettingsResult = new Humidifier.ECS.ClusterTypes.ClusterSettings();

        return clusterSettingsResult;
    }

} // End Of Class

public static class InnerClusterClusterSettingsFactoryExtensions
{
}
