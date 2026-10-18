// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetWise;

public class InnerSignalCatalogNodeCountsFactory(Action<Humidifier.IoTFleetWise.SignalCatalogTypes.NodeCounts> factoryAction = null) : SubResourceFactory<Humidifier.IoTFleetWise.SignalCatalogTypes.NodeCounts>
{

    protected override Humidifier.IoTFleetWise.SignalCatalogTypes.NodeCounts Create()
    {
        var nodeCountsResult = CreateNodeCounts();
        factoryAction?.Invoke(nodeCountsResult);

        return nodeCountsResult;
    }

    private Humidifier.IoTFleetWise.SignalCatalogTypes.NodeCounts CreateNodeCounts()
    {
        var nodeCountsResult = new Humidifier.IoTFleetWise.SignalCatalogTypes.NodeCounts();

        return nodeCountsResult;
    }

} // End Of Class

public static class InnerSignalCatalogNodeCountsFactoryExtensions
{
}
