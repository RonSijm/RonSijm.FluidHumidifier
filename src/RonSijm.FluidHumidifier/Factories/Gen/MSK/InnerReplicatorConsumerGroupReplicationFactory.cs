// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerReplicatorConsumerGroupReplicationFactory(Action<Humidifier.MSK.ReplicatorTypes.ConsumerGroupReplication> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ReplicatorTypes.ConsumerGroupReplication>
{

    protected override Humidifier.MSK.ReplicatorTypes.ConsumerGroupReplication Create()
    {
        var consumerGroupReplicationResult = CreateConsumerGroupReplication();
        factoryAction?.Invoke(consumerGroupReplicationResult);

        return consumerGroupReplicationResult;
    }

    private Humidifier.MSK.ReplicatorTypes.ConsumerGroupReplication CreateConsumerGroupReplication()
    {
        var consumerGroupReplicationResult = new Humidifier.MSK.ReplicatorTypes.ConsumerGroupReplication();

        return consumerGroupReplicationResult;
    }

} // End Of Class

public static class InnerReplicatorConsumerGroupReplicationFactoryExtensions
{
}
