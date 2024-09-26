// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVSChat;

public class InnerLoggingConfigurationCloudWatchLogsDestinationConfigurationFactory(Action<Humidifier.IVSChat.LoggingConfigurationTypes.CloudWatchLogsDestinationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IVSChat.LoggingConfigurationTypes.CloudWatchLogsDestinationConfiguration>
{

    protected override Humidifier.IVSChat.LoggingConfigurationTypes.CloudWatchLogsDestinationConfiguration Create()
    {
        var cloudWatchLogsDestinationConfigurationResult = CreateCloudWatchLogsDestinationConfiguration();
        factoryAction?.Invoke(cloudWatchLogsDestinationConfigurationResult);

        return cloudWatchLogsDestinationConfigurationResult;
    }

    private Humidifier.IVSChat.LoggingConfigurationTypes.CloudWatchLogsDestinationConfiguration CreateCloudWatchLogsDestinationConfiguration()
    {
        var cloudWatchLogsDestinationConfigurationResult = new Humidifier.IVSChat.LoggingConfigurationTypes.CloudWatchLogsDestinationConfiguration();

        return cloudWatchLogsDestinationConfigurationResult;
    }

} // End Of Class

public static class InnerLoggingConfigurationCloudWatchLogsDestinationConfigurationFactoryExtensions
{
}
