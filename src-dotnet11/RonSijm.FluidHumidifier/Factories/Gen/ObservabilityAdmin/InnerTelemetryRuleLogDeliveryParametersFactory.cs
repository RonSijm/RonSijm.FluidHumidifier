// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ObservabilityAdmin;

public class InnerTelemetryRuleLogDeliveryParametersFactory(Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.LogDeliveryParameters> factoryAction = null) : SubResourceFactory<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.LogDeliveryParameters>
{

    protected override Humidifier.ObservabilityAdmin.TelemetryRuleTypes.LogDeliveryParameters Create()
    {
        var logDeliveryParametersResult = CreateLogDeliveryParameters();
        factoryAction?.Invoke(logDeliveryParametersResult);

        return logDeliveryParametersResult;
    }

    private Humidifier.ObservabilityAdmin.TelemetryRuleTypes.LogDeliveryParameters CreateLogDeliveryParameters()
    {
        var logDeliveryParametersResult = new Humidifier.ObservabilityAdmin.TelemetryRuleTypes.LogDeliveryParameters();

        return logDeliveryParametersResult;
    }

} // End Of Class

public static class InnerTelemetryRuleLogDeliveryParametersFactoryExtensions
{
}
