// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ObservabilityAdmin;

public class TelemetryEnrichmentFactory(string resourceName = null, Action<Humidifier.ObservabilityAdmin.TelemetryEnrichment> factoryAction = null) : ResourceFactory<Humidifier.ObservabilityAdmin.TelemetryEnrichment>(resourceName)
{

    protected override Humidifier.ObservabilityAdmin.TelemetryEnrichment Create()
    {
        var telemetryEnrichmentResult = CreateTelemetryEnrichment();
        factoryAction?.Invoke(telemetryEnrichmentResult);

        return telemetryEnrichmentResult;
    }

    private Humidifier.ObservabilityAdmin.TelemetryEnrichment CreateTelemetryEnrichment()
    {
        var telemetryEnrichmentResult = new Humidifier.ObservabilityAdmin.TelemetryEnrichment
        {
            GivenName = InputResourceName,
        };

        return telemetryEnrichmentResult;
    }

} // End Of Class

public static class TelemetryEnrichmentFactoryExtensions
{
}
