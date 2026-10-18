// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityLake;

public class InnerDataLakeReplicationConfigurationFactory(Action<Humidifier.SecurityLake.DataLakeTypes.ReplicationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.SecurityLake.DataLakeTypes.ReplicationConfiguration>
{

    protected override Humidifier.SecurityLake.DataLakeTypes.ReplicationConfiguration Create()
    {
        var replicationConfigurationResult = CreateReplicationConfiguration();
        factoryAction?.Invoke(replicationConfigurationResult);

        return replicationConfigurationResult;
    }

    private Humidifier.SecurityLake.DataLakeTypes.ReplicationConfiguration CreateReplicationConfiguration()
    {
        var replicationConfigurationResult = new Humidifier.SecurityLake.DataLakeTypes.ReplicationConfiguration();

        return replicationConfigurationResult;
    }

} // End Of Class

public static class InnerDataLakeReplicationConfigurationFactoryExtensions
{
}
