// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElastiCache;

public class InnerServerlessCacheCacheUsageLimitsFactory(Action<Humidifier.ElastiCache.ServerlessCacheTypes.CacheUsageLimits> factoryAction = null) : SubResourceFactory<Humidifier.ElastiCache.ServerlessCacheTypes.CacheUsageLimits>
{

    internal InnerServerlessCacheDataStorageFactory DataStorageFactory { get; set; }

    internal InnerServerlessCacheECPUPerSecondFactory ECPUPerSecondFactory { get; set; }

    protected override Humidifier.ElastiCache.ServerlessCacheTypes.CacheUsageLimits Create()
    {
        var cacheUsageLimitsResult = CreateCacheUsageLimits();
        factoryAction?.Invoke(cacheUsageLimitsResult);

        return cacheUsageLimitsResult;
    }

    private Humidifier.ElastiCache.ServerlessCacheTypes.CacheUsageLimits CreateCacheUsageLimits()
    {
        var cacheUsageLimitsResult = new Humidifier.ElastiCache.ServerlessCacheTypes.CacheUsageLimits();

        return cacheUsageLimitsResult;
    }
    public override void CreateChildren(Humidifier.ElastiCache.ServerlessCacheTypes.CacheUsageLimits result)
    {
        base.CreateChildren(result);

        result.DataStorage ??= DataStorageFactory?.Build();
        result.ECPUPerSecond ??= ECPUPerSecondFactory?.Build();
    }

} // End Of Class

