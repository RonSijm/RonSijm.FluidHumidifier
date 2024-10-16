// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.XRay;

public class SamplingRuleFactory(string resourceName = null, Action<Humidifier.XRay.SamplingRule> factoryAction = null) : ResourceFactory<Humidifier.XRay.SamplingRule>(resourceName)
{

    internal InnerSamplingRuleSamplingRuleFactory SamplingRule_Factory { get; set; }

    protected override Humidifier.XRay.SamplingRule Create()
    {
        var samplingRuleResult = CreateSamplingRule();
        factoryAction?.Invoke(samplingRuleResult);

        return samplingRuleResult;
    }

    private Humidifier.XRay.SamplingRule CreateSamplingRule()
    {
        var samplingRuleResult = new Humidifier.XRay.SamplingRule
        {
            GivenName = InputResourceName,
        };

        return samplingRuleResult;
    }
    public override void CreateChildren(Humidifier.XRay.SamplingRule result)
    {
        base.CreateChildren(result);

        result.SamplingRule_ ??= SamplingRule_Factory?.Build();
    }

} // End Of Class

public static class SamplingRuleFactoryExtensions
{
    public static CombinedResult<SamplingRuleFactory, InnerSamplingRuleSamplingRuleFactory> WithSamplingRule_(this SamplingRuleFactory parentFactory, Action<Humidifier.XRay.SamplingRuleTypes.SamplingRule> subFactoryAction = null)
    {
        parentFactory.SamplingRule_Factory = new InnerSamplingRuleSamplingRuleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SamplingRule_Factory);
    }

    public static CombinedResult<SamplingRuleFactory, T1, InnerSamplingRuleSamplingRuleFactory> WithSamplingRule_<T1>(this CombinedResult<SamplingRuleFactory, T1> combinedResult, Action<Humidifier.XRay.SamplingRuleTypes.SamplingRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithSamplingRule_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SamplingRuleFactory, InnerSamplingRuleSamplingRuleFactory> WithSamplingRule_<T1>(this CombinedResult<T1, SamplingRuleFactory> combinedResult, Action<Humidifier.XRay.SamplingRuleTypes.SamplingRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithSamplingRule_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SamplingRuleFactory, T1, T2, InnerSamplingRuleSamplingRuleFactory> WithSamplingRule_<T1, T2>(this CombinedResult<SamplingRuleFactory, T1, T2> combinedResult, Action<Humidifier.XRay.SamplingRuleTypes.SamplingRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSamplingRule_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SamplingRuleFactory, T2, InnerSamplingRuleSamplingRuleFactory> WithSamplingRule_<T1, T2>(this CombinedResult<T1, SamplingRuleFactory, T2> combinedResult, Action<Humidifier.XRay.SamplingRuleTypes.SamplingRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSamplingRule_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SamplingRuleFactory, InnerSamplingRuleSamplingRuleFactory> WithSamplingRule_<T1, T2>(this CombinedResult<T1, T2, SamplingRuleFactory> combinedResult, Action<Humidifier.XRay.SamplingRuleTypes.SamplingRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSamplingRule_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SamplingRuleFactory, T1, T2, T3, InnerSamplingRuleSamplingRuleFactory> WithSamplingRule_<T1, T2, T3>(this CombinedResult<SamplingRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.XRay.SamplingRuleTypes.SamplingRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSamplingRule_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SamplingRuleFactory, T2, T3, InnerSamplingRuleSamplingRuleFactory> WithSamplingRule_<T1, T2, T3>(this CombinedResult<T1, SamplingRuleFactory, T2, T3> combinedResult, Action<Humidifier.XRay.SamplingRuleTypes.SamplingRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSamplingRule_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SamplingRuleFactory, T3, InnerSamplingRuleSamplingRuleFactory> WithSamplingRule_<T1, T2, T3>(this CombinedResult<T1, T2, SamplingRuleFactory, T3> combinedResult, Action<Humidifier.XRay.SamplingRuleTypes.SamplingRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSamplingRule_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SamplingRuleFactory, InnerSamplingRuleSamplingRuleFactory> WithSamplingRule_<T1, T2, T3>(this CombinedResult<T1, T2, T3, SamplingRuleFactory> combinedResult, Action<Humidifier.XRay.SamplingRuleTypes.SamplingRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSamplingRule_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SamplingRuleFactory, T1, T2, T3, T4, InnerSamplingRuleSamplingRuleFactory> WithSamplingRule_<T1, T2, T3, T4>(this CombinedResult<SamplingRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.XRay.SamplingRuleTypes.SamplingRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSamplingRule_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SamplingRuleFactory, T2, T3, T4, InnerSamplingRuleSamplingRuleFactory> WithSamplingRule_<T1, T2, T3, T4>(this CombinedResult<T1, SamplingRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.XRay.SamplingRuleTypes.SamplingRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSamplingRule_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SamplingRuleFactory, T3, T4, InnerSamplingRuleSamplingRuleFactory> WithSamplingRule_<T1, T2, T3, T4>(this CombinedResult<T1, T2, SamplingRuleFactory, T3, T4> combinedResult, Action<Humidifier.XRay.SamplingRuleTypes.SamplingRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSamplingRule_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SamplingRuleFactory, T4, InnerSamplingRuleSamplingRuleFactory> WithSamplingRule_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SamplingRuleFactory, T4> combinedResult, Action<Humidifier.XRay.SamplingRuleTypes.SamplingRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSamplingRule_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SamplingRuleFactory, InnerSamplingRuleSamplingRuleFactory> WithSamplingRule_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SamplingRuleFactory> combinedResult, Action<Humidifier.XRay.SamplingRuleTypes.SamplingRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSamplingRule_(combinedResult.T5, subFactoryAction));
}
