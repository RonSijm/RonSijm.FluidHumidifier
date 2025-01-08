// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class InnerWebExperienceCustomizationConfigurationFactory(Action<Humidifier.QBusiness.WebExperienceTypes.CustomizationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QBusiness.WebExperienceTypes.CustomizationConfiguration>
{

    protected override Humidifier.QBusiness.WebExperienceTypes.CustomizationConfiguration Create()
    {
        var customizationConfigurationResult = CreateCustomizationConfiguration();
        factoryAction?.Invoke(customizationConfigurationResult);

        return customizationConfigurationResult;
    }

    private Humidifier.QBusiness.WebExperienceTypes.CustomizationConfiguration CreateCustomizationConfiguration()
    {
        var customizationConfigurationResult = new Humidifier.QBusiness.WebExperienceTypes.CustomizationConfiguration();

        return customizationConfigurationResult;
    }

} // End Of Class

public static class InnerWebExperienceCustomizationConfigurationFactoryExtensions
{
}
