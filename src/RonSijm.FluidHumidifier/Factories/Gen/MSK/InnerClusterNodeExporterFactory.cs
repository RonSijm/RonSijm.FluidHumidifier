// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerClusterNodeExporterFactory(Action<Humidifier.MSK.ClusterTypes.NodeExporter> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ClusterTypes.NodeExporter>
{

    protected override Humidifier.MSK.ClusterTypes.NodeExporter Create()
    {
        var nodeExporterResult = CreateNodeExporter();
        factoryAction?.Invoke(nodeExporterResult);

        return nodeExporterResult;
    }

    private Humidifier.MSK.ClusterTypes.NodeExporter CreateNodeExporter()
    {
        var nodeExporterResult = new Humidifier.MSK.ClusterTypes.NodeExporter();

        return nodeExporterResult;
    }

} // End Of Class

public static class InnerClusterNodeExporterFactoryExtensions
{
}
