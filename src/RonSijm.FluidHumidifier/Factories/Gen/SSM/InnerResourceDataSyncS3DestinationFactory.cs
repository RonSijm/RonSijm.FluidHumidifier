// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSM;

public class InnerResourceDataSyncS3DestinationFactory(Action<Humidifier.SSM.ResourceDataSyncTypes.S3Destination> factoryAction = null) : SubResourceFactory<Humidifier.SSM.ResourceDataSyncTypes.S3Destination>
{

    protected override Humidifier.SSM.ResourceDataSyncTypes.S3Destination Create()
    {
        var s3DestinationResult = CreateS3Destination();
        factoryAction?.Invoke(s3DestinationResult);

        return s3DestinationResult;
    }

    private Humidifier.SSM.ResourceDataSyncTypes.S3Destination CreateS3Destination()
    {
        var s3DestinationResult = new Humidifier.SSM.ResourceDataSyncTypes.S3Destination();

        return s3DestinationResult;
    }

} // End Of Class

public static class InnerResourceDataSyncS3DestinationFactoryExtensions
{
}
