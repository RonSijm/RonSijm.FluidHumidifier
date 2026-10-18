// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerLoggingEventConfigurationFactory(Action<Humidifier.IoT.LoggingTypes.EventConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IoT.LoggingTypes.EventConfiguration>
{

    protected override Humidifier.IoT.LoggingTypes.EventConfiguration Create()
    {
        var eventConfigurationResult = CreateEventConfiguration();
        factoryAction?.Invoke(eventConfigurationResult);

        return eventConfigurationResult;
    }

    private Humidifier.IoT.LoggingTypes.EventConfiguration CreateEventConfiguration()
    {
        var eventConfigurationResult = new Humidifier.IoT.LoggingTypes.EventConfiguration();

        return eventConfigurationResult;
    }

} // End Of Class

public static class InnerLoggingEventConfigurationFactoryExtensions
{
}
