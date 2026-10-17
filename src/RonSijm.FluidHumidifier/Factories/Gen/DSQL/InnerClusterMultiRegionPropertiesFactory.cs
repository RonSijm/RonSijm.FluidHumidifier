// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DSQL;

public class InnerClusterMultiRegionPropertiesFactory(Action<Humidifier.DSQL.ClusterTypes.MultiRegionProperties> factoryAction = null) : SubResourceFactory<Humidifier.DSQL.ClusterTypes.MultiRegionProperties>
{

    protected override Humidifier.DSQL.ClusterTypes.MultiRegionProperties Create()
    {
        var multiRegionPropertiesResult = CreateMultiRegionProperties();
        factoryAction?.Invoke(multiRegionPropertiesResult);

        return multiRegionPropertiesResult;
    }

    private Humidifier.DSQL.ClusterTypes.MultiRegionProperties CreateMultiRegionProperties()
    {
        var multiRegionPropertiesResult = new Humidifier.DSQL.ClusterTypes.MultiRegionProperties();

        return multiRegionPropertiesResult;
    }

} // End Of Class

public static class InnerClusterMultiRegionPropertiesFactoryExtensions
{
}
