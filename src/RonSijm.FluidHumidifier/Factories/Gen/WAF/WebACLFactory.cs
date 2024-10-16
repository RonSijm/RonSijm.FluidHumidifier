// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAF;

public class WebACLFactory(string resourceName = null, Action<Humidifier.WAF.WebACL> factoryAction = null) : ResourceFactory<Humidifier.WAF.WebACL>(resourceName)
{

    internal List<InnerWebACLActivatedRuleFactory> RulesFactories { get; set; } = [];

    internal InnerWebACLWafActionFactory DefaultActionFactory { get; set; }

    protected override Humidifier.WAF.WebACL Create()
    {
        var webACLResult = CreateWebACL();
        factoryAction?.Invoke(webACLResult);

        return webACLResult;
    }

    private Humidifier.WAF.WebACL CreateWebACL()
    {
        var webACLResult = new Humidifier.WAF.WebACL
        {
            GivenName = InputResourceName,
        };

        return webACLResult;
    }
    public override void CreateChildren(Humidifier.WAF.WebACL result)
    {
        base.CreateChildren(result);

        result.Rules = RulesFactories.Any() ? RulesFactories.Select(x => x.Build()).ToList() : null;
        result.DefaultAction ??= DefaultActionFactory?.Build();
    }

} // End Of Class

public static class WebACLFactoryExtensions
{
    public static CombinedResult<WebACLFactory, InnerWebACLActivatedRuleFactory> WithRules(this WebACLFactory parentFactory, Action<Humidifier.WAF.WebACLTypes.ActivatedRule> subFactoryAction = null)
    {
        var factory = new InnerWebACLActivatedRuleFactory(subFactoryAction);
        parentFactory.RulesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<WebACLFactory, InnerWebACLWafActionFactory> WithDefaultAction(this WebACLFactory parentFactory, Action<Humidifier.WAF.WebACLTypes.WafAction> subFactoryAction = null)
    {
        parentFactory.DefaultActionFactory = new InnerWebACLWafActionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefaultActionFactory);
    }

