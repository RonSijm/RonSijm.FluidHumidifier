// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFRegional;

public class InnerWebACLRuleFactory(Action<Humidifier.WAFRegional.WebACLTypes.Rule> factoryAction = null) : SubResourceFactory<Humidifier.WAFRegional.WebACLTypes.Rule>
{

    internal InnerWebACLActionFactory ActionFactory { get; set; }

    protected override Humidifier.WAFRegional.WebACLTypes.Rule Create()
    {
        var ruleResult = CreateRule();
        factoryAction?.Invoke(ruleResult);

        return ruleResult;
    }

    private Humidifier.WAFRegional.WebACLTypes.Rule CreateRule()
    {
        var ruleResult = new Humidifier.WAFRegional.WebACLTypes.Rule();

        return ruleResult;
    }
    public override void CreateChildren(Humidifier.WAFRegional.WebACLTypes.Rule result)
    {
        base.CreateChildren(result);

        result.Action ??= ActionFactory?.Build();
    }

} // End Of Class

public static class InnerWebACLRuleFactoryExtensions
{
    public static CombinedResult<InnerWebACLRuleFactory, InnerWebACLActionFactory> WithAction(this InnerWebACLRuleFactory parentFactory, Action<Humidifier.WAFRegional.WebACLTypes.Action> subFactoryAction = null)
    {
        parentFactory.ActionFactory = new InnerWebACLActionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ActionFactory);
    }

    public static CombinedResult<InnerWebACLRuleFactory, T1, InnerWebACLActionFactory> WithAction<T1>(this CombinedResult<InnerWebACLRuleFactory, T1> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRuleFactory, InnerWebACLActionFactory> WithAction<T1>(this CombinedResult<T1, InnerWebACLRuleFactory> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWebACLRuleFactory, T1, T2, InnerWebACLActionFactory> WithAction<T1, T2>(this CombinedResult<InnerWebACLRuleFactory, T1, T2> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRuleFactory, T2, InnerWebACLActionFactory> WithAction<T1, T2>(this CombinedResult<T1, InnerWebACLRuleFactory, T2> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLRuleFactory, InnerWebACLActionFactory> WithAction<T1, T2>(this CombinedResult<T1, T2, InnerWebACLRuleFactory> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWebACLRuleFactory, T1, T2, T3, InnerWebACLActionFactory> WithAction<T1, T2, T3>(this CombinedResult<InnerWebACLRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRuleFactory, T2, T3, InnerWebACLActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, InnerWebACLRuleFactory, T2, T3> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLRuleFactory, T3, InnerWebACLActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebACLRuleFactory, T3> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLRuleFactory, InnerWebACLActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebACLRuleFactory> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWebACLRuleFactory, T1, T2, T3, T4, InnerWebACLActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<InnerWebACLRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRuleFactory, T2, T3, T4, InnerWebACLActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebACLRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLRuleFactory, T3, T4, InnerWebACLActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebACLRuleFactory, T3, T4> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLRuleFactory, T4, InnerWebACLActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebACLRuleFactory, T4> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWebACLRuleFactory, InnerWebACLActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebACLRuleFactory> combinedResult, Action<Humidifier.WAFRegional.WebACLTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T5, subFactoryAction));
}
