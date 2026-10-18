// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerLocationAzureBlobCustomSecretConfigFactory(Action<Humidifier.DataSync.LocationAzureBlobTypes.CustomSecretConfig> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.LocationAzureBlobTypes.CustomSecretConfig>
{

    protected override Humidifier.DataSync.LocationAzureBlobTypes.CustomSecretConfig Create()
    {
        var customSecretConfigResult = CreateCustomSecretConfig();
        factoryAction?.Invoke(customSecretConfigResult);

        return customSecretConfigResult;
    }

    private Humidifier.DataSync.LocationAzureBlobTypes.CustomSecretConfig CreateCustomSecretConfig()
    {
        var customSecretConfigResult = new Humidifier.DataSync.LocationAzureBlobTypes.CustomSecretConfig();

        return customSecretConfigResult;
    }

} // End Of Class

public static class InnerLocationAzureBlobCustomSecretConfigFactoryExtensions
{
}
