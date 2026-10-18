// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerAnomalyDetectorMetricMathAnomalyDetectorFactory(Action<Humidifier.CloudWatch.AnomalyDetectorTypes.MetricMathAnomalyDetector> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.AnomalyDetectorTypes.MetricMathAnomalyDetector>
{

    protected override Humidifier.CloudWatch.AnomalyDetectorTypes.MetricMathAnomalyDetector Create()
    {
        var metricMathAnomalyDetectorResult = CreateMetricMathAnomalyDetector();
        factoryAction?.Invoke(metricMathAnomalyDetectorResult);

        return metricMathAnomalyDetectorResult;
    }

    private Humidifier.CloudWatch.AnomalyDetectorTypes.MetricMathAnomalyDetector CreateMetricMathAnomalyDetector()
    {
        var metricMathAnomalyDetectorResult = new Humidifier.CloudWatch.AnomalyDetectorTypes.MetricMathAnomalyDetector();

        return metricMathAnomalyDetectorResult;
    }

} // End Of Class

public static class InnerAnomalyDetectorMetricMathAnomalyDetectorFactoryExtensions
{
}
