// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElastiCache;

public class ServerlessCacheFactory(string resourceName = null, Action<Humidifier.ElastiCache.ServerlessCache> factoryAction = null) : ResourceFactory<Humidifier.ElastiCache.ServerlessCache>(resourceName)
{

    internal InnerServerlessCacheCacheUsageLimitsFactory CacheUsageLimitsFactory { get; set; }

    internal InnerServerlessCacheEndpointFactory ReaderEndpointFactory { get; set; }

    internal InnerServerlessCacheEndpointFactory EndpointFactory { get; set; }

    protected override Humidifier.ElastiCache.ServerlessCache Create()
    {
        var serverlessCacheResult = CreateServerlessCache();
        factoryAction?.Invoke(serverlessCacheResult);

        return serverlessCacheResult;
    }

    private Humidifier.ElastiCache.ServerlessCache CreateServerlessCache()
    {
        var serverlessCacheResult = new Humidifier.ElastiCache.ServerlessCache
        {
            GivenName = InputResourceName,
        };

        return serverlessCacheResult;
    }
    public override void CreateChildren(Humidifier.ElastiCache.ServerlessCache result)
    {
        base.CreateChildren(result);

        result.CacheUsageLimits ??= CacheUsageLimitsFactory?.Build();
        result.ReaderEndpoint ??= ReaderEndpointFactory?.Build();
        result.Endpoint ??= EndpointFactory?.Build();
    }

} // End Of Class

