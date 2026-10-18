// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class InnerEventBusLogConfigFactory(Action<Humidifier.Events.EventBusTypes.LogConfig> factoryAction = null) : SubResourceFactory<Humidifier.Events.EventBusTypes.LogConfig>
{

    protected override Humidifier.Events.EventBusTypes.LogConfig Create()
    {
        var logConfigResult = CreateLogConfig();
        factoryAction?.Invoke(logConfigResult);

        return logConfigResult;
    }

    private Humidifier.Events.EventBusTypes.LogConfig CreateLogConfig()
    {
        var logConfigResult = new Humidifier.Events.EventBusTypes.LogConfig();

        return logConfigResult;
    }

} // End Of Class

public static class InnerEventBusLogConfigFactoryExtensions
{
}
