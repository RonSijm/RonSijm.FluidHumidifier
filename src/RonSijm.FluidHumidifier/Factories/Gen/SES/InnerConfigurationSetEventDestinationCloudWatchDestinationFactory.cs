// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerConfigurationSetEventDestinationCloudWatchDestinationFactory(Action<Humidifier.SES.ConfigurationSetEventDestinationTypes.CloudWatchDestination> factoryAction = null) : SubResourceFactory<Humidifier.SES.ConfigurationSetEventDestinationTypes.CloudWatchDestination>
{

    protected override Humidifier.SES.ConfigurationSetEventDestinationTypes.CloudWatchDestination Create()
    {
        var cloudWatchDestinationResult = CreateCloudWatchDestination();
        factoryAction?.Invoke(cloudWatchDestinationResult);

        return cloudWatchDestinationResult;
    }

    private Humidifier.SES.ConfigurationSetEventDestinationTypes.CloudWatchDestination CreateCloudWatchDestination()
    {
        var cloudWatchDestinationResult = new Humidifier.SES.ConfigurationSetEventDestinationTypes.CloudWatchDestination();

        return cloudWatchDestinationResult;
    }

} // End Of Class

public static class InnerConfigurationSetEventDestinationCloudWatchDestinationFactoryExtensions
{
}
