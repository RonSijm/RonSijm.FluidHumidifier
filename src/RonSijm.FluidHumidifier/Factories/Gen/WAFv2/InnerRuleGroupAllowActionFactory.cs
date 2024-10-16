// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupAllowActionFactory(Action<Humidifier.WAFv2.RuleGroupTypes.AllowAction> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.AllowAction>
{

    internal InnerRuleGroupCustomRequestHandlingFactory CustomRequestHandlingFactory { get; set; }

    protected override Humidifier.WAFv2.RuleGroupTypes.AllowAction Create()
    {
        var allowActionResult = CreateAllowAction();
        factoryAction?.Invoke(allowActionResult);

        return allowActionResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.AllowAction CreateAllowAction()
    {
        var allowActionResult = new Humidifier.WAFv2.RuleGroupTypes.AllowAction();

        return allowActionResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.RuleGroupTypes.AllowAction result)
    {
        base.CreateChildren(result);

        result.CustomRequestHandling ??= CustomRequestHandlingFactory?.Build();
    }

} // End Of Class

public static class InnerRuleGroupAllowActionFactoryExtensions
{
    public static CombinedResult<InnerRuleGroupAllowActionFactory, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling(this InnerRuleGroupAllowActionFactory parentFactory, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null)
    {
        parentFactory.CustomRequestHandlingFactory = new InnerRuleGroupCustomRequestHandlingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CustomRequestHandlingFactory);
    }

    public static CombinedResult<InnerRuleGroupAllowActionFactory, T1, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1>(this CombinedResult<InnerRuleGroupAllowActionFactory, T1> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupAllowActionFactory, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1>(this CombinedResult<T1, InnerRuleGroupAllowActionFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRuleGroupAllowActionFactory, T1, T2, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2>(this CombinedResult<InnerRuleGroupAllowActionFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupAllowActionFactory, T2, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2>(this CombinedResult<T1, InnerRuleGroupAllowActionFactory, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupAllowActionFactory, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2>(this CombinedResult<T1, T2, InnerRuleGroupAllowActionFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRuleGroupAllowActionFactory, T1, T2, T3, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3>(this CombinedResult<InnerRuleGroupAllowActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupAllowActionFactory, T2, T3, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3>(this CombinedResult<T1, InnerRuleGroupAllowActionFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupAllowActionFactory, T3, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3>(this CombinedResult<T1, T2, InnerRuleGroupAllowActionFactory, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupAllowActionFactory, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRuleGroupAllowActionFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRuleGroupAllowActionFactory, T1, T2, T3, T4, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<InnerRuleGroupAllowActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupAllowActionFactory, T2, T3, T4, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<T1, InnerRuleGroupAllowActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupAllowActionFactory, T3, T4, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRuleGroupAllowActionFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupAllowActionFactory, T4, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRuleGroupAllowActionFactory, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRuleGroupAllowActionFactory, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRuleGroupAllowActionFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T5, subFactoryAction));
}