public static class InnerServerlessCacheCacheUsageLimitsFactoryExtensions
{
    public static CombinedResult<InnerServerlessCacheCacheUsageLimitsFactory, InnerServerlessCacheDataStorageFactory> WithDataStorage(this InnerServerlessCacheCacheUsageLimitsFactory parentFactory, Action<Humidifier.ElastiCache.ServerlessCacheTypes.DataStorage> subFactoryAction = null)
    {
        parentFactory.DataStorageFactory = new InnerServerlessCacheDataStorageFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataStorageFactory);
    }

    public static CombinedResult<InnerServerlessCacheCacheUsageLimitsFactory, InnerServerlessCacheECPUPerSecondFactory> WithECPUPerSecond(this InnerServerlessCacheCacheUsageLimitsFactory parentFactory, Action<Humidifier.ElastiCache.ServerlessCacheTypes.ECPUPerSecond> subFactoryAction = null)
    {
        parentFactory.ECPUPerSecondFactory = new InnerServerlessCacheECPUPerSecondFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ECPUPerSecondFactory);
    }

    public static CombinedResult<InnerServerlessCacheCacheUsageLimitsFactory, T1, InnerServerlessCacheDataStorageFactory> WithDataStorage<T1>(this CombinedResult<InnerServerlessCacheCacheUsageLimitsFactory, T1> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.DataStorage> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataStorage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServerlessCacheCacheUsageLimitsFactory, InnerServerlessCacheDataStorageFactory> WithDataStorage<T1>(this CombinedResult<T1, InnerServerlessCacheCacheUsageLimitsFactory> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.DataStorage> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataStorage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerServerlessCacheCacheUsageLimitsFactory, T1, T2, InnerServerlessCacheDataStorageFactory> WithDataStorage<T1, T2>(this CombinedResult<InnerServerlessCacheCacheUsageLimitsFactory, T1, T2> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.DataStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataStorage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServerlessCacheCacheUsageLimitsFactory, T2, InnerServerlessCacheDataStorageFactory> WithDataStorage<T1, T2>(this CombinedResult<T1, InnerServerlessCacheCacheUsageLimitsFactory, T2> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.DataStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataStorage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServerlessCacheCacheUsageLimitsFactory, InnerServerlessCacheDataStorageFactory> WithDataStorage<T1, T2>(this CombinedResult<T1, T2, InnerServerlessCacheCacheUsageLimitsFactory> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.DataStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataStorage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerServerlessCacheCacheUsageLimitsFactory, T1, T2, T3, InnerServerlessCacheDataStorageFactory> WithDataStorage<T1, T2, T3>(this CombinedResult<InnerServerlessCacheCacheUsageLimitsFactory, T1, T2, T3> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.DataStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataStorage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServerlessCacheCacheUsageLimitsFactory, T2, T3, InnerServerlessCacheDataStorageFactory> WithDataStorage<T1, T2, T3>(this CombinedResult<T1, InnerServerlessCacheCacheUsageLimitsFactory, T2, T3> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.DataStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataStorage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServerlessCacheCacheUsageLimitsFactory, T3, InnerServerlessCacheDataStorageFactory> WithDataStorage<T1, T2, T3>(this CombinedResult<T1, T2, InnerServerlessCacheCacheUsageLimitsFactory, T3> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.DataStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataStorage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServerlessCacheCacheUsageLimitsFactory, InnerServerlessCacheDataStorageFactory> WithDataStorage<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServerlessCacheCacheUsageLimitsFactory> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.DataStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataStorage(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerServerlessCacheCacheUsageLimitsFactory, T1, T2, T3, T4, InnerServerlessCacheDataStorageFactory> WithDataStorage<T1, T2, T3, T4>(this CombinedResult<InnerServerlessCacheCacheUsageLimitsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.DataStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataStorage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServerlessCacheCacheUsageLimitsFactory, T2, T3, T4, InnerServerlessCacheDataStorageFactory> WithDataStorage<T1, T2, T3, T4>(this CombinedResult<T1, InnerServerlessCacheCacheUsageLimitsFactory, T2, T3, T4> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.DataStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataStorage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServerlessCacheCacheUsageLimitsFactory, T3, T4, InnerServerlessCacheDataStorageFactory> WithDataStorage<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServerlessCacheCacheUsageLimitsFactory, T3, T4> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.DataStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataStorage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServerlessCacheCacheUsageLimitsFactory, T4, InnerServerlessCacheDataStorageFactory> WithDataStorage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServerlessCacheCacheUsageLimitsFactory, T4> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.DataStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataStorage(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerServerlessCacheCacheUsageLimitsFactory, InnerServerlessCacheDataStorageFactory> WithDataStorage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServerlessCacheCacheUsageLimitsFactory> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.DataStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataStorage(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerServerlessCacheCacheUsageLimitsFactory, T1, InnerServerlessCacheECPUPerSecondFactory> WithECPUPerSecond<T1>(this CombinedResult<InnerServerlessCacheCacheUsageLimitsFactory, T1> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.ECPUPerSecond> subFactoryAction = null) => new (combinedResult, combinedResult, WithECPUPerSecond(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServerlessCacheCacheUsageLimitsFactory, InnerServerlessCacheECPUPerSecondFactory> WithECPUPerSecond<T1>(this CombinedResult<T1, InnerServerlessCacheCacheUsageLimitsFactory> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.ECPUPerSecond> subFactoryAction = null) => new (combinedResult, combinedResult, WithECPUPerSecond(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerServerlessCacheCacheUsageLimitsFactory, T1, T2, InnerServerlessCacheECPUPerSecondFactory> WithECPUPerSecond<T1, T2>(this CombinedResult<InnerServerlessCacheCacheUsageLimitsFactory, T1, T2> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.ECPUPerSecond> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithECPUPerSecond(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServerlessCacheCacheUsageLimitsFactory, T2, InnerServerlessCacheECPUPerSecondFactory> WithECPUPerSecond<T1, T2>(this CombinedResult<T1, InnerServerlessCacheCacheUsageLimitsFactory, T2> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.ECPUPerSecond> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithECPUPerSecond(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServerlessCacheCacheUsageLimitsFactory, InnerServerlessCacheECPUPerSecondFactory> WithECPUPerSecond<T1, T2>(this CombinedResult<T1, T2, InnerServerlessCacheCacheUsageLimitsFactory> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.ECPUPerSecond> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithECPUPerSecond(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerServerlessCacheCacheUsageLimitsFactory, T1, T2, T3, InnerServerlessCacheECPUPerSecondFactory> WithECPUPerSecond<T1, T2, T3>(this CombinedResult<InnerServerlessCacheCacheUsageLimitsFactory, T1, T2, T3> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.ECPUPerSecond> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithECPUPerSecond(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServerlessCacheCacheUsageLimitsFactory, T2, T3, InnerServerlessCacheECPUPerSecondFactory> WithECPUPerSecond<T1, T2, T3>(this CombinedResult<T1, InnerServerlessCacheCacheUsageLimitsFactory, T2, T3> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.ECPUPerSecond> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithECPUPerSecond(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServerlessCacheCacheUsageLimitsFactory, T3, InnerServerlessCacheECPUPerSecondFactory> WithECPUPerSecond<T1, T2, T3>(this CombinedResult<T1, T2, InnerServerlessCacheCacheUsageLimitsFactory, T3> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.ECPUPerSecond> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithECPUPerSecond(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServerlessCacheCacheUsageLimitsFactory, InnerServerlessCacheECPUPerSecondFactory> WithECPUPerSecond<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServerlessCacheCacheUsageLimitsFactory> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.ECPUPerSecond> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithECPUPerSecond(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerServerlessCacheCacheUsageLimitsFactory, T1, T2, T3, T4, InnerServerlessCacheECPUPerSecondFactory> WithECPUPerSecond<T1, T2, T3, T4>(this CombinedResult<InnerServerlessCacheCacheUsageLimitsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.ECPUPerSecond> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithECPUPerSecond(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServerlessCacheCacheUsageLimitsFactory, T2, T3, T4, InnerServerlessCacheECPUPerSecondFactory> WithECPUPerSecond<T1, T2, T3, T4>(this CombinedResult<T1, InnerServerlessCacheCacheUsageLimitsFactory, T2, T3, T4> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.ECPUPerSecond> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithECPUPerSecond(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServerlessCacheCacheUsageLimitsFactory, T3, T4, InnerServerlessCacheECPUPerSecondFactory> WithECPUPerSecond<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServerlessCacheCacheUsageLimitsFactory, T3, T4> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.ECPUPerSecond> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithECPUPerSecond(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServerlessCacheCacheUsageLimitsFactory, T4, InnerServerlessCacheECPUPerSecondFactory> WithECPUPerSecond<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServerlessCacheCacheUsageLimitsFactory, T4> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.ECPUPerSecond> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithECPUPerSecond(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerServerlessCacheCacheUsageLimitsFactory, InnerServerlessCacheECPUPerSecondFactory> WithECPUPerSecond<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServerlessCacheCacheUsageLimitsFactory> combinedResult, Action<Humidifier.ElastiCache.ServerlessCacheTypes.ECPUPerSecond> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithECPUPerSecond(combinedResult.T5, subFactoryAction));
}
