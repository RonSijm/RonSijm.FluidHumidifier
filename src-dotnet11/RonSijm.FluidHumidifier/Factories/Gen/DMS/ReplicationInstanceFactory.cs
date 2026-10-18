// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class ReplicationInstanceFactory(string resourceName = null, Action<Humidifier.DMS.ReplicationInstance> factoryAction = null) : ResourceFactory<Humidifier.DMS.ReplicationInstance>(resourceName)
{

    protected override Humidifier.DMS.ReplicationInstance Create()
    {
        var replicationInstanceResult = CreateReplicationInstance();
        factoryAction?.Invoke(replicationInstanceResult);

        return replicationInstanceResult;
    }

    private Humidifier.DMS.ReplicationInstance CreateReplicationInstance()
    {
        var replicationInstanceResult = new Humidifier.DMS.ReplicationInstance
        {
            GivenName = InputResourceName,
        };

        return replicationInstanceResult;
    }

} // End Of Class

public static class ReplicationInstanceFactoryExtensions
{
}
