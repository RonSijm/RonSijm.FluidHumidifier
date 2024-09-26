// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationInsights;

public class InnerApplicationNetWeaverPrometheusExporterFactory(Action<Humidifier.ApplicationInsights.ApplicationTypes.NetWeaverPrometheusExporter> factoryAction = null) : SubResourceFactory<Humidifier.ApplicationInsights.ApplicationTypes.NetWeaverPrometheusExporter>
{

    protected override Humidifier.ApplicationInsights.ApplicationTypes.NetWeaverPrometheusExporter Create()
    {
        var netWeaverPrometheusExporterResult = CreateNetWeaverPrometheusExporter();
        factoryAction?.Invoke(netWeaverPrometheusExporterResult);

        return netWeaverPrometheusExporterResult;
    }

    private Humidifier.ApplicationInsights.ApplicationTypes.NetWeaverPrometheusExporter CreateNetWeaverPrometheusExporter()
    {
        var netWeaverPrometheusExporterResult = new Humidifier.ApplicationInsights.ApplicationTypes.NetWeaverPrometheusExporter();

        return netWeaverPrometheusExporterResult;
    }

} // End Of Class

public static class InnerApplicationNetWeaverPrometheusExporterFactoryExtensions
{
}
