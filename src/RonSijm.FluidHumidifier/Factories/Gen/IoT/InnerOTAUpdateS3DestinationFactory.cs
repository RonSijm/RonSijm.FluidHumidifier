// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerOTAUpdateS3DestinationFactory(Action<Humidifier.IoT.OTAUpdateTypes.S3Destination> factoryAction = null) : SubResourceFactory<Humidifier.IoT.OTAUpdateTypes.S3Destination>
{

    protected override Humidifier.IoT.OTAUpdateTypes.S3Destination Create()
    {
        var s3DestinationResult = CreateS3Destination();
        factoryAction?.Invoke(s3DestinationResult);

        return s3DestinationResult;
    }

    private Humidifier.IoT.OTAUpdateTypes.S3Destination CreateS3Destination()
    {
        var s3DestinationResult = new Humidifier.IoT.OTAUpdateTypes.S3Destination();

        return s3DestinationResult;
    }

} // End Of Class

public static class InnerOTAUpdateS3DestinationFactoryExtensions
{
}
