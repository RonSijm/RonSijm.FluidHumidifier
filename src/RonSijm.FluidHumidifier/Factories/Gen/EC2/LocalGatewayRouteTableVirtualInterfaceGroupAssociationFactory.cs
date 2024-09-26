// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class LocalGatewayRouteTableVirtualInterfaceGroupAssociationFactory(string resourceName = null, Action<Humidifier.EC2.LocalGatewayRouteTableVirtualInterfaceGroupAssociation> factoryAction = null) : ResourceFactory<Humidifier.EC2.LocalGatewayRouteTableVirtualInterfaceGroupAssociation>(resourceName)
{

    protected override Humidifier.EC2.LocalGatewayRouteTableVirtualInterfaceGroupAssociation Create()
    {
        var localGatewayRouteTableVirtualInterfaceGroupAssociationResult = CreateLocalGatewayRouteTableVirtualInterfaceGroupAssociation();
        factoryAction?.Invoke(localGatewayRouteTableVirtualInterfaceGroupAssociationResult);

        return localGatewayRouteTableVirtualInterfaceGroupAssociationResult;
    }

    private Humidifier.EC2.LocalGatewayRouteTableVirtualInterfaceGroupAssociation CreateLocalGatewayRouteTableVirtualInterfaceGroupAssociation()
    {
        var localGatewayRouteTableVirtualInterfaceGroupAssociationResult = new Humidifier.EC2.LocalGatewayRouteTableVirtualInterfaceGroupAssociation
        {
            GivenName = InputResourceName,
        };

        return localGatewayRouteTableVirtualInterfaceGroupAssociationResult;
    }

} // End Of Class

public static class LocalGatewayRouteTableVirtualInterfaceGroupAssociationFactoryExtensions
{
}
