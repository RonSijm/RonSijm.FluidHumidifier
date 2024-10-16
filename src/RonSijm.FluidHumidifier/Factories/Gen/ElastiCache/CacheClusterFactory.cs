// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElastiCache;

public class CacheClusterFactory(string resourceName = null, Action<Humidifier.ElastiCache.CacheCluster> factoryAction = null) : ResourceFactory<Humidifier.ElastiCache.CacheCluster>(resourceName)
{

    internal List<InnerCacheClusterLogDeliveryConfigurationRequestFactory> LogDeliveryConfigurationsFactories { get; set; } = [];

    protected override Humidifier.ElastiCache.CacheCluster Create()
    {
        var cacheClusterResult = CreateCacheCluster();
        factoryAction?.Invoke(cacheClusterResult);

        return cacheClusterResult;
    }

    private Humidifier.ElastiCache.CacheCluster CreateCacheCluster()
    {
        var cacheClusterResult = new Humidifier.ElastiCache.CacheCluster
        {
            GivenName = InputResourceName,
        };

        return cacheClusterResult;
    }
    public override void CreateChildren(Humidifier.ElastiCache.CacheCluster result)
    {
        base.CreateChildren(result);

        result.LogDeliveryConfigurations = LogDeliveryConfigurationsFactories.Any() ? LogDeliveryConfigurationsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class CacheClusterFactoryExtensions
{
    public static CombinedResult<CacheClusterFactory, InnerCacheClusterLogDeliveryConfigurationRequestFactory> WithLogDeliveryConfigurations(this CacheClusterFactory parentFactory, Action<Humidifier.ElastiCache.CacheClusterTypes.LogDeliveryConfigurationRequest> subFactoryAction = null)
    {
        var factory = new InnerCacheClusterLogDeliveryConfigurationRequestFactory(subFactoryAction);
        parentFactory.LogDeliveryConfigurationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<CacheClusterFactory, T1, InnerCacheClusterLogDeliveryConfigurationRequestFactory> WithLogDeliveryConfigurations<T1>(this CombinedResult<CacheClusterFactory, T1> combinedResult, Action<Humidifier.ElastiCache.CacheClusterTypes.LogDeliveryConfigurationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, WithLogDeliveryConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CacheClusterFactory, InnerCacheClusterLogDeliveryConfigurationRequestFactory> WithLogDeliveryConfigurations<T1>(this CombinedResult<T1, CacheClusterFactory> combinedResult, Action<Humidifier.ElastiCache.CacheClusterTypes.LogDeliveryConfigurationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, WithLogDeliveryConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CacheClusterFactory, T1, T2, InnerCacheClusterLogDeliveryConfigurationRequestFactory> WithLogDeliveryConfigurations<T1, T2>(this CombinedResult<CacheClusterFactory, T1, T2> combinedResult, Action<Humidifier.ElastiCache.CacheClusterTypes.LogDeliveryConfigurationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogDeliveryConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CacheClusterFactory, T2, InnerCacheClusterLogDeliveryConfigurationRequestFactory> WithLogDeliveryConfigurations<T1, T2>(this CombinedResult<T1, CacheClusterFactory, T2> combinedResult, Action<Humidifier.ElastiCache.CacheClusterTypes.LogDeliveryConfigurationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogDeliveryConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CacheClusterFactory, InnerCacheClusterLogDeliveryConfigurationRequestFactory> WithLogDeliveryConfigurations<T1, T2>(this CombinedResult<T1, T2, CacheClusterFactory> combinedResult, Action<Humidifier.ElastiCache.CacheClusterTypes.LogDeliveryConfigurationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogDeliveryConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CacheClusterFactory, T1, T2, T3, InnerCacheClusterLogDeliveryConfigurationRequestFactory> WithLogDeliveryConfigurations<T1, T2, T3>(this CombinedResult<CacheClusterFactory, T1, T2, T3> combinedResult, Action<Humidifier.ElastiCache.CacheClusterTypes.LogDeliveryConfigurationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogDeliveryConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CacheClusterFactory, T2, T3, InnerCacheClusterLogDeliveryConfigurationRequestFactory> WithLogDeliveryConfigurations<T1, T2, T3>(this CombinedResult<T1, CacheClusterFactory, T2, T3> combinedResult, Action<Humidifier.ElastiCache.CacheClusterTypes.LogDeliveryConfigurationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogDeliveryConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CacheClusterFactory, T3, InnerCacheClusterLogDeliveryConfigurationRequestFactory> WithLogDeliveryConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, CacheClusterFactory, T3> combinedResult, Action<Humidifier.ElastiCache.CacheClusterTypes.LogDeliveryConfigurationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogDeliveryConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CacheClusterFactory, InnerCacheClusterLogDeliveryConfigurationRequestFactory> WithLogDeliveryConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, T3, CacheClusterFactory> combinedResult, Action<Humidifier.ElastiCache.CacheClusterTypes.LogDeliveryConfigurationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogDeliveryConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CacheClusterFactory, T1, T2, T3, T4, InnerCacheClusterLogDeliveryConfigurationRequestFactory> WithLogDeliveryConfigurations<T1, T2, T3, T4>(this CombinedResult<CacheClusterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ElastiCache.CacheClusterTypes.LogDeliveryConfigurationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogDeliveryConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CacheClusterFactory, T2, T3, T4, InnerCacheClusterLogDeliveryConfigurationRequestFactory> WithLogDeliveryConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, CacheClusterFactory, T2, T3, T4> combinedResult, Action<Humidifier.ElastiCache.CacheClusterTypes.LogDeliveryConfigurationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogDeliveryConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CacheClusterFactory, T3, T4, InnerCacheClusterLogDeliveryConfigurationRequestFactory> WithLogDeliveryConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, CacheClusterFactory, T3, T4> combinedResult, Action<Humidifier.ElastiCache.CacheClusterTypes.LogDeliveryConfigurationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogDeliveryConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CacheClusterFactory, T4, InnerCacheClusterLogDeliveryConfigurationRequestFactory> WithLogDeliveryConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CacheClusterFactory, T4> combinedResult, Action<Humidifier.ElastiCache.CacheClusterTypes.LogDeliveryConfigurationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogDeliveryConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CacheClusterFactory, InnerCacheClusterLogDeliveryConfigurationRequestFactory> WithLogDeliveryConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CacheClusterFactory> combinedResult, Action<Humidifier.ElastiCache.CacheClusterTypes.LogDeliveryConfigurationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogDeliveryConfigurations(combinedResult.T5, subFactoryAction));
}
