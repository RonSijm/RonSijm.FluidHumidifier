// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Omics;

public class RunCacheFactory(string resourceName = null, Action<Humidifier.Omics.RunCache> factoryAction = null) : ResourceFactory<Humidifier.Omics.RunCache>(resourceName)
{

    protected override Humidifier.Omics.RunCache Create()
    {
        var runCacheResult = CreateRunCache();
        factoryAction?.Invoke(runCacheResult);

        return runCacheResult;
    }

    private Humidifier.Omics.RunCache CreateRunCache()
    {
        var runCacheResult = new Humidifier.Omics.RunCache
        {
            GivenName = InputResourceName,
        };

        return runCacheResult;
    }

} // End Of Class

public static class RunCacheFactoryExtensions
{
}
