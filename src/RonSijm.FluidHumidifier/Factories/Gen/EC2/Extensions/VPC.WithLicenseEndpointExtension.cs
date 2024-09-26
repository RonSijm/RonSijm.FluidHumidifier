// ReSharper disable InconsistentNaming
// ReSharper disable RedundantUsingDirective
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public static class VPCWithLicenseEndpointExtension
{
    public static CombinedResult<VPCFactory, Deadline.LicenseEndpointFactory> WithLicenseEndpoint(this EC2.VPCFactory factory, string resourceName, Action<Humidifier.Deadline.LicenseEndpoint> action = null)
    {
        var childResourceFactory = factory.CreateSubFactory(() => new Deadline.LicenseEndpointFactory(resourceName, action));

        var vpcAction = new Action<Humidifier.EC2.VPC>(_ =>
        {
            var subResource = childResourceFactory.Build();
            subResource.DependsOn = FFn.FFNamedList(factory);
            subResource.VpcId = FFn.FFnREF(factory);
        });

        factory.ExtendedActions.Enqueue(vpcAction);

        return new CombinedResult<VPCFactory, Deadline.LicenseEndpointFactory>(factory, childResourceFactory);
    }
}
