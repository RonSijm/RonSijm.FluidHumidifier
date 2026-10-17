// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackage;

public class InnerHarvestJobS3DestinationFactory(Action<Humidifier.MediaPackage.HarvestJobTypes.S3Destination> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackage.HarvestJobTypes.S3Destination>
{

    protected override Humidifier.MediaPackage.HarvestJobTypes.S3Destination Create()
    {
        var s3DestinationResult = CreateS3Destination();
        factoryAction?.Invoke(s3DestinationResult);

        return s3DestinationResult;
    }

    private Humidifier.MediaPackage.HarvestJobTypes.S3Destination CreateS3Destination()
    {
        var s3DestinationResult = new Humidifier.MediaPackage.HarvestJobTypes.S3Destination();

        return s3DestinationResult;
    }

} // End Of Class

public static class InnerHarvestJobS3DestinationFactoryExtensions
{
}
