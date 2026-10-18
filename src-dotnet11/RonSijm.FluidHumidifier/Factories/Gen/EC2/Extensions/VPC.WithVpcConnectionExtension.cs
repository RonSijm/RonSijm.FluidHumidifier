// ReSharper disable InconsistentNaming
// ReSharper disable RedundantUsingDirective
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public static class VPCWithVpcConnectionExtension
{
    public static CombinedResult<VPCFactory, MSK.VpcConnectionFactory> WithVpcConnection(this EC2.VPCFactory factory, string resourceName, Action<Humidifier.MSK.VpcConnection> action = null)
    {
        var childResourceFactory = factory.CreateSubFactory(() => new MSK.VpcConnectionFactory(resourceName, action));

        var vpcAction = new Action<Humidifier.EC2.VPC>(_ =>
        {
            var subResource = childResourceFactory.Build();
            subResource.DependsOn = FFn.FFNamedList(factory);
            subResource.VpcId = FFn.FFnREF(factory);
        });

        factory.ExtendedActions.Enqueue(vpcAction);

        return new CombinedResult<VPCFactory, MSK.VpcConnectionFactory>(factory, childResourceFactory);
    }
}
