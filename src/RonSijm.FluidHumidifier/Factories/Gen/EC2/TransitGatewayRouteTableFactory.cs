// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class TransitGatewayRouteTableFactory(string resourceName = null, Action<Humidifier.EC2.TransitGatewayRouteTable> factoryAction = null) : ResourceFactory<Humidifier.EC2.TransitGatewayRouteTable>(resourceName)
{

    protected override Humidifier.EC2.TransitGatewayRouteTable Create()
    {
        var transitGatewayRouteTableResult = CreateTransitGatewayRouteTable();
        factoryAction?.Invoke(transitGatewayRouteTableResult);

        return transitGatewayRouteTableResult;
    }

    private Humidifier.EC2.TransitGatewayRouteTable CreateTransitGatewayRouteTable()
    {
        var transitGatewayRouteTableResult = new Humidifier.EC2.TransitGatewayRouteTable
        {
            GivenName = InputResourceName,
        };

        return transitGatewayRouteTableResult;
    }

} // End Of Class

public static class TransitGatewayRouteTableFactoryExtensions
{
}