public static class ServerlessCacheFactoryExtensions
{
    public static CombinedResult<ServerlessCacheFactory, InnerServerlessCacheCacheUsageLimitsFactory> WithCacheUsageLimits(this ServerlessCacheFactory parentFactory, Action<Humidifier.ElastiCache.ServerlessCacheTypes.CacheUsageLimits> subFactoryAction = null)
    {
        parentFactory.CacheUsageLimitsFactory = new InnerServerlessCacheCacheUsageLimitsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CacheUsageLimitsFactory);
    }

    public static CombinedResult<ServerlessCacheFactory, InnerServerlessCacheEndpointFactory> WithReaderEndpoint(this ServerlessCacheFactory parentFactory, Action<Humidifier.ElastiCache.ServerlessCacheTypes.Endpoint> subFactoryAction = null)
    {
        parentFactory.ReaderEndpointFactory = new InnerServerlessCacheEndpointFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ReaderEndpointFactory);
    }

    public static CombinedResult<ServerlessCacheFactory, InnerServerlessCacheEndpointFactory> WithEndpoint(this ServerlessCacheFactory parentFactory, Action<Humidifier.ElastiCache.ServerlessCacheTypes.Endpoint> subFactoryAction = null)
    {
        parentFactory.EndpointFactory = new InnerServerlessCacheEndpointFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EndpointFactory);
    }

    public static CombinedResult<ServerlessCacheFactory, T1, InnerServerlessCacheCacheUsageLimitsFactory> WithCacheUsageLimits<T1>(this CombinedResult<ServerlessCacheFactory, T1> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.CacheUsageLimits> subFactoryAction = null) => new (combinedResult, combinedResult, WithCacheUsageLimits(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServerlessCacheFactory, InnerServerlessCacheCacheUsageLimitsFactory> WithCacheUsageLimits<T1>(this CombinedResult<T1, ServerlessCacheFactory> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.CacheUsageLimits> subFactoryAction = null) => new (combinedResult, combinedResult, WithCacheUsageLimits(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ServerlessCacheFactory, T1, T2, InnerServerlessCacheCacheUsageLimitsFactory> WithCacheUsageLimits<T1, T2>(this CombinedResult<ServerlessCacheFactory, T1, T2> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.CacheUsageLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCacheUsageLimits(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServerlessCacheFactory, T2, InnerServerlessCacheCacheUsageLimitsFactory> WithCacheUsageLimits<T1, T2>(this CombinedResult<T1, ServerlessCacheFactory, T2> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.CacheUsageLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCacheUsageLimits(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServerlessCacheFactory, InnerServerlessCacheCacheUsageLimitsFactory> WithCacheUsageLimits<T1, T2>(this CombinedResult<T1, T2, ServerlessCacheFactory> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.CacheUsageLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCacheUsageLimits(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ServerlessCacheFactory, T1, T2, T3, InnerServerlessCacheCacheUsageLimitsFactory> WithCacheUsageLimits<T1, T2, T3>(this CombinedResult<ServerlessCacheFactory, T1, T2, T3> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.CacheUsageLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCacheUsageLimits(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServerlessCacheFactory, T2, T3, InnerServerlessCacheCacheUsageLimitsFactory> WithCacheUsageLimits<T1, T2, T3>(this CombinedResult<T1, ServerlessCacheFactory, T2, T3> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.CacheUsageLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCacheUsageLimits(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServerlessCacheFactory, T3, InnerServerlessCacheCacheUsageLimitsFactory> WithCacheUsageLimits<T1, T2, T3>(this CombinedResult<T1, T2, ServerlessCacheFactory, T3> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.CacheUsageLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCacheUsageLimits(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ServerlessCacheFactory, InnerServerlessCacheCacheUsageLimitsFactory> WithCacheUsageLimits<T1, T2, T3>(this CombinedResult<T1, T2, T3, ServerlessCacheFactory> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.CacheUsageLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCacheUsageLimits(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ServerlessCacheFactory, T1, T2, T3, T4, InnerServerlessCacheCacheUsageLimitsFactory> WithCacheUsageLimits<T1, T2, T3, T4>(this CombinedResult<ServerlessCacheFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.CacheUsageLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCacheUsageLimits(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServerlessCacheFactory, T2, T3, T4, InnerServerlessCacheCacheUsageLimitsFactory> WithCacheUsageLimits<T1, T2, T3, T4>(this CombinedResult<T1, ServerlessCacheFactory, T2, T3, T4> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.CacheUsageLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCacheUsageLimits(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServerlessCacheFactory, T3, T4, InnerServerlessCacheCacheUsageLimitsFactory> WithCacheUsageLimits<T1, T2, T3, T4>(this CombinedResult<T1, T2, ServerlessCacheFactory, T3, T4> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.CacheUsageLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCacheUsageLimits(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ServerlessCacheFactory, T4, InnerServerlessCacheCacheUsageLimitsFactory> WithCacheUsageLimits<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ServerlessCacheFactory, T4> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.CacheUsageLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCacheUsageLimits(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ServerlessCacheFactory, InnerServerlessCacheCacheUsageLimitsFactory> WithCacheUsageLimits<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ServerlessCacheFactory> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.CacheUsageLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCacheUsageLimits(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ServerlessCacheFactory, T1, InnerServerlessCacheEndpointFactory> WithReaderEndpoint<T1>(this CombinedResult<ServerlessCacheFactory, T1> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithReaderEndpoint(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServerlessCacheFactory, InnerServerlessCacheEndpointFactory> WithReaderEndpoint<T1>(this CombinedResult<T1, ServerlessCacheFactory> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithReaderEndpoint(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ServerlessCacheFactory, T1, T2, InnerServerlessCacheEndpointFactory> WithReaderEndpoint<T1, T2>(this CombinedResult<ServerlessCacheFactory, T1, T2> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReaderEndpoint(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServerlessCacheFactory, T2, InnerServerlessCacheEndpointFactory> WithReaderEndpoint<T1, T2>(this CombinedResult<T1, ServerlessCacheFactory, T2> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReaderEndpoint(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServerlessCacheFactory, InnerServerlessCacheEndpointFactory> WithReaderEndpoint<T1, T2>(this CombinedResult<T1, T2, ServerlessCacheFactory> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReaderEndpoint(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ServerlessCacheFactory, T1, T2, T3, InnerServerlessCacheEndpointFactory> WithReaderEndpoint<T1, T2, T3>(this CombinedResult<ServerlessCacheFactory, T1, T2, T3> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReaderEndpoint(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServerlessCacheFactory, T2, T3, InnerServerlessCacheEndpointFactory> WithReaderEndpoint<T1, T2, T3>(this CombinedResult<T1, ServerlessCacheFactory, T2, T3> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReaderEndpoint(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServerlessCacheFactory, T3, InnerServerlessCacheEndpointFactory> WithReaderEndpoint<T1, T2, T3>(this CombinedResult<T1, T2, ServerlessCacheFactory, T3> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReaderEndpoint(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ServerlessCacheFactory, InnerServerlessCacheEndpointFactory> WithReaderEndpoint<T1, T2, T3>(this CombinedResult<T1, T2, T3, ServerlessCacheFactory> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReaderEndpoint(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ServerlessCacheFactory, T1, T2, T3, T4, InnerServerlessCacheEndpointFactory> WithReaderEndpoint<T1, T2, T3, T4>(this CombinedResult<ServerlessCacheFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReaderEndpoint(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServerlessCacheFactory, T2, T3, T4, InnerServerlessCacheEndpointFactory> WithReaderEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, ServerlessCacheFactory, T2, T3, T4> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReaderEndpoint(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServerlessCacheFactory, T3, T4, InnerServerlessCacheEndpointFactory> WithReaderEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, ServerlessCacheFactory, T3, T4> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReaderEndpoint(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ServerlessCacheFactory, T4, InnerServerlessCacheEndpointFactory> WithReaderEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ServerlessCacheFactory, T4> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReaderEndpoint(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ServerlessCacheFactory, InnerServerlessCacheEndpointFactory> WithReaderEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ServerlessCacheFactory> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReaderEndpoint(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ServerlessCacheFactory, T1, InnerServerlessCacheEndpointFactory> WithEndpoint<T1>(this CombinedResult<ServerlessCacheFactory, T1> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithEndpoint(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServerlessCacheFactory, InnerServerlessCacheEndpointFactory> WithEndpoint<T1>(this CombinedResult<T1, ServerlessCacheFactory> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithEndpoint(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ServerlessCacheFactory, T1, T2, InnerServerlessCacheEndpointFactory> WithEndpoint<T1, T2>(this CombinedResult<ServerlessCacheFactory, T1, T2> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndpoint(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServerlessCacheFactory, T2, InnerServerlessCacheEndpointFactory> WithEndpoint<T1, T2>(this CombinedResult<T1, ServerlessCacheFactory, T2> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndpoint(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServerlessCacheFactory, InnerServerlessCacheEndpointFactory> WithEndpoint<T1, T2>(this CombinedResult<T1, T2, ServerlessCacheFactory> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndpoint(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ServerlessCacheFactory, T1, T2, T3, InnerServerlessCacheEndpointFactory> WithEndpoint<T1, T2, T3>(this CombinedResult<ServerlessCacheFactory, T1, T2, T3> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoint(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServerlessCacheFactory, T2, T3, InnerServerlessCacheEndpointFactory> WithEndpoint<T1, T2, T3>(this CombinedResult<T1, ServerlessCacheFactory, T2, T3> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoint(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServerlessCacheFactory, T3, InnerServerlessCacheEndpointFactory> WithEndpoint<T1, T2, T3>(this CombinedResult<T1, T2, ServerlessCacheFactory, T3> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoint(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ServerlessCacheFactory, InnerServerlessCacheEndpointFactory> WithEndpoint<T1, T2, T3>(this CombinedResult<T1, T2, T3, ServerlessCacheFactory> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoint(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ServerlessCacheFactory, T1, T2, T3, T4, InnerServerlessCacheEndpointFactory> WithEndpoint<T1, T2, T3, T4>(this CombinedResult<ServerlessCacheFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoint(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServerlessCacheFactory, T2, T3, T4, InnerServerlessCacheEndpointFactory> WithEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, ServerlessCacheFactory, T2, T3, T4> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoint(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServerlessCacheFactory, T3, T4, InnerServerlessCacheEndpointFactory> WithEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, ServerlessCacheFactory, T3, T4> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoint(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ServerlessCacheFactory, T4, InnerServerlessCacheEndpointFactory> WithEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ServerlessCacheFactory, T4> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoint(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ServerlessCacheFactory, InnerServerlessCacheEndpointFactory> WithEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ServerlessCacheFactory> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoint(combinedResult.T5, subFactoryAction));
}
