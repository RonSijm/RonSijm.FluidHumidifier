// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationSignals;

public class InnerServiceLevelObjectiveMonitoredRequestCountMetricFactory(Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.MonitoredRequestCountMetric> factoryAction = null) : SubResourceFactory<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.MonitoredRequestCountMetric>
{

    protected override Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.MonitoredRequestCountMetric Create()
    {
        var monitoredRequestCountMetricResult = CreateMonitoredRequestCountMetric();
        factoryAction?.Invoke(monitoredRequestCountMetricResult);

        return monitoredRequestCountMetricResult;
    }

    private Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.MonitoredRequestCountMetric CreateMonitoredRequestCountMetric()
    {
        var monitoredRequestCountMetricResult = new Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.MonitoredRequestCountMetric();

        return monitoredRequestCountMetricResult;
    }

} // End Of Class

public static class InnerServiceLevelObjectiveMonitoredRequestCountMetricFactoryExtensions
{
}
