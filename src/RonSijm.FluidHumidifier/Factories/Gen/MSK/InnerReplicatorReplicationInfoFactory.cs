// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerReplicatorReplicationInfoFactory(Action<Humidifier.MSK.ReplicatorTypes.ReplicationInfo> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ReplicatorTypes.ReplicationInfo>
{

    internal InnerReplicatorTopicReplicationFactory TopicReplicationFactory { get; set; }

    internal InnerReplicatorConsumerGroupReplicationFactory ConsumerGroupReplicationFactory { get; set; }

    protected override Humidifier.MSK.ReplicatorTypes.ReplicationInfo Create()
    {
        var replicationInfoResult = CreateReplicationInfo();
        factoryAction?.Invoke(replicationInfoResult);

        return replicationInfoResult;
    }

    private Humidifier.MSK.ReplicatorTypes.ReplicationInfo CreateReplicationInfo()
    {
        var replicationInfoResult = new Humidifier.MSK.ReplicatorTypes.ReplicationInfo();

        return replicationInfoResult;
    }
    public override void CreateChildren(Humidifier.MSK.ReplicatorTypes.ReplicationInfo result)
    {
        base.CreateChildren(result);

        result.TopicReplication ??= TopicReplicationFactory?.Build();
        result.ConsumerGroupReplication ??= ConsumerGroupReplicationFactory?.Build();
    }

} // End Of Class

