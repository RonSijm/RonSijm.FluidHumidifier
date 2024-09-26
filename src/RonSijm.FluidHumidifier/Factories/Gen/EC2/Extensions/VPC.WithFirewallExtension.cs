// ReSharper disable InconsistentNaming
// ReSharper disable RedundantUsingDirective
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public static class VPCWithFirewallExtension
{
    public static CombinedResult<VPCFactory, NetworkFirewall.FirewallFactory> WithFirewall(this EC2.VPCFactory factory, string resourceName, Action<Humidifier.NetworkFirewall.Firewall> action = null)
    {
        var childResourceFactory = factory.CreateSubFactory(() => new NetworkFirewall.FirewallFactory(resourceName, action));

        var vpcAction = new Action<Humidifier.EC2.VPC>(_ =>
        {
            var subResource = childResourceFactory.Build();
            subResource.DependsOn = FFn.FFNamedList(factory);
            subResource.VpcId = FFn.FFnREF(factory);
        });

        factory.ExtendedActions.Enqueue(vpcAction);

        return new CombinedResult<VPCFactory, NetworkFirewall.FirewallFactory>(factory, childResourceFactory);
    }
}
