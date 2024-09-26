// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class InnerWebExperienceOpenIDConnectProviderConfigurationFactory(Action<Humidifier.QBusiness.WebExperienceTypes.OpenIDConnectProviderConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QBusiness.WebExperienceTypes.OpenIDConnectProviderConfiguration>
{

    protected override Humidifier.QBusiness.WebExperienceTypes.OpenIDConnectProviderConfiguration Create()
    {
        var openIDConnectProviderConfigurationResult = CreateOpenIDConnectProviderConfiguration();
        factoryAction?.Invoke(openIDConnectProviderConfigurationResult);

        return openIDConnectProviderConfigurationResult;
    }

    private Humidifier.QBusiness.WebExperienceTypes.OpenIDConnectProviderConfiguration CreateOpenIDConnectProviderConfiguration()
    {
        var openIDConnectProviderConfigurationResult = new Humidifier.QBusiness.WebExperienceTypes.OpenIDConnectProviderConfiguration();

        return openIDConnectProviderConfigurationResult;
    }

} // End Of Class

public static class InnerWebExperienceOpenIDConnectProviderConfigurationFactoryExtensions
{
}
