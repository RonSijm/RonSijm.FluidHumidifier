// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationSignals;

public class InnerServiceLevelObjectiveSliMetricFactory(Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SliMetric> factoryAction = null) : SubResourceFactory<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SliMetric>
{

    protected override Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SliMetric Create()
    {
        var sliMetricResult = CreateSliMetric();
        factoryAction?.Invoke(sliMetricResult);

        return sliMetricResult;
    }

    private Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SliMetric CreateSliMetric()
    {
        var sliMetricResult = new Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SliMetric();

        return sliMetricResult;
    }

} // End Of Class

public static class InnerServiceLevelObjectiveSliMetricFactoryExtensions
{
}
