// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerTransitGatewayConnectPeerTransitGatewayConnectPeerConfigurationFactory(Action<Humidifier.EC2.TransitGatewayConnectPeerTypes.TransitGatewayConnectPeerConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EC2.TransitGatewayConnectPeerTypes.TransitGatewayConnectPeerConfiguration>
{

    protected override Humidifier.EC2.TransitGatewayConnectPeerTypes.TransitGatewayConnectPeerConfiguration Create()
    {
        var transitGatewayConnectPeerConfigurationResult = CreateTransitGatewayConnectPeerConfiguration();
        factoryAction?.Invoke(transitGatewayConnectPeerConfigurationResult);

        return transitGatewayConnectPeerConfigurationResult;
    }

    private Humidifier.EC2.TransitGatewayConnectPeerTypes.TransitGatewayConnectPeerConfiguration CreateTransitGatewayConnectPeerConfiguration()
    {
        var transitGatewayConnectPeerConfigurationResult = new Humidifier.EC2.TransitGatewayConnectPeerTypes.TransitGatewayConnectPeerConfiguration();

        return transitGatewayConnectPeerConfigurationResult;
    }

} // End Of Class

public static class InnerTransitGatewayConnectPeerTransitGatewayConnectPeerConfigurationFactoryExtensions
{
}
