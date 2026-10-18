// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerReplicatorCloudWatchLogsFactory(Action<Humidifier.MSK.ReplicatorTypes.CloudWatchLogs> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ReplicatorTypes.CloudWatchLogs>
{

    protected override Humidifier.MSK.ReplicatorTypes.CloudWatchLogs Create()
    {
        var cloudWatchLogsResult = CreateCloudWatchLogs();
        factoryAction?.Invoke(cloudWatchLogsResult);

        return cloudWatchLogsResult;
    }

    private Humidifier.MSK.ReplicatorTypes.CloudWatchLogs CreateCloudWatchLogs()
    {
        var cloudWatchLogsResult = new Humidifier.MSK.ReplicatorTypes.CloudWatchLogs();

        return cloudWatchLogsResult;
    }

} // End Of Class

public static class InnerReplicatorCloudWatchLogsFactoryExtensions
{
}
