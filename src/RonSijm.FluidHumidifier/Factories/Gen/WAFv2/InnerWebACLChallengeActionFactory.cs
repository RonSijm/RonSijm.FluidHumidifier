// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLChallengeActionFactory(Action<Humidifier.WAFv2.WebACLTypes.ChallengeAction> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.ChallengeAction>
{

    internal InnerWebACLCustomRequestHandlingFactory CustomRequestHandlingFactory { get; set; }

    protected override Humidifier.WAFv2.WebACLTypes.ChallengeAction Create()
    {
        var challengeActionResult = CreateChallengeAction();
        factoryAction?.Invoke(challengeActionResult);

        return challengeActionResult;
    }

    private Humidifier.WAFv2.WebACLTypes.ChallengeAction CreateChallengeAction()
    {
        var challengeActionResult = new Humidifier.WAFv2.WebACLTypes.ChallengeAction();

        return challengeActionResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.WebACLTypes.ChallengeAction result)
    {
        base.CreateChildren(result);

        result.CustomRequestHandling ??= CustomRequestHandlingFactory?.Build();
    }

} // End Of Class

public static class InnerWebACLChallengeActionFactoryExtensions
{
    public static CombinedResult<InnerWebACLChallengeActionFactory, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling(this InnerWebACLChallengeActionFactory parentFactory, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null)
    {
        parentFactory.CustomRequestHandlingFactory = new InnerWebACLCustomRequestHandlingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CustomRequestHandlingFactory);
    }

    public static CombinedResult<InnerWebACLChallengeActionFactory, T1, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1>(this CombinedResult<InnerWebACLChallengeActionFactory, T1> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLChallengeActionFactory, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1>(this CombinedResult<T1, InnerWebACLChallengeActionFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWebACLChallengeActionFactory, T1, T2, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2>(this CombinedResult<InnerWebACLChallengeActionFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLChallengeActionFactory, T2, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2>(this CombinedResult<T1, InnerWebACLChallengeActionFactory, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLChallengeActionFactory, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2>(this CombinedResult<T1, T2, InnerWebACLChallengeActionFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWebACLChallengeActionFactory, T1, T2, T3, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3>(this CombinedResult<InnerWebACLChallengeActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLChallengeActionFactory, T2, T3, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3>(this CombinedResult<T1, InnerWebACLChallengeActionFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLChallengeActionFactory, T3, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebACLChallengeActionFactory, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLChallengeActionFactory, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebACLChallengeActionFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWebACLChallengeActionFactory, T1, T2, T3, T4, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<InnerWebACLChallengeActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLChallengeActionFactory, T2, T3, T4, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebACLChallengeActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLChallengeActionFactory, T3, T4, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebACLChallengeActionFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLChallengeActionFactory, T4, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebACLChallengeActionFactory, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWebACLChallengeActionFactory, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebACLChallengeActionFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T5, subFactoryAction));
}
