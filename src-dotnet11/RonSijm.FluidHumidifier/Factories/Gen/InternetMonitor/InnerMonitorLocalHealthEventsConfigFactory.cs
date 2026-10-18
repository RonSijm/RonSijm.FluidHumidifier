// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.InternetMonitor;

public class InnerMonitorLocalHealthEventsConfigFactory(Action<Humidifier.InternetMonitor.MonitorTypes.LocalHealthEventsConfig> factoryAction = null) : SubResourceFactory<Humidifier.InternetMonitor.MonitorTypes.LocalHealthEventsConfig>
{

    protected override Humidifier.InternetMonitor.MonitorTypes.LocalHealthEventsConfig Create()
    {
        var localHealthEventsConfigResult = CreateLocalHealthEventsConfig();
        factoryAction?.Invoke(localHealthEventsConfigResult);

        return localHealthEventsConfigResult;
    }

    private Humidifier.InternetMonitor.MonitorTypes.LocalHealthEventsConfig CreateLocalHealthEventsConfig()
    {
        var localHealthEventsConfigResult = new Humidifier.InternetMonitor.MonitorTypes.LocalHealthEventsConfig();

        return localHealthEventsConfigResult;
    }

} // End Of Class

public static class InnerMonitorLocalHealthEventsConfigFactoryExtensions
{
}
