// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElastiCache;

public class ReplicationGroupFactory(string resourceName = null, Action<Humidifier.ElastiCache.ReplicationGroup> factoryAction = null) : ResourceFactory<Humidifier.ElastiCache.ReplicationGroup>(resourceName)
{

    internal List<InnerReplicationGroupLogDeliveryConfigurationRequestFactory> LogDeliveryConfigurationsFactories { get; set; } = [];

    internal List<InnerReplicationGroupNodeGroupConfigurationFactory> NodeGroupConfigurationFactories { get; set; } = [];

    protected override Humidifier.ElastiCache.ReplicationGroup Create()
    {
        var replicationGroupResult = CreateReplicationGroup();
        factoryAction?.Invoke(replicationGroupResult);

        return replicationGroupResult;
    }

    private Humidifier.ElastiCache.ReplicationGroup CreateReplicationGroup()
    {
        var replicationGroupResult = new Humidifier.ElastiCache.ReplicationGroup
        {
            GivenName = InputResourceName,
        };

        return replicationGroupResult;
    }
    public override void CreateChildren(Humidifier.ElastiCache.ReplicationGroup result)
    {
        base.CreateChildren(result);

        result.LogDeliveryConfigurations = LogDeliveryConfigurationsFactories.Any() ? LogDeliveryConfigurationsFactories.Select(x => x.Build()).ToList() : null;
        result.NodeGroupConfiguration = NodeGroupConfigurationFactories.Any() ? NodeGroupConfigurationFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ReplicationGroupFactoryExtensions
{
    public static CombinedResult<ReplicationGroupFactory, InnerReplicationGroupLogDeliveryConfigurationRequestFactory> WithLogDeliveryConfigurations(this ReplicationGroupFactory parentFactory, Action<Humidifier.ElastiCache.ReplicationGroupTypes.LogDeliveryConfigurationRequest> subFactoryAction = null)
    {
        var factory = new InnerReplicationGroupLogDeliveryConfigurationRequestFactory(subFactoryAction);
        parentFactory.LogDeliveryConfigurationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ReplicationGroupFactory, InnerReplicationGroupNodeGroupConfigurationFactory> WithNodeGroupConfiguration(this ReplicationGroupFactory parentFactory, Action<Humidifier.ElastiCache.ReplicationGroupTypes.NodeGroupConfiguration> subFactoryAction = null)
    {
        var factory = new InnerReplicationGroupNodeGroupConfigurationFactory(subFactoryAction);
        parentFactory.NodeGroupConfigurationFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ReplicationGroupFactory, T1, InnerReplicationGroupLogDeliveryConfigurationRequestFactory> WithLogDeliveryConfigurations<T1>(this CombinedResult<ReplicationGroupFactory, T1> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.LogDeliveryConfigurationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, WithLogDeliveryConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReplicationGroupFactory, InnerReplicationGroupLogDeliveryConfigurationRequestFactory> WithLogDeliveryConfigurations<T1>(this CombinedResult<T1, ReplicationGroupFactory> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.LogDeliveryConfigurationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, WithLogDeliveryConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ReplicationGroupFactory, T1, T2, InnerReplicationGroupLogDeliveryConfigurationRequestFactory> WithLogDeliveryConfigurations<T1, T2>(this CombinedResult<ReplicationGroupFactory, T1, T2> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.LogDeliveryConfigurationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogDeliveryConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReplicationGroupFactory, T2, InnerReplicationGroupLogDeliveryConfigurationRequestFactory> WithLogDeliveryConfigurations<T1, T2>(this CombinedResult<T1, ReplicationGroupFactory, T2> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.LogDeliveryConfigurationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogDeliveryConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReplicationGroupFactory, InnerReplicationGroupLogDeliveryConfigurationRequestFactory> WithLogDeliveryConfigurations<T1, T2>(this CombinedResult<T1, T2, ReplicationGroupFactory> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.LogDeliveryConfigurationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogDeliveryConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ReplicationGroupFactory, T1, T2, T3, InnerReplicationGroupLogDeliveryConfigurationRequestFactory> WithLogDeliveryConfigurations<T1, T2, T3>(this CombinedResult<ReplicationGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.LogDeliveryConfigurationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogDeliveryConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReplicationGroupFactory, T2, T3, InnerReplicationGroupLogDeliveryConfigurationRequestFactory> WithLogDeliveryConfigurations<T1, T2, T3>(this CombinedResult<T1, ReplicationGroupFactory, T2, T3> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.LogDeliveryConfigurationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogDeliveryConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReplicationGroupFactory, T3, InnerReplicationGroupLogDeliveryConfigurationRequestFactory> WithLogDeliveryConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, ReplicationGroupFactory, T3> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.LogDeliveryConfigurationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogDeliveryConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ReplicationGroupFactory, InnerReplicationGroupLogDeliveryConfigurationRequestFactory> WithLogDeliveryConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, T3, ReplicationGroupFactory> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.LogDeliveryConfigurationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogDeliveryConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ReplicationGroupFactory, T1, T2, T3, T4, InnerReplicationGroupLogDeliveryConfigurationRequestFactory> WithLogDeliveryConfigurations<T1, T2, T3, T4>(this CombinedResult<ReplicationGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.LogDeliveryConfigurationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogDeliveryConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReplicationGroupFactory, T2, T3, T4, InnerReplicationGroupLogDeliveryConfigurationRequestFactory> WithLogDeliveryConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, ReplicationGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.LogDeliveryConfigurationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogDeliveryConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReplicationGroupFactory, T3, T4, InnerReplicationGroupLogDeliveryConfigurationRequestFactory> WithLogDeliveryConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, ReplicationGroupFactory, T3, T4> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.LogDeliveryConfigurationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogDeliveryConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ReplicationGroupFactory, T4, InnerReplicationGroupLogDeliveryConfigurationRequestFactory> WithLogDeliveryConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ReplicationGroupFactory, T4> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.LogDeliveryConfigurationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogDeliveryConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ReplicationGroupFactory, InnerReplicationGroupLogDeliveryConfigurationRequestFactory> WithLogDeliveryConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ReplicationGroupFactory> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.LogDeliveryConfigurationRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogDeliveryConfigurations(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ReplicationGroupFactory, T1, InnerReplicationGroupNodeGroupConfigurationFactory> WithNodeGroupConfiguration<T1>(this CombinedResult<ReplicationGroupFactory, T1> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.NodeGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithNodeGroupConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReplicationGroupFactory, InnerReplicationGroupNodeGroupConfigurationFactory> WithNodeGroupConfiguration<T1>(this CombinedResult<T1, ReplicationGroupFactory> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.NodeGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithNodeGroupConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ReplicationGroupFactory, T1, T2, InnerReplicationGroupNodeGroupConfigurationFactory> WithNodeGroupConfiguration<T1, T2>(this CombinedResult<ReplicationGroupFactory, T1, T2> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.NodeGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNodeGroupConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReplicationGroupFactory, T2, InnerReplicationGroupNodeGroupConfigurationFactory> WithNodeGroupConfiguration<T1, T2>(this CombinedResult<T1, ReplicationGroupFactory, T2> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.NodeGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNodeGroupConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReplicationGroupFactory, InnerReplicationGroupNodeGroupConfigurationFactory> WithNodeGroupConfiguration<T1, T2>(this CombinedResult<T1, T2, ReplicationGroupFactory> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.NodeGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNodeGroupConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ReplicationGroupFactory, T1, T2, T3, InnerReplicationGroupNodeGroupConfigurationFactory> WithNodeGroupConfiguration<T1, T2, T3>(this CombinedResult<ReplicationGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.NodeGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNodeGroupConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReplicationGroupFactory, T2, T3, InnerReplicationGroupNodeGroupConfigurationFactory> WithNodeGroupConfiguration<T1, T2, T3>(this CombinedResult<T1, ReplicationGroupFactory, T2, T3> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.NodeGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNodeGroupConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReplicationGroupFactory, T3, InnerReplicationGroupNodeGroupConfigurationFactory> WithNodeGroupConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, ReplicationGroupFactory, T3> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.NodeGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNodeGroupConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ReplicationGroupFactory, InnerReplicationGroupNodeGroupConfigurationFactory> WithNodeGroupConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, ReplicationGroupFactory> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.NodeGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNodeGroupConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ReplicationGroupFactory, T1, T2, T3, T4, InnerReplicationGroupNodeGroupConfigurationFactory> WithNodeGroupConfiguration<T1, T2, T3, T4>(this CombinedResult<ReplicationGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.NodeGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNodeGroupConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReplicationGroupFactory, T2, T3, T4, InnerReplicationGroupNodeGroupConfigurationFactory> WithNodeGroupConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, ReplicationGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.NodeGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNodeGroupConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReplicationGroupFactory, T3, T4, InnerReplicationGroupNodeGroupConfigurationFactory> WithNodeGroupConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, ReplicationGroupFactory, T3, T4> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.NodeGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNodeGroupConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ReplicationGroupFactory, T4, InnerReplicationGroupNodeGroupConfigurationFactory> WithNodeGroupConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ReplicationGroupFactory, T4> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.NodeGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNodeGroupConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ReplicationGroupFactory, InnerReplicationGroupNodeGroupConfigurationFactory> WithNodeGroupConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ReplicationGroupFactory> combinedResult, Action<Humidifier.ElastiCache.ReplicationGroupTypes.NodeGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNodeGroupConfiguration(combinedResult.T5, subFactoryAction));
}
