// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Express;

public class DirectoryBucketFactory(string resourceName = null, Action<Humidifier.S3Express.DirectoryBucket> factoryAction = null) : ResourceFactory<Humidifier.S3Express.DirectoryBucket>(resourceName)
{

    protected override Humidifier.S3Express.DirectoryBucket Create()
    {
        var directoryBucketResult = CreateDirectoryBucket();
        factoryAction?.Invoke(directoryBucketResult);

        return directoryBucketResult;
    }

    private Humidifier.S3Express.DirectoryBucket CreateDirectoryBucket()
    {
        var directoryBucketResult = new Humidifier.S3Express.DirectoryBucket
        {
            GivenName = InputResourceName,
        };

        return directoryBucketResult;
    }

} // End Of Class

public static class DirectoryBucketFactoryExtensions
{
}
