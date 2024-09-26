// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationInsights;

public class InnerApplicationJMXPrometheusExporterFactory(Action<Humidifier.ApplicationInsights.ApplicationTypes.JMXPrometheusExporter> factoryAction = null) : SubResourceFactory<Humidifier.ApplicationInsights.ApplicationTypes.JMXPrometheusExporter>
{

    protected override Humidifier.ApplicationInsights.ApplicationTypes.JMXPrometheusExporter Create()
    {
        var jMXPrometheusExporterResult = CreateJMXPrometheusExporter();
        factoryAction?.Invoke(jMXPrometheusExporterResult);

        return jMXPrometheusExporterResult;
    }

    private Humidifier.ApplicationInsights.ApplicationTypes.JMXPrometheusExporter CreateJMXPrometheusExporter()
    {
        var jMXPrometheusExporterResult = new Humidifier.ApplicationInsights.ApplicationTypes.JMXPrometheusExporter();

        return jMXPrometheusExporterResult;
    }

} // End Of Class

public static class InnerApplicationJMXPrometheusExporterFactoryExtensions
{
}
