// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackageV2;

public class InnerHarvestJobS3DestinationConfigFactory(Action<Humidifier.MediaPackageV2.HarvestJobTypes.S3DestinationConfig> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackageV2.HarvestJobTypes.S3DestinationConfig>
{

    protected override Humidifier.MediaPackageV2.HarvestJobTypes.S3DestinationConfig Create()
    {
        var s3DestinationConfigResult = CreateS3DestinationConfig();
        factoryAction?.Invoke(s3DestinationConfigResult);

        return s3DestinationConfigResult;
    }

    private Humidifier.MediaPackageV2.HarvestJobTypes.S3DestinationConfig CreateS3DestinationConfig()
    {
        var s3DestinationConfigResult = new Humidifier.MediaPackageV2.HarvestJobTypes.S3DestinationConfig();

        return s3DestinationConfigResult;
    }

} // End Of Class

public static class InnerHarvestJobS3DestinationConfigFactoryExtensions
{
}
