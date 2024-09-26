// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ConnectCampaigns;

public class InnerCampaignProgressiveDialerConfigFactory(Action<Humidifier.ConnectCampaigns.CampaignTypes.ProgressiveDialerConfig> factoryAction = null) : SubResourceFactory<Humidifier.ConnectCampaigns.CampaignTypes.ProgressiveDialerConfig>
{

    protected override Humidifier.ConnectCampaigns.CampaignTypes.ProgressiveDialerConfig Create()
    {
        var progressiveDialerConfigResult = CreateProgressiveDialerConfig();
        factoryAction?.Invoke(progressiveDialerConfigResult);

        return progressiveDialerConfigResult;
    }

    private Humidifier.ConnectCampaigns.CampaignTypes.ProgressiveDialerConfig CreateProgressiveDialerConfig()
    {
        var progressiveDialerConfigResult = new Humidifier.ConnectCampaigns.CampaignTypes.ProgressiveDialerConfig();

        return progressiveDialerConfigResult;
    }

} // End Of Class

public static class InnerCampaignProgressiveDialerConfigFactoryExtensions
{
}
