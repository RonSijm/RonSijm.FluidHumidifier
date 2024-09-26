// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalyticsV2;

public class InnerApplicationMonitoringConfigurationFactory(Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.MonitoringConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalyticsV2.ApplicationTypes.MonitoringConfiguration>
{

    protected override Humidifier.KinesisAnalyticsV2.ApplicationTypes.MonitoringConfiguration Create()
    {
        var monitoringConfigurationResult = CreateMonitoringConfiguration();
        factoryAction?.Invoke(monitoringConfigurationResult);

        return monitoringConfigurationResult;
    }

    private Humidifier.KinesisAnalyticsV2.ApplicationTypes.MonitoringConfiguration CreateMonitoringConfiguration()
    {
        var monitoringConfigurationResult = new Humidifier.KinesisAnalyticsV2.ApplicationTypes.MonitoringConfiguration();

        return monitoringConfigurationResult;
    }

} // End Of Class

public static class InnerApplicationMonitoringConfigurationFactoryExtensions
{
}
