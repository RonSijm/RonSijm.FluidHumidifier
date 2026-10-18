// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerReplicatorReplicationTopicNameConfigurationFactory(Action<Humidifier.MSK.ReplicatorTypes.ReplicationTopicNameConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ReplicatorTypes.ReplicationTopicNameConfiguration>
{

    protected override Humidifier.MSK.ReplicatorTypes.ReplicationTopicNameConfiguration Create()
    {
        var replicationTopicNameConfigurationResult = CreateReplicationTopicNameConfiguration();
        factoryAction?.Invoke(replicationTopicNameConfigurationResult);

        return replicationTopicNameConfigurationResult;
    }

    private Humidifier.MSK.ReplicatorTypes.ReplicationTopicNameConfiguration CreateReplicationTopicNameConfiguration()
    {
        var replicationTopicNameConfigurationResult = new Humidifier.MSK.ReplicatorTypes.ReplicationTopicNameConfiguration();

        return replicationTopicNameConfigurationResult;
    }

} // End Of Class

public static class InnerReplicatorReplicationTopicNameConfigurationFactoryExtensions
{
}
