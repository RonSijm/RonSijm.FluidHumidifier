// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class OriginRequestPolicyFactory(string resourceName = null, Action<Humidifier.CloudFront.OriginRequestPolicy> factoryAction = null) : ResourceFactory<Humidifier.CloudFront.OriginRequestPolicy>(resourceName)
{

    internal InnerOriginRequestPolicyOriginRequestPolicyConfigFactory OriginRequestPolicyConfigFactory { get; set; }

    protected override Humidifier.CloudFront.OriginRequestPolicy Create()
    {
        var originRequestPolicyResult = CreateOriginRequestPolicy();
        factoryAction?.Invoke(originRequestPolicyResult);

        return originRequestPolicyResult;
    }

    private Humidifier.CloudFront.OriginRequestPolicy CreateOriginRequestPolicy()
    {
        var originRequestPolicyResult = new Humidifier.CloudFront.OriginRequestPolicy
        {
            GivenName = InputResourceName,
        };

        return originRequestPolicyResult;
    }
    public override void CreateChildren(Humidifier.CloudFront.OriginRequestPolicy result)
    {
        base.CreateChildren(result);

        result.OriginRequestPolicyConfig ??= OriginRequestPolicyConfigFactory?.Build();
    }

} // End Of Class

public static class OriginRequestPolicyFactoryExtensions
{
    public static CombinedResult<OriginRequestPolicyFactory, InnerOriginRequestPolicyOriginRequestPolicyConfigFactory> WithOriginRequestPolicyConfig(this OriginRequestPolicyFactory parentFactory, Action<Humidifier.CloudFront.OriginRequestPolicyTypes.OriginRequestPolicyConfig> subFactoryAction = null)
    {
        parentFactory.OriginRequestPolicyConfigFactory = new InnerOriginRequestPolicyOriginRequestPolicyConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OriginRequestPolicyConfigFactory);
    }

    public static CombinedResult<OriginRequestPolicyFactory, T1, InnerOriginRequestPolicyOriginRequestPolicyConfigFactory> WithOriginRequestPolicyConfig<T1>(this CombinedResult<OriginRequestPolicyFactory, T1> combinedResult, Action<Humidifier.CloudFront.OriginRequestPolicyTypes.OriginRequestPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithOriginRequestPolicyConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, OriginRequestPolicyFactory, InnerOriginRequestPolicyOriginRequestPolicyConfigFactory> WithOriginRequestPolicyConfig<T1>(this CombinedResult<T1, OriginRequestPolicyFactory> combinedResult, Action<Humidifier.CloudFront.OriginRequestPolicyTypes.OriginRequestPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithOriginRequestPolicyConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<OriginRequestPolicyFactory, T1, T2, InnerOriginRequestPolicyOriginRequestPolicyConfigFactory> WithOriginRequestPolicyConfig<T1, T2>(this CombinedResult<OriginRequestPolicyFactory, T1, T2> combinedResult, Action<Humidifier.CloudFront.OriginRequestPolicyTypes.OriginRequestPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOriginRequestPolicyConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, OriginRequestPolicyFactory, T2, InnerOriginRequestPolicyOriginRequestPolicyConfigFactory> WithOriginRequestPolicyConfig<T1, T2>(this CombinedResult<T1, OriginRequestPolicyFactory, T2> combinedResult, Action<Humidifier.CloudFront.OriginRequestPolicyTypes.OriginRequestPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOriginRequestPolicyConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, OriginRequestPolicyFactory, InnerOriginRequestPolicyOriginRequestPolicyConfigFactory> WithOriginRequestPolicyConfig<T1, T2>(this CombinedResult<T1, T2, OriginRequestPolicyFactory> combinedResult, Action<Humidifier.CloudFront.OriginRequestPolicyTypes.OriginRequestPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOriginRequestPolicyConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<OriginRequestPolicyFactory, T1, T2, T3, InnerOriginRequestPolicyOriginRequestPolicyConfigFactory> WithOriginRequestPolicyConfig<T1, T2, T3>(this CombinedResult<OriginRequestPolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFront.OriginRequestPolicyTypes.OriginRequestPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOriginRequestPolicyConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, OriginRequestPolicyFactory, T2, T3, InnerOriginRequestPolicyOriginRequestPolicyConfigFactory> WithOriginRequestPolicyConfig<T1, T2, T3>(this CombinedResult<T1, OriginRequestPolicyFactory, T2, T3> combinedResult, Action<Humidifier.CloudFront.OriginRequestPolicyTypes.OriginRequestPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOriginRequestPolicyConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, OriginRequestPolicyFactory, T3, InnerOriginRequestPolicyOriginRequestPolicyConfigFactory> WithOriginRequestPolicyConfig<T1, T2, T3>(this CombinedResult<T1, T2, OriginRequestPolicyFactory, T3> combinedResult, Action<Humidifier.CloudFront.OriginRequestPolicyTypes.OriginRequestPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOriginRequestPolicyConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, OriginRequestPolicyFactory, InnerOriginRequestPolicyOriginRequestPolicyConfigFactory> WithOriginRequestPolicyConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, OriginRequestPolicyFactory> combinedResult, Action<Humidifier.CloudFront.OriginRequestPolicyTypes.OriginRequestPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOriginRequestPolicyConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<OriginRequestPolicyFactory, T1, T2, T3, T4, InnerOriginRequestPolicyOriginRequestPolicyConfigFactory> WithOriginRequestPolicyConfig<T1, T2, T3, T4>(this CombinedResult<OriginRequestPolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.OriginRequestPolicyTypes.OriginRequestPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOriginRequestPolicyConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, OriginRequestPolicyFactory, T2, T3, T4, InnerOriginRequestPolicyOriginRequestPolicyConfigFactory> WithOriginRequestPolicyConfig<T1, T2, T3, T4>(this CombinedResult<T1, OriginRequestPolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.OriginRequestPolicyTypes.OriginRequestPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOriginRequestPolicyConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, OriginRequestPolicyFactory, T3, T4, InnerOriginRequestPolicyOriginRequestPolicyConfigFactory> WithOriginRequestPolicyConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, OriginRequestPolicyFactory, T3, T4> combinedResult, Action<Humidifier.CloudFront.OriginRequestPolicyTypes.OriginRequestPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOriginRequestPolicyConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, OriginRequestPolicyFactory, T4, InnerOriginRequestPolicyOriginRequestPolicyConfigFactory> WithOriginRequestPolicyConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, OriginRequestPolicyFactory, T4> combinedResult, Action<Humidifier.CloudFront.OriginRequestPolicyTypes.OriginRequestPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOriginRequestPolicyConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, OriginRequestPolicyFactory, InnerOriginRequestPolicyOriginRequestPolicyConfigFactory> WithOriginRequestPolicyConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, OriginRequestPolicyFactory> combinedResult, Action<Humidifier.CloudFront.OriginRequestPolicyTypes.OriginRequestPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOriginRequestPolicyConfig(combinedResult.T5, subFactoryAction));
}
