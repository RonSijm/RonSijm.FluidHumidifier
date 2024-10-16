// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerContinuousDeploymentPolicySingleWeightConfigFactory(Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SingleWeightConfig> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SingleWeightConfig>
{

    internal InnerContinuousDeploymentPolicySessionStickinessConfigFactory SessionStickinessConfigFactory { get; set; }

    protected override Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SingleWeightConfig Create()
    {
        var singleWeightConfigResult = CreateSingleWeightConfig();
        factoryAction?.Invoke(singleWeightConfigResult);

        return singleWeightConfigResult;
    }

    private Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SingleWeightConfig CreateSingleWeightConfig()
    {
        var singleWeightConfigResult = new Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SingleWeightConfig();

        return singleWeightConfigResult;
    }
    public override void CreateChildren(Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SingleWeightConfig result)
    {
        base.CreateChildren(result);

        result.SessionStickinessConfig ??= SessionStickinessConfigFactory?.Build();
    }

} // End Of Class

public static class InnerContinuousDeploymentPolicySingleWeightConfigFactoryExtensions
{
    public static CombinedResult<InnerContinuousDeploymentPolicySingleWeightConfigFactory, InnerContinuousDeploymentPolicySessionStickinessConfigFactory> WithSessionStickinessConfig(this InnerContinuousDeploymentPolicySingleWeightConfigFactory parentFactory, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig> subFactoryAction = null)
    {
        parentFactory.SessionStickinessConfigFactory = new InnerContinuousDeploymentPolicySessionStickinessConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SessionStickinessConfigFactory);
    }

    public static CombinedResult<InnerContinuousDeploymentPolicySingleWeightConfigFactory, T1, InnerContinuousDeploymentPolicySessionStickinessConfigFactory> WithSessionStickinessConfig<T1>(this CombinedResult<InnerContinuousDeploymentPolicySingleWeightConfigFactory, T1> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSessionStickinessConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerContinuousDeploymentPolicySingleWeightConfigFactory, InnerContinuousDeploymentPolicySessionStickinessConfigFactory> WithSessionStickinessConfig<T1>(this CombinedResult<T1, InnerContinuousDeploymentPolicySingleWeightConfigFactory> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSessionStickinessConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerContinuousDeploymentPolicySingleWeightConfigFactory, T1, T2, InnerContinuousDeploymentPolicySessionStickinessConfigFactory> WithSessionStickinessConfig<T1, T2>(this CombinedResult<InnerContinuousDeploymentPolicySingleWeightConfigFactory, T1, T2> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSessionStickinessConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerContinuousDeploymentPolicySingleWeightConfigFactory, T2, InnerContinuousDeploymentPolicySessionStickinessConfigFactory> WithSessionStickinessConfig<T1, T2>(this CombinedResult<T1, InnerContinuousDeploymentPolicySingleWeightConfigFactory, T2> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSessionStickinessConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerContinuousDeploymentPolicySingleWeightConfigFactory, InnerContinuousDeploymentPolicySessionStickinessConfigFactory> WithSessionStickinessConfig<T1, T2>(this CombinedResult<T1, T2, InnerContinuousDeploymentPolicySingleWeightConfigFactory> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSessionStickinessConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerContinuousDeploymentPolicySingleWeightConfigFactory, T1, T2, T3, InnerContinuousDeploymentPolicySessionStickinessConfigFactory> WithSessionStickinessConfig<T1, T2, T3>(this CombinedResult<InnerContinuousDeploymentPolicySingleWeightConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSessionStickinessConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerContinuousDeploymentPolicySingleWeightConfigFactory, T2, T3, InnerContinuousDeploymentPolicySessionStickinessConfigFactory> WithSessionStickinessConfig<T1, T2, T3>(this CombinedResult<T1, InnerContinuousDeploymentPolicySingleWeightConfigFactory, T2, T3> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSessionStickinessConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerContinuousDeploymentPolicySingleWeightConfigFactory, T3, InnerContinuousDeploymentPolicySessionStickinessConfigFactory> WithSessionStickinessConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerContinuousDeploymentPolicySingleWeightConfigFactory, T3> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSessionStickinessConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerContinuousDeploymentPolicySingleWeightConfigFactory, InnerContinuousDeploymentPolicySessionStickinessConfigFactory> WithSessionStickinessConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerContinuousDeploymentPolicySingleWeightConfigFactory> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSessionStickinessConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerContinuousDeploymentPolicySingleWeightConfigFactory, T1, T2, T3, T4, InnerContinuousDeploymentPolicySessionStickinessConfigFactory> WithSessionStickinessConfig<T1, T2, T3, T4>(this CombinedResult<InnerContinuousDeploymentPolicySingleWeightConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSessionStickinessConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerContinuousDeploymentPolicySingleWeightConfigFactory, T2, T3, T4, InnerContinuousDeploymentPolicySessionStickinessConfigFactory> WithSessionStickinessConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerContinuousDeploymentPolicySingleWeightConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSessionStickinessConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerContinuousDeploymentPolicySingleWeightConfigFactory, T3, T4, InnerContinuousDeploymentPolicySessionStickinessConfigFactory> WithSessionStickinessConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerContinuousDeploymentPolicySingleWeightConfigFactory, T3, T4> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSessionStickinessConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerContinuousDeploymentPolicySingleWeightConfigFactory, T4, InnerContinuousDeploymentPolicySessionStickinessConfigFactory> WithSessionStickinessConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerContinuousDeploymentPolicySingleWeightConfigFactory, T4> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSessionStickinessConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerContinuousDeploymentPolicySingleWeightConfigFactory, InnerContinuousDeploymentPolicySessionStickinessConfigFactory> WithSessionStickinessConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerContinuousDeploymentPolicySingleWeightConfigFactory> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSessionStickinessConfig(combinedResult.T5, subFactoryAction));
}
