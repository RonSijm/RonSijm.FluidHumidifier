// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PinpointEmail;

public class InnerConfigurationSetSendingOptionsFactory(Action<Humidifier.PinpointEmail.ConfigurationSetTypes.SendingOptions> factoryAction = null) : SubResourceFactory<Humidifier.PinpointEmail.ConfigurationSetTypes.SendingOptions>
{

    protected override Humidifier.PinpointEmail.ConfigurationSetTypes.SendingOptions Create()
    {
        var sendingOptionsResult = CreateSendingOptions();
        factoryAction?.Invoke(sendingOptionsResult);

        return sendingOptionsResult;
    }

    private Humidifier.PinpointEmail.ConfigurationSetTypes.SendingOptions CreateSendingOptions()
    {
        var sendingOptionsResult = new Humidifier.PinpointEmail.ConfigurationSetTypes.SendingOptions();

        return sendingOptionsResult;
    }

} // End Of Class

public static class InnerConfigurationSetSendingOptionsFactoryExtensions
{
}
