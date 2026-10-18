// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class DeliveryFactory(string resourceName = null, Action<Humidifier.Logs.Delivery> factoryAction = null) : ResourceFactory<Humidifier.Logs.Delivery>(resourceName)
{

    protected override Humidifier.Logs.Delivery Create()
    {
        var deliveryResult = CreateDelivery();
        factoryAction?.Invoke(deliveryResult);

        return deliveryResult;
    }

    private Humidifier.Logs.Delivery CreateDelivery()
    {
        var deliveryResult = new Humidifier.Logs.Delivery
        {
            GivenName = InputResourceName,
        };

        return deliveryResult;
    }

} // End Of Class

public static class DeliveryFactoryExtensions
{
}
