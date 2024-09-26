// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class InnerDatasetResourceConfigurationFactory(Action<Humidifier.IoTAnalytics.DatasetTypes.ResourceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IoTAnalytics.DatasetTypes.ResourceConfiguration>
{

    protected override Humidifier.IoTAnalytics.DatasetTypes.ResourceConfiguration Create()
    {
        var resourceConfigurationResult = CreateResourceConfiguration();
        factoryAction?.Invoke(resourceConfigurationResult);

        return resourceConfigurationResult;
    }

    private Humidifier.IoTAnalytics.DatasetTypes.ResourceConfiguration CreateResourceConfiguration()
    {
        var resourceConfigurationResult = new Humidifier.IoTAnalytics.DatasetTypes.ResourceConfiguration();

        return resourceConfigurationResult;
    }

} // End Of Class

public static class InnerDatasetResourceConfigurationFactoryExtensions
{
}
