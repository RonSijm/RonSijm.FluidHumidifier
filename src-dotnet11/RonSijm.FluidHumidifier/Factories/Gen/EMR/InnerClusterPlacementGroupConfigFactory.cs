// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerClusterPlacementGroupConfigFactory(Action<Humidifier.EMR.ClusterTypes.PlacementGroupConfig> factoryAction = null) : SubResourceFactory<Humidifier.EMR.ClusterTypes.PlacementGroupConfig>
{

    protected override Humidifier.EMR.ClusterTypes.PlacementGroupConfig Create()
    {
        var placementGroupConfigResult = CreatePlacementGroupConfig();
        factoryAction?.Invoke(placementGroupConfigResult);

        return placementGroupConfigResult;
    }

    private Humidifier.EMR.ClusterTypes.PlacementGroupConfig CreatePlacementGroupConfig()
    {
        var placementGroupConfigResult = new Humidifier.EMR.ClusterTypes.PlacementGroupConfig();

        return placementGroupConfigResult;
    }

} // End Of Class

public static class InnerClusterPlacementGroupConfigFactoryExtensions
{
}
