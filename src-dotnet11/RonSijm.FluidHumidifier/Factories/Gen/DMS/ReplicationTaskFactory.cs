// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class ReplicationTaskFactory(string resourceName = null, Action<Humidifier.DMS.ReplicationTask> factoryAction = null) : ResourceFactory<Humidifier.DMS.ReplicationTask>(resourceName)
{

    protected override Humidifier.DMS.ReplicationTask Create()
    {
        var replicationTaskResult = CreateReplicationTask();
        factoryAction?.Invoke(replicationTaskResult);

        return replicationTaskResult;
    }

    private Humidifier.DMS.ReplicationTask CreateReplicationTask()
    {
        var replicationTaskResult = new Humidifier.DMS.ReplicationTask
        {
            GivenName = InputResourceName,
        };

        return replicationTaskResult;
    }

} // End Of Class

public static class ReplicationTaskFactoryExtensions
{
}
