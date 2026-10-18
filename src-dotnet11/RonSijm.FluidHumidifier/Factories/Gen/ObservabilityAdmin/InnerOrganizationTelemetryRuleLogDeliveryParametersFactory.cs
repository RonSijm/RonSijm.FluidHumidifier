// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ObservabilityAdmin;

public class InnerOrganizationTelemetryRuleLogDeliveryParametersFactory(Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.LogDeliveryParameters> factoryAction = null) : SubResourceFactory<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.LogDeliveryParameters>
{

    protected override Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.LogDeliveryParameters Create()
    {
        var logDeliveryParametersResult = CreateLogDeliveryParameters();
        factoryAction?.Invoke(logDeliveryParametersResult);

        return logDeliveryParametersResult;
    }

    private Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.LogDeliveryParameters CreateLogDeliveryParameters()
    {
        var logDeliveryParametersResult = new Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.LogDeliveryParameters();

        return logDeliveryParametersResult;
    }

} // End Of Class

public static class InnerOrganizationTelemetryRuleLogDeliveryParametersFactoryExtensions
{
}
