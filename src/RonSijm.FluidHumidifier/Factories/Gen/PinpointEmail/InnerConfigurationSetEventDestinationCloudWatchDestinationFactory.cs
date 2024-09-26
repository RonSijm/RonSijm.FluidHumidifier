// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PinpointEmail;

public class InnerConfigurationSetEventDestinationCloudWatchDestinationFactory(Action<Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.CloudWatchDestination> factoryAction = null) : SubResourceFactory<Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.CloudWatchDestination>
{

    protected override Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.CloudWatchDestination Create()
    {
        var cloudWatchDestinationResult = CreateCloudWatchDestination();
        factoryAction?.Invoke(cloudWatchDestinationResult);

        return cloudWatchDestinationResult;
    }

    private Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.CloudWatchDestination CreateCloudWatchDestination()
    {
        var cloudWatchDestinationResult = new Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.CloudWatchDestination();

        return cloudWatchDestinationResult;
    }

} // End Of Class

public static class InnerConfigurationSetEventDestinationCloudWatchDestinationFactoryExtensions
{
}
