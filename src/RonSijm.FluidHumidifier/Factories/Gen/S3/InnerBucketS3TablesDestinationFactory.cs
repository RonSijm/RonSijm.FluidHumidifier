// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerBucketS3TablesDestinationFactory(Action<Humidifier.S3.BucketTypes.S3TablesDestination> factoryAction = null) : SubResourceFactory<Humidifier.S3.BucketTypes.S3TablesDestination>
{

    protected override Humidifier.S3.BucketTypes.S3TablesDestination Create()
    {
        var s3TablesDestinationResult = CreateS3TablesDestination();
        factoryAction?.Invoke(s3TablesDestinationResult);

        return s3TablesDestinationResult;
    }

    private Humidifier.S3.BucketTypes.S3TablesDestination CreateS3TablesDestination()
    {
        var s3TablesDestinationResult = new Humidifier.S3.BucketTypes.S3TablesDestination();

        return s3TablesDestinationResult;
    }

} // End Of Class

public static class InnerBucketS3TablesDestinationFactoryExtensions
{
}
