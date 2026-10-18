// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PinpointEmail;

public class InnerConfigurationSetDeliveryOptionsFactory(Action<Humidifier.PinpointEmail.ConfigurationSetTypes.DeliveryOptions> factoryAction = null) : SubResourceFactory<Humidifier.PinpointEmail.ConfigurationSetTypes.DeliveryOptions>
{

    protected override Humidifier.PinpointEmail.ConfigurationSetTypes.DeliveryOptions Create()
    {
        var deliveryOptionsResult = CreateDeliveryOptions();
        factoryAction?.Invoke(deliveryOptionsResult);

        return deliveryOptionsResult;
    }

    private Humidifier.PinpointEmail.ConfigurationSetTypes.DeliveryOptions CreateDeliveryOptions()
    {
        var deliveryOptionsResult = new Humidifier.PinpointEmail.ConfigurationSetTypes.DeliveryOptions();

        return deliveryOptionsResult;
    }

} // End Of Class

public static class InnerConfigurationSetDeliveryOptionsFactoryExtensions
{
}
