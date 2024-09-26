// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerConfigurationSetSendingOptionsFactory(Action<Humidifier.SES.ConfigurationSetTypes.SendingOptions> factoryAction = null) : SubResourceFactory<Humidifier.SES.ConfigurationSetTypes.SendingOptions>
{

    protected override Humidifier.SES.ConfigurationSetTypes.SendingOptions Create()
    {
        var sendingOptionsResult = CreateSendingOptions();
        factoryAction?.Invoke(sendingOptionsResult);

        return sendingOptionsResult;
    }

    private Humidifier.SES.ConfigurationSetTypes.SendingOptions CreateSendingOptions()
    {
        var sendingOptionsResult = new Humidifier.SES.ConfigurationSetTypes.SendingOptions();

        return sendingOptionsResult;
    }

} // End Of Class

public static class InnerConfigurationSetSendingOptionsFactoryExtensions
{
}
