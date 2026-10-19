// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFabric;

public class InnerIngestionDestinationS3BucketFactory(Action<Humidifier.AppFabric.IngestionDestinationTypes.S3Bucket> factoryAction = null) : SubResourceFactory<Humidifier.AppFabric.IngestionDestinationTypes.S3Bucket>
{

    protected override Humidifier.AppFabric.IngestionDestinationTypes.S3Bucket Create()
    {
        var s3BucketResult = CreateS3Bucket();
        factoryAction?.Invoke(s3BucketResult);

        return s3BucketResult;
    }

    private Humidifier.AppFabric.IngestionDestinationTypes.S3Bucket CreateS3Bucket()
    {
        var s3BucketResult = new Humidifier.AppFabric.IngestionDestinationTypes.S3Bucket();

        return s3BucketResult;
    }

} // End Of Class

public static class InnerIngestionDestinationS3BucketFactoryExtensions
{
}
