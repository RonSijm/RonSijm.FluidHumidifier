// ReSharper disable InconsistentNaming
// ReSharper disable RedundantUsingDirective
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public static class VPCWithVpcEndpointAssociationExtension
{
    public static CombinedResult<VPCFactory, NetworkFirewall.VpcEndpointAssociationFactory> WithVpcEndpointAssociation(this EC2.VPCFactory factory, string resourceName, Action<Humidifier.NetworkFirewall.VpcEndpointAssociation> action = null)
    {
        var childResourceFactory = factory.CreateSubFactory(() => new NetworkFirewall.VpcEndpointAssociationFactory(resourceName, action));

        var vpcAction = new Action<Humidifier.EC2.VPC>(_ =>
        {
            var subResource = childResourceFactory.Build();
            subResource.DependsOn = FFn.FFNamedList(factory);
            subResource.VpcId = FFn.FFnREF(factory);
        });

        factory.ExtendedActions.Enqueue(vpcAction);

        return new CombinedResult<VPCFactory, NetworkFirewall.VpcEndpointAssociationFactory>(factory, childResourceFactory);
    }
}
