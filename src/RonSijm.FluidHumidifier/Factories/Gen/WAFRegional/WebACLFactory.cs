// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFRegional;

public class WebACLFactory(string resourceName = null, Action<Humidifier.WAFRegional.WebACL> factoryAction = null) : ResourceFactory<Humidifier.WAFRegional.WebACL>(resourceName)
{

    internal List<InnerWebACLRuleFactory> RulesFactories { get; set; } = [];

    internal InnerWebACLActionFactory DefaultActionFactory { get; set; }

    protected override Humidifier.WAFRegional.WebACL Create()
    {
        var webACLResult = CreateWebACL();
        factoryAction?.Invoke(webACLResult);

        return webACLResult;
    }

    private Humidifier.WAFRegional.WebACL CreateWebACL()
    {
        var webACLResult = new Humidifier.WAFRegional.WebACL
        {
            GivenName = InputResourceName,
        };

        return webACLResult;
    }
    public override void CreateChildren(Humidifier.WAFRegional.WebACL result)
    {
        base.CreateChildren(result);

        result.Rules = RulesFactories.Any() ? RulesFactories.Select(x => x.Build()).ToList() : null;
        result.DefaultAction ??= DefaultActionFactory?.Build();
    }

} // End Of Class

public static class WebACLFactoryExtensions
{
    public static CombinedResult<WebACLFactory, InnerWebACLRuleFactory> WithRules(this WebACLFactory parentFactory, Action<Humidifier.WAFRegional.WebACLTypes.Rule> subFactoryAction = null)
    {
        var factory = new InnerWebACLRuleFactory(subFactoryAction);
        parentFactory.RulesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<WebACLFactory, InnerWebACLActionFactory> WithDefaultAction(this WebACLFactory parentFactory, Action<Humidifier.WAFRegional.WebACLTypes.Action> subFactoryAction = null)
    {
        parentFactory.DefaultActionFactory = new InnerWebACLActionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefaultActionFactory);
    }

    public static CombinedResult<WebACLFactory, T1, InnerWebACLRuleFactory> WithRules<T1>(this CombinedResult<WebACLFactory, T1> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WebACLFactory, InnerWebACLRuleFactory> WithRules<T1>(this CombinedResult<T1, WebACLFactory> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<WebACLFactory, T1, T2, InnerWebACLRuleFactory> WithRules<T1, T2>(this CombinedResult<WebACLFactory, T1, T2> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WebACLFactory, T2, InnerWebACLRuleFactory> WithRules<T1, T2>(this CombinedResult<T1, WebACLFactory, T2> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WebACLFactory, InnerWebACLRuleFactory> WithRules<T1, T2>(this CombinedResult<T1, T2, WebACLFactory> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<WebACLFactory, T1, T2, T3, InnerWebACLRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<WebACLFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WebACLFactory, T2, T3, InnerWebACLRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, WebACLFactory, T2, T3> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WebACLFactory, T3, InnerWebACLRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, T2, WebACLFactory, T3> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WebACLFactory, InnerWebACLRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, T2, T3, WebACLFactory> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T4, subFactoryAction));
    public static CombinedResult<WebACLFactory, T1, T2, T3, T4, InnerWebACLRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<WebACLFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WebACLFactory, T2, T3, T4, InnerWebACLRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, WebACLFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WebACLFactory, T3, T4, InnerWebACLRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, WebACLFactory, T3, T4> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WebACLFactory, T4, InnerWebACLRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WebACLFactory, T4> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, WebACLFactory, InnerWebACLRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WebACLFactory> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T5, subFactoryAction));
    public static CombinedResult<WebACLFactory, T1, InnerWebACLActionFactory> WithDefaultAction<T1>(this CombinedResult<WebACLFactory, T1> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WebACLFactory, InnerWebACLActionFactory> WithDefaultAction<T1>(this CombinedResult<T1, WebACLFactory> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<WebACLFactory, T1, T2, InnerWebACLActionFactory> WithDefaultAction<T1, T2>(this CombinedResult<WebACLFactory, T1, T2> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WebACLFactory, T2, InnerWebACLActionFactory> WithDefaultAction<T1, T2>(this CombinedResult<T1, WebACLFactory, T2> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WebACLFactory, InnerWebACLActionFactory> WithDefaultAction<T1, T2>(this CombinedResult<T1, T2, WebACLFactory> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<WebACLFactory, T1, T2, T3, InnerWebACLActionFactory> WithDefaultAction<T1, T2, T3>(this CombinedResult<WebACLFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WebACLFactory, T2, T3, InnerWebACLActionFactory> WithDefaultAction<T1, T2, T3>(this CombinedResult<T1, WebACLFactory, T2, T3> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WebACLFactory, T3, InnerWebACLActionFactory> WithDefaultAction<T1, T2, T3>(this CombinedResult<T1, T2, WebACLFactory, T3> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WebACLFactory, InnerWebACLActionFactory> WithDefaultAction<T1, T2, T3>(this CombinedResult<T1, T2, T3, WebACLFactory> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<WebACLFactory, T1, T2, T3, T4, InnerWebACLActionFactory> WithDefaultAction<T1, T2, T3, T4>(this CombinedResult<WebACLFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WebACLFactory, T2, T3, T4, InnerWebACLActionFactory> WithDefaultAction<T1, T2, T3, T4>(this CombinedResult<T1, WebACLFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WebACLFactory, T3, T4, InnerWebACLActionFactory> WithDefaultAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, WebACLFactory, T3, T4> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WebACLFactory, T4, InnerWebACLActionFactory> WithDefaultAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WebACLFactory, T4> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, WebACLFactory, InnerWebACLActionFactory> WithDefaultAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WebACLFactory> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultAction(combinedResult.T5, subFactoryAction));
}
