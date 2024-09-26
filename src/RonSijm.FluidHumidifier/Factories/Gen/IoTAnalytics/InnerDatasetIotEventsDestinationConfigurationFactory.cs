// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class InnerDatasetIotEventsDestinationConfigurationFactory(Action<Humidifier.IoTAnalytics.DatasetTypes.IotEventsDestinationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IoTAnalytics.DatasetTypes.IotEventsDestinationConfiguration>
{

    protected override Humidifier.IoTAnalytics.DatasetTypes.IotEventsDestinationConfiguration Create()
    {
        var iotEventsDestinationConfigurationResult = CreateIotEventsDestinationConfiguration();
        factoryAction?.Invoke(iotEventsDestinationConfigurationResult);

        return iotEventsDestinationConfigurationResult;
    }

    private Humidifier.IoTAnalytics.DatasetTypes.IotEventsDestinationConfiguration CreateIotEventsDestinationConfiguration()
    {
        var iotEventsDestinationConfigurationResult = new Humidifier.IoTAnalytics.DatasetTypes.IotEventsDestinationConfiguration();

        return iotEventsDestinationConfigurationResult;
    }

} // End Of Class

public static class InnerDatasetIotEventsDestinationConfigurationFactoryExtensions
{
}
