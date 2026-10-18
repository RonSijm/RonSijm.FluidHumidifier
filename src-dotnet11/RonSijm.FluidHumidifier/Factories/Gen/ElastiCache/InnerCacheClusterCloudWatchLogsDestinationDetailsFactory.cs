// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElastiCache;

public class InnerCacheClusterCloudWatchLogsDestinationDetailsFactory(Action<Humidifier.ElastiCache.CacheClusterTypes.CloudWatchLogsDestinationDetails> factoryAction = null) : SubResourceFactory<Humidifier.ElastiCache.CacheClusterTypes.CloudWatchLogsDestinationDetails>
{

    protected override Humidifier.ElastiCache.CacheClusterTypes.CloudWatchLogsDestinationDetails Create()
    {
        var cloudWatchLogsDestinationDetailsResult = CreateCloudWatchLogsDestinationDetails();
        factoryAction?.Invoke(cloudWatchLogsDestinationDetailsResult);

        return cloudWatchLogsDestinationDetailsResult;
    }

    private Humidifier.ElastiCache.CacheClusterTypes.CloudWatchLogsDestinationDetails CreateCloudWatchLogsDestinationDetails()
    {
        var cloudWatchLogsDestinationDetailsResult = new Humidifier.ElastiCache.CacheClusterTypes.CloudWatchLogsDestinationDetails();

        return cloudWatchLogsDestinationDetailsResult;
    }

} // End Of Class

public static class InnerCacheClusterCloudWatchLogsDestinationDetailsFactoryExtensions
{
}
