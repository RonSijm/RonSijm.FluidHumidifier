// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class InnerResolverCachingConfigFactory(Action<Humidifier.AppSync.ResolverTypes.CachingConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppSync.ResolverTypes.CachingConfig>
{

    protected override Humidifier.AppSync.ResolverTypes.CachingConfig Create()
    {
        var cachingConfigResult = CreateCachingConfig();
        factoryAction?.Invoke(cachingConfigResult);

        return cachingConfigResult;
    }

    private Humidifier.AppSync.ResolverTypes.CachingConfig CreateCachingConfig()
    {
        var cachingConfigResult = new Humidifier.AppSync.ResolverTypes.CachingConfig();

        return cachingConfigResult;
    }

} // End Of Class

public static class InnerResolverCachingConfigFactoryExtensions
{
}
