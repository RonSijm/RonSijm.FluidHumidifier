// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RUM;

public class InnerAppMonitorAppMonitorConfigurationFactory(Action<Humidifier.RUM.AppMonitorTypes.AppMonitorConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.RUM.AppMonitorTypes.AppMonitorConfiguration>
{

    protected override Humidifier.RUM.AppMonitorTypes.AppMonitorConfiguration Create()
    {
        var appMonitorConfigurationResult = CreateAppMonitorConfiguration();
        factoryAction?.Invoke(appMonitorConfigurationResult);

        return appMonitorConfigurationResult;
    }

    private Humidifier.RUM.AppMonitorTypes.AppMonitorConfiguration CreateAppMonitorConfiguration()
    {
        var appMonitorConfigurationResult = new Humidifier.RUM.AppMonitorTypes.AppMonitorConfiguration();

        return appMonitorConfigurationResult;
    }

} // End Of Class

public static class InnerAppMonitorAppMonitorConfigurationFactoryExtensions
{
}
