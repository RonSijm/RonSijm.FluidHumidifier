// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53Resolver;

public class InnerResolverRuleTargetAddressFactory(Action<Humidifier.Route53Resolver.ResolverRuleTypes.TargetAddress> factoryAction = null) : SubResourceFactory<Humidifier.Route53Resolver.ResolverRuleTypes.TargetAddress>
{

    protected override Humidifier.Route53Resolver.ResolverRuleTypes.TargetAddress Create()
    {
        var targetAddressResult = CreateTargetAddress();
        factoryAction?.Invoke(targetAddressResult);

        return targetAddressResult;
    }

    private Humidifier.Route53Resolver.ResolverRuleTypes.TargetAddress CreateTargetAddress()
    {
        var targetAddressResult = new Humidifier.Route53Resolver.ResolverRuleTypes.TargetAddress();

        return targetAddressResult;
    }

} // End Of Class

public static class InnerResolverRuleTargetAddressFactoryExtensions
{
}
