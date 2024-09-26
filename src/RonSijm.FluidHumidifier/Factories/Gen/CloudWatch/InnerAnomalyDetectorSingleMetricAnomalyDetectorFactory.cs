// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerAnomalyDetectorSingleMetricAnomalyDetectorFactory(Action<Humidifier.CloudWatch.AnomalyDetectorTypes.SingleMetricAnomalyDetector> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.AnomalyDetectorTypes.SingleMetricAnomalyDetector>
{

    protected override Humidifier.CloudWatch.AnomalyDetectorTypes.SingleMetricAnomalyDetector Create()
    {
        var singleMetricAnomalyDetectorResult = CreateSingleMetricAnomalyDetector();
        factoryAction?.Invoke(singleMetricAnomalyDetectorResult);

        return singleMetricAnomalyDetectorResult;
    }

    private Humidifier.CloudWatch.AnomalyDetectorTypes.SingleMetricAnomalyDetector CreateSingleMetricAnomalyDetector()
    {
        var singleMetricAnomalyDetectorResult = new Humidifier.CloudWatch.AnomalyDetectorTypes.SingleMetricAnomalyDetector();

        return singleMetricAnomalyDetectorResult;
    }

} // End Of Class

public static class InnerAnomalyDetectorSingleMetricAnomalyDetectorFactoryExtensions
{
}
