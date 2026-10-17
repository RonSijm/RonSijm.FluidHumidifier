// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class InnerWebExperienceBrowserExtensionConfigurationFactory(Action<Humidifier.QBusiness.WebExperienceTypes.BrowserExtensionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QBusiness.WebExperienceTypes.BrowserExtensionConfiguration>
{

    protected override Humidifier.QBusiness.WebExperienceTypes.BrowserExtensionConfiguration Create()
    {
        var browserExtensionConfigurationResult = CreateBrowserExtensionConfiguration();
        factoryAction?.Invoke(browserExtensionConfigurationResult);

        return browserExtensionConfigurationResult;
    }

    private Humidifier.QBusiness.WebExperienceTypes.BrowserExtensionConfiguration CreateBrowserExtensionConfiguration()
    {
        var browserExtensionConfigurationResult = new Humidifier.QBusiness.WebExperienceTypes.BrowserExtensionConfiguration();

        return browserExtensionConfigurationResult;
    }

} // End Of Class

public static class InnerWebExperienceBrowserExtensionConfigurationFactoryExtensions
{
}
