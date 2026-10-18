// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MGN;

public class InnerImportS3BucketSourceFactory(Action<Humidifier.MGN.ImportTypes.S3BucketSource> factoryAction = null) : SubResourceFactory<Humidifier.MGN.ImportTypes.S3BucketSource>
{

    protected override Humidifier.MGN.ImportTypes.S3BucketSource Create()
    {
        var s3BucketSourceResult = CreateS3BucketSource();
        factoryAction?.Invoke(s3BucketSourceResult);

        return s3BucketSourceResult;
    }

    private Humidifier.MGN.ImportTypes.S3BucketSource CreateS3BucketSource()
    {
        var s3BucketSourceResult = new Humidifier.MGN.ImportTypes.S3BucketSource();

        return s3BucketSourceResult;
    }

} // End Of Class

public static class InnerImportS3BucketSourceFactoryExtensions
{
}
