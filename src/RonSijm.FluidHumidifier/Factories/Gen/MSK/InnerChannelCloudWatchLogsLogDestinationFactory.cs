// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerChannelCloudWatchLogsLogDestinationFactory(Action<Humidifier.MSK.ChannelTypes.CloudWatchLogsLogDestination> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ChannelTypes.CloudWatchLogsLogDestination>
{

    protected override Humidifier.MSK.ChannelTypes.CloudWatchLogsLogDestination Create()
    {
        var cloudWatchLogsLogDestinationResult = CreateCloudWatchLogsLogDestination();
        factoryAction?.Invoke(cloudWatchLogsLogDestinationResult);

        return cloudWatchLogsLogDestinationResult;
    }

    private Humidifier.MSK.ChannelTypes.CloudWatchLogsLogDestination CreateCloudWatchLogsLogDestination()
    {
        var cloudWatchLogsLogDestinationResult = new Humidifier.MSK.ChannelTypes.CloudWatchLogsLogDestination();

        return cloudWatchLogsLogDestinationResult;
    }

} // End Of Class

public static class InnerChannelCloudWatchLogsLogDestinationFactoryExtensions
{
}
