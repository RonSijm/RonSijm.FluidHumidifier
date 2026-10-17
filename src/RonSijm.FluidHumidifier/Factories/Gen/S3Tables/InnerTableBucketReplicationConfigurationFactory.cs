// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Tables;

public class InnerTableBucketReplicationConfigurationFactory(Action<Humidifier.S3Tables.TableBucketTypes.ReplicationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3Tables.TableBucketTypes.ReplicationConfiguration>
{

    protected override Humidifier.S3Tables.TableBucketTypes.ReplicationConfiguration Create()
    {
        var replicationConfigurationResult = CreateReplicationConfiguration();
        factoryAction?.Invoke(replicationConfigurationResult);

        return replicationConfigurationResult;
    }

    private Humidifier.S3Tables.TableBucketTypes.ReplicationConfiguration CreateReplicationConfiguration()
    {
        var replicationConfigurationResult = new Humidifier.S3Tables.TableBucketTypes.ReplicationConfiguration();

        return replicationConfigurationResult;
    }

} // End Of Class

public static class InnerTableBucketReplicationConfigurationFactoryExtensions
{
}
