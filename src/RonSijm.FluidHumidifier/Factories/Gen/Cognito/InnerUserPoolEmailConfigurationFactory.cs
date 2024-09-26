// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolEmailConfigurationFactory(Action<Humidifier.Cognito.UserPoolTypes.EmailConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolTypes.EmailConfiguration>
{

    protected override Humidifier.Cognito.UserPoolTypes.EmailConfiguration Create()
    {
        var emailConfigurationResult = CreateEmailConfiguration();
        factoryAction?.Invoke(emailConfigurationResult);

        return emailConfigurationResult;
    }

    private Humidifier.Cognito.UserPoolTypes.EmailConfiguration CreateEmailConfiguration()
    {
        var emailConfigurationResult = new Humidifier.Cognito.UserPoolTypes.EmailConfiguration();

        return emailConfigurationResult;
    }

} // End Of Class

public static class InnerUserPoolEmailConfigurationFactoryExtensions
{
}
