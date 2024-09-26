// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolSmsConfigurationFactory(Action<Humidifier.Cognito.UserPoolTypes.SmsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolTypes.SmsConfiguration>
{

    protected override Humidifier.Cognito.UserPoolTypes.SmsConfiguration Create()
    {
        var smsConfigurationResult = CreateSmsConfiguration();
        factoryAction?.Invoke(smsConfigurationResult);

        return smsConfigurationResult;
    }

    private Humidifier.Cognito.UserPoolTypes.SmsConfiguration CreateSmsConfiguration()
    {
        var smsConfigurationResult = new Humidifier.Cognito.UserPoolTypes.SmsConfiguration();

        return smsConfigurationResult;
    }

} // End Of Class

public static class InnerUserPoolSmsConfigurationFactoryExtensions
{
}
