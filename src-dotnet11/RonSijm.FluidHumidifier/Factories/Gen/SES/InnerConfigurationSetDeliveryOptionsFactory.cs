// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerConfigurationSetDeliveryOptionsFactory(Action<Humidifier.SES.ConfigurationSetTypes.DeliveryOptions> factoryAction = null) : SubResourceFactory<Humidifier.SES.ConfigurationSetTypes.DeliveryOptions>
{

    protected override Humidifier.SES.ConfigurationSetTypes.DeliveryOptions Create()
    {
        var deliveryOptionsResult = CreateDeliveryOptions();
        factoryAction?.Invoke(deliveryOptionsResult);

        return deliveryOptionsResult;
    }

    private Humidifier.SES.ConfigurationSetTypes.DeliveryOptions CreateDeliveryOptions()
    {
        var deliveryOptionsResult = new Humidifier.SES.ConfigurationSetTypes.DeliveryOptions();

        return deliveryOptionsResult;
    }

} // End Of Class

public static class InnerConfigurationSetDeliveryOptionsFactoryExtensions
{
}
