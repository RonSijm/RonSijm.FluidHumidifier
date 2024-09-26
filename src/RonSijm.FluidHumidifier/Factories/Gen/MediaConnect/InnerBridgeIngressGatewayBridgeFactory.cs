// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerBridgeIngressGatewayBridgeFactory(Action<Humidifier.MediaConnect.BridgeTypes.IngressGatewayBridge> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.BridgeTypes.IngressGatewayBridge>
{

    protected override Humidifier.MediaConnect.BridgeTypes.IngressGatewayBridge Create()
    {
        var ingressGatewayBridgeResult = CreateIngressGatewayBridge();
        factoryAction?.Invoke(ingressGatewayBridgeResult);

        return ingressGatewayBridgeResult;
    }

    private Humidifier.MediaConnect.BridgeTypes.IngressGatewayBridge CreateIngressGatewayBridge()
    {
        var ingressGatewayBridgeResult = new Humidifier.MediaConnect.BridgeTypes.IngressGatewayBridge();

        return ingressGatewayBridgeResult;
    }

} // End Of Class

public static class InnerBridgeIngressGatewayBridgeFactoryExtensions
{
}
