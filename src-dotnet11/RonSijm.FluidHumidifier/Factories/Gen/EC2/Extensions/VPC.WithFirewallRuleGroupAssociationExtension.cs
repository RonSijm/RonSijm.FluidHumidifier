// ReSharper disable InconsistentNaming
// ReSharper disable RedundantUsingDirective
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public static class VPCWithFirewallRuleGroupAssociationExtension
{
    public static CombinedResult<VPCFactory, Route53Resolver.FirewallRuleGroupAssociationFactory> WithFirewallRuleGroupAssociation(this EC2.VPCFactory factory, string resourceName, Action<Humidifier.Route53Resolver.FirewallRuleGroupAssociation> action = null)
    {
        var childResourceFactory = factory.CreateSubFactory(() => new Route53Resolver.FirewallRuleGroupAssociationFactory(resourceName, action));

        var vpcAction = new Action<Humidifier.EC2.VPC>(_ =>
        {
            var subResource = childResourceFactory.Build();
            subResource.DependsOn = FFn.FFNamedList(factory);
            subResource.VpcId = FFn.FFnREF(factory);
        });

        factory.ExtendedActions.Enqueue(vpcAction);

        return new CombinedResult<VPCFactory, Route53Resolver.FirewallRuleGroupAssociationFactory>(factory, childResourceFactory);
    }
}
