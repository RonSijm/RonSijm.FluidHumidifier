// ReSharper disable InconsistentNaming
// ReSharper disable RedundantUsingDirective
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public static class VPCWithLocalGatewayRouteTableVPCAssociationExtension
{
    public static CombinedResult<VPCFactory, EC2.LocalGatewayRouteTableVPCAssociationFactory> WithLocalGatewayRouteTableVPCAssociation(this EC2.VPCFactory factory, string resourceName, Action<Humidifier.EC2.LocalGatewayRouteTableVPCAssociation> action = null)
    {
        var childResourceFactory = factory.CreateSubFactory(() => new EC2.LocalGatewayRouteTableVPCAssociationFactory(resourceName, action));

        var vpcAction = new Action<Humidifier.EC2.VPC>(_ =>
        {
            var subResource = childResourceFactory.Build();
            subResource.DependsOn = FFn.FFNamedList(factory);
            subResource.VpcId = FFn.FFnREF(factory);
        });

        factory.ExtendedActions.Enqueue(vpcAction);

        return new CombinedResult<VPCFactory, EC2.LocalGatewayRouteTableVPCAssociationFactory>(factory, childResourceFactory);
    }
}
