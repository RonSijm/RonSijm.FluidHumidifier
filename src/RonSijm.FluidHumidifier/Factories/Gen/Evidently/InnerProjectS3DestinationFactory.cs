// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Evidently;

public class InnerProjectS3DestinationFactory(Action<Humidifier.Evidently.ProjectTypes.S3Destination> factoryAction = null) : SubResourceFactory<Humidifier.Evidently.ProjectTypes.S3Destination>
{

    protected override Humidifier.Evidently.ProjectTypes.S3Destination Create()
    {
        var s3DestinationResult = CreateS3Destination();
        factoryAction?.Invoke(s3DestinationResult);

        return s3DestinationResult;
    }

    private Humidifier.Evidently.ProjectTypes.S3Destination CreateS3Destination()
    {
        var s3DestinationResult = new Humidifier.Evidently.ProjectTypes.S3Destination();

        return s3DestinationResult;
    }

} // End Of Class

public static class InnerProjectS3DestinationFactoryExtensions
{
}
