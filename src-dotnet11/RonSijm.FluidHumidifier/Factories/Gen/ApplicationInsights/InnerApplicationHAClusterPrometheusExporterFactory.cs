// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationInsights;

public class InnerApplicationHAClusterPrometheusExporterFactory(Action<Humidifier.ApplicationInsights.ApplicationTypes.HAClusterPrometheusExporter> factoryAction = null) : SubResourceFactory<Humidifier.ApplicationInsights.ApplicationTypes.HAClusterPrometheusExporter>
{

    protected override Humidifier.ApplicationInsights.ApplicationTypes.HAClusterPrometheusExporter Create()
    {
        var hAClusterPrometheusExporterResult = CreateHAClusterPrometheusExporter();
        factoryAction?.Invoke(hAClusterPrometheusExporterResult);

        return hAClusterPrometheusExporterResult;
    }

    private Humidifier.ApplicationInsights.ApplicationTypes.HAClusterPrometheusExporter CreateHAClusterPrometheusExporter()
    {
        var hAClusterPrometheusExporterResult = new Humidifier.ApplicationInsights.ApplicationTypes.HAClusterPrometheusExporter();

        return hAClusterPrometheusExporterResult;
    }

} // End Of Class

public static class InnerApplicationHAClusterPrometheusExporterFactoryExtensions
{
}
