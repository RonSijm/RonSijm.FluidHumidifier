// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Express;

public class InnerDirectoryBucketBucketEncryptionFactory(Action<Humidifier.S3Express.DirectoryBucketTypes.BucketEncryption> factoryAction = null) : SubResourceFactory<Humidifier.S3Express.DirectoryBucketTypes.BucketEncryption>
{

    protected override Humidifier.S3Express.DirectoryBucketTypes.BucketEncryption Create()
    {
        var bucketEncryptionResult = CreateBucketEncryption();
        factoryAction?.Invoke(bucketEncryptionResult);

        return bucketEncryptionResult;
    }

    private Humidifier.S3Express.DirectoryBucketTypes.BucketEncryption CreateBucketEncryption()
    {
        var bucketEncryptionResult = new Humidifier.S3Express.DirectoryBucketTypes.BucketEncryption();

        return bucketEncryptionResult;
    }

} // End Of Class

public static class InnerDirectoryBucketBucketEncryptionFactoryExtensions
{
}