    public static CombinedResult<WebACLFactory, T1, InnerWebACLActivatedRuleFactory> WithRules<T1>(this CombinedResult<WebACLFactory, T1> combinedResult, Action<Humidifier.WAF.WebACLTypes.ActivatedRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WebACLFactory, InnerWebACLActivatedRuleFactory> WithRules<T1>(this CombinedResult<T1, WebACLFactory> combinedResult, Action<Humidifier.WAF.WebACLTypes.ActivatedRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<WebACLFactory, T1, T2, InnerWebACLActivatedRuleFactory> WithRules<T1, T2>(this CombinedResult<WebACLFactory, T1, T2> combinedResult, Action<Humidifier.WAF.WebACLTypes.ActivatedRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WebACLFactory, T2, InnerWebACLActivatedRuleFactory> WithRules<T1, T2>(this CombinedResult<T1, WebACLFactory, T2> combinedResult, Action<Humidifier.WAF.WebACLTypes.ActivatedRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WebACLFactory, InnerWebACLActivatedRuleFactory> WithRules<T1, T2>(this CombinedResult<T1, T2, WebACLFactory> combinedResult, Action<Humidifier.WAF.WebACLTypes.ActivatedRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<WebACLFactory, T1, T2, T3, InnerWebACLActivatedRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<WebACLFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAF.WebACLTypes.ActivatedRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WebACLFactory, T2, T3, InnerWebACLActivatedRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, WebACLFactory, T2, T3> combinedResult, Action<Humidifier.WAF.WebACLTypes.ActivatedRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WebACLFactory, T3, InnerWebACLActivatedRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, T2, WebACLFactory, T3> combinedResult, Action<Humidifier.WAF.WebACLTypes.ActivatedRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WebACLFactory, InnerWebACLActivatedRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, T2, T3, WebACLFactory> combinedResult, Action<Humidifier.WAF.WebACLTypes.ActivatedRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T4, subFactoryAction));
    public static CombinedResult<WebACLFactory, T1, T2, T3, T4, InnerWebACLActivatedRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<WebACLFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAF.WebACLTypes.ActivatedRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WebACLFactory, T2, T3, T4, InnerWebACLActivatedRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, WebACLFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAF.WebACLTypes.ActivatedRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WebACLFactory, T3, T4, InnerWebACLActivatedRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, WebACLFactory, T3, T4> combinedResult, Action<Humidifier.WAF.WebACLTypes.ActivatedRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WebACLFactory, T4, InnerWebACLActivatedRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WebACLFactory, T4> combinedResult, Action<Humidifier.WAF.WebACLTypes.ActivatedRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, WebACLFactory, InnerWebACLActivatedRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WebACLFactory> combinedResult, Action<Humidifier.WAF.WebACLTypes.ActivatedRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T5, subFactoryAction));
    public static CombinedResult<WebACLFactory, T1, InnerWebACLWafActionFactory> WithDefaultAction<T1>(this CombinedResult<WebACLFactory, T1> combinedResult, Action<Humidifier.WAF.WebACLTypes.WafAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WebACLFactory, InnerWebACLWafActionFactory> WithDefaultAction<T1>(this CombinedResult<T1, WebACLFactory> combinedResult, Action<Humidifier.WAF.WebACLTypes.WafAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<WebACLFactory, T1, T2, InnerWebACLWafActionFactory> WithDefaultAction<T1, T2>(this CombinedResult<WebACLFactory, T1, T2> combinedResult, Action<Humidifier.WAF.WebACLTypes.WafAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WebACLFactory, T2, InnerWebACLWafActionFactory> WithDefaultAction<T1, T2>(this CombinedResult<T1, WebACLFactory, T2> combinedResult, Action<Humidifier.WAF.WebACLTypes.WafAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WebACLFactory, InnerWebACLWafActionFactory> WithDefaultAction<T1, T2>(this CombinedResult<T1, T2, WebACLFactory> combinedResult, Action<Humidifier.WAF.WebACLTypes.WafAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<WebACLFactory, T1, T2, T3, InnerWebACLWafActionFactory> WithDefaultAction<T1, T2, T3>(this CombinedResult<WebACLFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAF.WebACLTypes.WafAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WebACLFactory, T2, T3, InnerWebACLWafActionFactory> WithDefaultAction<T1, T2, T3>(this CombinedResult<T1, WebACLFactory, T2, T3> combinedResult, Action<Humidifier.WAF.WebACLTypes.WafAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WebACLFactory, T3, InnerWebACLWafActionFactory> WithDefaultAction<T1, T2, T3>(this CombinedResult<T1, T2, WebACLFactory, T3> combinedResult, Action<Humidifier.WAF.WebACLTypes.WafAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WebACLFactory, InnerWebACLWafActionFactory> WithDefaultAction<T1, T2, T3>(this CombinedResult<T1, T2, T3, WebACLFactory> combinedResult, Action<Humidifier.WAF.WebACLTypes.WafAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<WebACLFactory, T1, T2, T3, T4, InnerWebACLWafActionFactory> WithDefaultAction<T1, T2, T3, T4>(this CombinedResult<WebACLFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAF.WebACLTypes.WafAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WebACLFactory, T2, T3, T4, InnerWebACLWafActionFactory> WithDefaultAction<T1, T2, T3, T4>(this CombinedResult<T1, WebACLFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAF.WebACLTypes.WafAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WebACLFactory, T3, T4, InnerWebACLWafActionFactory> WithDefaultAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, WebACLFactory, T3, T4> combinedResult, Action<Humidifier.WAF.WebACLTypes.WafAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WebACLFactory, T4, InnerWebACLWafActionFactory> WithDefaultAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WebACLFactory, T4> combinedResult, Action<Humidifier.WAF.WebACLTypes.WafAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, WebACLFactory, InnerWebACLWafActionFactory> WithDefaultAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WebACLFactory> combinedResult, Action<Humidifier.WAF.WebACLTypes.WafAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultAction(combinedResult.T5, subFactoryAction));
}
