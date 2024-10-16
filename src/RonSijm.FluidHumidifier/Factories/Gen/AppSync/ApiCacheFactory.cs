// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class ApiCacheFactory(string resourceName = null, Action<Humidifier.AppSync.ApiCache> factoryAction = null) : ResourceFactory<Humidifier.AppSync.ApiCache>(resourceName)
{

    protected override Humidifier.AppSync.ApiCache Create()
    {
        var apiCacheResult = CreateApiCache();
        factoryAction?.Invoke(apiCacheResult);

        return apiCacheResult;
    }

    private Humidifier.AppSync.ApiCache CreateApiCache()
    {
        var apiCacheResult = new Humidifier.AppSync.ApiCache
        {
            GivenName = InputResourceName,
        };

        return apiCacheResult;
    }

} // End Of Class

public static class ApiCacheFactoryExtensions
{
}
