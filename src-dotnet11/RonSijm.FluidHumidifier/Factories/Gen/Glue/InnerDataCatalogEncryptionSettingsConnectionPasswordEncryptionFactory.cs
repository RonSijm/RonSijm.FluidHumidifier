// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerDataCatalogEncryptionSettingsConnectionPasswordEncryptionFactory(Action<Humidifier.Glue.DataCatalogEncryptionSettingsTypes.ConnectionPasswordEncryption> factoryAction = null) : SubResourceFactory<Humidifier.Glue.DataCatalogEncryptionSettingsTypes.ConnectionPasswordEncryption>
{

    protected override Humidifier.Glue.DataCatalogEncryptionSettingsTypes.ConnectionPasswordEncryption Create()
    {
        var connectionPasswordEncryptionResult = CreateConnectionPasswordEncryption();
        factoryAction?.Invoke(connectionPasswordEncryptionResult);

        return connectionPasswordEncryptionResult;
    }

    private Humidifier.Glue.DataCatalogEncryptionSettingsTypes.ConnectionPasswordEncryption CreateConnectionPasswordEncryption()
    {
        var connectionPasswordEncryptionResult = new Humidifier.Glue.DataCatalogEncryptionSettingsTypes.ConnectionPasswordEncryption();

        return connectionPasswordEncryptionResult;
    }

} // End Of Class

public static class InnerDataCatalogEncryptionSettingsConnectionPasswordEncryptionFactoryExtensions
{
}
