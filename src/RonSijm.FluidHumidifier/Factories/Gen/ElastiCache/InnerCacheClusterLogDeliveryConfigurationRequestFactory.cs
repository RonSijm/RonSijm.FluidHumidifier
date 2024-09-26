// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElastiCache;

public class InnerCacheClusterLogDeliveryConfigurationRequestFactory(Action<Humidifier.ElastiCache.CacheClusterTypes.LogDeliveryConfigurationRequest> factoryAction = null) : SubResourceFactory<Humidifier.ElastiCache.CacheClusterTypes.LogDeliveryConfigurationRequest>
{

    internal InnerCacheClusterDestinationDetailsFactory DestinationDetailsFactory { get; set; }

    protected override Humidifier.ElastiCache.CacheClusterTypes.LogDeliveryConfigurationRequest Create()
    {
        var logDeliveryConfigurationRequestResult = CreateLogDeliveryConfigurationRequest();
        factoryAction?.Invoke(logDeliveryConfigurationRequestResult);

        return logDeliveryConfigurationRequestResult;
    }

    private Humidifier.ElastiCache.CacheClusterTypes.LogDeliveryConfigurationRequest CreateLogDeliveryConfigurationRequest()
    {
        var logDeliveryConfigurationRequestResult = new Humidifier.ElastiCache.CacheClusterTypes.LogDeliveryConfigurationRequest();

        return logDeliveryConfigurationRequestResult;
    }
    public override void CreateChildren(Humidifier.ElastiCache.CacheClusterTypes.LogDeliveryConfigurationRequest result)
    {
        base.CreateChildren(result);

        result.DestinationDetails ??= DestinationDetailsFactory?.Build();
    }

} // End Of Class

public static class InnerCacheClusterLogDeliveryConfigurationRequestFactoryExtensions
{
    public static CombinedResult<InnerCacheClusterLogDeliveryConfigurationRequestFactory, InnerCacheClusterDestinationDetailsFactory> WithDestinationDetails(this InnerCacheClusterLogDeliveryConfigurationRequestFactory parentFactory, Action<Humidifier.ElastiCache.CacheClusterTypes.DestinationDetails> subFactoryAction = null)
    {
        parentFactory.DestinationDetailsFactory = new InnerCacheClusterDestinationDetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DestinationDetailsFactory);
    }

    public static CombinedResult<InnerCacheClusterLogDeliveryConfigurationRequestFactory, T1, InnerCacheClusterDestinationDetailsFactory> WithDestinationDetails<T1>(this CombinedResult<InnerCacheClusterLogDeliveryConfigurationRequestFactory, T1> combinedResult, Action<Humidifier.ElastiCache.CacheClusterTypes.DestinationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCacheClusterLogDeliveryConfigurationRequestFactory, InnerCacheClusterDestinationDetailsFactory> WithDestinationDetails<T1>(this CombinedResult<T1, InnerCacheClusterLogDeliveryConfigurationRequestFactory> combinedResult, Action<Humidifier.ElastiCache.CacheClusterTypes.DestinationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCacheClusterLogDeliveryConfigurationRequestFactory, T1, T2, InnerCacheClusterDestinationDetailsFactory> WithDestinationDetails<T1, T2>(this CombinedResult<InnerCacheClusterLogDeliveryConfigurationRequestFactory, T1, T2> combinedResult, Action<Humidifier.ElastiCache.CacheClusterTypes.DestinationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCacheClusterLogDeliveryConfigurationRequestFactory, T2, InnerCacheClusterDestinationDetailsFactory> WithDestinationDetails<T1, T2>(this CombinedResult<T1, InnerCacheClusterLogDeliveryConfigurationRequestFactory, T2> combinedResult, Action<Humidifier.ElastiCache.CacheClusterTypes.DestinationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCacheClusterLogDeliveryConfigurationRequestFactory, InnerCacheClusterDestinationDetailsFactory> WithDestinationDetails<T1, T2>(this CombinedResult<T1, T2, InnerCacheClusterLogDeliveryConfigurationRequestFactory> combinedResult, Action<Humidifier.ElastiCache.CacheClusterTypes.DestinationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCacheClusterLogDeliveryConfigurationRequestFactory, T1, T2, T3, InnerCacheClusterDestinationDetailsFactory> WithDestinationDetails<T1, T2, T3>(this CombinedResult<InnerCacheClusterLogDeliveryConfigurationRequestFactory, T1, T2, T3> combinedResult, Action<Humidifier.ElastiCache.CacheClusterTypes.DestinationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCacheClusterLogDeliveryConfigurationRequestFactory, T2, T3, InnerCacheClusterDestinationDetailsFactory> WithDestinationDetails<T1, T2, T3>(this CombinedResult<T1, InnerCacheClusterLogDeliveryConfigurationRequestFactory, T2, T3> combinedResult, Action<Humidifier.ElastiCache.CacheClusterTypes.DestinationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCacheClusterLogDeliveryConfigurationRequestFactory, T3, InnerCacheClusterDestinationDetailsFactory> WithDestinationDetails<T1, T2, T3>(this CombinedResult<T1, T2, InnerCacheClusterLogDeliveryConfigurationRequestFactory, T3> combinedResult, Action<Humidifier.ElastiCache.CacheClusterTypes.DestinationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCacheClusterLogDeliveryConfigurationRequestFactory, InnerCacheClusterDestinationDetailsFactory> WithDestinationDetails<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCacheClusterLogDeliveryConfigurationRequestFactory> combinedResult, Action<Humidifier.ElastiCache.CacheClusterTypes.DestinationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationDetails(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCacheClusterLogDeliveryConfigurationRequestFactory, T1, T2, T3, T4, InnerCacheClusterDestinationDetailsFactory> WithDestinationDetails<T1, T2, T3, T4>(this CombinedResult<InnerCacheClusterLogDeliveryConfigurationRequestFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ElastiCache.CacheClusterTypes.DestinationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCacheClusterLogDeliveryConfigurationRequestFactory, T2, T3, T4, InnerCacheClusterDestinationDetailsFactory> WithDestinationDetails<T1, T2, T3, T4>(this CombinedResult<T1, InnerCacheClusterLogDeliveryConfigurationRequestFactory, T2, T3, T4> combinedResult, Action<Humidifier.ElastiCache.CacheClusterTypes.DestinationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCacheClusterLogDeliveryConfigurationRequestFactory, T3, T4, InnerCacheClusterDestinationDetailsFactory> WithDestinationDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCacheClusterLogDeliveryConfigurationRequestFactory, T3, T4> combinedResult, Action<Humidifier.ElastiCache.CacheClusterTypes.DestinationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCacheClusterLogDeliveryConfigurationRequestFactory, T4, InnerCacheClusterDestinationDetailsFactory> WithDestinationDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCacheClusterLogDeliveryConfigurationRequestFactory, T4> combinedResult, Action<Humidifier.ElastiCache.CacheClusterTypes.DestinationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationDetails(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCacheClusterLogDeliveryConfigurationRequestFactory, InnerCacheClusterDestinationDetailsFactory> WithDestinationDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCacheClusterLogDeliveryConfigurationRequestFactory> combinedResult, Action<Humidifier.ElastiCache.CacheClusterTypes.DestinationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationDetails(combinedResult.T5, subFactoryAction));
}
