// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Synthetics;

public class InnerCanaryS3EncryptionFactory(Action<Humidifier.Synthetics.CanaryTypes.S3Encryption> factoryAction = null) : SubResourceFactory<Humidifier.Synthetics.CanaryTypes.S3Encryption>
{

    protected override Humidifier.Synthetics.CanaryTypes.S3Encryption Create()
    {
        var s3EncryptionResult = CreateS3Encryption();
        factoryAction?.Invoke(s3EncryptionResult);

        return s3EncryptionResult;
    }

    private Humidifier.Synthetics.CanaryTypes.S3Encryption CreateS3Encryption()
    {
        var s3EncryptionResult = new Humidifier.Synthetics.CanaryTypes.S3Encryption();

        return s3EncryptionResult;
    }

} // End Of Class

public static class InnerCanaryS3EncryptionFactoryExtensions
{
}
