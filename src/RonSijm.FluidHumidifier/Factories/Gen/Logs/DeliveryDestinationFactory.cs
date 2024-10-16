// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class DeliveryDestinationFactory(string resourceName = null, Action<Humidifier.Logs.DeliveryDestination> factoryAction = null) : ResourceFactory<Humidifier.Logs.DeliveryDestination>(resourceName)
{

    protected override Humidifier.Logs.DeliveryDestination Create()
    {
        var deliveryDestinationResult = CreateDeliveryDestination();
        factoryAction?.Invoke(deliveryDestinationResult);

        return deliveryDestinationResult;
    }

    private Humidifier.Logs.DeliveryDestination CreateDeliveryDestination()
    {
        var deliveryDestinationResult = new Humidifier.Logs.DeliveryDestination
        {
            GivenName = InputResourceName,
        };

        return deliveryDestinationResult;
    }

} // End Of Class

public static class DeliveryDestinationFactoryExtensions
{
}
