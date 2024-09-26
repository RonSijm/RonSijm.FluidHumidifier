// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class TransitGatewayRouteTableAssociationFactory(string resourceName = null, Action<Humidifier.EC2.TransitGatewayRouteTableAssociation> factoryAction = null) : ResourceFactory<Humidifier.EC2.TransitGatewayRouteTableAssociation>(resourceName)
{

    protected override Humidifier.EC2.TransitGatewayRouteTableAssociation Create()
    {
        var transitGatewayRouteTableAssociationResult = CreateTransitGatewayRouteTableAssociation();
        factoryAction?.Invoke(transitGatewayRouteTableAssociationResult);

        return transitGatewayRouteTableAssociationResult;
    }

    private Humidifier.EC2.TransitGatewayRouteTableAssociation CreateTransitGatewayRouteTableAssociation()
    {
        var transitGatewayRouteTableAssociationResult = new Humidifier.EC2.TransitGatewayRouteTableAssociation
        {
            GivenName = InputResourceName,
        };

        return transitGatewayRouteTableAssociationResult;
    }

} // End Of Class

public static class TransitGatewayRouteTableAssociationFactoryExtensions
{
}
