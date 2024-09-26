// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElastiCache;

public class InnerReplicationGroupLogDeliveryConfigurationRequestFactory(Action<Humidifier.ElastiCache.ReplicationGroupTypes.LogDeliveryConfigurationRequest> factoryAction = null) : SubResourceFactory<Humidifier.ElastiCache.ReplicationGroupTypes.LogDeliveryConfigurationRequest>
{

    internal InnerReplicationGroupDestinationDetailsFactory DestinationDetailsFactory { get; set; }

    protected override Humidifier.ElastiCache.ReplicationGroupTypes.LogDeliveryConfigurationRequest Create()
    {
        var logDeliveryConfigurationRequestResult = CreateLogDeliveryConfigurationRequest();
        factoryAction?.Invoke(logDeliveryConfigurationRequestResult);

        return logDeliveryConfigurationRequestResult;
    }

    private Humidifier.ElastiCache.ReplicationGroupTypes.LogDeliveryConfigurationRequest CreateLogDeliveryConfigurationRequest()
    {
        var logDeliveryConfigurationRequestResult = new Humidifier.ElastiCache.ReplicationGroupTypes.LogDeliveryConfigurationRequest();

        return logDeliveryConfigurationRequestResult;
    }
    public override void CreateChildren(Humidifier.ElastiCache.ReplicationGroupTypes.LogDeliveryConfigurationRequest result)
    {
        base.CreateChildren(result);

        result.DestinationDetails ??= DestinationDetailsFactory?.Build();
    }

} // End Of Class

public static class InnerReplicationGroupLogDeliveryConfigurationRequestFactoryExtensions
{
    public static CombinedResult<InnerReplicationGroupLogDeliveryConfigurationRequestFactory, InnerReplicationGroupDestinationDetailsFactory> WithDestinationDetails(this InnerReplicationGroupLogDeliveryConfigurationRequestFactory parentFactory, Action<Humidifier.ElastiCache.ReplicationGroupTypes.DestinationDetails> subFactoryAction = null)
    {
        parentFactory.DestinationDetailsFactory = new InnerReplicationGroupDestinationDetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DestinationDetailsFactory);
    }

    public static CombinedResult<InnerReplicationGroupLogDeliveryConfigurationRequestFactory, T1, InnerReplicationGroupDestinationDetailsFactory> WithDestinationDetails<T1>(this CombinedResult<InnerReplicationGroupLogDeliveryConfigurationRequestFactory, T1> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.DestinationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerReplicationGroupLogDeliveryConfigurationRequestFactory, InnerReplicationGroupDestinationDetailsFactory> WithDestinationDetails<T1>(this CombinedResult<T1, InnerReplicationGroupLogDeliveryConfigurationRequestFactory> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.DestinationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerReplicationGroupLogDeliveryConfigurationRequestFactory, T1, T2, InnerReplicationGroupDestinationDetailsFactory> WithDestinationDetails<T1, T2>(this CombinedResult<InnerReplicationGroupLogDeliveryConfigurationRequestFactory, T1, T2> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.DestinationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerReplicationGroupLogDeliveryConfigurationRequestFactory, T2, InnerReplicationGroupDestinationDetailsFactory> WithDestinationDetails<T1, T2>(this CombinedResult<T1, InnerReplicationGroupLogDeliveryConfigurationRequestFactory, T2> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.DestinationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerReplicationGroupLogDeliveryConfigurationRequestFactory, InnerReplicationGroupDestinationDetailsFactory> WithDestinationDetails<T1, T2>(this CombinedResult<T1, T2, InnerReplicationGroupLogDeliveryConfigurationRequestFactory> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.DestinationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerReplicationGroupLogDeliveryConfigurationRequestFactory, T1, T2, T3, InnerReplicationGroupDestinationDetailsFactory> WithDestinationDetails<T1, T2, T3>(this CombinedResult<InnerReplicationGroupLogDeliveryConfigurationRequestFactory, T1, T2, T3> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.DestinationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerReplicationGroupLogDeliveryConfigurationRequestFactory, T2, T3, InnerReplicationGroupDestinationDetailsFactory> WithDestinationDetails<T1, T2, T3>(this CombinedResult<T1, InnerReplicationGroupLogDeliveryConfigurationRequestFactory, T2, T3> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.DestinationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerReplicationGroupLogDeliveryConfigurationRequestFactory, T3, InnerReplicationGroupDestinationDetailsFactory> WithDestinationDetails<T1, T2, T3>(this CombinedResult<T1, T2, InnerReplicationGroupLogDeliveryConfigurationRequestFactory, T3> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.DestinationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerReplicationGroupLogDeliveryConfigurationRequestFactory, InnerReplicationGroupDestinationDetailsFactory> WithDestinationDetails<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerReplicationGroupLogDeliveryConfigurationRequestFactory> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.DestinationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationDetails(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerReplicationGroupLogDeliveryConfigurationRequestFactory, T1, T2, T3, T4, InnerReplicationGroupDestinationDetailsFactory> WithDestinationDetails<T1, T2, T3, T4>(this CombinedResult<InnerReplicationGroupLogDeliveryConfigurationRequestFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.DestinationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerReplicationGroupLogDeliveryConfigurationRequestFactory, T2, T3, T4, InnerReplicationGroupDestinationDetailsFactory> WithDestinationDetails<T1, T2, T3, T4>(this CombinedResult<T1, InnerReplicationGroupLogDeliveryConfigurationRequestFactory, T2, T3, T4> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.DestinationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerReplicationGroupLogDeliveryConfigurationRequestFactory, T3, T4, InnerReplicationGroupDestinationDetailsFactory> WithDestinationDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerReplicationGroupLogDeliveryConfigurationRequestFactory, T3, T4> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.DestinationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerReplicationGroupLogDeliveryConfigurationRequestFactory, T4, InnerReplicationGroupDestinationDetailsFactory> WithDestinationDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerReplicationGroupLogDeliveryConfigurationRequestFactory, T4> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.DestinationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationDetails(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerReplicationGroupLogDeliveryConfigurationRequestFactory, InnerReplicationGroupDestinationDetailsFactory> WithDestinationDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerReplicationGroupLogDeliveryConfigurationRequestFactory> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.DestinationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationDetails(combinedResult.T5, subFactoryAction));
}
