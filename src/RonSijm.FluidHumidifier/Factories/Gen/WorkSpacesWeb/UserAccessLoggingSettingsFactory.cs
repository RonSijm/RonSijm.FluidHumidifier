// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpacesWeb;

public class UserAccessLoggingSettingsFactory(string resourceName = null, Action<Humidifier.WorkSpacesWeb.UserAccessLoggingSettings> factoryAction = null) : ResourceFactory<Humidifier.WorkSpacesWeb.UserAccessLoggingSettings>(resourceName)
{

    protected override Humidifier.WorkSpacesWeb.UserAccessLoggingSettings Create()
    {
        var userAccessLoggingSettingsResult = CreateUserAccessLoggingSettings();
        factoryAction?.Invoke(userAccessLoggingSettingsResult);

        return userAccessLoggingSettingsResult;
    }

    private Humidifier.WorkSpacesWeb.UserAccessLoggingSettings CreateUserAccessLoggingSettings()
    {
        var userAccessLoggingSettingsResult = new Humidifier.WorkSpacesWeb.UserAccessLoggingSettings
        {
            GivenName = InputResourceName,
        };

        return userAccessLoggingSettingsResult;
    }

} // End Of Class

public static class UserAccessLoggingSettingsFactoryExtensions
{
}
