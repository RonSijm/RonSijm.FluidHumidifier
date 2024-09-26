// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.HealthLake;

public class InnerFHIRDatastoreKmsEncryptionConfigFactory(Action<Humidifier.HealthLake.FHIRDatastoreTypes.KmsEncryptionConfig> factoryAction = null) : SubResourceFactory<Humidifier.HealthLake.FHIRDatastoreTypes.KmsEncryptionConfig>
{

    protected override Humidifier.HealthLake.FHIRDatastoreTypes.KmsEncryptionConfig Create()
    {
        var kmsEncryptionConfigResult = CreateKmsEncryptionConfig();
        factoryAction?.Invoke(kmsEncryptionConfigResult);

        return kmsEncryptionConfigResult;
    }

    private Humidifier.HealthLake.FHIRDatastoreTypes.KmsEncryptionConfig CreateKmsEncryptionConfig()
    {
        var kmsEncryptionConfigResult = new Humidifier.HealthLake.FHIRDatastoreTypes.KmsEncryptionConfig();

        return kmsEncryptionConfigResult;
    }

} // End Of Class

public static class InnerFHIRDatastoreKmsEncryptionConfigFactoryExtensions
{
}
