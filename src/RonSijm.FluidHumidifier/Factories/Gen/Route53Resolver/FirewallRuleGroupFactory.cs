// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53Resolver;

public class FirewallRuleGroupFactory(string resourceName = null, Action<Humidifier.Route53Resolver.FirewallRuleGroup> factoryAction = null) : ResourceFactory<Humidifier.Route53Resolver.FirewallRuleGroup>(resourceName)
{

    internal List<InnerFirewallRuleGroupFirewallRuleFactory> FirewallRulesFactories { get; set; } = [];

    protected override Humidifier.Route53Resolver.FirewallRuleGroup Create()
    {
        var firewallRuleGroupResult = CreateFirewallRuleGroup();
        factoryAction?.Invoke(firewallRuleGroupResult);

        return firewallRuleGroupResult;
    }

    private Humidifier.Route53Resolver.FirewallRuleGroup CreateFirewallRuleGroup()
    {
        var firewallRuleGroupResult = new Humidifier.Route53Resolver.FirewallRuleGroup
        {
            GivenName = InputResourceName,
        };

        return firewallRuleGroupResult;
    }
    public override void CreateChildren(Humidifier.Route53Resolver.FirewallRuleGroup result)
    {
        base.CreateChildren(result);

        result.FirewallRules = FirewallRulesFactories.Any() ? FirewallRulesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class FirewallRuleGroupFactoryExtensions
{
    public static CombinedResult<FirewallRuleGroupFactory, InnerFirewallRuleGroupFirewallRuleFactory> WithFirewallRules(this FirewallRuleGroupFactory parentFactory, Action<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRule> subFactoryAction = null)
    {
        var factory = new InnerFirewallRuleGroupFirewallRuleFactory(subFactoryAction);
        parentFactory.FirewallRulesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<FirewallRuleGroupFactory, T1, InnerFirewallRuleGroupFirewallRuleFactory> WithFirewallRules<T1>(this CombinedResult<FirewallRuleGroupFactory, T1> combinedResult, Action<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithFirewallRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FirewallRuleGroupFactory, InnerFirewallRuleGroupFirewallRuleFactory> WithFirewallRules<T1>(this CombinedResult<T1, FirewallRuleGroupFactory> combinedResult, Action<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithFirewallRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FirewallRuleGroupFactory, T1, T2, InnerFirewallRuleGroupFirewallRuleFactory> WithFirewallRules<T1, T2>(this CombinedResult<FirewallRuleGroupFactory, T1, T2> combinedResult, Action<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFirewallRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FirewallRuleGroupFactory, T2, InnerFirewallRuleGroupFirewallRuleFactory> WithFirewallRules<T1, T2>(this CombinedResult<T1, FirewallRuleGroupFactory, T2> combinedResult, Action<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFirewallRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FirewallRuleGroupFactory, InnerFirewallRuleGroupFirewallRuleFactory> WithFirewallRules<T1, T2>(this CombinedResult<T1, T2, FirewallRuleGroupFactory> combinedResult, Action<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFirewallRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FirewallRuleGroupFactory, T1, T2, T3, InnerFirewallRuleGroupFirewallRuleFactory> WithFirewallRules<T1, T2, T3>(this CombinedResult<FirewallRuleGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFirewallRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FirewallRuleGroupFactory, T2, T3, InnerFirewallRuleGroupFirewallRuleFactory> WithFirewallRules<T1, T2, T3>(this CombinedResult<T1, FirewallRuleGroupFactory, T2, T3> combinedResult, Action<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFirewallRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FirewallRuleGroupFactory, T3, InnerFirewallRuleGroupFirewallRuleFactory> WithFirewallRules<T1, T2, T3>(this CombinedResult<T1, T2, FirewallRuleGroupFactory, T3> combinedResult, Action<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFirewallRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FirewallRuleGroupFactory, InnerFirewallRuleGroupFirewallRuleFactory> WithFirewallRules<T1, T2, T3>(this CombinedResult<T1, T2, T3, FirewallRuleGroupFactory> combinedResult, Action<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFirewallRules(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FirewallRuleGroupFactory, T1, T2, T3, T4, InnerFirewallRuleGroupFirewallRuleFactory> WithFirewallRules<T1, T2, T3, T4>(this CombinedResult<FirewallRuleGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFirewallRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FirewallRuleGroupFactory, T2, T3, T4, InnerFirewallRuleGroupFirewallRuleFactory> WithFirewallRules<T1, T2, T3, T4>(this CombinedResult<T1, FirewallRuleGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFirewallRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FirewallRuleGroupFactory, T3, T4, InnerFirewallRuleGroupFirewallRuleFactory> WithFirewallRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, FirewallRuleGroupFactory, T3, T4> combinedResult, Action<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFirewallRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FirewallRuleGroupFactory, T4, InnerFirewallRuleGroupFirewallRuleFactory> WithFirewallRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FirewallRuleGroupFactory, T4> combinedResult, Action<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFirewallRules(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FirewallRuleGroupFactory, InnerFirewallRuleGroupFirewallRuleFactory> WithFirewallRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FirewallRuleGroupFactory> combinedResult, Action<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFirewallRules(combinedResult.T5, subFactoryAction));
}
