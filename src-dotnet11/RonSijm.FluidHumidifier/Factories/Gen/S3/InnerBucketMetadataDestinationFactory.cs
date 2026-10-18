// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerBucketMetadataDestinationFactory(Action<Humidifier.S3.BucketTypes.MetadataDestination> factoryAction = null) : SubResourceFactory<Humidifier.S3.BucketTypes.MetadataDestination>
{

    protected override Humidifier.S3.BucketTypes.MetadataDestination Create()
    {
        var metadataDestinationResult = CreateMetadataDestination();
        factoryAction?.Invoke(metadataDestinationResult);

        return metadataDestinationResult;
    }

    private Humidifier.S3.BucketTypes.MetadataDestination CreateMetadataDestination()
    {
        var metadataDestinationResult = new Humidifier.S3.BucketTypes.MetadataDestination();

        return metadataDestinationResult;
    }

} // End Of Class

public static class InnerBucketMetadataDestinationFactoryExtensions
{
}
