// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerLocationHDFSCustomSecretConfigFactory(Action<Humidifier.DataSync.LocationHDFSTypes.CustomSecretConfig> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.LocationHDFSTypes.CustomSecretConfig>
{

    protected override Humidifier.DataSync.LocationHDFSTypes.CustomSecretConfig Create()
    {
        var customSecretConfigResult = CreateCustomSecretConfig();
        factoryAction?.Invoke(customSecretConfigResult);

        return customSecretConfigResult;
    }

    private Humidifier.DataSync.LocationHDFSTypes.CustomSecretConfig CreateCustomSecretConfig()
    {
        var customSecretConfigResult = new Humidifier.DataSync.LocationHDFSTypes.CustomSecretConfig();

        return customSecretConfigResult;
    }

} // End Of Class

public static class InnerLocationHDFSCustomSecretConfigFactoryExtensions
{
}
