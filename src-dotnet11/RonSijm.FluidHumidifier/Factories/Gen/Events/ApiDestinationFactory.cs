// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class ApiDestinationFactory(string resourceName = null, Action<Humidifier.Events.ApiDestination> factoryAction = null) : ResourceFactory<Humidifier.Events.ApiDestination>(resourceName)
{

    protected override Humidifier.Events.ApiDestination Create()
    {
        var apiDestinationResult = CreateApiDestination();
        factoryAction?.Invoke(apiDestinationResult);

        return apiDestinationResult;
    }

    private Humidifier.Events.ApiDestination CreateApiDestination()
    {
        var apiDestinationResult = new Humidifier.Events.ApiDestination
        {
            GivenName = InputResourceName,
        };

        return apiDestinationResult;
    }

} // End Of Class

public static class ApiDestinationFactoryExtensions
{
}
