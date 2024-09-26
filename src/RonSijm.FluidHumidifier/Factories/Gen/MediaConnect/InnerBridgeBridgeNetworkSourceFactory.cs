// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerBridgeBridgeNetworkSourceFactory(Action<Humidifier.MediaConnect.BridgeTypes.BridgeNetworkSource> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.BridgeTypes.BridgeNetworkSource>
{

    protected override Humidifier.MediaConnect.BridgeTypes.BridgeNetworkSource Create()
    {
        var bridgeNetworkSourceResult = CreateBridgeNetworkSource();
        factoryAction?.Invoke(bridgeNetworkSourceResult);

        return bridgeNetworkSourceResult;
    }

    private Humidifier.MediaConnect.BridgeTypes.BridgeNetworkSource CreateBridgeNetworkSource()
    {
        var bridgeNetworkSourceResult = new Humidifier.MediaConnect.BridgeTypes.BridgeNetworkSource();

        return bridgeNetworkSourceResult;
    }

} // End Of Class

public static class InnerBridgeBridgeNetworkSourceFactoryExtensions
{
}
