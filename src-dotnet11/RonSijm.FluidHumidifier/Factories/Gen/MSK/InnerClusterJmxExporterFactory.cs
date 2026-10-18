// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerClusterJmxExporterFactory(Action<Humidifier.MSK.ClusterTypes.JmxExporter> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ClusterTypes.JmxExporter>
{

    protected override Humidifier.MSK.ClusterTypes.JmxExporter Create()
    {
        var jmxExporterResult = CreateJmxExporter();
        factoryAction?.Invoke(jmxExporterResult);

        return jmxExporterResult;
    }

    private Humidifier.MSK.ClusterTypes.JmxExporter CreateJmxExporter()
    {
        var jmxExporterResult = new Humidifier.MSK.ClusterTypes.JmxExporter();

        return jmxExporterResult;
    }

} // End Of Class

public static class InnerClusterJmxExporterFactoryExtensions
{
}
