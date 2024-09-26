// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerBucketBucketEncryptionFactory(Action<Humidifier.S3.BucketTypes.BucketEncryption> factoryAction = null) : SubResourceFactory<Humidifier.S3.BucketTypes.BucketEncryption>
{

    protected override Humidifier.S3.BucketTypes.BucketEncryption Create()
    {
        var bucketEncryptionResult = CreateBucketEncryption();
        factoryAction?.Invoke(bucketEncryptionResult);

        return bucketEncryptionResult;
    }

    private Humidifier.S3.BucketTypes.BucketEncryption CreateBucketEncryption()
    {
        var bucketEncryptionResult = new Humidifier.S3.BucketTypes.BucketEncryption();

        return bucketEncryptionResult;
    }

} // End Of Class

public static class InnerBucketBucketEncryptionFactoryExtensions
{
}
