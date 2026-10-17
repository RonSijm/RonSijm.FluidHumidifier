// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerLocationFSxWindowsCustomSecretConfigFactory(Action<Humidifier.DataSync.LocationFSxWindowsTypes.CustomSecretConfig> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.LocationFSxWindowsTypes.CustomSecretConfig>
{

    protected override Humidifier.DataSync.LocationFSxWindowsTypes.CustomSecretConfig Create()
    {
        var customSecretConfigResult = CreateCustomSecretConfig();
        factoryAction?.Invoke(customSecretConfigResult);

        return customSecretConfigResult;
    }

    private Humidifier.DataSync.LocationFSxWindowsTypes.CustomSecretConfig CreateCustomSecretConfig()
    {
        var customSecretConfigResult = new Humidifier.DataSync.LocationFSxWindowsTypes.CustomSecretConfig();

        return customSecretConfigResult;
    }

} // End Of Class

public static class InnerLocationFSxWindowsCustomSecretConfigFactoryExtensions
{
}
