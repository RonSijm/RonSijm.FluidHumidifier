// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.HealthLake;

public class InnerFHIRDatastorePreloadDataConfigFactory(Action<Humidifier.HealthLake.FHIRDatastoreTypes.PreloadDataConfig> factoryAction = null) : SubResourceFactory<Humidifier.HealthLake.FHIRDatastoreTypes.PreloadDataConfig>
{

    protected override Humidifier.HealthLake.FHIRDatastoreTypes.PreloadDataConfig Create()
    {
        var preloadDataConfigResult = CreatePreloadDataConfig();
        factoryAction?.Invoke(preloadDataConfigResult);

        return preloadDataConfigResult;
    }

    private Humidifier.HealthLake.FHIRDatastoreTypes.PreloadDataConfig CreatePreloadDataConfig()
    {
        var preloadDataConfigResult = new Humidifier.HealthLake.FHIRDatastoreTypes.PreloadDataConfig();

        return preloadDataConfigResult;
    }

} // End Of Class

public static class InnerFHIRDatastorePreloadDataConfigFactoryExtensions
{
}
