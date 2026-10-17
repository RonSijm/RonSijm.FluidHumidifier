// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationSignals;

public class InnerServiceLevelObjectiveMetricSourceFactory(Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.MetricSource> factoryAction = null) : SubResourceFactory<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.MetricSource>
{

    protected override Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.MetricSource Create()
    {
        var metricSourceResult = CreateMetricSource();
        factoryAction?.Invoke(metricSourceResult);

        return metricSourceResult;
    }

    private Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.MetricSource CreateMetricSource()
    {
        var metricSourceResult = new Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.MetricSource();

        return metricSourceResult;
    }

} // End Of Class

public static class InnerServiceLevelObjectiveMetricSourceFactoryExtensions
{
}
