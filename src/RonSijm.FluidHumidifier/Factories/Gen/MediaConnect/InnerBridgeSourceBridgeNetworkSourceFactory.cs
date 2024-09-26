// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerBridgeSourceBridgeNetworkSourceFactory(Action<Humidifier.MediaConnect.BridgeSourceTypes.BridgeNetworkSource> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.BridgeSourceTypes.BridgeNetworkSource>
{

    protected override Humidifier.MediaConnect.BridgeSourceTypes.BridgeNetworkSource Create()
    {
        var bridgeNetworkSourceResult = CreateBridgeNetworkSource();
        factoryAction?.Invoke(bridgeNetworkSourceResult);

        return bridgeNetworkSourceResult;
    }

    private Humidifier.MediaConnect.BridgeSourceTypes.BridgeNetworkSource CreateBridgeNetworkSource()
    {
        var bridgeNetworkSourceResult = new Humidifier.MediaConnect.BridgeSourceTypes.BridgeNetworkSource();

        return bridgeNetworkSourceResult;
    }

} // End Of Class

public static class InnerBridgeSourceBridgeNetworkSourceFactoryExtensions
{
}
