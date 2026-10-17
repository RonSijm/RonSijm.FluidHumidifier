// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ObservabilityAdmin;

public class InnerOrganizationTelemetryRuleLoggingFilterFactory(Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.LoggingFilter> factoryAction = null) : SubResourceFactory<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.LoggingFilter>
{

    protected override Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.LoggingFilter Create()
    {
        var loggingFilterResult = CreateLoggingFilter();
        factoryAction?.Invoke(loggingFilterResult);

        return loggingFilterResult;
    }

    private Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.LoggingFilter CreateLoggingFilter()
    {
        var loggingFilterResult = new Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.LoggingFilter();

        return loggingFilterResult;
    }

} // End Of Class

public static class InnerOrganizationTelemetryRuleLoggingFilterFactoryExtensions
{
}
