// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupCaptchaActionFactory(Action<Humidifier.WAFv2.RuleGroupTypes.CaptchaAction> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.CaptchaAction>
{

    internal InnerRuleGroupCustomRequestHandlingFactory CustomRequestHandlingFactory { get; set; }

    protected override Humidifier.WAFv2.RuleGroupTypes.CaptchaAction Create()
    {
        var captchaActionResult = CreateCaptchaAction();
        factoryAction?.Invoke(captchaActionResult);

        return captchaActionResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.CaptchaAction CreateCaptchaAction()
    {
        var captchaActionResult = new Humidifier.WAFv2.RuleGroupTypes.CaptchaAction();

        return captchaActionResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.RuleGroupTypes.CaptchaAction result)
    {
        base.CreateChildren(result);

        result.CustomRequestHandling ??= CustomRequestHandlingFactory?.Build();
    }

} // End Of Class

public static class InnerRuleGroupCaptchaActionFactoryExtensions
{
    public static CombinedResult<InnerRuleGroupCaptchaActionFactory, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling(this InnerRuleGroupCaptchaActionFactory parentFactory, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null)
    {
        parentFactory.CustomRequestHandlingFactory = new InnerRuleGroupCustomRequestHandlingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CustomRequestHandlingFactory);
    }

    public static CombinedResult<InnerRuleGroupCaptchaActionFactory, T1, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1>(this CombinedResult<InnerRuleGroupCaptchaActionFactory, T1> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupCaptchaActionFactory, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1>(this CombinedResult<T1, InnerRuleGroupCaptchaActionFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRuleGroupCaptchaActionFactory, T1, T2, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2>(this CombinedResult<InnerRuleGroupCaptchaActionFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupCaptchaActionFactory, T2, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2>(this CombinedResult<T1, InnerRuleGroupCaptchaActionFactory, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupCaptchaActionFactory, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2>(this CombinedResult<T1, T2, InnerRuleGroupCaptchaActionFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRuleGroupCaptchaActionFactory, T1, T2, T3, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3>(this CombinedResult<InnerRuleGroupCaptchaActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupCaptchaActionFactory, T2, T3, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3>(this CombinedResult<T1, InnerRuleGroupCaptchaActionFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupCaptchaActionFactory, T3, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3>(this CombinedResult<T1, T2, InnerRuleGroupCaptchaActionFactory, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupCaptchaActionFactory, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRuleGroupCaptchaActionFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRuleGroupCaptchaActionFactory, T1, T2, T3, T4, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<InnerRuleGroupCaptchaActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupCaptchaActionFactory, T2, T3, T4, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<T1, InnerRuleGroupCaptchaActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupCaptchaActionFactory, T3, T4, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRuleGroupCaptchaActionFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupCaptchaActionFactory, T4, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRuleGroupCaptchaActionFactory, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRuleGroupCaptchaActionFactory, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRuleGroupCaptchaActionFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T5, subFactoryAction));
}
