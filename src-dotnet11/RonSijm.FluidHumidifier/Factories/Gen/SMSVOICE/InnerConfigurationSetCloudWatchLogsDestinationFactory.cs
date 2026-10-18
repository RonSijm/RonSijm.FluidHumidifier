// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SMSVOICE;

public class InnerConfigurationSetCloudWatchLogsDestinationFactory(Action<Humidifier.SMSVOICE.ConfigurationSetTypes.CloudWatchLogsDestination> factoryAction = null) : SubResourceFactory<Humidifier.SMSVOICE.ConfigurationSetTypes.CloudWatchLogsDestination>
{

    protected override Humidifier.SMSVOICE.ConfigurationSetTypes.CloudWatchLogsDestination Create()
    {
        var cloudWatchLogsDestinationResult = CreateCloudWatchLogsDestination();
        factoryAction?.Invoke(cloudWatchLogsDestinationResult);

        return cloudWatchLogsDestinationResult;
    }

    private Humidifier.SMSVOICE.ConfigurationSetTypes.CloudWatchLogsDestination CreateCloudWatchLogsDestination()
    {
        var cloudWatchLogsDestinationResult = new Humidifier.SMSVOICE.ConfigurationSetTypes.CloudWatchLogsDestination();

        return cloudWatchLogsDestinationResult;
    }

} // End Of Class

public static class InnerConfigurationSetCloudWatchLogsDestinationFactoryExtensions
{
}
