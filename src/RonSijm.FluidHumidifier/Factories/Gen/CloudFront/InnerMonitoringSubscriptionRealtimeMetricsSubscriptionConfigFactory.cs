// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerMonitoringSubscriptionRealtimeMetricsSubscriptionConfigFactory(Action<Humidifier.CloudFront.MonitoringSubscriptionTypes.RealtimeMetricsSubscriptionConfig> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.MonitoringSubscriptionTypes.RealtimeMetricsSubscriptionConfig>
{

    protected override Humidifier.CloudFront.MonitoringSubscriptionTypes.RealtimeMetricsSubscriptionConfig Create()
    {
        var realtimeMetricsSubscriptionConfigResult = CreateRealtimeMetricsSubscriptionConfig();
        factoryAction?.Invoke(realtimeMetricsSubscriptionConfigResult);

        return realtimeMetricsSubscriptionConfigResult;
    }

    private Humidifier.CloudFront.MonitoringSubscriptionTypes.RealtimeMetricsSubscriptionConfig CreateRealtimeMetricsSubscriptionConfig()
    {
        var realtimeMetricsSubscriptionConfigResult = new Humidifier.CloudFront.MonitoringSubscriptionTypes.RealtimeMetricsSubscriptionConfig();

        return realtimeMetricsSubscriptionConfigResult;
    }

} // End Of Class

public static class InnerMonitoringSubscriptionRealtimeMetricsSubscriptionConfigFactoryExtensions
{
}
