// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Express;

public class InnerDirectoryBucketDestinationFactory(Action<Humidifier.S3Express.DirectoryBucketTypes.Destination> factoryAction = null) : SubResourceFactory<Humidifier.S3Express.DirectoryBucketTypes.Destination>
{

    protected override Humidifier.S3Express.DirectoryBucketTypes.Destination Create()
    {
        var destinationResult = CreateDestination();
        factoryAction?.Invoke(destinationResult);

        return destinationResult;
    }

    private Humidifier.S3Express.DirectoryBucketTypes.Destination CreateDestination()
    {
        var destinationResult = new Humidifier.S3Express.DirectoryBucketTypes.Destination();

        return destinationResult;
    }

} // End Of Class

public static class InnerDirectoryBucketDestinationFactoryExtensions
{
}
