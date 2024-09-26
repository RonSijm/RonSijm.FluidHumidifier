// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerSecurityProfileMetricsExportConfigFactory(Action<Humidifier.IoT.SecurityProfileTypes.MetricsExportConfig> factoryAction = null) : SubResourceFactory<Humidifier.IoT.SecurityProfileTypes.MetricsExportConfig>
{

    protected override Humidifier.IoT.SecurityProfileTypes.MetricsExportConfig Create()
    {
        var metricsExportConfigResult = CreateMetricsExportConfig();
        factoryAction?.Invoke(metricsExportConfigResult);

        return metricsExportConfigResult;
    }

    private Humidifier.IoT.SecurityProfileTypes.MetricsExportConfig CreateMetricsExportConfig()
    {
        var metricsExportConfigResult = new Humidifier.IoT.SecurityProfileTypes.MetricsExportConfig();

        return metricsExportConfigResult;
    }

} // End Of Class

public static class InnerSecurityProfileMetricsExportConfigFactoryExtensions
{
}
