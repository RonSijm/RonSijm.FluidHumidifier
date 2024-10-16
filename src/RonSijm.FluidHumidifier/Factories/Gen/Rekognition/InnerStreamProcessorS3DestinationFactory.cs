// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Rekognition;

public class InnerStreamProcessorS3DestinationFactory(Action<Humidifier.Rekognition.StreamProcessorTypes.S3Destination> factoryAction = null) : SubResourceFactory<Humidifier.Rekognition.StreamProcessorTypes.S3Destination>
{

    protected override Humidifier.Rekognition.StreamProcessorTypes.S3Destination Create()
    {
        var s3DestinationResult = CreateS3Destination();
        factoryAction?.Invoke(s3DestinationResult);

        return s3DestinationResult;
    }

    private Humidifier.Rekognition.StreamProcessorTypes.S3Destination CreateS3Destination()
    {
        var s3DestinationResult = new Humidifier.Rekognition.StreamProcessorTypes.S3Destination();

        return s3DestinationResult;
    }

} // End Of Class

public static class InnerStreamProcessorS3DestinationFactoryExtensions
{
}
