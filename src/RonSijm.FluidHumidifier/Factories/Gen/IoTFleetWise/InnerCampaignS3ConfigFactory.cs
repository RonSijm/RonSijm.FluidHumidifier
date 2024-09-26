// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetWise;

public class InnerCampaignS3ConfigFactory(Action<Humidifier.IoTFleetWise.CampaignTypes.S3Config> factoryAction = null) : SubResourceFactory<Humidifier.IoTFleetWise.CampaignTypes.S3Config>
{

    protected override Humidifier.IoTFleetWise.CampaignTypes.S3Config Create()
    {
        var s3ConfigResult = CreateS3Config();
        factoryAction?.Invoke(s3ConfigResult);

        return s3ConfigResult;
    }

    private Humidifier.IoTFleetWise.CampaignTypes.S3Config CreateS3Config()
    {
        var s3ConfigResult = new Humidifier.IoTFleetWise.CampaignTypes.S3Config();

        return s3ConfigResult;
    }

} // End Of Class

public static class InnerCampaignS3ConfigFactoryExtensions
{
}
