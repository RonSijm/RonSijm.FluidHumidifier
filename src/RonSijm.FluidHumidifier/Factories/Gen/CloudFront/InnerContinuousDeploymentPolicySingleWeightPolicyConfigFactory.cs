// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerContinuousDeploymentPolicySingleWeightPolicyConfigFactory(Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SingleWeightPolicyConfig> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SingleWeightPolicyConfig>
{

    internal InnerContinuousDeploymentPolicySessionStickinessConfigFactory SessionStickinessConfigFactory { get; set; }

    protected override Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SingleWeightPolicyConfig Create()
    {
        var singleWeightPolicyConfigResult = CreateSingleWeightPolicyConfig();
        factoryAction?.Invoke(singleWeightPolicyConfigResult);

        return singleWeightPolicyConfigResult;
    }

    private Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SingleWeightPolicyConfig CreateSingleWeightPolicyConfig()
    {
        var singleWeightPolicyConfigResult = new Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SingleWeightPolicyConfig();

        return singleWeightPolicyConfigResult;
    }
    public override void CreateChildren(Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SingleWeightPolicyConfig result)
    {
        base.CreateChildren(result);

        result.SessionStickinessConfig ??= SessionStickinessConfigFactory?.Build();
    }

} // End Of Class

public static class InnerContinuousDeploymentPolicySingleWeightPolicyConfigFactoryExtensions
{
    public static CombinedResult<InnerContinuousDeploymentPolicySingleWeightPolicyConfigFactory, InnerContinuousDeploymentPolicySessionStickinessConfigFactory> WithSessionStickinessConfig(this InnerContinuousDeploymentPolicySingleWeightPolicyConfigFactory parentFactory, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig> subFactoryAction = null)
    {
        parentFactory.SessionStickinessConfigFactory = new InnerContinuousDeploymentPolicySessionStickinessConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SessionStickinessConfigFactory);
    }

    public static CombinedResult<InnerContinuousDeploymentPolicySingleWeightPolicyConfigFactory, T1, InnerContinuousDeploymentPolicySessionStickinessConfigFactory> WithSessionStickinessConfig<T1>(this CombinedResult<InnerContinuousDeploymentPolicySingleWeightPolicyConfigFactory, T1> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSessionStickinessConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerContinuousDeploymentPolicySingleWeightPolicyConfigFactory, InnerContinuousDeploymentPolicySessionStickinessConfigFactory> WithSessionStickinessConfig<T1>(this CombinedResult<T1, InnerContinuousDeploymentPolicySingleWeightPolicyConfigFactory> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSessionStickinessConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerContinuousDeploymentPolicySingleWeightPolicyConfigFactory, T1, T2, InnerContinuousDeploymentPolicySessionStickinessConfigFactory> WithSessionStickinessConfig<T1, T2>(this CombinedResult<InnerContinuousDeploymentPolicySingleWeightPolicyConfigFactory, T1, T2> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSessionStickinessConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerContinuousDeploymentPolicySingleWeightPolicyConfigFactory, T2, InnerContinuousDeploymentPolicySessionStickinessConfigFactory> WithSessionStickinessConfig<T1, T2>(this CombinedResult<T1, InnerContinuousDeploymentPolicySingleWeightPolicyConfigFactory, T2> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSessionStickinessConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerContinuousDeploymentPolicySingleWeightPolicyConfigFactory, InnerContinuousDeploymentPolicySessionStickinessConfigFactory> WithSessionStickinessConfig<T1, T2>(this CombinedResult<T1, T2, InnerContinuousDeploymentPolicySingleWeightPolicyConfigFactory> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSessionStickinessConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerContinuousDeploymentPolicySingleWeightPolicyConfigFactory, T1, T2, T3, InnerContinuousDeploymentPolicySessionStickinessConfigFactory> WithSessionStickinessConfig<T1, T2, T3>(this CombinedResult<InnerContinuousDeploymentPolicySingleWeightPolicyConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSessionStickinessConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerContinuousDeploymentPolicySingleWeightPolicyConfigFactory, T2, T3, InnerContinuousDeploymentPolicySessionStickinessConfigFactory> WithSessionStickinessConfig<T1, T2, T3>(this CombinedResult<T1, InnerContinuousDeploymentPolicySingleWeightPolicyConfigFactory, T2, T3> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSessionStickinessConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerContinuousDeploymentPolicySingleWeightPolicyConfigFactory, T3, InnerContinuousDeploymentPolicySessionStickinessConfigFactory> WithSessionStickinessConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerContinuousDeploymentPolicySingleWeightPolicyConfigFactory, T3> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSessionStickinessConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerContinuousDeploymentPolicySingleWeightPolicyConfigFactory, InnerContinuousDeploymentPolicySessionStickinessConfigFactory> WithSessionStickinessConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerContinuousDeploymentPolicySingleWeightPolicyConfigFactory> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSessionStickinessConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerContinuousDeploymentPolicySingleWeightPolicyConfigFactory, T1, T2, T3, T4, InnerContinuousDeploymentPolicySessionStickinessConfigFactory> WithSessionStickinessConfig<T1, T2, T3, T4>(this CombinedResult<InnerContinuousDeploymentPolicySingleWeightPolicyConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSessionStickinessConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerContinuousDeploymentPolicySingleWeightPolicyConfigFactory, T2, T3, T4, InnerContinuousDeploymentPolicySessionStickinessConfigFactory> WithSessionStickinessConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerContinuousDeploymentPolicySingleWeightPolicyConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSessionStickinessConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerContinuousDeploymentPolicySingleWeightPolicyConfigFactory, T3, T4, InnerContinuousDeploymentPolicySessionStickinessConfigFactory> WithSessionStickinessConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerContinuousDeploymentPolicySingleWeightPolicyConfigFactory, T3, T4> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSessionStickinessConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerContinuousDeploymentPolicySingleWeightPolicyConfigFactory, T4, InnerContinuousDeploymentPolicySessionStickinessConfigFactory> WithSessionStickinessConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerContinuousDeploymentPolicySingleWeightPolicyConfigFactory, T4> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSessionStickinessConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerContinuousDeploymentPolicySingleWeightPolicyConfigFactory, InnerContinuousDeploymentPolicySessionStickinessConfigFactory> WithSessionStickinessConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerContinuousDeploymentPolicySingleWeightPolicyConfigFactory> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.SessionStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSessionStickinessConfig(combinedResult.T5, subFactoryAction));
}
