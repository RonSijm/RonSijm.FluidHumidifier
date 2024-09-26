// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LookoutMetrics;

public class InnerAnomalyDetectorCloudwatchConfigFactory(Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.CloudwatchConfig> factoryAction = null) : SubResourceFactory<Humidifier.LookoutMetrics.AnomalyDetectorTypes.CloudwatchConfig>
{

    protected override Humidifier.LookoutMetrics.AnomalyDetectorTypes.CloudwatchConfig Create()
    {
        var cloudwatchConfigResult = CreateCloudwatchConfig();
        factoryAction?.Invoke(cloudwatchConfigResult);

        return cloudwatchConfigResult;
    }

    private Humidifier.LookoutMetrics.AnomalyDetectorTypes.CloudwatchConfig CreateCloudwatchConfig()
    {
        var cloudwatchConfigResult = new Humidifier.LookoutMetrics.AnomalyDetectorTypes.CloudwatchConfig();

        return cloudwatchConfigResult;
    }

} // End Of Class

public static class InnerAnomalyDetectorCloudwatchConfigFactoryExtensions
{
}
