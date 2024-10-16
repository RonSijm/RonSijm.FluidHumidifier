// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Amplify;

public class InnerAppCacheConfigFactory(Action<Humidifier.Amplify.AppTypes.CacheConfig> factoryAction = null) : SubResourceFactory<Humidifier.Amplify.AppTypes.CacheConfig>
{

    protected override Humidifier.Amplify.AppTypes.CacheConfig Create()
    {
        var cacheConfigResult = CreateCacheConfig();
        factoryAction?.Invoke(cacheConfigResult);

        return cacheConfigResult;
    }

    private Humidifier.Amplify.AppTypes.CacheConfig CreateCacheConfig()
    {
        var cacheConfigResult = new Humidifier.Amplify.AppTypes.CacheConfig();

        return cacheConfigResult;
    }

} // End Of Class

public static class InnerAppCacheConfigFactoryExtensions
{
}
