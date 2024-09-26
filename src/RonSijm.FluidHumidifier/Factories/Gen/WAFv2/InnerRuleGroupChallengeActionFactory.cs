// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupChallengeActionFactory(Action<Humidifier.WAFv2.RuleGroupTypes.ChallengeAction> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.ChallengeAction>
{

    internal InnerRuleGroupCustomRequestHandlingFactory CustomRequestHandlingFactory { get; set; }

    protected override Humidifier.WAFv2.RuleGroupTypes.ChallengeAction Create()
    {
        var challengeActionResult = CreateChallengeAction();
        factoryAction?.Invoke(challengeActionResult);

        return challengeActionResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.ChallengeAction CreateChallengeAction()
    {
        var challengeActionResult = new Humidifier.WAFv2.RuleGroupTypes.ChallengeAction();

        return challengeActionResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.RuleGroupTypes.ChallengeAction result)
    {
        base.CreateChildren(result);

        result.CustomRequestHandling ??= CustomRequestHandlingFactory?.Build();
    }

} // End Of Class

public static class InnerRuleGroupChallengeActionFactoryExtensions
{
    public static CombinedResult<InnerRuleGroupChallengeActionFactory, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling(this InnerRuleGroupChallengeActionFactory parentFactory, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null)
    {
        parentFactory.CustomRequestHandlingFactory = new InnerRuleGroupCustomRequestHandlingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CustomRequestHandlingFactory);
    }

    public static CombinedResult<InnerRuleGroupChallengeActionFactory, T1, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1>(this CombinedResult<InnerRuleGroupChallengeActionFactory, T1> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupChallengeActionFactory, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1>(this CombinedResult<T1, InnerRuleGroupChallengeActionFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRuleGroupChallengeActionFactory, T1, T2, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2>(this CombinedResult<InnerRuleGroupChallengeActionFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupChallengeActionFactory, T2, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2>(this CombinedResult<T1, InnerRuleGroupChallengeActionFactory, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupChallengeActionFactory, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2>(this CombinedResult<T1, T2, InnerRuleGroupChallengeActionFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRuleGroupChallengeActionFactory, T1, T2, T3, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3>(this CombinedResult<InnerRuleGroupChallengeActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupChallengeActionFactory, T2, T3, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3>(this CombinedResult<T1, InnerRuleGroupChallengeActionFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupChallengeActionFactory, T3, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3>(this CombinedResult<T1, T2, InnerRuleGroupChallengeActionFactory, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupChallengeActionFactory, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRuleGroupChallengeActionFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRuleGroupChallengeActionFactory, T1, T2, T3, T4, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<InnerRuleGroupChallengeActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupChallengeActionFactory, T2, T3, T4, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<T1, InnerRuleGroupChallengeActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupChallengeActionFactory, T3, T4, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRuleGroupChallengeActionFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupChallengeActionFactory, T4, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRuleGroupChallengeActionFactory, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRuleGroupChallengeActionFactory, InnerRuleGroupCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRuleGroupChallengeActionFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T5, subFactoryAction));
}
