// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EFS;

public class InnerFileSystemReplicationConfigurationFactory(Action<Humidifier.EFS.FileSystemTypes.ReplicationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EFS.FileSystemTypes.ReplicationConfiguration>
{

    protected override Humidifier.EFS.FileSystemTypes.ReplicationConfiguration Create()
    {
        var replicationConfigurationResult = CreateReplicationConfiguration();
        factoryAction?.Invoke(replicationConfigurationResult);

        return replicationConfigurationResult;
    }

    private Humidifier.EFS.FileSystemTypes.ReplicationConfiguration CreateReplicationConfiguration()
    {
        var replicationConfigurationResult = new Humidifier.EFS.FileSystemTypes.ReplicationConfiguration();

        return replicationConfigurationResult;
    }

} // End Of Class

public static class InnerFileSystemReplicationConfigurationFactoryExtensions
{
}