public static class InnerReplicatorReplicationInfoFactoryExtensions
{
    public static CombinedResult<InnerReplicatorReplicationInfoFactory, InnerReplicatorTopicReplicationFactory> WithTopicReplication(this InnerReplicatorReplicationInfoFactory parentFactory, Action<Humidifier.MSK.ReplicatorTypes.TopicReplication> subFactoryAction = null)
    {
        parentFactory.TopicReplicationFactory = new InnerReplicatorTopicReplicationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TopicReplicationFactory);
    }

    public static CombinedResult<InnerReplicatorReplicationInfoFactory, InnerReplicatorConsumerGroupReplicationFactory> WithConsumerGroupReplication(this InnerReplicatorReplicationInfoFactory parentFactory, Action<Humidifier.MSK.ReplicatorTypes.ConsumerGroupReplication> subFactoryAction = null)
    {
        parentFactory.ConsumerGroupReplicationFactory = new InnerReplicatorConsumerGroupReplicationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConsumerGroupReplicationFactory);
    }

    public static CombinedResult<InnerReplicatorReplicationInfoFactory, T1, InnerReplicatorTopicReplicationFactory> WithTopicReplication<T1>(this CombinedResult<InnerReplicatorReplicationInfoFactory, T1> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.TopicReplication> subFactoryAction = null) => new (combinedResult, combinedResult, WithTopicReplication(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerReplicatorReplicationInfoFactory, InnerReplicatorTopicReplicationFactory> WithTopicReplication<T1>(this CombinedResult<T1, InnerReplicatorReplicationInfoFactory> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.TopicReplication> subFactoryAction = null) => new (combinedResult, combinedResult, WithTopicReplication(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerReplicatorReplicationInfoFactory, T1, T2, InnerReplicatorTopicReplicationFactory> WithTopicReplication<T1, T2>(this CombinedResult<InnerReplicatorReplicationInfoFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.TopicReplication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTopicReplication(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerReplicatorReplicationInfoFactory, T2, InnerReplicatorTopicReplicationFactory> WithTopicReplication<T1, T2>(this CombinedResult<T1, InnerReplicatorReplicationInfoFactory, T2> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.TopicReplication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTopicReplication(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerReplicatorReplicationInfoFactory, InnerReplicatorTopicReplicationFactory> WithTopicReplication<T1, T2>(this CombinedResult<T1, T2, InnerReplicatorReplicationInfoFactory> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.TopicReplication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTopicReplication(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerReplicatorReplicationInfoFactory, T1, T2, T3, InnerReplicatorTopicReplicationFactory> WithTopicReplication<T1, T2, T3>(this CombinedResult<InnerReplicatorReplicationInfoFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.TopicReplication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTopicReplication(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerReplicatorReplicationInfoFactory, T2, T3, InnerReplicatorTopicReplicationFactory> WithTopicReplication<T1, T2, T3>(this CombinedResult<T1, InnerReplicatorReplicationInfoFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.TopicReplication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTopicReplication(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerReplicatorReplicationInfoFactory, T3, InnerReplicatorTopicReplicationFactory> WithTopicReplication<T1, T2, T3>(this CombinedResult<T1, T2, InnerReplicatorReplicationInfoFactory, T3> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.TopicReplication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTopicReplication(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerReplicatorReplicationInfoFactory, InnerReplicatorTopicReplicationFactory> WithTopicReplication<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerReplicatorReplicationInfoFactory> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.TopicReplication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTopicReplication(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerReplicatorReplicationInfoFactory, T1, T2, T3, T4, InnerReplicatorTopicReplicationFactory> WithTopicReplication<T1, T2, T3, T4>(this CombinedResult<InnerReplicatorReplicationInfoFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.TopicReplication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTopicReplication(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerReplicatorReplicationInfoFactory, T2, T3, T4, InnerReplicatorTopicReplicationFactory> WithTopicReplication<T1, T2, T3, T4>(this CombinedResult<T1, InnerReplicatorReplicationInfoFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.TopicReplication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTopicReplication(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerReplicatorReplicationInfoFactory, T3, T4, InnerReplicatorTopicReplicationFactory> WithTopicReplication<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerReplicatorReplicationInfoFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.TopicReplication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTopicReplication(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerReplicatorReplicationInfoFactory, T4, InnerReplicatorTopicReplicationFactory> WithTopicReplication<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerReplicatorReplicationInfoFactory, T4> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.TopicReplication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTopicReplication(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerReplicatorReplicationInfoFactory, InnerReplicatorTopicReplicationFactory> WithTopicReplication<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerReplicatorReplicationInfoFactory> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.TopicReplication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTopicReplication(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerReplicatorReplicationInfoFactory, T1, InnerReplicatorConsumerGroupReplicationFactory> WithConsumerGroupReplication<T1>(this CombinedResult<InnerReplicatorReplicationInfoFactory, T1> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ConsumerGroupReplication> subFactoryAction = null) => new (combinedResult, combinedResult, WithConsumerGroupReplication(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerReplicatorReplicationInfoFactory, InnerReplicatorConsumerGroupReplicationFactory> WithConsumerGroupReplication<T1>(this CombinedResult<T1, InnerReplicatorReplicationInfoFactory> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ConsumerGroupReplication> subFactoryAction = null) => new (combinedResult, combinedResult, WithConsumerGroupReplication(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerReplicatorReplicationInfoFactory, T1, T2, InnerReplicatorConsumerGroupReplicationFactory> WithConsumerGroupReplication<T1, T2>(this CombinedResult<InnerReplicatorReplicationInfoFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ConsumerGroupReplication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConsumerGroupReplication(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerReplicatorReplicationInfoFactory, T2, InnerReplicatorConsumerGroupReplicationFactory> WithConsumerGroupReplication<T1, T2>(this CombinedResult<T1, InnerReplicatorReplicationInfoFactory, T2> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ConsumerGroupReplication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConsumerGroupReplication(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerReplicatorReplicationInfoFactory, InnerReplicatorConsumerGroupReplicationFactory> WithConsumerGroupReplication<T1, T2>(this CombinedResult<T1, T2, InnerReplicatorReplicationInfoFactory> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ConsumerGroupReplication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConsumerGroupReplication(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerReplicatorReplicationInfoFactory, T1, T2, T3, InnerReplicatorConsumerGroupReplicationFactory> WithConsumerGroupReplication<T1, T2, T3>(this CombinedResult<InnerReplicatorReplicationInfoFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ConsumerGroupReplication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConsumerGroupReplication(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerReplicatorReplicationInfoFactory, T2, T3, InnerReplicatorConsumerGroupReplicationFactory> WithConsumerGroupReplication<T1, T2, T3>(this CombinedResult<T1, InnerReplicatorReplicationInfoFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ConsumerGroupReplication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConsumerGroupReplication(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerReplicatorReplicationInfoFactory, T3, InnerReplicatorConsumerGroupReplicationFactory> WithConsumerGroupReplication<T1, T2, T3>(this CombinedResult<T1, T2, InnerReplicatorReplicationInfoFactory, T3> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ConsumerGroupReplication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConsumerGroupReplication(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerReplicatorReplicationInfoFactory, InnerReplicatorConsumerGroupReplicationFactory> WithConsumerGroupReplication<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerReplicatorReplicationInfoFactory> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ConsumerGroupReplication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConsumerGroupReplication(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerReplicatorReplicationInfoFactory, T1, T2, T3, T4, InnerReplicatorConsumerGroupReplicationFactory> WithConsumerGroupReplication<T1, T2, T3, T4>(this CombinedResult<InnerReplicatorReplicationInfoFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ConsumerGroupReplication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConsumerGroupReplication(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerReplicatorReplicationInfoFactory, T2, T3, T4, InnerReplicatorConsumerGroupReplicationFactory> WithConsumerGroupReplication<T1, T2, T3, T4>(this CombinedResult<T1, InnerReplicatorReplicationInfoFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ConsumerGroupReplication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConsumerGroupReplication(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerReplicatorReplicationInfoFactory, T3, T4, InnerReplicatorConsumerGroupReplicationFactory> WithConsumerGroupReplication<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerReplicatorReplicationInfoFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ConsumerGroupReplication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConsumerGroupReplication(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerReplicatorReplicationInfoFactory, T4, InnerReplicatorConsumerGroupReplicationFactory> WithConsumerGroupReplication<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerReplicatorReplicationInfoFactory, T4> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ConsumerGroupReplication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConsumerGroupReplication(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerReplicatorReplicationInfoFactory, InnerReplicatorConsumerGroupReplicationFactory> WithConsumerGroupReplication<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerReplicatorReplicationInfoFactory> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.ConsumerGroupReplication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConsumerGroupReplication(combinedResult.T5, subFactoryAction));
}
