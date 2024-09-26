// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerTransitGatewayConnectTransitGatewayConnectOptionsFactory(Action<Humidifier.EC2.TransitGatewayConnectTypes.TransitGatewayConnectOptions> factoryAction = null) : SubResourceFactory<Humidifier.EC2.TransitGatewayConnectTypes.TransitGatewayConnectOptions>
{

    protected override Humidifier.EC2.TransitGatewayConnectTypes.TransitGatewayConnectOptions Create()
    {
        var transitGatewayConnectOptionsResult = CreateTransitGatewayConnectOptions();
        factoryAction?.Invoke(transitGatewayConnectOptionsResult);

        return transitGatewayConnectOptionsResult;
    }

    private Humidifier.EC2.TransitGatewayConnectTypes.TransitGatewayConnectOptions CreateTransitGatewayConnectOptions()
    {
        var transitGatewayConnectOptionsResult = new Humidifier.EC2.TransitGatewayConnectTypes.TransitGatewayConnectOptions();

        return transitGatewayConnectOptionsResult;
    }

} // End Of Class

public static class InnerTransitGatewayConnectTransitGatewayConnectOptionsFactoryExtensions
{
}
