// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LookoutMetrics;

public class InnerAnomalyDetectorAnomalyDetectorConfigFactory(Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.AnomalyDetectorConfig> factoryAction = null) : SubResourceFactory<Humidifier.LookoutMetrics.AnomalyDetectorTypes.AnomalyDetectorConfig>
{

    protected override Humidifier.LookoutMetrics.AnomalyDetectorTypes.AnomalyDetectorConfig Create()
    {
        var anomalyDetectorConfigResult = CreateAnomalyDetectorConfig();
        factoryAction?.Invoke(anomalyDetectorConfigResult);

        return anomalyDetectorConfigResult;
    }

    private Humidifier.LookoutMetrics.AnomalyDetectorTypes.AnomalyDetectorConfig CreateAnomalyDetectorConfig()
    {
        var anomalyDetectorConfigResult = new Humidifier.LookoutMetrics.AnomalyDetectorTypes.AnomalyDetectorConfig();

        return anomalyDetectorConfigResult;
    }

} // End Of Class

public static class InnerAnomalyDetectorAnomalyDetectorConfigFactoryExtensions
{
}
