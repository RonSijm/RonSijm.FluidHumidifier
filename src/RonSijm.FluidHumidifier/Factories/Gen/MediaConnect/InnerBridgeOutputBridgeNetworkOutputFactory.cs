// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerBridgeOutputBridgeNetworkOutputFactory(Action<Humidifier.MediaConnect.BridgeOutputTypes.BridgeNetworkOutput> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.BridgeOutputTypes.BridgeNetworkOutput>
{

    protected override Humidifier.MediaConnect.BridgeOutputTypes.BridgeNetworkOutput Create()
    {
        var bridgeNetworkOutputResult = CreateBridgeNetworkOutput();
        factoryAction?.Invoke(bridgeNetworkOutputResult);

        return bridgeNetworkOutputResult;
    }

    private Humidifier.MediaConnect.BridgeOutputTypes.BridgeNetworkOutput CreateBridgeNetworkOutput()
    {
        var bridgeNetworkOutputResult = new Humidifier.MediaConnect.BridgeOutputTypes.BridgeNetworkOutput();

        return bridgeNetworkOutputResult;
    }

} // End Of Class

public static class InnerBridgeOutputBridgeNetworkOutputFactoryExtensions
{
}
