// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerBucketDestinationFactory(Action<Humidifier.S3.BucketTypes.Destination> factoryAction = null) : SubResourceFactory<Humidifier.S3.BucketTypes.Destination>
{

    protected override Humidifier.S3.BucketTypes.Destination Create()
    {
        var destinationResult = CreateDestination();
        factoryAction?.Invoke(destinationResult);

        return destinationResult;
    }

    private Humidifier.S3.BucketTypes.Destination CreateDestination()
    {
        var destinationResult = new Humidifier.S3.BucketTypes.Destination();

        return destinationResult;
    }

} // End Of Class

public static class InnerBucketDestinationFactoryExtensions
{
}
