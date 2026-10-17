// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpacesWeb;

public class InnerBrowserSettingsWebContentFilteringPolicyFactory(Action<Humidifier.WorkSpacesWeb.BrowserSettingsTypes.WebContentFilteringPolicy> factoryAction = null) : SubResourceFactory<Humidifier.WorkSpacesWeb.BrowserSettingsTypes.WebContentFilteringPolicy>
{

    protected override Humidifier.WorkSpacesWeb.BrowserSettingsTypes.WebContentFilteringPolicy Create()
    {
        var webContentFilteringPolicyResult = CreateWebContentFilteringPolicy();
        factoryAction?.Invoke(webContentFilteringPolicyResult);

        return webContentFilteringPolicyResult;
    }

    private Humidifier.WorkSpacesWeb.BrowserSettingsTypes.WebContentFilteringPolicy CreateWebContentFilteringPolicy()
    {
        var webContentFilteringPolicyResult = new Humidifier.WorkSpacesWeb.BrowserSettingsTypes.WebContentFilteringPolicy();

        return webContentFilteringPolicyResult;
    }

} // End Of Class

public static class InnerBrowserSettingsWebContentFilteringPolicyFactoryExtensions
{
}
