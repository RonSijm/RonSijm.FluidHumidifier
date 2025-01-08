// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class InnerApiEventLogConfigFactory(Action<Humidifier.AppSync.ApiTypes.EventLogConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppSync.ApiTypes.EventLogConfig>
{

    protected override Humidifier.AppSync.ApiTypes.EventLogConfig Create()
    {
        var eventLogConfigResult = CreateEventLogConfig();
        factoryAction?.Invoke(eventLogConfigResult);

        return eventLogConfigResult;
    }

    private Humidifier.AppSync.ApiTypes.EventLogConfig CreateEventLogConfig()
    {
        var eventLogConfigResult = new Humidifier.AppSync.ApiTypes.EventLogConfig();

        return eventLogConfigResult;
    }

} // End Of Class

public static class InnerApiEventLogConfigFactoryExtensions
{
}
