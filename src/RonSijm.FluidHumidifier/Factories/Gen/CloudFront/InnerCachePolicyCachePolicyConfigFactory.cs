// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerCachePolicyCachePolicyConfigFactory(Action<Humidifier.CloudFront.CachePolicyTypes.CachePolicyConfig> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.CachePolicyTypes.CachePolicyConfig>
{

    internal InnerCachePolicyParametersInCacheKeyAndForwardedToOriginFactory ParametersInCacheKeyAndForwardedToOriginFactory { get; set; }

    protected override Humidifier.CloudFront.CachePolicyTypes.CachePolicyConfig Create()
    {
        var cachePolicyConfigResult = CreateCachePolicyConfig();
        factoryAction?.Invoke(cachePolicyConfigResult);

        return cachePolicyConfigResult;
    }

    private Humidifier.CloudFront.CachePolicyTypes.CachePolicyConfig CreateCachePolicyConfig()
    {
        var cachePolicyConfigResult = new Humidifier.CloudFront.CachePolicyTypes.CachePolicyConfig();

        return cachePolicyConfigResult;
    }
    public override void CreateChildren(Humidifier.CloudFront.CachePolicyTypes.CachePolicyConfig result)
    {
        base.CreateChildren(result);

        result.ParametersInCacheKeyAndForwardedToOrigin ??= ParametersInCacheKeyAndForwardedToOriginFactory?.Build();
    }

} // End Of Class

