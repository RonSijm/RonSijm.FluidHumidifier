// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerLocationObjectStorageCustomSecretConfigFactory(Action<Humidifier.DataSync.LocationObjectStorageTypes.CustomSecretConfig> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.LocationObjectStorageTypes.CustomSecretConfig>
{

    protected override Humidifier.DataSync.LocationObjectStorageTypes.CustomSecretConfig Create()
    {
        var customSecretConfigResult = CreateCustomSecretConfig();
        factoryAction?.Invoke(customSecretConfigResult);

        return customSecretConfigResult;
    }

    private Humidifier.DataSync.LocationObjectStorageTypes.CustomSecretConfig CreateCustomSecretConfig()
    {
        var customSecretConfigResult = new Humidifier.DataSync.LocationObjectStorageTypes.CustomSecretConfig();

        return customSecretConfigResult;
    }

} // End Of Class

public static class InnerLocationObjectStorageCustomSecretConfigFactoryExtensions
{
}
