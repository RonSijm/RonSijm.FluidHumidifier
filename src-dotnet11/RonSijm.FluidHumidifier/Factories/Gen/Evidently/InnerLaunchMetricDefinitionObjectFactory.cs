// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Evidently;

public class InnerLaunchMetricDefinitionObjectFactory(Action<Humidifier.Evidently.LaunchTypes.MetricDefinitionObject> factoryAction = null) : SubResourceFactory<Humidifier.Evidently.LaunchTypes.MetricDefinitionObject>
{

    protected override Humidifier.Evidently.LaunchTypes.MetricDefinitionObject Create()
    {
        var metricDefinitionObjectResult = CreateMetricDefinitionObject();
        factoryAction?.Invoke(metricDefinitionObjectResult);

        return metricDefinitionObjectResult;
    }

    private Humidifier.Evidently.LaunchTypes.MetricDefinitionObject CreateMetricDefinitionObject()
    {
        var metricDefinitionObjectResult = new Humidifier.Evidently.LaunchTypes.MetricDefinitionObject();

        return metricDefinitionObjectResult;
    }

} // End Of Class

public static class InnerLaunchMetricDefinitionObjectFactoryExtensions
{
}
