// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpacesWeb;

public class BrowserSettingsFactory(string resourceName = null, Action<Humidifier.WorkSpacesWeb.BrowserSettings> factoryAction = null) : ResourceFactory<Humidifier.WorkSpacesWeb.BrowserSettings>(resourceName)
{

    protected override Humidifier.WorkSpacesWeb.BrowserSettings Create()
    {
        var browserSettingsResult = CreateBrowserSettings();
        factoryAction?.Invoke(browserSettingsResult);

        return browserSettingsResult;
    }

    private Humidifier.WorkSpacesWeb.BrowserSettings CreateBrowserSettings()
    {
        var browserSettingsResult = new Humidifier.WorkSpacesWeb.BrowserSettings
        {
            GivenName = InputResourceName,
        };

        return browserSettingsResult;
    }

} // End Of Class

public static class BrowserSettingsFactoryExtensions
{
}