public static class InnerCachePolicyCachePolicyConfigFactoryExtensions
{
    public static CombinedResult<InnerCachePolicyCachePolicyConfigFactory, InnerCachePolicyParametersInCacheKeyAndForwardedToOriginFactory> WithParametersInCacheKeyAndForwardedToOrigin(this InnerCachePolicyCachePolicyConfigFactory parentFactory, Action<Humidifier.CloudFront.CachePolicyTypes.ParametersInCacheKeyAndForwardedToOrigin> subFactoryAction = null)
    {
        parentFactory.ParametersInCacheKeyAndForwardedToOriginFactory = new InnerCachePolicyParametersInCacheKeyAndForwardedToOriginFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ParametersInCacheKeyAndForwardedToOriginFactory);
    }

    public static CombinedResult<InnerCachePolicyCachePolicyConfigFactory, T1, InnerCachePolicyParametersInCacheKeyAndForwardedToOriginFactory> WithParametersInCacheKeyAndForwardedToOrigin<T1>(this CombinedResult<InnerCachePolicyCachePolicyConfigFactory, T1> combinedResult, Action<Humidifier.CloudFront.CachePolicyTypes.ParametersInCacheKeyAndForwardedToOrigin> subFactoryAction = null) => new (combinedResult, combinedResult, WithParametersInCacheKeyAndForwardedToOrigin(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCachePolicyCachePolicyConfigFactory, InnerCachePolicyParametersInCacheKeyAndForwardedToOriginFactory> WithParametersInCacheKeyAndForwardedToOrigin<T1>(this CombinedResult<T1, InnerCachePolicyCachePolicyConfigFactory> combinedResult, Action<Humidifier.CloudFront.CachePolicyTypes.ParametersInCacheKeyAndForwardedToOrigin> subFactoryAction = null) => new (combinedResult, combinedResult, WithParametersInCacheKeyAndForwardedToOrigin(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCachePolicyCachePolicyConfigFactory, T1, T2, InnerCachePolicyParametersInCacheKeyAndForwardedToOriginFactory> WithParametersInCacheKeyAndForwardedToOrigin<T1, T2>(this CombinedResult<InnerCachePolicyCachePolicyConfigFactory, T1, T2> combinedResult, Action<Humidifier.CloudFront.CachePolicyTypes.ParametersInCacheKeyAndForwardedToOrigin> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParametersInCacheKeyAndForwardedToOrigin(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCachePolicyCachePolicyConfigFactory, T2, InnerCachePolicyParametersInCacheKeyAndForwardedToOriginFactory> WithParametersInCacheKeyAndForwardedToOrigin<T1, T2>(this CombinedResult<T1, InnerCachePolicyCachePolicyConfigFactory, T2> combinedResult, Action<Humidifier.CloudFront.CachePolicyTypes.ParametersInCacheKeyAndForwardedToOrigin> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParametersInCacheKeyAndForwardedToOrigin(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCachePolicyCachePolicyConfigFactory, InnerCachePolicyParametersInCacheKeyAndForwardedToOriginFactory> WithParametersInCacheKeyAndForwardedToOrigin<T1, T2>(this CombinedResult<T1, T2, InnerCachePolicyCachePolicyConfigFactory> combinedResult, Action<Humidifier.CloudFront.CachePolicyTypes.ParametersInCacheKeyAndForwardedToOrigin> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParametersInCacheKeyAndForwardedToOrigin(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCachePolicyCachePolicyConfigFactory, T1, T2, T3, InnerCachePolicyParametersInCacheKeyAndForwardedToOriginFactory> WithParametersInCacheKeyAndForwardedToOrigin<T1, T2, T3>(this CombinedResult<InnerCachePolicyCachePolicyConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFront.CachePolicyTypes.ParametersInCacheKeyAndForwardedToOrigin> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParametersInCacheKeyAndForwardedToOrigin(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCachePolicyCachePolicyConfigFactory, T2, T3, InnerCachePolicyParametersInCacheKeyAndForwardedToOriginFactory> WithParametersInCacheKeyAndForwardedToOrigin<T1, T2, T3>(this CombinedResult<T1, InnerCachePolicyCachePolicyConfigFactory, T2, T3> combinedResult, Action<Humidifier.CloudFront.CachePolicyTypes.ParametersInCacheKeyAndForwardedToOrigin> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParametersInCacheKeyAndForwardedToOrigin(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCachePolicyCachePolicyConfigFactory, T3, InnerCachePolicyParametersInCacheKeyAndForwardedToOriginFactory> WithParametersInCacheKeyAndForwardedToOrigin<T1, T2, T3>(this CombinedResult<T1, T2, InnerCachePolicyCachePolicyConfigFactory, T3> combinedResult, Action<Humidifier.CloudFront.CachePolicyTypes.ParametersInCacheKeyAndForwardedToOrigin> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParametersInCacheKeyAndForwardedToOrigin(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCachePolicyCachePolicyConfigFactory, InnerCachePolicyParametersInCacheKeyAndForwardedToOriginFactory> WithParametersInCacheKeyAndForwardedToOrigin<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCachePolicyCachePolicyConfigFactory> combinedResult, Action<Humidifier.CloudFront.CachePolicyTypes.ParametersInCacheKeyAndForwardedToOrigin> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParametersInCacheKeyAndForwardedToOrigin(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCachePolicyCachePolicyConfigFactory, T1, T2, T3, T4, InnerCachePolicyParametersInCacheKeyAndForwardedToOriginFactory> WithParametersInCacheKeyAndForwardedToOrigin<T1, T2, T3, T4>(this CombinedResult<InnerCachePolicyCachePolicyConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.CachePolicyTypes.ParametersInCacheKeyAndForwardedToOrigin> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParametersInCacheKeyAndForwardedToOrigin(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCachePolicyCachePolicyConfigFactory, T2, T3, T4, InnerCachePolicyParametersInCacheKeyAndForwardedToOriginFactory> WithParametersInCacheKeyAndForwardedToOrigin<T1, T2, T3, T4>(this CombinedResult<T1, InnerCachePolicyCachePolicyConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.CachePolicyTypes.ParametersInCacheKeyAndForwardedToOrigin> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParametersInCacheKeyAndForwardedToOrigin(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCachePolicyCachePolicyConfigFactory, T3, T4, InnerCachePolicyParametersInCacheKeyAndForwardedToOriginFactory> WithParametersInCacheKeyAndForwardedToOrigin<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCachePolicyCachePolicyConfigFactory, T3, T4> combinedResult, Action<Humidifier.CloudFront.CachePolicyTypes.ParametersInCacheKeyAndForwardedToOrigin> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParametersInCacheKeyAndForwardedToOrigin(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCachePolicyCachePolicyConfigFactory, T4, InnerCachePolicyParametersInCacheKeyAndForwardedToOriginFactory> WithParametersInCacheKeyAndForwardedToOrigin<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCachePolicyCachePolicyConfigFactory, T4> combinedResult, Action<Humidifier.CloudFront.CachePolicyTypes.ParametersInCacheKeyAndForwardedToOrigin> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParametersInCacheKeyAndForwardedToOrigin(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCachePolicyCachePolicyConfigFactory, InnerCachePolicyParametersInCacheKeyAndForwardedToOriginFactory> WithParametersInCacheKeyAndForwardedToOrigin<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCachePolicyCachePolicyConfigFactory> combinedResult, Action<Humidifier.CloudFront.CachePolicyTypes.ParametersInCacheKeyAndForwardedToOrigin> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParametersInCacheKeyAndForwardedToOrigin(combinedResult.T5, subFactoryAction));
}
