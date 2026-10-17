// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerDistributionCacheTagConfigFactory(Action<Humidifier.CloudFront.DistributionTypes.CacheTagConfig> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.DistributionTypes.CacheTagConfig>
{

    protected override Humidifier.CloudFront.DistributionTypes.CacheTagConfig Create()
    {
        var cacheTagConfigResult = CreateCacheTagConfig();
        factoryAction?.Invoke(cacheTagConfigResult);

        return cacheTagConfigResult;
    }

    private Humidifier.CloudFront.DistributionTypes.CacheTagConfig CreateCacheTagConfig()
    {
        var cacheTagConfigResult = new Humidifier.CloudFront.DistributionTypes.CacheTagConfig();

        return cacheTagConfigResult;
    }

} // End Of Class

public static class InnerDistributionCacheTagConfigFactoryExtensions
{
}
