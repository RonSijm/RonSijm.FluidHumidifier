// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LookoutMetrics;

public class InnerAnomalyDetectorAppFlowConfigFactory(Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.AppFlowConfig> factoryAction = null) : SubResourceFactory<Humidifier.LookoutMetrics.AnomalyDetectorTypes.AppFlowConfig>
{

    protected override Humidifier.LookoutMetrics.AnomalyDetectorTypes.AppFlowConfig Create()
    {
        var appFlowConfigResult = CreateAppFlowConfig();
        factoryAction?.Invoke(appFlowConfigResult);

        return appFlowConfigResult;
    }

    private Humidifier.LookoutMetrics.AnomalyDetectorTypes.AppFlowConfig CreateAppFlowConfig()
    {
        var appFlowConfigResult = new Humidifier.LookoutMetrics.AnomalyDetectorTypes.AppFlowConfig();

        return appFlowConfigResult;
    }

} // End Of Class

public static class InnerAnomalyDetectorAppFlowConfigFactoryExtensions
{
}
