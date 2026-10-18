// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ConnectCampaignsV2;

public class InnerCampaignProgressiveConfigFactory(Action<Humidifier.ConnectCampaignsV2.CampaignTypes.ProgressiveConfig> factoryAction = null) : SubResourceFactory<Humidifier.ConnectCampaignsV2.CampaignTypes.ProgressiveConfig>
{

    protected override Humidifier.ConnectCampaignsV2.CampaignTypes.ProgressiveConfig Create()
    {
        var progressiveConfigResult = CreateProgressiveConfig();
        factoryAction?.Invoke(progressiveConfigResult);

        return progressiveConfigResult;
    }

    private Humidifier.ConnectCampaignsV2.CampaignTypes.ProgressiveConfig CreateProgressiveConfig()
    {
        var progressiveConfigResult = new Humidifier.ConnectCampaignsV2.CampaignTypes.ProgressiveConfig();

        return progressiveConfigResult;
    }

} // End Of Class

public static class InnerCampaignProgressiveConfigFactoryExtensions
{
}
