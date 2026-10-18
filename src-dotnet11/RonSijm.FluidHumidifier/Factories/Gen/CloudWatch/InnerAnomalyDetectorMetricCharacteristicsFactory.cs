// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerAnomalyDetectorMetricCharacteristicsFactory(Action<Humidifier.CloudWatch.AnomalyDetectorTypes.MetricCharacteristics> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.AnomalyDetectorTypes.MetricCharacteristics>
{

    protected override Humidifier.CloudWatch.AnomalyDetectorTypes.MetricCharacteristics Create()
    {
        var metricCharacteristicsResult = CreateMetricCharacteristics();
        factoryAction?.Invoke(metricCharacteristicsResult);

        return metricCharacteristicsResult;
    }

    private Humidifier.CloudWatch.AnomalyDetectorTypes.MetricCharacteristics CreateMetricCharacteristics()
    {
        var metricCharacteristicsResult = new Humidifier.CloudWatch.AnomalyDetectorTypes.MetricCharacteristics();

        return metricCharacteristicsResult;
    }

} // End Of Class

public static class InnerAnomalyDetectorMetricCharacteristicsFactoryExtensions
{
}
