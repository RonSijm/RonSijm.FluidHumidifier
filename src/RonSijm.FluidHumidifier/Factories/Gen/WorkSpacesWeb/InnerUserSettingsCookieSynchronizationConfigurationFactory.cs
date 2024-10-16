// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpacesWeb;

public class InnerUserSettingsCookieSynchronizationConfigurationFactory(Action<Humidifier.WorkSpacesWeb.UserSettingsTypes.CookieSynchronizationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.WorkSpacesWeb.UserSettingsTypes.CookieSynchronizationConfiguration>
{

    protected override Humidifier.WorkSpacesWeb.UserSettingsTypes.CookieSynchronizationConfiguration Create()
    {
        var cookieSynchronizationConfigurationResult = CreateCookieSynchronizationConfiguration();
        factoryAction?.Invoke(cookieSynchronizationConfigurationResult);

        return cookieSynchronizationConfigurationResult;
    }

    private Humidifier.WorkSpacesWeb.UserSettingsTypes.CookieSynchronizationConfiguration CreateCookieSynchronizationConfiguration()
    {
        var cookieSynchronizationConfigurationResult = new Humidifier.WorkSpacesWeb.UserSettingsTypes.CookieSynchronizationConfiguration();

        return cookieSynchronizationConfigurationResult;
    }

} // End Of Class

public static class InnerUserSettingsCookieSynchronizationConfigurationFactoryExtensions
{
}
