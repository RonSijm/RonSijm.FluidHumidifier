// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ObservabilityAdmin;

public class InnerS3TableIntegrationEncryptionConfigFactory(Action<Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.EncryptionConfig> factoryAction = null) : SubResourceFactory<Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.EncryptionConfig>
{

    protected override Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.EncryptionConfig Create()
    {
        var encryptionConfigResult = CreateEncryptionConfig();
        factoryAction?.Invoke(encryptionConfigResult);

        return encryptionConfigResult;
    }

    private Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.EncryptionConfig CreateEncryptionConfig()
    {
        var encryptionConfigResult = new Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.EncryptionConfig();

        return encryptionConfigResult;
    }

} // End Of Class

public static class InnerS3TableIntegrationEncryptionConfigFactoryExtensions
{
}
