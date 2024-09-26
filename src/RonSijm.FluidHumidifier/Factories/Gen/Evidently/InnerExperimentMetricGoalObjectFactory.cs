// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Evidently;

public class InnerExperimentMetricGoalObjectFactory(Action<Humidifier.Evidently.ExperimentTypes.MetricGoalObject> factoryAction = null) : SubResourceFactory<Humidifier.Evidently.ExperimentTypes.MetricGoalObject>
{

    protected override Humidifier.Evidently.ExperimentTypes.MetricGoalObject Create()
    {
        var metricGoalObjectResult = CreateMetricGoalObject();
        factoryAction?.Invoke(metricGoalObjectResult);

        return metricGoalObjectResult;
    }

    private Humidifier.Evidently.ExperimentTypes.MetricGoalObject CreateMetricGoalObject()
    {
        var metricGoalObjectResult = new Humidifier.Evidently.ExperimentTypes.MetricGoalObject();

        return metricGoalObjectResult;
    }

} // End Of Class

public static class InnerExperimentMetricGoalObjectFactoryExtensions
{
}
