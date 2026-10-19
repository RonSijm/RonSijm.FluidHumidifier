// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.HealthLake;

public class InnerFHIRDatastoreAnalyticsConfigurationFactory(Action<Humidifier.HealthLake.FHIRDatastoreTypes.AnalyticsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.HealthLake.FHIRDatastoreTypes.AnalyticsConfiguration>
{

    protected override Humidifier.HealthLake.FHIRDatastoreTypes.AnalyticsConfiguration Create()
    {
        var analyticsConfigurationResult = CreateAnalyticsConfiguration();
        factoryAction?.Invoke(analyticsConfigurationResult);

        return analyticsConfigurationResult;
    }

    private Humidifier.HealthLake.FHIRDatastoreTypes.AnalyticsConfiguration CreateAnalyticsConfiguration()
    {
        var analyticsConfigurationResult = new Humidifier.HealthLake.FHIRDatastoreTypes.AnalyticsConfiguration();

        return analyticsConfigurationResult;
    }

} // End Of Class

public static class InnerFHIRDatastoreAnalyticsConfigurationFactoryExtensions
{
}
