// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerReplicatorReplicationStartingPositionFactory(Action<Humidifier.MSK.ReplicatorTypes.ReplicationStartingPosition> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ReplicatorTypes.ReplicationStartingPosition>
{

    protected override Humidifier.MSK.ReplicatorTypes.ReplicationStartingPosition Create()
    {
        var replicationStartingPositionResult = CreateReplicationStartingPosition();
        factoryAction?.Invoke(replicationStartingPositionResult);

        return replicationStartingPositionResult;
    }

    private Humidifier.MSK.ReplicatorTypes.ReplicationStartingPosition CreateReplicationStartingPosition()
    {
        var replicationStartingPositionResult = new Humidifier.MSK.ReplicatorTypes.ReplicationStartingPosition();

        return replicationStartingPositionResult;
    }

} // End Of Class

public static class InnerReplicatorReplicationStartingPositionFactoryExtensions
{
}
