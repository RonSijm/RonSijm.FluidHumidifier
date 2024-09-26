// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationInsights;

public class InnerApplicationSQLServerPrometheusExporterFactory(Action<Humidifier.ApplicationInsights.ApplicationTypes.SQLServerPrometheusExporter> factoryAction = null) : SubResourceFactory<Humidifier.ApplicationInsights.ApplicationTypes.SQLServerPrometheusExporter>
{

    protected override Humidifier.ApplicationInsights.ApplicationTypes.SQLServerPrometheusExporter Create()
    {
        var sQLServerPrometheusExporterResult = CreateSQLServerPrometheusExporter();
        factoryAction?.Invoke(sQLServerPrometheusExporterResult);

        return sQLServerPrometheusExporterResult;
    }

    private Humidifier.ApplicationInsights.ApplicationTypes.SQLServerPrometheusExporter CreateSQLServerPrometheusExporter()
    {
        var sQLServerPrometheusExporterResult = new Humidifier.ApplicationInsights.ApplicationTypes.SQLServerPrometheusExporter();

        return sQLServerPrometheusExporterResult;
    }

} // End Of Class

public static class InnerApplicationSQLServerPrometheusExporterFactoryExtensions
{
}
