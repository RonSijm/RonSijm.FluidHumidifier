// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerBridgeEgressGatewayBridgeFactory(Action<Humidifier.MediaConnect.BridgeTypes.EgressGatewayBridge> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.BridgeTypes.EgressGatewayBridge>
{

    protected override Humidifier.MediaConnect.BridgeTypes.EgressGatewayBridge Create()
    {
        var egressGatewayBridgeResult = CreateEgressGatewayBridge();
        factoryAction?.Invoke(egressGatewayBridgeResult);

        return egressGatewayBridgeResult;
    }

    private Humidifier.MediaConnect.BridgeTypes.EgressGatewayBridge CreateEgressGatewayBridge()
    {
        var egressGatewayBridgeResult = new Humidifier.MediaConnect.BridgeTypes.EgressGatewayBridge();

        return egressGatewayBridgeResult;
    }

} // End Of Class

public static class InnerBridgeEgressGatewayBridgeFactoryExtensions
{
}
