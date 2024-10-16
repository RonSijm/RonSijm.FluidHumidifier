// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class ContinuousDeploymentPolicyFactory(string resourceName = null, Action<Humidifier.CloudFront.ContinuousDeploymentPolicy> factoryAction = null) : ResourceFactory<Humidifier.CloudFront.ContinuousDeploymentPolicy>(resourceName)
{

    internal InnerContinuousDeploymentPolicyContinuousDeploymentPolicyConfigFactory ContinuousDeploymentPolicyConfigFactory { get; set; }

    protected override Humidifier.CloudFront.ContinuousDeploymentPolicy Create()
    {
        var continuousDeploymentPolicyResult = CreateContinuousDeploymentPolicy();
        factoryAction?.Invoke(continuousDeploymentPolicyResult);

        return continuousDeploymentPolicyResult;
    }

    private Humidifier.CloudFront.ContinuousDeploymentPolicy CreateContinuousDeploymentPolicy()
    {
        var continuousDeploymentPolicyResult = new Humidifier.CloudFront.ContinuousDeploymentPolicy
        {
            GivenName = InputResourceName,
        };

        return continuousDeploymentPolicyResult;
    }
    public override void CreateChildren(Humidifier.CloudFront.ContinuousDeploymentPolicy result)
    {
        base.CreateChildren(result);

        result.ContinuousDeploymentPolicyConfig ??= ContinuousDeploymentPolicyConfigFactory?.Build();
    }

} // End Of Class

public static class ContinuousDeploymentPolicyFactoryExtensions
{
    public static CombinedResult<ContinuousDeploymentPolicyFactory, InnerContinuousDeploymentPolicyContinuousDeploymentPolicyConfigFactory> WithContinuousDeploymentPolicyConfig(this ContinuousDeploymentPolicyFactory parentFactory, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.ContinuousDeploymentPolicyConfig> subFactoryAction = null)
    {
        parentFactory.ContinuousDeploymentPolicyConfigFactory = new InnerContinuousDeploymentPolicyContinuousDeploymentPolicyConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ContinuousDeploymentPolicyConfigFactory);
    }

    public static CombinedResult<ContinuousDeploymentPolicyFactory, T1, InnerContinuousDeploymentPolicyContinuousDeploymentPolicyConfigFactory> WithContinuousDeploymentPolicyConfig<T1>(this CombinedResult<ContinuousDeploymentPolicyFactory, T1> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.ContinuousDeploymentPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithContinuousDeploymentPolicyConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ContinuousDeploymentPolicyFactory, InnerContinuousDeploymentPolicyContinuousDeploymentPolicyConfigFactory> WithContinuousDeploymentPolicyConfig<T1>(this CombinedResult<T1, ContinuousDeploymentPolicyFactory> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.ContinuousDeploymentPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithContinuousDeploymentPolicyConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ContinuousDeploymentPolicyFactory, T1, T2, InnerContinuousDeploymentPolicyContinuousDeploymentPolicyConfigFactory> WithContinuousDeploymentPolicyConfig<T1, T2>(this CombinedResult<ContinuousDeploymentPolicyFactory, T1, T2> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.ContinuousDeploymentPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContinuousDeploymentPolicyConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ContinuousDeploymentPolicyFactory, T2, InnerContinuousDeploymentPolicyContinuousDeploymentPolicyConfigFactory> WithContinuousDeploymentPolicyConfig<T1, T2>(this CombinedResult<T1, ContinuousDeploymentPolicyFactory, T2> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.ContinuousDeploymentPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContinuousDeploymentPolicyConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ContinuousDeploymentPolicyFactory, InnerContinuousDeploymentPolicyContinuousDeploymentPolicyConfigFactory> WithContinuousDeploymentPolicyConfig<T1, T2>(this CombinedResult<T1, T2, ContinuousDeploymentPolicyFactory> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.ContinuousDeploymentPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContinuousDeploymentPolicyConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ContinuousDeploymentPolicyFactory, T1, T2, T3, InnerContinuousDeploymentPolicyContinuousDeploymentPolicyConfigFactory> WithContinuousDeploymentPolicyConfig<T1, T2, T3>(this CombinedResult<ContinuousDeploymentPolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.ContinuousDeploymentPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContinuousDeploymentPolicyConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ContinuousDeploymentPolicyFactory, T2, T3, InnerContinuousDeploymentPolicyContinuousDeploymentPolicyConfigFactory> WithContinuousDeploymentPolicyConfig<T1, T2, T3>(this CombinedResult<T1, ContinuousDeploymentPolicyFactory, T2, T3> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.ContinuousDeploymentPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContinuousDeploymentPolicyConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ContinuousDeploymentPolicyFactory, T3, InnerContinuousDeploymentPolicyContinuousDeploymentPolicyConfigFactory> WithContinuousDeploymentPolicyConfig<T1, T2, T3>(this CombinedResult<T1, T2, ContinuousDeploymentPolicyFactory, T3> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.ContinuousDeploymentPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContinuousDeploymentPolicyConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ContinuousDeploymentPolicyFactory, InnerContinuousDeploymentPolicyContinuousDeploymentPolicyConfigFactory> WithContinuousDeploymentPolicyConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ContinuousDeploymentPolicyFactory> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.ContinuousDeploymentPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContinuousDeploymentPolicyConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ContinuousDeploymentPolicyFactory, T1, T2, T3, T4, InnerContinuousDeploymentPolicyContinuousDeploymentPolicyConfigFactory> WithContinuousDeploymentPolicyConfig<T1, T2, T3, T4>(this CombinedResult<ContinuousDeploymentPolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.ContinuousDeploymentPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContinuousDeploymentPolicyConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ContinuousDeploymentPolicyFactory, T2, T3, T4, InnerContinuousDeploymentPolicyContinuousDeploymentPolicyConfigFactory> WithContinuousDeploymentPolicyConfig<T1, T2, T3, T4>(this CombinedResult<T1, ContinuousDeploymentPolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.ContinuousDeploymentPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContinuousDeploymentPolicyConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ContinuousDeploymentPolicyFactory, T3, T4, InnerContinuousDeploymentPolicyContinuousDeploymentPolicyConfigFactory> WithContinuousDeploymentPolicyConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ContinuousDeploymentPolicyFactory, T3, T4> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.ContinuousDeploymentPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContinuousDeploymentPolicyConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ContinuousDeploymentPolicyFactory, T4, InnerContinuousDeploymentPolicyContinuousDeploymentPolicyConfigFactory> WithContinuousDeploymentPolicyConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ContinuousDeploymentPolicyFactory, T4> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.ContinuousDeploymentPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContinuousDeploymentPolicyConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ContinuousDeploymentPolicyFactory, InnerContinuousDeploymentPolicyContinuousDeploymentPolicyConfigFactory> WithContinuousDeploymentPolicyConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ContinuousDeploymentPolicyFactory> combinedResult, Action<Humidifier.CloudFront.ContinuousDeploymentPolicyTypes.ContinuousDeploymentPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContinuousDeploymentPolicyConfig(combinedResult.T5, subFactoryAction));
}
