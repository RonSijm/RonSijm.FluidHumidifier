// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RTBFabric;

public class LinkRoutingRuleFactory(string resourceName = null, Action<Humidifier.RTBFabric.LinkRoutingRule> factoryAction = null) : ResourceFactory<Humidifier.RTBFabric.LinkRoutingRule>(resourceName)
{

    internal InnerLinkRoutingRuleRuleConditionFactory ConditionsFactory { get; set; }

    protected override Humidifier.RTBFabric.LinkRoutingRule Create()
    {
        var linkRoutingRuleResult = CreateLinkRoutingRule();
        factoryAction?.Invoke(linkRoutingRuleResult);

        return linkRoutingRuleResult;
    }

    private Humidifier.RTBFabric.LinkRoutingRule CreateLinkRoutingRule()
    {
        var linkRoutingRuleResult = new Humidifier.RTBFabric.LinkRoutingRule
        {
            GivenName = InputResourceName,
        };

        return linkRoutingRuleResult;
    }
    public override void CreateChildren(Humidifier.RTBFabric.LinkRoutingRule result)
    {
        base.CreateChildren(result);

        result.Conditions ??= ConditionsFactory?.Build();
    }

} // End Of Class

public static class LinkRoutingRuleFactoryExtensions
{
    public static CombinedResult<LinkRoutingRuleFactory, InnerLinkRoutingRuleRuleConditionFactory> WithConditions(this LinkRoutingRuleFactory parentFactory, Action<Humidifier.RTBFabric.LinkRoutingRuleTypes.RuleCondition> subFactoryAction = null)
    {
        parentFactory.ConditionsFactory = new InnerLinkRoutingRuleRuleConditionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConditionsFactory);
    }

    public static CombinedResult<LinkRoutingRuleFactory, T1, InnerLinkRoutingRuleRuleConditionFactory> WithConditions<T1>(this CombinedResult<LinkRoutingRuleFactory, T1> combinedResult, Action<Humidifier.RTBFabric.LinkRoutingRuleTypes.RuleCondition> subFactoryAction = null) => new (combinedResult, combinedResult, WithConditions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LinkRoutingRuleFactory, InnerLinkRoutingRuleRuleConditionFactory> WithConditions<T1>(this CombinedResult<T1, LinkRoutingRuleFactory> combinedResult, Action<Humidifier.RTBFabric.LinkRoutingRuleTypes.RuleCondition> subFactoryAction = null) => new (combinedResult, combinedResult, WithConditions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<LinkRoutingRuleFactory, T1, T2, InnerLinkRoutingRuleRuleConditionFactory> WithConditions<T1, T2>(this CombinedResult<LinkRoutingRuleFactory, T1, T2> combinedResult, Action<Humidifier.RTBFabric.LinkRoutingRuleTypes.RuleCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LinkRoutingRuleFactory, T2, InnerLinkRoutingRuleRuleConditionFactory> WithConditions<T1, T2>(this CombinedResult<T1, LinkRoutingRuleFactory, T2> combinedResult, Action<Humidifier.RTBFabric.LinkRoutingRuleTypes.RuleCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LinkRoutingRuleFactory, InnerLinkRoutingRuleRuleConditionFactory> WithConditions<T1, T2>(this CombinedResult<T1, T2, LinkRoutingRuleFactory> combinedResult, Action<Humidifier.RTBFabric.LinkRoutingRuleTypes.RuleCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<LinkRoutingRuleFactory, T1, T2, T3, InnerLinkRoutingRuleRuleConditionFactory> WithConditions<T1, T2, T3>(this CombinedResult<LinkRoutingRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.RTBFabric.LinkRoutingRuleTypes.RuleCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LinkRoutingRuleFactory, T2, T3, InnerLinkRoutingRuleRuleConditionFactory> WithConditions<T1, T2, T3>(this CombinedResult<T1, LinkRoutingRuleFactory, T2, T3> combinedResult, Action<Humidifier.RTBFabric.LinkRoutingRuleTypes.RuleCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LinkRoutingRuleFactory, T3, InnerLinkRoutingRuleRuleConditionFactory> WithConditions<T1, T2, T3>(this CombinedResult<T1, T2, LinkRoutingRuleFactory, T3> combinedResult, Action<Humidifier.RTBFabric.LinkRoutingRuleTypes.RuleCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LinkRoutingRuleFactory, InnerLinkRoutingRuleRuleConditionFactory> WithConditions<T1, T2, T3>(this CombinedResult<T1, T2, T3, LinkRoutingRuleFactory> combinedResult, Action<Humidifier.RTBFabric.LinkRoutingRuleTypes.RuleCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<LinkRoutingRuleFactory, T1, T2, T3, T4, InnerLinkRoutingRuleRuleConditionFactory> WithConditions<T1, T2, T3, T4>(this CombinedResult<LinkRoutingRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkRoutingRuleTypes.RuleCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LinkRoutingRuleFactory, T2, T3, T4, InnerLinkRoutingRuleRuleConditionFactory> WithConditions<T1, T2, T3, T4>(this CombinedResult<T1, LinkRoutingRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkRoutingRuleTypes.RuleCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LinkRoutingRuleFactory, T3, T4, InnerLinkRoutingRuleRuleConditionFactory> WithConditions<T1, T2, T3, T4>(this CombinedResult<T1, T2, LinkRoutingRuleFactory, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkRoutingRuleTypes.RuleCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LinkRoutingRuleFactory, T4, InnerLinkRoutingRuleRuleConditionFactory> WithConditions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LinkRoutingRuleFactory, T4> combinedResult, Action<Humidifier.RTBFabric.LinkRoutingRuleTypes.RuleCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, LinkRoutingRuleFactory, InnerLinkRoutingRuleRuleConditionFactory> WithConditions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LinkRoutingRuleFactory> combinedResult, Action<Humidifier.RTBFabric.LinkRoutingRuleTypes.RuleCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T5, subFactoryAction).T2);
}
