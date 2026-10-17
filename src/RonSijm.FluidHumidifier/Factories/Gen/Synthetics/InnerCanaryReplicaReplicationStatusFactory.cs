// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Synthetics;

public class InnerCanaryReplicaReplicationStatusFactory(Action<Humidifier.Synthetics.CanaryTypes.ReplicaReplicationStatus> factoryAction = null) : SubResourceFactory<Humidifier.Synthetics.CanaryTypes.ReplicaReplicationStatus>
{

    protected override Humidifier.Synthetics.CanaryTypes.ReplicaReplicationStatus Create()
    {
        var replicaReplicationStatusResult = CreateReplicaReplicationStatus();
        factoryAction?.Invoke(replicaReplicationStatusResult);

        return replicaReplicationStatusResult;
    }

    private Humidifier.Synthetics.CanaryTypes.ReplicaReplicationStatus CreateReplicaReplicationStatus()
    {
        var replicaReplicationStatusResult = new Humidifier.Synthetics.CanaryTypes.ReplicaReplicationStatus();

        return replicaReplicationStatusResult;
    }

} // End Of Class

public static class InnerCanaryReplicaReplicationStatusFactoryExtensions
{
}
