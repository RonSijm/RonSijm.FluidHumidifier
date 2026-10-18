// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53Resolver;

public class InnerFirewallRuleGroupFirewallRuleFactory(Action<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRule> factoryAction = null) : SubResourceFactory<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRule>
{

    internal InnerFirewallRuleGroupFirewallRuleTypeFactory FirewallRuleTypeFactory { get; set; }

    protected override Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRule Create()
    {
        var firewallRuleResult = CreateFirewallRule();
        factoryAction?.Invoke(firewallRuleResult);

        return firewallRuleResult;
    }

    private Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRule CreateFirewallRule()
    {
        var firewallRuleResult = new Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRule();

        return firewallRuleResult;
    }
    public override void CreateChildren(Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRule result)
    {
        base.CreateChildren(result);

        result.FirewallRuleType ??= FirewallRuleTypeFactory?.Build();
    }

} // End Of Class

public static class InnerFirewallRuleGroupFirewallRuleFactoryExtensions
{
    public static CombinedResult<InnerFirewallRuleGroupFirewallRuleFactory, InnerFirewallRuleGroupFirewallRuleTypeFactory> WithFirewallRuleType(this InnerFirewallRuleGroupFirewallRuleFactory parentFactory, Action<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRuleType> subFactoryAction = null)
    {
        parentFactory.FirewallRuleTypeFactory = new InnerFirewallRuleGroupFirewallRuleTypeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FirewallRuleTypeFactory);
    }

    public static CombinedResult<InnerFirewallRuleGroupFirewallRuleFactory, T1, InnerFirewallRuleGroupFirewallRuleTypeFactory> WithFirewallRuleType<T1>(this CombinedResult<InnerFirewallRuleGroupFirewallRuleFactory, T1> combinedResult, Action<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRuleType> subFactoryAction = null) => new (combinedResult, combinedResult, WithFirewallRuleType(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFirewallRuleGroupFirewallRuleFactory, InnerFirewallRuleGroupFirewallRuleTypeFactory> WithFirewallRuleType<T1>(this CombinedResult<T1, InnerFirewallRuleGroupFirewallRuleFactory> combinedResult, Action<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRuleType> subFactoryAction = null) => new (combinedResult, combinedResult, WithFirewallRuleType(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerFirewallRuleGroupFirewallRuleFactory, T1, T2, InnerFirewallRuleGroupFirewallRuleTypeFactory> WithFirewallRuleType<T1, T2>(this CombinedResult<InnerFirewallRuleGroupFirewallRuleFactory, T1, T2> combinedResult, Action<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRuleType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFirewallRuleType(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFirewallRuleGroupFirewallRuleFactory, T2, InnerFirewallRuleGroupFirewallRuleTypeFactory> WithFirewallRuleType<T1, T2>(this CombinedResult<T1, InnerFirewallRuleGroupFirewallRuleFactory, T2> combinedResult, Action<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRuleType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFirewallRuleType(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFirewallRuleGroupFirewallRuleFactory, InnerFirewallRuleGroupFirewallRuleTypeFactory> WithFirewallRuleType<T1, T2>(this CombinedResult<T1, T2, InnerFirewallRuleGroupFirewallRuleFactory> combinedResult, Action<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRuleType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFirewallRuleType(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerFirewallRuleGroupFirewallRuleFactory, T1, T2, T3, InnerFirewallRuleGroupFirewallRuleTypeFactory> WithFirewallRuleType<T1, T2, T3>(this CombinedResult<InnerFirewallRuleGroupFirewallRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRuleType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFirewallRuleType(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFirewallRuleGroupFirewallRuleFactory, T2, T3, InnerFirewallRuleGroupFirewallRuleTypeFactory> WithFirewallRuleType<T1, T2, T3>(this CombinedResult<T1, InnerFirewallRuleGroupFirewallRuleFactory, T2, T3> combinedResult, Action<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRuleType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFirewallRuleType(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFirewallRuleGroupFirewallRuleFactory, T3, InnerFirewallRuleGroupFirewallRuleTypeFactory> WithFirewallRuleType<T1, T2, T3>(this CombinedResult<T1, T2, InnerFirewallRuleGroupFirewallRuleFactory, T3> combinedResult, Action<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRuleType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFirewallRuleType(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerFirewallRuleGroupFirewallRuleFactory, InnerFirewallRuleGroupFirewallRuleTypeFactory> WithFirewallRuleType<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFirewallRuleGroupFirewallRuleFactory> combinedResult, Action<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRuleType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFirewallRuleType(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerFirewallRuleGroupFirewallRuleFactory, T1, T2, T3, T4, InnerFirewallRuleGroupFirewallRuleTypeFactory> WithFirewallRuleType<T1, T2, T3, T4>(this CombinedResult<InnerFirewallRuleGroupFirewallRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRuleType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFirewallRuleType(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFirewallRuleGroupFirewallRuleFactory, T2, T3, T4, InnerFirewallRuleGroupFirewallRuleTypeFactory> WithFirewallRuleType<T1, T2, T3, T4>(this CombinedResult<T1, InnerFirewallRuleGroupFirewallRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRuleType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFirewallRuleType(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFirewallRuleGroupFirewallRuleFactory, T3, T4, InnerFirewallRuleGroupFirewallRuleTypeFactory> WithFirewallRuleType<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFirewallRuleGroupFirewallRuleFactory, T3, T4> combinedResult, Action<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRuleType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFirewallRuleType(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerFirewallRuleGroupFirewallRuleFactory, T4, InnerFirewallRuleGroupFirewallRuleTypeFactory> WithFirewallRuleType<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFirewallRuleGroupFirewallRuleFactory, T4> combinedResult, Action<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRuleType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFirewallRuleType(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerFirewallRuleGroupFirewallRuleFactory, InnerFirewallRuleGroupFirewallRuleTypeFactory> WithFirewallRuleType<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFirewallRuleGroupFirewallRuleFactory> combinedResult, Action<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRuleType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFirewallRuleType(combinedResult.T5, subFactoryAction).T2);
}
