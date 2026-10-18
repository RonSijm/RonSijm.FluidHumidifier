// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class InnerPluginOAuth2ClientCredentialConfigurationFactory(Action<Humidifier.QBusiness.PluginTypes.OAuth2ClientCredentialConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QBusiness.PluginTypes.OAuth2ClientCredentialConfiguration>
{

    protected override Humidifier.QBusiness.PluginTypes.OAuth2ClientCredentialConfiguration Create()
    {
        var oAuth2ClientCredentialConfigurationResult = CreateOAuth2ClientCredentialConfiguration();
        factoryAction?.Invoke(oAuth2ClientCredentialConfigurationResult);

        return oAuth2ClientCredentialConfigurationResult;
    }

    private Humidifier.QBusiness.PluginTypes.OAuth2ClientCredentialConfiguration CreateOAuth2ClientCredentialConfiguration()
    {
        var oAuth2ClientCredentialConfigurationResult = new Humidifier.QBusiness.PluginTypes.OAuth2ClientCredentialConfiguration();

        return oAuth2ClientCredentialConfigurationResult;
    }

} // End Of Class

public static class InnerPluginOAuth2ClientCredentialConfigurationFactoryExtensions
{
}
