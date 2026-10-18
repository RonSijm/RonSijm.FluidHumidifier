// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerBucketReplicationConfigurationFactory(Action<Humidifier.S3.BucketTypes.ReplicationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3.BucketTypes.ReplicationConfiguration>
{

    protected override Humidifier.S3.BucketTypes.ReplicationConfiguration Create()
    {
        var replicationConfigurationResult = CreateReplicationConfiguration();
        factoryAction?.Invoke(replicationConfigurationResult);

        return replicationConfigurationResult;
    }

    private Humidifier.S3.BucketTypes.ReplicationConfiguration CreateReplicationConfiguration()
    {
        var replicationConfigurationResult = new Humidifier.S3.BucketTypes.ReplicationConfiguration();

        return replicationConfigurationResult;
    }

} // End Of Class

public static class InnerBucketReplicationConfigurationFactoryExtensions
{
}
