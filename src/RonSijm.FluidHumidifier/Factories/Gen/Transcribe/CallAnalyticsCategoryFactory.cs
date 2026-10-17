// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transcribe;

public class CallAnalyticsCategoryFactory(string resourceName = null, Action<Humidifier.Transcribe.CallAnalyticsCategory> factoryAction = null) : ResourceFactory<Humidifier.Transcribe.CallAnalyticsCategory>(resourceName)
{

    internal List<InnerCallAnalyticsCategoryRuleFactory> RulesFactories { get; set; } = [];

    protected override Humidifier.Transcribe.CallAnalyticsCategory Create()
    {
        var callAnalyticsCategoryResult = CreateCallAnalyticsCategory();
        factoryAction?.Invoke(callAnalyticsCategoryResult);

        return callAnalyticsCategoryResult;
    }

    private Humidifier.Transcribe.CallAnalyticsCategory CreateCallAnalyticsCategory()
    {
        var callAnalyticsCategoryResult = new Humidifier.Transcribe.CallAnalyticsCategory
        {
            GivenName = InputResourceName,
        };

        return callAnalyticsCategoryResult;
    }
    public override void CreateChildren(Humidifier.Transcribe.CallAnalyticsCategory result)
    {
        base.CreateChildren(result);

        result.Rules = RulesFactories.Any() ? RulesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class CallAnalyticsCategoryFactoryExtensions
{
    public static CombinedResult<CallAnalyticsCategoryFactory, InnerCallAnalyticsCategoryRuleFactory> WithRules(this CallAnalyticsCategoryFactory parentFactory, Action<Humidifier.Transcribe.CallAnalyticsCategoryTypes.Rule> subFactoryAction = null)
    {
        var factory = new InnerCallAnalyticsCategoryRuleFactory(subFactoryAction);
        parentFactory.RulesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<CallAnalyticsCategoryFactory, T1, InnerCallAnalyticsCategoryRuleFactory> WithRules<T1>(this CombinedResult<CallAnalyticsCategoryFactory, T1> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsCategoryTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CallAnalyticsCategoryFactory, InnerCallAnalyticsCategoryRuleFactory> WithRules<T1>(this CombinedResult<T1, CallAnalyticsCategoryFactory> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsCategoryTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<CallAnalyticsCategoryFactory, T1, T2, InnerCallAnalyticsCategoryRuleFactory> WithRules<T1, T2>(this CombinedResult<CallAnalyticsCategoryFactory, T1, T2> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsCategoryTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CallAnalyticsCategoryFactory, T2, InnerCallAnalyticsCategoryRuleFactory> WithRules<T1, T2>(this CombinedResult<T1, CallAnalyticsCategoryFactory, T2> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsCategoryTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CallAnalyticsCategoryFactory, InnerCallAnalyticsCategoryRuleFactory> WithRules<T1, T2>(this CombinedResult<T1, T2, CallAnalyticsCategoryFactory> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsCategoryTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<CallAnalyticsCategoryFactory, T1, T2, T3, InnerCallAnalyticsCategoryRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<CallAnalyticsCategoryFactory, T1, T2, T3> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsCategoryTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CallAnalyticsCategoryFactory, T2, T3, InnerCallAnalyticsCategoryRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, CallAnalyticsCategoryFactory, T2, T3> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsCategoryTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CallAnalyticsCategoryFactory, T3, InnerCallAnalyticsCategoryRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, T2, CallAnalyticsCategoryFactory, T3> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsCategoryTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CallAnalyticsCategoryFactory, InnerCallAnalyticsCategoryRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, T2, T3, CallAnalyticsCategoryFactory> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsCategoryTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<CallAnalyticsCategoryFactory, T1, T2, T3, T4, InnerCallAnalyticsCategoryRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<CallAnalyticsCategoryFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsCategoryTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CallAnalyticsCategoryFactory, T2, T3, T4, InnerCallAnalyticsCategoryRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, CallAnalyticsCategoryFactory, T2, T3, T4> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsCategoryTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CallAnalyticsCategoryFactory, T3, T4, InnerCallAnalyticsCategoryRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, CallAnalyticsCategoryFactory, T3, T4> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsCategoryTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CallAnalyticsCategoryFactory, T4, InnerCallAnalyticsCategoryRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CallAnalyticsCategoryFactory, T4> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsCategoryTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, CallAnalyticsCategoryFactory, InnerCallAnalyticsCategoryRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CallAnalyticsCategoryFactory> combinedResult, Action<Humidifier.Transcribe.CallAnalyticsCategoryTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T5, subFactoryAction).T2);
}
