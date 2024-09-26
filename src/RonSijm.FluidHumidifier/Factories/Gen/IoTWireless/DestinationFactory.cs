// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTWireless;

public class DestinationFactory(string resourceName = null, Action<Humidifier.IoTWireless.Destination> factoryAction = null) : ResourceFactory<Humidifier.IoTWireless.Destination>(resourceName)
{

    protected override Humidifier.IoTWireless.Destination Create()
    {
        var destinationResult = CreateDestination();
        factoryAction?.Invoke(destinationResult);

        return destinationResult;
    }

    private Humidifier.IoTWireless.Destination CreateDestination()
    {
        var destinationResult = new Humidifier.IoTWireless.Destination
        {
            GivenName = InputResourceName,
        };

        return destinationResult;
    }

} // End Of Class

public static class DestinationFactoryExtensions
{
}
