// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerClusterCloudWatchLogsFactory(Action<Humidifier.MSK.ClusterTypes.CloudWatchLogs> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ClusterTypes.CloudWatchLogs>
{

    protected override Humidifier.MSK.ClusterTypes.CloudWatchLogs Create()
    {
        var cloudWatchLogsResult = CreateCloudWatchLogs();
        factoryAction?.Invoke(cloudWatchLogsResult);

        return cloudWatchLogsResult;
    }

    private Humidifier.MSK.ClusterTypes.CloudWatchLogs CreateCloudWatchLogs()
    {
        var cloudWatchLogsResult = new Humidifier.MSK.ClusterTypes.CloudWatchLogs();

        return cloudWatchLogsResult;
    }

} // End Of Class

public static class InnerClusterCloudWatchLogsFactoryExtensions
{
}
