// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalyticsV2;

public class InnerApplicationZeppelinMonitoringConfigurationFactory(Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.ZeppelinMonitoringConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalyticsV2.ApplicationTypes.ZeppelinMonitoringConfiguration>
{

    protected override Humidifier.KinesisAnalyticsV2.ApplicationTypes.ZeppelinMonitoringConfiguration Create()
    {
        var zeppelinMonitoringConfigurationResult = CreateZeppelinMonitoringConfiguration();
        factoryAction?.Invoke(zeppelinMonitoringConfigurationResult);

        return zeppelinMonitoringConfigurationResult;
    }

    private Humidifier.KinesisAnalyticsV2.ApplicationTypes.ZeppelinMonitoringConfiguration CreateZeppelinMonitoringConfiguration()
    {
        var zeppelinMonitoringConfigurationResult = new Humidifier.KinesisAnalyticsV2.ApplicationTypes.ZeppelinMonitoringConfiguration();

        return zeppelinMonitoringConfigurationResult;
    }

} // End Of Class

public static class InnerApplicationZeppelinMonitoringConfigurationFactoryExtensions
{
}
