// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ObservabilityAdmin;

public class InnerTelemetryRuleLoggingFilterFactory(Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.LoggingFilter> factoryAction = null) : SubResourceFactory<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.LoggingFilter>
{

    protected override Humidifier.ObservabilityAdmin.TelemetryRuleTypes.LoggingFilter Create()
    {
        var loggingFilterResult = CreateLoggingFilter();
        factoryAction?.Invoke(loggingFilterResult);

        return loggingFilterResult;
    }

    private Humidifier.ObservabilityAdmin.TelemetryRuleTypes.LoggingFilter CreateLoggingFilter()
    {
        var loggingFilterResult = new Humidifier.ObservabilityAdmin.TelemetryRuleTypes.LoggingFilter();

        return loggingFilterResult;
    }

} // End Of Class

public static class InnerTelemetryRuleLoggingFilterFactoryExtensions
{
}
