// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerLocationSMBCustomSecretConfigFactory(Action<Humidifier.DataSync.LocationSMBTypes.CustomSecretConfig> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.LocationSMBTypes.CustomSecretConfig>
{

    protected override Humidifier.DataSync.LocationSMBTypes.CustomSecretConfig Create()
    {
        var customSecretConfigResult = CreateCustomSecretConfig();
        factoryAction?.Invoke(customSecretConfigResult);

        return customSecretConfigResult;
    }

    private Humidifier.DataSync.LocationSMBTypes.CustomSecretConfig CreateCustomSecretConfig()
    {
        var customSecretConfigResult = new Humidifier.DataSync.LocationSMBTypes.CustomSecretConfig();

        return customSecretConfigResult;
    }

} // End Of Class

public static class InnerLocationSMBCustomSecretConfigFactoryExtensions
{
}
