// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kinesis;

public class InnerChannelCloudWatchLogsConfigurationFactory(Action<Humidifier.Kinesis.ChannelTypes.CloudWatchLogsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kinesis.ChannelTypes.CloudWatchLogsConfiguration>
{

    protected override Humidifier.Kinesis.ChannelTypes.CloudWatchLogsConfiguration Create()
    {
        var cloudWatchLogsConfigurationResult = CreateCloudWatchLogsConfiguration();
        factoryAction?.Invoke(cloudWatchLogsConfigurationResult);

        return cloudWatchLogsConfigurationResult;
    }

    private Humidifier.Kinesis.ChannelTypes.CloudWatchLogsConfiguration CreateCloudWatchLogsConfiguration()
    {
        var cloudWatchLogsConfigurationResult = new Humidifier.Kinesis.ChannelTypes.CloudWatchLogsConfiguration();

        return cloudWatchLogsConfigurationResult;
    }

} // End Of Class

public static class InnerChannelCloudWatchLogsConfigurationFactoryExtensions
{
}
