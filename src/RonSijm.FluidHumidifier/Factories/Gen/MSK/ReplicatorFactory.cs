// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class ReplicatorFactory(string resourceName = null, Action<Humidifier.MSK.Replicator> factoryAction = null) : ResourceFactory<Humidifier.MSK.Replicator>(resourceName)
{

    internal List<InnerReplicatorReplicationInfoFactory> ReplicationInfoListFactories { get; set; } = [];

    internal List<InnerReplicatorKafkaClusterFactory> KafkaClustersFactories { get; set; } = [];

    protected override Humidifier.MSK.Replicator Create()
    {
        var replicatorResult = CreateReplicator();
        factoryAction?.Invoke(replicatorResult);

        return replicatorResult;
    }

    private Humidifier.MSK.Replicator CreateReplicator()
    {
        var replicatorResult = new Humidifier.MSK.Replicator
        {
            GivenName = InputResourceName,
        };

        return replicatorResult;
    }
    public override void CreateChildren(Humidifier.MSK.Replicator result)
    {
        base.CreateChildren(result);

        result.ReplicationInfoList = ReplicationInfoListFactories.Any() ? ReplicationInfoListFactories.Select(x => x.Build()).ToList() : null;
        result.KafkaClusters = KafkaClustersFactories.Any() ? KafkaClustersFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ReplicatorFactoryExtensions
{
    public static CombinedResult<ReplicatorFactory, InnerReplicatorReplicationInfoFactory> WithReplicationInfoList(this ReplicatorFactory parentFactory, Action<Humidifier.MSK.ReplicatorTypes.ReplicationInfo> subFactoryAction = null)
    {
        var factory = new InnerReplicatorReplicationInfoFactory(subFactoryAction);
        parentFactory.ReplicationInfoListFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ReplicatorFactory, InnerReplicatorKafkaClusterFactory> WithKafkaClusters(this ReplicatorFactory parentFactory, Action<Humidifier.MSK.ReplicatorTypes.KafkaCluster> subFactoryAction = null)
    {
        var factory = new InnerReplicatorKafkaClusterFactory(subFactoryAction);
        parentFactory.KafkaClustersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ReplicatorFactory, T1, InnerReplicatorReplicationInfoFactory> WithReplicationInfoList<T1>(this CombinedResult<ReplicatorFactory, T1> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ReplicationInfo> subFactoryAction = null) => new (combinedResult, combinedResult, WithReplicationInfoList(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReplicatorFactory, InnerReplicatorReplicationInfoFactory> WithReplicationInfoList<T1>(this CombinedResult<T1, ReplicatorFactory> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ReplicationInfo> subFactoryAction = null) => new (combinedResult, combinedResult, WithReplicationInfoList(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ReplicatorFactory, T1, T2, InnerReplicatorReplicationInfoFactory> WithReplicationInfoList<T1, T2>(this CombinedResult<ReplicatorFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ReplicationInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReplicationInfoList(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReplicatorFactory, T2, InnerReplicatorReplicationInfoFactory> WithReplicationInfoList<T1, T2>(this CombinedResult<T1, ReplicatorFactory, T2> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ReplicationInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReplicationInfoList(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReplicatorFactory, InnerReplicatorReplicationInfoFactory> WithReplicationInfoList<T1, T2>(this CombinedResult<T1, T2, ReplicatorFactory> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ReplicationInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReplicationInfoList(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ReplicatorFactory, T1, T2, T3, InnerReplicatorReplicationInfoFactory> WithReplicationInfoList<T1, T2, T3>(this CombinedResult<ReplicatorFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ReplicationInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationInfoList(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReplicatorFactory, T2, T3, InnerReplicatorReplicationInfoFactory> WithReplicationInfoList<T1, T2, T3>(this CombinedResult<T1, ReplicatorFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ReplicationInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationInfoList(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReplicatorFactory, T3, InnerReplicatorReplicationInfoFactory> WithReplicationInfoList<T1, T2, T3>(this CombinedResult<T1, T2, ReplicatorFactory, T3> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ReplicationInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationInfoList(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ReplicatorFactory, InnerReplicatorReplicationInfoFactory> WithReplicationInfoList<T1, T2, T3>(this CombinedResult<T1, T2, T3, ReplicatorFactory> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ReplicationInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationInfoList(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ReplicatorFactory, T1, T2, T3, T4, InnerReplicatorReplicationInfoFactory> WithReplicationInfoList<T1, T2, T3, T4>(this CombinedResult<ReplicatorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ReplicationInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationInfoList(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReplicatorFactory, T2, T3, T4, InnerReplicatorReplicationInfoFactory> WithReplicationInfoList<T1, T2, T3, T4>(this CombinedResult<T1, ReplicatorFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ReplicationInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationInfoList(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReplicatorFactory, T3, T4, InnerReplicatorReplicationInfoFactory> WithReplicationInfoList<T1, T2, T3, T4>(this CombinedResult<T1, T2, ReplicatorFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ReplicationInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationInfoList(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ReplicatorFactory, T4, InnerReplicatorReplicationInfoFactory> WithReplicationInfoList<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ReplicatorFactory, T4> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ReplicationInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationInfoList(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ReplicatorFactory, InnerReplicatorReplicationInfoFactory> WithReplicationInfoList<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ReplicatorFactory> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ReplicationInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationInfoList(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ReplicatorFactory, T1, InnerReplicatorKafkaClusterFactory> WithKafkaClusters<T1>(this CombinedResult<ReplicatorFactory, T1> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.KafkaCluster> subFactoryAction = null) => new (combinedResult, combinedResult, WithKafkaClusters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReplicatorFactory, InnerReplicatorKafkaClusterFactory> WithKafkaClusters<T1>(this CombinedResult<T1, ReplicatorFactory> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.KafkaCluster> subFactoryAction = null) => new (combinedResult, combinedResult, WithKafkaClusters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ReplicatorFactory, T1, T2, InnerReplicatorKafkaClusterFactory> WithKafkaClusters<T1, T2>(this CombinedResult<ReplicatorFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.KafkaCluster> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKafkaClusters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReplicatorFactory, T2, InnerReplicatorKafkaClusterFactory> WithKafkaClusters<T1, T2>(this CombinedResult<T1, ReplicatorFactory, T2> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.KafkaCluster> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKafkaClusters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReplicatorFactory, InnerReplicatorKafkaClusterFactory> WithKafkaClusters<T1, T2>(this CombinedResult<T1, T2, ReplicatorFactory> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.KafkaCluster> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKafkaClusters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ReplicatorFactory, T1, T2, T3, InnerReplicatorKafkaClusterFactory> WithKafkaClusters<T1, T2, T3>(this CombinedResult<ReplicatorFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.KafkaCluster> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKafkaClusters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReplicatorFactory, T2, T3, InnerReplicatorKafkaClusterFactory> WithKafkaClusters<T1, T2, T3>(this CombinedResult<T1, ReplicatorFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.KafkaCluster> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKafkaClusters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReplicatorFactory, T3, InnerReplicatorKafkaClusterFactory> WithKafkaClusters<T1, T2, T3>(this CombinedResult<T1, T2, ReplicatorFactory, T3> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.KafkaCluster> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKafkaClusters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ReplicatorFactory, InnerReplicatorKafkaClusterFactory> WithKafkaClusters<T1, T2, T3>(this CombinedResult<T1, T2, T3, ReplicatorFactory> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.KafkaCluster> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKafkaClusters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ReplicatorFactory, T1, T2, T3, T4, InnerReplicatorKafkaClusterFactory> WithKafkaClusters<T1, T2, T3, T4>(this CombinedResult<ReplicatorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.KafkaCluster> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKafkaClusters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReplicatorFactory, T2, T3, T4, InnerReplicatorKafkaClusterFactory> WithKafkaClusters<T1, T2, T3, T4>(this CombinedResult<T1, ReplicatorFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.KafkaCluster> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKafkaClusters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReplicatorFactory, T3, T4, InnerReplicatorKafkaClusterFactory> WithKafkaClusters<T1, T2, T3, T4>(this CombinedResult<T1, T2, ReplicatorFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.KafkaCluster> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKafkaClusters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ReplicatorFactory, T4, InnerReplicatorKafkaClusterFactory> WithKafkaClusters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ReplicatorFactory, T4> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.KafkaCluster> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKafkaClusters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ReplicatorFactory, InnerReplicatorKafkaClusterFactory> WithKafkaClusters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ReplicatorFactory> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.KafkaCluster> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKafkaClusters(combinedResult.T5, subFactoryAction));
}
