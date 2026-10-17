// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerConfigurationSetOverallConfidenceThresholdFactory(Action<Humidifier.SES.ConfigurationSetTypes.OverallConfidenceThreshold> factoryAction = null) : SubResourceFactory<Humidifier.SES.ConfigurationSetTypes.OverallConfidenceThreshold>
{

    protected override Humidifier.SES.ConfigurationSetTypes.OverallConfidenceThreshold Create()
    {
        var overallConfidenceThresholdResult = CreateOverallConfidenceThreshold();
        factoryAction?.Invoke(overallConfidenceThresholdResult);

        return overallConfidenceThresholdResult;
    }

    private Humidifier.SES.ConfigurationSetTypes.OverallConfidenceThreshold CreateOverallConfidenceThreshold()
    {
        var overallConfidenceThresholdResult = new Humidifier.SES.ConfigurationSetTypes.OverallConfidenceThreshold();

        return overallConfidenceThresholdResult;
    }

} // End Of Class

public static class InnerConfigurationSetOverallConfidenceThresholdFactoryExtensions
{
}
