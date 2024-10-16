// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerDataCatalogEncryptionSettingsEncryptionAtRestFactory(Action<Humidifier.Glue.DataCatalogEncryptionSettingsTypes.EncryptionAtRest> factoryAction = null) : SubResourceFactory<Humidifier.Glue.DataCatalogEncryptionSettingsTypes.EncryptionAtRest>
{

    protected override Humidifier.Glue.DataCatalogEncryptionSettingsTypes.EncryptionAtRest Create()
    {
        var encryptionAtRestResult = CreateEncryptionAtRest();
        factoryAction?.Invoke(encryptionAtRestResult);

        return encryptionAtRestResult;
    }

    private Humidifier.Glue.DataCatalogEncryptionSettingsTypes.EncryptionAtRest CreateEncryptionAtRest()
    {
        var encryptionAtRestResult = new Humidifier.Glue.DataCatalogEncryptionSettingsTypes.EncryptionAtRest();

        return encryptionAtRestResult;
    }

} // End Of Class

public static class InnerDataCatalogEncryptionSettingsEncryptionAtRestFactoryExtensions
{
}
