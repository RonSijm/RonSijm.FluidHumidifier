// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElastiCache;

public class InnerGlobalReplicationGroupRegionalConfigurationFactory(Action<Humidifier.ElastiCache.GlobalReplicationGroupTypes.RegionalConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ElastiCache.GlobalReplicationGroupTypes.RegionalConfiguration>
{

    protected override Humidifier.ElastiCache.GlobalReplicationGroupTypes.RegionalConfiguration Create()
    {
        var regionalConfigurationResult = CreateRegionalConfiguration();
        factoryAction?.Invoke(regionalConfigurationResult);

        return regionalConfigurationResult;
    }

    private Humidifier.ElastiCache.GlobalReplicationGroupTypes.RegionalConfiguration CreateRegionalConfiguration()
    {
        var regionalConfigurationResult = new Humidifier.ElastiCache.GlobalReplicationGroupTypes.RegionalConfiguration();

        return regionalConfigurationResult;
    }

} // End Of Class

public static class InnerGlobalReplicationGroupRegionalConfigurationFactoryExtensions
{
}
