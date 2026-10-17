// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RTBFabric;

public class InnerLinkRoutingRuleRuleConditionFactory(Action<Humidifier.RTBFabric.LinkRoutingRuleTypes.RuleCondition> factoryAction = null) : SubResourceFactory<Humidifier.RTBFabric.LinkRoutingRuleTypes.RuleCondition>
{

    internal InnerLinkRoutingRuleQueryStringKeyValuePairFactory QueryStringEqualsFactory { get; set; }

    protected override Humidifier.RTBFabric.LinkRoutingRuleTypes.RuleCondition Create()
    {
        var ruleConditionResult = CreateRuleCondition();
        factoryAction?.Invoke(ruleConditionResult);

        return ruleConditionResult;
    }

    private Humidifier.RTBFabric.LinkRoutingRuleTypes.RuleCondition CreateRuleCondition()
    {
        var ruleConditionResult = new Humidifier.RTBFabric.LinkRoutingRuleTypes.RuleCondition();

        return ruleConditionResult;
    }
    public override void CreateChildren(Humidifier.RTBFabric.LinkRoutingRuleTypes.RuleCondition result)
    {
        base.CreateChildren(result);

        result.QueryStringEquals ??= QueryStringEqualsFactory?.Build();
    }

} // End Of Class

public static class InnerLinkRoutingRuleRuleConditionFactoryExtensions
{
    public static CombinedResult<InnerLinkRoutingRuleRuleConditionFactory, InnerLinkRoutingRuleQueryStringKeyValuePairFactory> WithQueryStringEquals(this InnerLinkRoutingRuleRuleConditionFactory parentFactory, Action<Humidifier.RTBFabric.LinkRoutingRuleTypes.QueryStringKeyValuePair> subFactoryAction = null)
    {
        parentFactory.QueryStringEqualsFactory = new InnerLinkRoutingRuleQueryStringKeyValuePairFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.QueryStringEqualsFactory);
    }

    public static CombinedResult<InnerLinkRoutingRuleRuleConditionFactory, T1, InnerLinkRoutingRuleQueryStringKeyValuePairFactory> WithQueryStringEquals<T1>(this CombinedResult<InnerLinkRoutingRuleRuleConditionFactory, T1> combinedResult, Action<Humidifier.RTBFabric.LinkRoutingRuleTypes.QueryStringKeyValuePair> subFactoryAction = null) => new (combinedResult, combinedResult, WithQueryStringEquals(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLinkRoutingRuleRuleConditionFactory, InnerLinkRoutingRuleQueryStringKeyValuePairFactory> WithQueryStringEquals<T1>(this CombinedResult<T1, InnerLinkRoutingRuleRuleConditionFactory> combinedResult, Action<Humidifier.RTBFabric.LinkRoutingRuleTypes.QueryStringKeyValuePair> subFactoryAction = null) => new (combinedResult, combinedResult, WithQueryStringEquals(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerLinkRoutingRuleRuleConditionFactory, T1, T2, InnerLinkRoutingRuleQueryStringKeyValuePairFactory> WithQueryStringEquals<T1, T2>(this CombinedResult<InnerLinkRoutingRuleRuleConditionFactory, T1, T2> combinedResult, Action<Humidifier.RTBFabric.LinkRoutingRuleTypes.QueryStringKeyValuePair> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQueryStringEquals(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLinkRoutingRuleRuleConditionFactory, T2, InnerLinkRoutingRuleQueryStringKeyValuePairFactory> WithQueryStringEquals<T1, T2>(this CombinedResult<T1, InnerLinkRoutingRuleRuleConditionFactory, T2> combinedResult, Action<Humidifier.RTBFabric.LinkRoutingRuleTypes.QueryStringKeyValuePair> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQueryStringEquals(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLinkRoutingRuleRuleConditionFactory, InnerLinkRoutingRuleQueryStringKeyValuePairFactory> WithQueryStringEquals<T1, T2>(this CombinedResult<T1, T2, InnerLinkRoutingRuleRuleConditionFactory> combinedResult, Action<Humidifier.RTBFabric.LinkRoutingRuleTypes.QueryStringKeyValuePair> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQueryStringEquals(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerLinkRoutingRuleRuleConditionFactory, T1, T2, T3, InnerLinkRoutingRuleQueryStringKeyValuePairFactory> WithQueryStringEquals<T1, T2, T3>(this CombinedResult<InnerLinkRoutingRuleRuleConditionFactory, T1, T2, T3> combinedResult, Action<Humidifier.RTBFabric.LinkRoutingRuleTypes.QueryStringKeyValuePair> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQueryStringEquals(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLinkRoutingRuleRuleConditionFactory, T2, T3, InnerLinkRoutingRuleQueryStringKeyValuePairFactory> WithQueryStringEquals<T1, T2, T3>(this CombinedResult<T1, InnerLinkRoutingRuleRuleConditionFactory, T2, T3> combinedResult, Action<Humidifier.RTBFabric.LinkRoutingRuleTypes.QueryStringKeyValuePair> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQueryStringEquals(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLinkRoutingRuleRuleConditionFactory, T3, InnerLinkRoutingRuleQueryStringKeyValuePairFactory> WithQueryStringEquals<T1, T2, T3>(this CombinedResult<T1, T2, InnerLinkRoutingRuleRuleConditionFactory, T3> combinedResult, Action<Humidifier.RTBFabric.LinkRoutingRuleTypes.QueryStringKeyValuePair> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQueryStringEquals(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLinkRoutingRuleRuleConditionFactory, InnerLinkRoutingRuleQueryStringKeyValuePairFactory> WithQueryStringEquals<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLinkRoutingRuleRuleConditionFactory> combinedResult, Action<Humidifier.RTBFabric.LinkRoutingRuleTypes.QueryStringKeyValuePair> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQueryStringEquals(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerLinkRoutingRuleRuleConditionFactory, T1, T2, T3, T4, InnerLinkRoutingRuleQueryStringKeyValuePairFactory> WithQueryStringEquals<T1, T2, T3, T4>(this CombinedResult<InnerLinkRoutingRuleRuleConditionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkRoutingRuleTypes.QueryStringKeyValuePair> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQueryStringEquals(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLinkRoutingRuleRuleConditionFactory, T2, T3, T4, InnerLinkRoutingRuleQueryStringKeyValuePairFactory> WithQueryStringEquals<T1, T2, T3, T4>(this CombinedResult<T1, InnerLinkRoutingRuleRuleConditionFactory, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkRoutingRuleTypes.QueryStringKeyValuePair> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQueryStringEquals(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLinkRoutingRuleRuleConditionFactory, T3, T4, InnerLinkRoutingRuleQueryStringKeyValuePairFactory> WithQueryStringEquals<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLinkRoutingRuleRuleConditionFactory, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkRoutingRuleTypes.QueryStringKeyValuePair> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQueryStringEquals(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLinkRoutingRuleRuleConditionFactory, T4, InnerLinkRoutingRuleQueryStringKeyValuePairFactory> WithQueryStringEquals<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLinkRoutingRuleRuleConditionFactory, T4> combinedResult, Action<Humidifier.RTBFabric.LinkRoutingRuleTypes.QueryStringKeyValuePair> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQueryStringEquals(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerLinkRoutingRuleRuleConditionFactory, InnerLinkRoutingRuleQueryStringKeyValuePairFactory> WithQueryStringEquals<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLinkRoutingRuleRuleConditionFactory> combinedResult, Action<Humidifier.RTBFabric.LinkRoutingRuleTypes.QueryStringKeyValuePair> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQueryStringEquals(combinedResult.T5, subFactoryAction).T2);
}
