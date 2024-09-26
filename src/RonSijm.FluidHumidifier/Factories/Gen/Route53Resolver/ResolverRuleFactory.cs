// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53Resolver;

public class ResolverRuleFactory(string resourceName = null, Action<Humidifier.Route53Resolver.ResolverRule> factoryAction = null) : ResourceFactory<Humidifier.Route53Resolver.ResolverRule>(resourceName)
{

    internal List<InnerResolverRuleTargetAddressFactory> TargetIpsFactories { get; set; } = [];

    protected override Humidifier.Route53Resolver.ResolverRule Create()
    {
        var resolverRuleResult = CreateResolverRule();
        factoryAction?.Invoke(resolverRuleResult);

        return resolverRuleResult;
    }

    private Humidifier.Route53Resolver.ResolverRule CreateResolverRule()
    {
        var resolverRuleResult = new Humidifier.Route53Resolver.ResolverRule
        {
            GivenName = InputResourceName,
        };

        return resolverRuleResult;
    }
    public override void CreateChildren(Humidifier.Route53Resolver.ResolverRule result)
    {
        base.CreateChildren(result);

        result.TargetIps = TargetIpsFactories.Any() ? TargetIpsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ResolverRuleFactoryExtensions
{
    public static CombinedResult<ResolverRuleFactory, InnerResolverRuleTargetAddressFactory> WithTargetIps(this ResolverRuleFactory parentFactory, Action<Humidifier.Route53Resolver.ResolverRuleTypes.TargetAddress> subFactoryAction = null)
    {
        var factory = new InnerResolverRuleTargetAddressFactory(subFactoryAction);
        parentFactory.TargetIpsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ResolverRuleFactory, T1, InnerResolverRuleTargetAddressFactory> WithTargetIps<T1>(this CombinedResult<ResolverRuleFactory, T1> combinedResult, Action<Humidifier.Route53Resolver.ResolverRuleTypes.TargetAddress> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetIps(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResolverRuleFactory, InnerResolverRuleTargetAddressFactory> WithTargetIps<T1>(this CombinedResult<T1, ResolverRuleFactory> combinedResult, Action<Humidifier.Route53Resolver.ResolverRuleTypes.TargetAddress> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetIps(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ResolverRuleFactory, T1, T2, InnerResolverRuleTargetAddressFactory> WithTargetIps<T1, T2>(this CombinedResult<ResolverRuleFactory, T1, T2> combinedResult, Action<Humidifier.Route53Resolver.ResolverRuleTypes.TargetAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetIps(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResolverRuleFactory, T2, InnerResolverRuleTargetAddressFactory> WithTargetIps<T1, T2>(this CombinedResult<T1, ResolverRuleFactory, T2> combinedResult, Action<Humidifier.Route53Resolver.ResolverRuleTypes.TargetAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetIps(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResolverRuleFactory, InnerResolverRuleTargetAddressFactory> WithTargetIps<T1, T2>(this CombinedResult<T1, T2, ResolverRuleFactory> combinedResult, Action<Humidifier.Route53Resolver.ResolverRuleTypes.TargetAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetIps(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ResolverRuleFactory, T1, T2, T3, InnerResolverRuleTargetAddressFactory> WithTargetIps<T1, T2, T3>(this CombinedResult<ResolverRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.Route53Resolver.ResolverRuleTypes.TargetAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetIps(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResolverRuleFactory, T2, T3, InnerResolverRuleTargetAddressFactory> WithTargetIps<T1, T2, T3>(this CombinedResult<T1, ResolverRuleFactory, T2, T3> combinedResult, Action<Humidifier.Route53Resolver.ResolverRuleTypes.TargetAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetIps(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResolverRuleFactory, T3, InnerResolverRuleTargetAddressFactory> WithTargetIps<T1, T2, T3>(this CombinedResult<T1, T2, ResolverRuleFactory, T3> combinedResult, Action<Humidifier.Route53Resolver.ResolverRuleTypes.TargetAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetIps(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ResolverRuleFactory, InnerResolverRuleTargetAddressFactory> WithTargetIps<T1, T2, T3>(this CombinedResult<T1, T2, T3, ResolverRuleFactory> combinedResult, Action<Humidifier.Route53Resolver.ResolverRuleTypes.TargetAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetIps(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ResolverRuleFactory, T1, T2, T3, T4, InnerResolverRuleTargetAddressFactory> WithTargetIps<T1, T2, T3, T4>(this CombinedResult<ResolverRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Route53Resolver.ResolverRuleTypes.TargetAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetIps(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResolverRuleFactory, T2, T3, T4, InnerResolverRuleTargetAddressFactory> WithTargetIps<T1, T2, T3, T4>(this CombinedResult<T1, ResolverRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.Route53Resolver.ResolverRuleTypes.TargetAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetIps(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResolverRuleFactory, T3, T4, InnerResolverRuleTargetAddressFactory> WithTargetIps<T1, T2, T3, T4>(this CombinedResult<T1, T2, ResolverRuleFactory, T3, T4> combinedResult, Action<Humidifier.Route53Resolver.ResolverRuleTypes.TargetAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetIps(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ResolverRuleFactory, T4, InnerResolverRuleTargetAddressFactory> WithTargetIps<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ResolverRuleFactory, T4> combinedResult, Action<Humidifier.Route53Resolver.ResolverRuleTypes.TargetAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetIps(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ResolverRuleFactory, InnerResolverRuleTargetAddressFactory> WithTargetIps<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ResolverRuleFactory> combinedResult, Action<Humidifier.Route53Resolver.ResolverRuleTypes.TargetAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetIps(combinedResult.T5, subFactoryAction));
}
