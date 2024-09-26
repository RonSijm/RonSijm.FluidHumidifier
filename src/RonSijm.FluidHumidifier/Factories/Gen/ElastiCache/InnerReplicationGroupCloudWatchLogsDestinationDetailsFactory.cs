// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElastiCache;

public class InnerReplicationGroupCloudWatchLogsDestinationDetailsFactory(Action<Humidifier.ElastiCache.ReplicationGroupTypes.CloudWatchLogsDestinationDetails> factoryAction = null) : SubResourceFactory<Humidifier.ElastiCache.ReplicationGroupTypes.CloudWatchLogsDestinationDetails>
{

    protected override Humidifier.ElastiCache.ReplicationGroupTypes.CloudWatchLogsDestinationDetails Create()
    {
        var cloudWatchLogsDestinationDetailsResult = CreateCloudWatchLogsDestinationDetails();
        factoryAction?.Invoke(cloudWatchLogsDestinationDetailsResult);

        return cloudWatchLogsDestinationDetailsResult;
    }

    private Humidifier.ElastiCache.ReplicationGroupTypes.CloudWatchLogsDestinationDetails CreateCloudWatchLogsDestinationDetails()
    {
        var cloudWatchLogsDestinationDetailsResult = new Humidifier.ElastiCache.ReplicationGroupTypes.CloudWatchLogsDestinationDetails();

        return cloudWatchLogsDestinationDetailsResult;
    }

} // End Of Class

public static class InnerReplicationGroupCloudWatchLogsDestinationDetailsFactoryExtensions
{
}
