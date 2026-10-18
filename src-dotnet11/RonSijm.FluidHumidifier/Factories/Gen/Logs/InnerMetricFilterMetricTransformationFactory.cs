// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class InnerMetricFilterMetricTransformationFactory(Action<Humidifier.Logs.MetricFilterTypes.MetricTransformation> factoryAction = null) : SubResourceFactory<Humidifier.Logs.MetricFilterTypes.MetricTransformation>
{

    protected override Humidifier.Logs.MetricFilterTypes.MetricTransformation Create()
    {
        var metricTransformationResult = CreateMetricTransformation();
        factoryAction?.Invoke(metricTransformationResult);

        return metricTransformationResult;
    }

    private Humidifier.Logs.MetricFilterTypes.MetricTransformation CreateMetricTransformation()
    {
        var metricTransformationResult = new Humidifier.Logs.MetricFilterTypes.MetricTransformation();

        return metricTransformationResult;
    }

} // End Of Class

public static class InnerMetricFilterMetricTransformationFactoryExtensions
{
}
