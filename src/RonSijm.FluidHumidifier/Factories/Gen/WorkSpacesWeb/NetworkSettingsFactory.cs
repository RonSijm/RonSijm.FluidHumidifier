// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpacesWeb;

public class NetworkSettingsFactory(string resourceName = null, Action<Humidifier.WorkSpacesWeb.NetworkSettings> factoryAction = null) : ResourceFactory<Humidifier.WorkSpacesWeb.NetworkSettings>(resourceName)
{

    protected override Humidifier.WorkSpacesWeb.NetworkSettings Create()
    {
        var networkSettingsResult = CreateNetworkSettings();
        factoryAction?.Invoke(networkSettingsResult);

        return networkSettingsResult;
    }

    private Humidifier.WorkSpacesWeb.NetworkSettings CreateNetworkSettings()
    {
        var networkSettingsResult = new Humidifier.WorkSpacesWeb.NetworkSettings
        {
            GivenName = InputResourceName,
        };

        return networkSettingsResult;
    }

} // End Of Class

public static class NetworkSettingsFactoryExtensions
{
}
