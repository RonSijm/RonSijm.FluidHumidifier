// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class LocalGatewayRouteTableVPCAssociationFactory(string resourceName = null, Action<Humidifier.EC2.LocalGatewayRouteTableVPCAssociation> factoryAction = null) : ResourceFactory<Humidifier.EC2.LocalGatewayRouteTableVPCAssociation>(resourceName)
{

    protected override Humidifier.EC2.LocalGatewayRouteTableVPCAssociation Create()
    {
        var localGatewayRouteTableVPCAssociationResult = CreateLocalGatewayRouteTableVPCAssociation();
        factoryAction?.Invoke(localGatewayRouteTableVPCAssociationResult);

        return localGatewayRouteTableVPCAssociationResult;
    }

    private Humidifier.EC2.LocalGatewayRouteTableVPCAssociation CreateLocalGatewayRouteTableVPCAssociation()
    {
        var localGatewayRouteTableVPCAssociationResult = new Humidifier.EC2.LocalGatewayRouteTableVPCAssociation
        {
            GivenName = InputResourceName,
        };

        return localGatewayRouteTableVPCAssociationResult;
    }

} // End Of Class

public static class LocalGatewayRouteTableVPCAssociationFactoryExtensions
{
}
