// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupCountActionFactory(Action<Humidifier.WAFv2.RuleGroupTypes.CountAction> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.CountAction>
{

    internal InnerRuleGroupCustomRequestHandlingFactory CustomRequestHandlingFactory { get; set; }

    protected override Humidifier.WAFv2.RuleGroupTypes.CountAction Create()
    {
        var countActionResult = CreateCountAction();
        factoryAction?.Invoke(countActionResult);

        return countActionResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.CountAction CreateCountAction()
    {
        var countActionResult = new Humidifier.WAFv2.RuleGroupTypes.CountAction();

        return countActionResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.RuleGroupTypes.CountAction result)
    {
        base.CreateChildren(result);

        result.CustomRequestHandling ??= CustomRequestHandlingFactory?.Build();
    }

} // End Of Class

public static class InnerRuleGroupCountActionFactoryExtensions
{
    public static CombinedResult<InnerRuleGroupCountActionFactory, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling(this InnerRuleGroupCountActionFactory parentFactory, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null)
    {
        parentFactory.CustomRequestHandlingFactory = new InnerRuleGroupCustomRequestHandlingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CustomRequestHandlingFactory);
    }

    public static CombinedResult<InnerRuleGroupCountActionFactory, T1, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1>(this CombinedResult<InnerRuleGroupCountActionFactory, T1> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupCountActionFactory, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1>(this CombinedResult<T1, InnerRuleGroupCountActionFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRuleGroupCountActionFactory, T1, T2, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2>(this CombinedResult<InnerRuleGroupCountActionFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupCountActionFactory, T2, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2>(this CombinedResult<T1, InnerRuleGroupCountActionFactory, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupCountActionFactory, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2>(this CombinedResult<T1, T2, InnerRuleGroupCountActionFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRuleGroupCountActionFactory, T1, T2, T3, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3>(this CombinedResult<InnerRuleGroupCountActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupCountActionFactory, T2, T3, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3>(this CombinedResult<T1, InnerRuleGroupCountActionFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupCountActionFactory, T3, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3>(this CombinedResult<T1, T2, InnerRuleGroupCountActionFactory, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupCountActionFactory, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRuleGroupCountActionFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRuleGroupCountActionFactory, T1, T2, T3, T4, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<InnerRuleGroupCountActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupCountActionFactory, T2, T3, T4, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<T1, InnerRuleGroupCountActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupCountActionFactory, T3, T4, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRuleGroupCountActionFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupCountActionFactory, T4, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRuleGroupCountActionFactory, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRuleGroupCountActionFactory, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRuleGroupCountActionFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T5, subFactoryAction));
}
