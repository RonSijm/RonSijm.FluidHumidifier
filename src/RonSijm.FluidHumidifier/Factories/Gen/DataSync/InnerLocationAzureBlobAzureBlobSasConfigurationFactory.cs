// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerLocationAzureBlobAzureBlobSasConfigurationFactory(Action<Humidifier.DataSync.LocationAzureBlobTypes.AzureBlobSasConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.LocationAzureBlobTypes.AzureBlobSasConfiguration>
{

    protected override Humidifier.DataSync.LocationAzureBlobTypes.AzureBlobSasConfiguration Create()
    {
        var azureBlobSasConfigurationResult = CreateAzureBlobSasConfiguration();
        factoryAction?.Invoke(azureBlobSasConfigurationResult);

        return azureBlobSasConfigurationResult;
    }

    private Humidifier.DataSync.LocationAzureBlobTypes.AzureBlobSasConfiguration CreateAzureBlobSasConfiguration()
    {
        var azureBlobSasConfigurationResult = new Humidifier.DataSync.LocationAzureBlobTypes.AzureBlobSasConfiguration();

        return azureBlobSasConfigurationResult;
    }

} // End Of Class

public static class InnerLocationAzureBlobAzureBlobSasConfigurationFactoryExtensions
{
}
