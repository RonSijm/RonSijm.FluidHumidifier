// ReSharper disable InconsistentNaming
// ReSharper disable RedundantUsingDirective
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public static class VPCWithVpcEndpointExtension
{
    public static CombinedResult<VPCFactory, OpenSearchServerless.VpcEndpointFactory> WithVpcEndpoint(this EC2.VPCFactory factory, string resourceName, Action<Humidifier.OpenSearchServerless.VpcEndpoint> action = null)
    {
        var childResourceFactory = factory.CreateSubFactory(() => new OpenSearchServerless.VpcEndpointFactory(resourceName, action));

        var vpcAction = new Action<Humidifier.EC2.VPC>(_ =>
        {
            var subResource = childResourceFactory.Build();
            subResource.DependsOn = FFn.FFNamedList(factory);
            subResource.VpcId = FFn.FFnREF(factory);
        });

        factory.ExtendedActions.Enqueue(vpcAction);

        return new CombinedResult<VPCFactory, OpenSearchServerless.VpcEndpointFactory>(factory, childResourceFactory);
    }
}
