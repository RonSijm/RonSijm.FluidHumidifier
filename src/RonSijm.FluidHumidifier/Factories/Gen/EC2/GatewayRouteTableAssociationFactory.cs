// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class GatewayRouteTableAssociationFactory(string resourceName = null, Action<Humidifier.EC2.GatewayRouteTableAssociation> factoryAction = null) : ResourceFactory<Humidifier.EC2.GatewayRouteTableAssociation>(resourceName)
{

    protected override Humidifier.EC2.GatewayRouteTableAssociation Create()
    {
        var gatewayRouteTableAssociationResult = CreateGatewayRouteTableAssociation();
        factoryAction?.Invoke(gatewayRouteTableAssociationResult);

        return gatewayRouteTableAssociationResult;
    }

    private Humidifier.EC2.GatewayRouteTableAssociation CreateGatewayRouteTableAssociation()
    {
        var gatewayRouteTableAssociationResult = new Humidifier.EC2.GatewayRouteTableAssociation
        {
            GivenName = InputResourceName,
        };

        return gatewayRouteTableAssociationResult;
    }

} // End Of Class

public static class GatewayRouteTableAssociationFactoryExtensions
{
}
