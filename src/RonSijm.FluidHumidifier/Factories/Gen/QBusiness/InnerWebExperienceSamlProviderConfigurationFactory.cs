// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class InnerWebExperienceSamlProviderConfigurationFactory(Action<Humidifier.QBusiness.WebExperienceTypes.SamlProviderConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QBusiness.WebExperienceTypes.SamlProviderConfiguration>
{

    protected override Humidifier.QBusiness.WebExperienceTypes.SamlProviderConfiguration Create()
    {
        var samlProviderConfigurationResult = CreateSamlProviderConfiguration();
        factoryAction?.Invoke(samlProviderConfigurationResult);

        return samlProviderConfigurationResult;
    }

    private Humidifier.QBusiness.WebExperienceTypes.SamlProviderConfiguration CreateSamlProviderConfiguration()
    {
        var samlProviderConfigurationResult = new Humidifier.QBusiness.WebExperienceTypes.SamlProviderConfiguration();

        return samlProviderConfigurationResult;
    }

} // End Of Class

public static class InnerWebExperienceSamlProviderConfigurationFactoryExtensions
{
}
