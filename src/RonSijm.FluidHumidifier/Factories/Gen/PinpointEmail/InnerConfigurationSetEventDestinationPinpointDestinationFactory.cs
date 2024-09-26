// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PinpointEmail;

public class InnerConfigurationSetEventDestinationPinpointDestinationFactory(Action<Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.PinpointDestination> factoryAction = null) : SubResourceFactory<Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.PinpointDestination>
{

    protected override Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.PinpointDestination Create()
    {
        var pinpointDestinationResult = CreatePinpointDestination();
        factoryAction?.Invoke(pinpointDestinationResult);

        return pinpointDestinationResult;
    }

    private Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.PinpointDestination CreatePinpointDestination()
    {
        var pinpointDestinationResult = new Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.PinpointDestination();

        return pinpointDestinationResult;
    }

} // End Of Class

public static class InnerConfigurationSetEventDestinationPinpointDestinationFactoryExtensions
{
}
