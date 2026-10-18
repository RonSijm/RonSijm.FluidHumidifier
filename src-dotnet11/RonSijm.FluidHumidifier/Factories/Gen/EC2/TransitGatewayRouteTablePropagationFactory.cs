// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class TransitGatewayRouteTablePropagationFactory(string resourceName = null, Action<Humidifier.EC2.TransitGatewayRouteTablePropagation> factoryAction = null) : ResourceFactory<Humidifier.EC2.TransitGatewayRouteTablePropagation>(resourceName)
{

    protected override Humidifier.EC2.TransitGatewayRouteTablePropagation Create()
    {
        var transitGatewayRouteTablePropagationResult = CreateTransitGatewayRouteTablePropagation();
        factoryAction?.Invoke(transitGatewayRouteTablePropagationResult);

        return transitGatewayRouteTablePropagationResult;
    }

    private Humidifier.EC2.TransitGatewayRouteTablePropagation CreateTransitGatewayRouteTablePropagation()
    {
        var transitGatewayRouteTablePropagationResult = new Humidifier.EC2.TransitGatewayRouteTablePropagation
        {
            GivenName = InputResourceName,
        };

        return transitGatewayRouteTablePropagationResult;
    }

} // End Of Class

public static class TransitGatewayRouteTablePropagationFactoryExtensions
{
}
