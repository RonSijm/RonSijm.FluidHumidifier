// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class DeliverySourceFactory(string resourceName = null, Action<Humidifier.Logs.DeliverySource> factoryAction = null) : ResourceFactory<Humidifier.Logs.DeliverySource>(resourceName)
{

    protected override Humidifier.Logs.DeliverySource Create()
    {
        var deliverySourceResult = CreateDeliverySource();
        factoryAction?.Invoke(deliverySourceResult);

        return deliverySourceResult;
    }

    private Humidifier.Logs.DeliverySource CreateDeliverySource()
    {
        var deliverySourceResult = new Humidifier.Logs.DeliverySource
        {
            GivenName = InputResourceName,
        };

        return deliverySourceResult;
    }

} // End Of Class

public static class DeliverySourceFactoryExtensions
{
}
