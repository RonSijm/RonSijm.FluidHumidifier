// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerClientVpnEndpointTransitGatewayConfigurationFactory(Action<Humidifier.EC2.ClientVpnEndpointTypes.TransitGatewayConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EC2.ClientVpnEndpointTypes.TransitGatewayConfiguration>
{

    protected override Humidifier.EC2.ClientVpnEndpointTypes.TransitGatewayConfiguration Create()
    {
        var transitGatewayConfigurationResult = CreateTransitGatewayConfiguration();
        factoryAction?.Invoke(transitGatewayConfigurationResult);

        return transitGatewayConfigurationResult;
    }

    private Humidifier.EC2.ClientVpnEndpointTypes.TransitGatewayConfiguration CreateTransitGatewayConfiguration()
    {
        var transitGatewayConfigurationResult = new Humidifier.EC2.ClientVpnEndpointTypes.TransitGatewayConfiguration();

        return transitGatewayConfigurationResult;
    }

} // End Of Class

public static class InnerClientVpnEndpointTransitGatewayConfigurationFactoryExtensions
{
}
