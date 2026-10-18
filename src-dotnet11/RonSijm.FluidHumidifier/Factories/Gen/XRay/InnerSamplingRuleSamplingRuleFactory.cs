// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.XRay;

public class InnerSamplingRuleSamplingRuleFactory(Action<Humidifier.XRay.SamplingRuleTypes.SamplingRule> factoryAction = null) : SubResourceFactory<Humidifier.XRay.SamplingRuleTypes.SamplingRule>
{

    internal InnerSamplingRuleSamplingRateBoostFactory SamplingRateBoostFactory { get; set; }

    protected override Humidifier.XRay.SamplingRuleTypes.SamplingRule Create()
    {
        var samplingRuleResult = CreateSamplingRule();
        factoryAction?.Invoke(samplingRuleResult);

        return samplingRuleResult;
    }

    private Humidifier.XRay.SamplingRuleTypes.SamplingRule CreateSamplingRule()
    {
        var samplingRuleResult = new Humidifier.XRay.SamplingRuleTypes.SamplingRule();

        return samplingRuleResult;
    }
    public override void CreateChildren(Humidifier.XRay.SamplingRuleTypes.SamplingRule result)
    {
        base.CreateChildren(result);

        result.SamplingRateBoost ??= SamplingRateBoostFactory?.Build();
    }

} // End Of Class

public static class InnerSamplingRuleSamplingRuleFactoryExtensions
{
    public static CombinedResult<InnerSamplingRuleSamplingRuleFactory, InnerSamplingRuleSamplingRateBoostFactory> WithSamplingRateBoost(this InnerSamplingRuleSamplingRuleFactory parentFactory, Action<Humidifier.XRay.SamplingRuleTypes.SamplingRateBoost> subFactoryAction = null)
    {
        parentFactory.SamplingRateBoostFactory = new InnerSamplingRuleSamplingRateBoostFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SamplingRateBoostFactory);
    }

    public static CombinedResult<InnerSamplingRuleSamplingRuleFactory, T1, InnerSamplingRuleSamplingRateBoostFactory> WithSamplingRateBoost<T1>(this CombinedResult<InnerSamplingRuleSamplingRuleFactory, T1> combinedResult, Action<Humidifier.XRay.SamplingRuleTypes.SamplingRateBoost> subFactoryAction = null) => new (combinedResult, combinedResult, WithSamplingRateBoost(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSamplingRuleSamplingRuleFactory, InnerSamplingRuleSamplingRateBoostFactory> WithSamplingRateBoost<T1>(this CombinedResult<T1, InnerSamplingRuleSamplingRuleFactory> combinedResult, Action<Humidifier.XRay.SamplingRuleTypes.SamplingRateBoost> subFactoryAction = null) => new (combinedResult, combinedResult, WithSamplingRateBoost(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerSamplingRuleSamplingRuleFactory, T1, T2, InnerSamplingRuleSamplingRateBoostFactory> WithSamplingRateBoost<T1, T2>(this CombinedResult<InnerSamplingRuleSamplingRuleFactory, T1, T2> combinedResult, Action<Humidifier.XRay.SamplingRuleTypes.SamplingRateBoost> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSamplingRateBoost(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSamplingRuleSamplingRuleFactory, T2, InnerSamplingRuleSamplingRateBoostFactory> WithSamplingRateBoost<T1, T2>(this CombinedResult<T1, InnerSamplingRuleSamplingRuleFactory, T2> combinedResult, Action<Humidifier.XRay.SamplingRuleTypes.SamplingRateBoost> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSamplingRateBoost(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSamplingRuleSamplingRuleFactory, InnerSamplingRuleSamplingRateBoostFactory> WithSamplingRateBoost<T1, T2>(this CombinedResult<T1, T2, InnerSamplingRuleSamplingRuleFactory> combinedResult, Action<Humidifier.XRay.SamplingRuleTypes.SamplingRateBoost> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSamplingRateBoost(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerSamplingRuleSamplingRuleFactory, T1, T2, T3, InnerSamplingRuleSamplingRateBoostFactory> WithSamplingRateBoost<T1, T2, T3>(this CombinedResult<InnerSamplingRuleSamplingRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.XRay.SamplingRuleTypes.SamplingRateBoost> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSamplingRateBoost(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSamplingRuleSamplingRuleFactory, T2, T3, InnerSamplingRuleSamplingRateBoostFactory> WithSamplingRateBoost<T1, T2, T3>(this CombinedResult<T1, InnerSamplingRuleSamplingRuleFactory, T2, T3> combinedResult, Action<Humidifier.XRay.SamplingRuleTypes.SamplingRateBoost> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSamplingRateBoost(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSamplingRuleSamplingRuleFactory, T3, InnerSamplingRuleSamplingRateBoostFactory> WithSamplingRateBoost<T1, T2, T3>(this CombinedResult<T1, T2, InnerSamplingRuleSamplingRuleFactory, T3> combinedResult, Action<Humidifier.XRay.SamplingRuleTypes.SamplingRateBoost> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSamplingRateBoost(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerSamplingRuleSamplingRuleFactory, InnerSamplingRuleSamplingRateBoostFactory> WithSamplingRateBoost<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSamplingRuleSamplingRuleFactory> combinedResult, Action<Humidifier.XRay.SamplingRuleTypes.SamplingRateBoost> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSamplingRateBoost(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerSamplingRuleSamplingRuleFactory, T1, T2, T3, T4, InnerSamplingRuleSamplingRateBoostFactory> WithSamplingRateBoost<T1, T2, T3, T4>(this CombinedResult<InnerSamplingRuleSamplingRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.XRay.SamplingRuleTypes.SamplingRateBoost> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSamplingRateBoost(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSamplingRuleSamplingRuleFactory, T2, T3, T4, InnerSamplingRuleSamplingRateBoostFactory> WithSamplingRateBoost<T1, T2, T3, T4>(this CombinedResult<T1, InnerSamplingRuleSamplingRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.XRay.SamplingRuleTypes.SamplingRateBoost> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSamplingRateBoost(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSamplingRuleSamplingRuleFactory, T3, T4, InnerSamplingRuleSamplingRateBoostFactory> WithSamplingRateBoost<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSamplingRuleSamplingRuleFactory, T3, T4> combinedResult, Action<Humidifier.XRay.SamplingRuleTypes.SamplingRateBoost> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSamplingRateBoost(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerSamplingRuleSamplingRuleFactory, T4, InnerSamplingRuleSamplingRateBoostFactory> WithSamplingRateBoost<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSamplingRuleSamplingRuleFactory, T4> combinedResult, Action<Humidifier.XRay.SamplingRuleTypes.SamplingRateBoost> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSamplingRateBoost(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerSamplingRuleSamplingRuleFactory, InnerSamplingRuleSamplingRateBoostFactory> WithSamplingRateBoost<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSamplingRuleSamplingRuleFactory> combinedResult, Action<Humidifier.XRay.SamplingRuleTypes.SamplingRateBoost> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSamplingRateBoost(combinedResult.T5, subFactoryAction).T2);
}
