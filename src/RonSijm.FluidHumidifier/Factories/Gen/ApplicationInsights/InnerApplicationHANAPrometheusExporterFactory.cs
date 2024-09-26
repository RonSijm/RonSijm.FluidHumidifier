// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationInsights;

public class InnerApplicationHANAPrometheusExporterFactory(Action<Humidifier.ApplicationInsights.ApplicationTypes.HANAPrometheusExporter> factoryAction = null) : SubResourceFactory<Humidifier.ApplicationInsights.ApplicationTypes.HANAPrometheusExporter>
{

    protected override Humidifier.ApplicationInsights.ApplicationTypes.HANAPrometheusExporter Create()
    {
        var hANAPrometheusExporterResult = CreateHANAPrometheusExporter();
        factoryAction?.Invoke(hANAPrometheusExporterResult);

        return hANAPrometheusExporterResult;
    }

    private Humidifier.ApplicationInsights.ApplicationTypes.HANAPrometheusExporter CreateHANAPrometheusExporter()
    {
        var hANAPrometheusExporterResult = new Humidifier.ApplicationInsights.ApplicationTypes.HANAPrometheusExporter();

        return hANAPrometheusExporterResult;
    }

} // End Of Class

public static class InnerApplicationHANAPrometheusExporterFactoryExtensions
{
}
