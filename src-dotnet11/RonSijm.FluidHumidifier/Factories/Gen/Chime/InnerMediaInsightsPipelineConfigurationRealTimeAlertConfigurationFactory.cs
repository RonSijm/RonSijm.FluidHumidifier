// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaInsightsPipelineConfigurationRealTimeAlertConfigurationFactory(Action<Humidifier.Chime.MediaInsightsPipelineConfigurationTypes.RealTimeAlertConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaInsightsPipelineConfigurationTypes.RealTimeAlertConfiguration>
{

    protected override Humidifier.Chime.MediaInsightsPipelineConfigurationTypes.RealTimeAlertConfiguration Create()
    {
        var realTimeAlertConfigurationResult = CreateRealTimeAlertConfiguration();
        factoryAction?.Invoke(realTimeAlertConfigurationResult);

        return realTimeAlertConfigurationResult;
    }

    private Humidifier.Chime.MediaInsightsPipelineConfigurationTypes.RealTimeAlertConfiguration CreateRealTimeAlertConfiguration()
    {
        var realTimeAlertConfigurationResult = new Humidifier.Chime.MediaInsightsPipelineConfigurationTypes.RealTimeAlertConfiguration();

        return realTimeAlertConfigurationResult;
    }

} // End Of Class

public static class InnerMediaInsightsPipelineConfigurationRealTimeAlertConfigurationFactoryExtensions
{
}
