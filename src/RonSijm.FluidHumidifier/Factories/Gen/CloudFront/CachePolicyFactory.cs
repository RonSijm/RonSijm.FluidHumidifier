// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class CachePolicyFactory(string resourceName = null, Action<Humidifier.CloudFront.CachePolicy> factoryAction = null) : ResourceFactory<Humidifier.CloudFront.CachePolicy>(resourceName)
{

    internal InnerCachePolicyCachePolicyConfigFactory CachePolicyConfigFactory { get; set; }

    protected override Humidifier.CloudFront.CachePolicy Create()
    {
        var cachePolicyResult = CreateCachePolicy();
        factoryAction?.Invoke(cachePolicyResult);

        return cachePolicyResult;
    }

    private Humidifier.CloudFront.CachePolicy CreateCachePolicy()
    {
        var cachePolicyResult = new Humidifier.CloudFront.CachePolicy
        {
            GivenName = InputResourceName,
        };

        return cachePolicyResult;
    }
    public override void CreateChildren(Humidifier.CloudFront.CachePolicy result)
    {
        base.CreateChildren(result);

        result.CachePolicyConfig ??= CachePolicyConfigFactory?.Build();
    }

} // End Of Class

public static class CachePolicyFactoryExtensions
{
    public static CombinedResult<CachePolicyFactory, InnerCachePolicyCachePolicyConfigFactory> WithCachePolicyConfig(this CachePolicyFactory parentFactory, Action<Humidifier.CloudFront.CachePolicyTypes.CachePolicyConfig> subFactoryAction = null)
    {
        parentFactory.CachePolicyConfigFactory = new InnerCachePolicyCachePolicyConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CachePolicyConfigFactory);
    }

    public static CombinedResult<CachePolicyFactory, T1, InnerCachePolicyCachePolicyConfigFactory> WithCachePolicyConfig<T1>(this CombinedResult<CachePolicyFactory, T1> combinedResult, Action<Humidifier.CloudFront.CachePolicyTypes.CachePolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCachePolicyConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CachePolicyFactory, InnerCachePolicyCachePolicyConfigFactory> WithCachePolicyConfig<T1>(this CombinedResult<T1, CachePolicyFactory> combinedResult, Action<Humidifier.CloudFront.CachePolicyTypes.CachePolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCachePolicyConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CachePolicyFactory, T1, T2, InnerCachePolicyCachePolicyConfigFactory> WithCachePolicyConfig<T1, T2>(this CombinedResult<CachePolicyFactory, T1, T2> combinedResult, Action<Humidifier.CloudFront.CachePolicyTypes.CachePolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCachePolicyConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CachePolicyFactory, T2, InnerCachePolicyCachePolicyConfigFactory> WithCachePolicyConfig<T1, T2>(this CombinedResult<T1, CachePolicyFactory, T2> combinedResult, Action<Humidifier.CloudFront.CachePolicyTypes.CachePolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCachePolicyConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CachePolicyFactory, InnerCachePolicyCachePolicyConfigFactory> WithCachePolicyConfig<T1, T2>(this CombinedResult<T1, T2, CachePolicyFactory> combinedResult, Action<Humidifier.CloudFront.CachePolicyTypes.CachePolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCachePolicyConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CachePolicyFactory, T1, T2, T3, InnerCachePolicyCachePolicyConfigFactory> WithCachePolicyConfig<T1, T2, T3>(this CombinedResult<CachePolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFront.CachePolicyTypes.CachePolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCachePolicyConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CachePolicyFactory, T2, T3, InnerCachePolicyCachePolicyConfigFactory> WithCachePolicyConfig<T1, T2, T3>(this CombinedResult<T1, CachePolicyFactory, T2, T3> combinedResult, Action<Humidifier.CloudFront.CachePolicyTypes.CachePolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCachePolicyConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CachePolicyFactory, T3, InnerCachePolicyCachePolicyConfigFactory> WithCachePolicyConfig<T1, T2, T3>(this CombinedResult<T1, T2, CachePolicyFactory, T3> combinedResult, Action<Humidifier.CloudFront.CachePolicyTypes.CachePolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCachePolicyConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CachePolicyFactory, InnerCachePolicyCachePolicyConfigFactory> WithCachePolicyConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, CachePolicyFactory> combinedResult, Action<Humidifier.CloudFront.CachePolicyTypes.CachePolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCachePolicyConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CachePolicyFactory, T1, T2, T3, T4, InnerCachePolicyCachePolicyConfigFactory> WithCachePolicyConfig<T1, T2, T3, T4>(this CombinedResult<CachePolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.CachePolicyTypes.CachePolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCachePolicyConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CachePolicyFactory, T2, T3, T4, InnerCachePolicyCachePolicyConfigFactory> WithCachePolicyConfig<T1, T2, T3, T4>(this CombinedResult<T1, CachePolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.CachePolicyTypes.CachePolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCachePolicyConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CachePolicyFactory, T3, T4, InnerCachePolicyCachePolicyConfigFactory> WithCachePolicyConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, CachePolicyFactory, T3, T4> combinedResult, Action<Humidifier.CloudFront.CachePolicyTypes.CachePolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCachePolicyConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CachePolicyFactory, T4, InnerCachePolicyCachePolicyConfigFactory> WithCachePolicyConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CachePolicyFactory, T4> combinedResult, Action<Humidifier.CloudFront.CachePolicyTypes.CachePolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCachePolicyConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CachePolicyFactory, InnerCachePolicyCachePolicyConfigFactory> WithCachePolicyConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CachePolicyFactory> combinedResult, Action<Humidifier.CloudFront.CachePolicyTypes.CachePolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCachePolicyConfig(combinedResult.T5, subFactoryAction));
}
