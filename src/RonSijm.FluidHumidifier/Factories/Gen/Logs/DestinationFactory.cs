// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class DestinationFactory(string resourceName = null, Action<Humidifier.Logs.Destination> factoryAction = null) : ResourceFactory<Humidifier.Logs.Destination>(resourceName)
{

    protected override Humidifier.Logs.Destination Create()
    {
        var destinationResult = CreateDestination();
        factoryAction?.Invoke(destinationResult);

        return destinationResult;
    }

    private Humidifier.Logs.Destination CreateDestination()
    {
        var destinationResult = new Humidifier.Logs.Destination
        {
            GivenName = InputResourceName,
        };

        return destinationResult;
    }

} // End Of Class

public static class DestinationFactoryExtensions
{
}
