// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAF;

public class InnerWebACLActivatedRuleFactory(Action<Humidifier.WAF.WebACLTypes.ActivatedRule> factoryAction = null) : SubResourceFactory<Humidifier.WAF.WebACLTypes.ActivatedRule>
{

    internal InnerWebACLWafActionFactory ActionFactory { get; set; }

    protected override Humidifier.WAF.WebACLTypes.ActivatedRule Create()
    {
        var activatedRuleResult = CreateActivatedRule();
        factoryAction?.Invoke(activatedRuleResult);

        return activatedRuleResult;
    }

    private Humidifier.WAF.WebACLTypes.ActivatedRule CreateActivatedRule()
    {
        var activatedRuleResult = new Humidifier.WAF.WebACLTypes.ActivatedRule();

        return activatedRuleResult;
    }
    public override void CreateChildren(Humidifier.WAF.WebACLTypes.ActivatedRule result)
    {
        base.CreateChildren(result);

        result.Action ??= ActionFactory?.Build();
    }

} // End Of Class

public static class InnerWebACLActivatedRuleFactoryExtensions
{
    public static CombinedResult<InnerWebACLActivatedRuleFactory, InnerWebACLWafActionFactory> WithAction(this InnerWebACLActivatedRuleFactory parentFactory, Action<Humidifier.WAF.WebACLTypes.WafAction> subFactoryAction = null)
    {
        parentFactory.ActionFactory = new InnerWebACLWafActionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ActionFactory);
    }

    public static CombinedResult<InnerWebACLActivatedRuleFactory, T1, InnerWebACLWafActionFactory> WithAction<T1>(this CombinedResult<InnerWebACLActivatedRuleFactory, T1> combinedResult, Action<Humidifier.WAF.WebACLTypes.WafAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLActivatedRuleFactory, InnerWebACLWafActionFactory> WithAction<T1>(this CombinedResult<T1, InnerWebACLActivatedRuleFactory> combinedResult, Action<Humidifier.WAF.WebACLTypes.WafAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWebACLActivatedRuleFactory, T1, T2, InnerWebACLWafActionFactory> WithAction<T1, T2>(this CombinedResult<InnerWebACLActivatedRuleFactory, T1, T2> combinedResult, Action<Humidifier.WAF.WebACLTypes.WafAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLActivatedRuleFactory, T2, InnerWebACLWafActionFactory> WithAction<T1, T2>(this CombinedResult<T1, InnerWebACLActivatedRuleFactory, T2> combinedResult, Action<Humidifier.WAF.WebACLTypes.WafAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLActivatedRuleFactory, InnerWebACLWafActionFactory> WithAction<T1, T2>(this CombinedResult<T1, T2, InnerWebACLActivatedRuleFactory> combinedResult, Action<Humidifier.WAF.WebACLTypes.WafAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWebACLActivatedRuleFactory, T1, T2, T3, InnerWebACLWafActionFactory> WithAction<T1, T2, T3>(this CombinedResult<InnerWebACLActivatedRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAF.WebACLTypes.WafAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLActivatedRuleFactory, T2, T3, InnerWebACLWafActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, InnerWebACLActivatedRuleFactory, T2, T3> combinedResult, Action<Humidifier.WAF.WebACLTypes.WafAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLActivatedRuleFactory, T3, InnerWebACLWafActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebACLActivatedRuleFactory, T3> combinedResult, Action<Humidifier.WAF.WebACLTypes.WafAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLActivatedRuleFactory, InnerWebACLWafActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebACLActivatedRuleFactory> combinedResult, Action<Humidifier.WAF.WebACLTypes.WafAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWebACLActivatedRuleFactory, T1, T2, T3, T4, InnerWebACLWafActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<InnerWebACLActivatedRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAF.WebACLTypes.WafAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLActivatedRuleFactory, T2, T3, T4, InnerWebACLWafActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebACLActivatedRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAF.WebACLTypes.WafAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLActivatedRuleFactory, T3, T4, InnerWebACLWafActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebACLActivatedRuleFactory, T3, T4> combinedResult, Action<Humidifier.WAF.WebACLTypes.WafAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLActivatedRuleFactory, T4, InnerWebACLWafActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebACLActivatedRuleFactory, T4> combinedResult, Action<Humidifier.WAF.WebACLTypes.WafAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWebACLActivatedRuleFactory, InnerWebACLWafActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebACLActivatedRuleFactory> combinedResult, Action<Humidifier.WAF.WebACLTypes.WafAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T5, subFactoryAction));
}
