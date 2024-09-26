// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerBridgeBridgeNetworkOutputFactory(Action<Humidifier.MediaConnect.BridgeTypes.BridgeNetworkOutput> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.BridgeTypes.BridgeNetworkOutput>
{

    protected override Humidifier.MediaConnect.BridgeTypes.BridgeNetworkOutput Create()
    {
        var bridgeNetworkOutputResult = CreateBridgeNetworkOutput();
        factoryAction?.Invoke(bridgeNetworkOutputResult);

        return bridgeNetworkOutputResult;
    }

    private Humidifier.MediaConnect.BridgeTypes.BridgeNetworkOutput CreateBridgeNetworkOutput()
    {
        var bridgeNetworkOutputResult = new Humidifier.MediaConnect.BridgeTypes.BridgeNetworkOutput();

        return bridgeNetworkOutputResult;
    }

} // End Of Class

public static class InnerBridgeBridgeNetworkOutputFactoryExtensions
{
}
