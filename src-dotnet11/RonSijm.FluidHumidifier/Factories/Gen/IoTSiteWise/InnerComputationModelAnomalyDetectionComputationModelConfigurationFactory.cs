// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class InnerComputationModelAnomalyDetectionComputationModelConfigurationFactory(Action<Humidifier.IoTSiteWise.ComputationModelTypes.AnomalyDetectionComputationModelConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IoTSiteWise.ComputationModelTypes.AnomalyDetectionComputationModelConfiguration>
{

    protected override Humidifier.IoTSiteWise.ComputationModelTypes.AnomalyDetectionComputationModelConfiguration Create()
    {
        var anomalyDetectionComputationModelConfigurationResult = CreateAnomalyDetectionComputationModelConfiguration();
        factoryAction?.Invoke(anomalyDetectionComputationModelConfigurationResult);

        return anomalyDetectionComputationModelConfigurationResult;
    }

    private Humidifier.IoTSiteWise.ComputationModelTypes.AnomalyDetectionComputationModelConfiguration CreateAnomalyDetectionComputationModelConfiguration()
    {
        var anomalyDetectionComputationModelConfigurationResult = new Humidifier.IoTSiteWise.ComputationModelTypes.AnomalyDetectionComputationModelConfiguration();

        return anomalyDetectionComputationModelConfigurationResult;
    }

} // End Of Class

public static class InnerComputationModelAnomalyDetectionComputationModelConfigurationFactoryExtensions
{
}
