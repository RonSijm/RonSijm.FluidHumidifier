// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Synthetics;

public class InnerCanaryReplicaFactory(Action<Humidifier.Synthetics.CanaryTypes.Replica> factoryAction = null) : SubResourceFactory<Humidifier.Synthetics.CanaryTypes.Replica>
{

    internal InnerCanaryVPCConfigFactory VpcConfigFactory { get; set; }

    internal InnerCanaryReplicaReplicationStatusFactory ReplicationStatusFactory { get; set; }

    protected override Humidifier.Synthetics.CanaryTypes.Replica Create()
    {
        var replicaResult = CreateReplica();
        factoryAction?.Invoke(replicaResult);

        return replicaResult;
    }

    private Humidifier.Synthetics.CanaryTypes.Replica CreateReplica()
    {
        var replicaResult = new Humidifier.Synthetics.CanaryTypes.Replica();

        return replicaResult;
    }
    public override void CreateChildren(Humidifier.Synthetics.CanaryTypes.Replica result)
    {
        base.CreateChildren(result);

        result.VpcConfig ??= VpcConfigFactory?.Build();
        result.ReplicationStatus ??= ReplicationStatusFactory?.Build();
    }

} // End Of Class

public static class InnerCanaryReplicaFactoryExtensions
{
    public static CombinedResult<InnerCanaryReplicaFactory, InnerCanaryVPCConfigFactory> WithVpcConfig(this InnerCanaryReplicaFactory parentFactory, Action<Humidifier.Synthetics.CanaryTypes.VPCConfig> subFactoryAction = null)
    {
        parentFactory.VpcConfigFactory = new InnerCanaryVPCConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcConfigFactory);
    }

    public static CombinedResult<InnerCanaryReplicaFactory, InnerCanaryReplicaReplicationStatusFactory> WithReplicationStatus(this InnerCanaryReplicaFactory parentFactory, Action<Humidifier.Synthetics.CanaryTypes.ReplicaReplicationStatus> subFactoryAction = null)
    {
        parentFactory.ReplicationStatusFactory = new InnerCanaryReplicaReplicationStatusFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ReplicationStatusFactory);
    }

    public static CombinedResult<InnerCanaryReplicaFactory, T1, InnerCanaryVPCConfigFactory> WithVpcConfig<T1>(this CombinedResult<InnerCanaryReplicaFactory, T1> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.VPCConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCanaryReplicaFactory, InnerCanaryVPCConfigFactory> WithVpcConfig<T1>(this CombinedResult<T1, InnerCanaryReplicaFactory> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.VPCConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerCanaryReplicaFactory, T1, T2, InnerCanaryVPCConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<InnerCanaryReplicaFactory, T1, T2> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.VPCConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCanaryReplicaFactory, T2, InnerCanaryVPCConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, InnerCanaryReplicaFactory, T2> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.VPCConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCanaryReplicaFactory, InnerCanaryVPCConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, T2, InnerCanaryReplicaFactory> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.VPCConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerCanaryReplicaFactory, T1, T2, T3, InnerCanaryVPCConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<InnerCanaryReplicaFactory, T1, T2, T3> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.VPCConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCanaryReplicaFactory, T2, T3, InnerCanaryVPCConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, InnerCanaryReplicaFactory, T2, T3> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.VPCConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCanaryReplicaFactory, T3, InnerCanaryVPCConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerCanaryReplicaFactory, T3> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.VPCConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCanaryReplicaFactory, InnerCanaryVPCConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCanaryReplicaFactory> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.VPCConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerCanaryReplicaFactory, T1, T2, T3, T4, InnerCanaryVPCConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<InnerCanaryReplicaFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.VPCConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCanaryReplicaFactory, T2, T3, T4, InnerCanaryVPCConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerCanaryReplicaFactory, T2, T3, T4> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.VPCConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCanaryReplicaFactory, T3, T4, InnerCanaryVPCConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCanaryReplicaFactory, T3, T4> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.VPCConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCanaryReplicaFactory, T4, InnerCanaryVPCConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCanaryReplicaFactory, T4> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.VPCConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerCanaryReplicaFactory, InnerCanaryVPCConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCanaryReplicaFactory> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.VPCConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerCanaryReplicaFactory, T1, InnerCanaryReplicaReplicationStatusFactory> WithReplicationStatus<T1>(this CombinedResult<InnerCanaryReplicaFactory, T1> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.ReplicaReplicationStatus> subFactoryAction = null) => new (combinedResult, combinedResult, WithReplicationStatus(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCanaryReplicaFactory, InnerCanaryReplicaReplicationStatusFactory> WithReplicationStatus<T1>(this CombinedResult<T1, InnerCanaryReplicaFactory> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.ReplicaReplicationStatus> subFactoryAction = null) => new (combinedResult, combinedResult, WithReplicationStatus(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerCanaryReplicaFactory, T1, T2, InnerCanaryReplicaReplicationStatusFactory> WithReplicationStatus<T1, T2>(this CombinedResult<InnerCanaryReplicaFactory, T1, T2> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.ReplicaReplicationStatus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReplicationStatus(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCanaryReplicaFactory, T2, InnerCanaryReplicaReplicationStatusFactory> WithReplicationStatus<T1, T2>(this CombinedResult<T1, InnerCanaryReplicaFactory, T2> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.ReplicaReplicationStatus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReplicationStatus(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCanaryReplicaFactory, InnerCanaryReplicaReplicationStatusFactory> WithReplicationStatus<T1, T2>(this CombinedResult<T1, T2, InnerCanaryReplicaFactory> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.ReplicaReplicationStatus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReplicationStatus(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerCanaryReplicaFactory, T1, T2, T3, InnerCanaryReplicaReplicationStatusFactory> WithReplicationStatus<T1, T2, T3>(this CombinedResult<InnerCanaryReplicaFactory, T1, T2, T3> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.ReplicaReplicationStatus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationStatus(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCanaryReplicaFactory, T2, T3, InnerCanaryReplicaReplicationStatusFactory> WithReplicationStatus<T1, T2, T3>(this CombinedResult<T1, InnerCanaryReplicaFactory, T2, T3> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.ReplicaReplicationStatus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationStatus(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCanaryReplicaFactory, T3, InnerCanaryReplicaReplicationStatusFactory> WithReplicationStatus<T1, T2, T3>(this CombinedResult<T1, T2, InnerCanaryReplicaFactory, T3> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.ReplicaReplicationStatus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationStatus(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCanaryReplicaFactory, InnerCanaryReplicaReplicationStatusFactory> WithReplicationStatus<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCanaryReplicaFactory> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.ReplicaReplicationStatus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationStatus(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerCanaryReplicaFactory, T1, T2, T3, T4, InnerCanaryReplicaReplicationStatusFactory> WithReplicationStatus<T1, T2, T3, T4>(this CombinedResult<InnerCanaryReplicaFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.ReplicaReplicationStatus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationStatus(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCanaryReplicaFactory, T2, T3, T4, InnerCanaryReplicaReplicationStatusFactory> WithReplicationStatus<T1, T2, T3, T4>(this CombinedResult<T1, InnerCanaryReplicaFactory, T2, T3, T4> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.ReplicaReplicationStatus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationStatus(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCanaryReplicaFactory, T3, T4, InnerCanaryReplicaReplicationStatusFactory> WithReplicationStatus<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCanaryReplicaFactory, T3, T4> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.ReplicaReplicationStatus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationStatus(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCanaryReplicaFactory, T4, InnerCanaryReplicaReplicationStatusFactory> WithReplicationStatus<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCanaryReplicaFactory, T4> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.ReplicaReplicationStatus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationStatus(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerCanaryReplicaFactory, InnerCanaryReplicaReplicationStatusFactory> WithReplicationStatus<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCanaryReplicaFactory> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.ReplicaReplicationStatus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationStatus(combinedResult.T5, subFactoryAction).T2);
}
