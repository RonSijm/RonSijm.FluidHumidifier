// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerLocationAzureBlobAzureOidcConfigFactory(Action<Humidifier.DataSync.LocationAzureBlobTypes.AzureOidcConfig> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.LocationAzureBlobTypes.AzureOidcConfig>
{

    protected override Humidifier.DataSync.LocationAzureBlobTypes.AzureOidcConfig Create()
    {
        var azureOidcConfigResult = CreateAzureOidcConfig();
        factoryAction?.Invoke(azureOidcConfigResult);

        return azureOidcConfigResult;
    }

    private Humidifier.DataSync.LocationAzureBlobTypes.AzureOidcConfig CreateAzureOidcConfig()
    {
        var azureOidcConfigResult = new Humidifier.DataSync.LocationAzureBlobTypes.AzureOidcConfig();

        return azureOidcConfigResult;
    }

} // End Of Class

public static class InnerLocationAzureBlobAzureOidcConfigFactoryExtensions
{
}
