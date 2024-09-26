// ReSharper disable InconsistentNaming
// ReSharper disable RedundantUsingDirective
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public static class VPCWithPrivateGraphEndpointExtension
{
    public static CombinedResult<VPCFactory, NeptuneGraph.PrivateGraphEndpointFactory> WithPrivateGraphEndpoint(this EC2.VPCFactory factory, string resourceName, Action<Humidifier.NeptuneGraph.PrivateGraphEndpoint> action = null)
    {
        var childResourceFactory = factory.CreateSubFactory(() => new NeptuneGraph.PrivateGraphEndpointFactory(resourceName, action));

        var vpcAction = new Action<Humidifier.EC2.VPC>(_ =>
        {
            var subResource = childResourceFactory.Build();
            subResource.DependsOn = FFn.FFNamedList(factory);
            subResource.VpcId = FFn.FFnREF(factory);
        });

        factory.ExtendedActions.Enqueue(vpcAction);

        return new CombinedResult<VPCFactory, NeptuneGraph.PrivateGraphEndpointFactory>(factory, childResourceFactory);
    }
}
