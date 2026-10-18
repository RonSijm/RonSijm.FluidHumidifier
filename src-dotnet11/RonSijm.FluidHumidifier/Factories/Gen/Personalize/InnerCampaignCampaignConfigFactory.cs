// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Personalize;

public class InnerCampaignCampaignConfigFactory(Action<Humidifier.Personalize.CampaignTypes.CampaignConfig> factoryAction = null) : SubResourceFactory<Humidifier.Personalize.CampaignTypes.CampaignConfig>
{

    protected override Humidifier.Personalize.CampaignTypes.CampaignConfig Create()
    {
        var campaignConfigResult = CreateCampaignConfig();
        factoryAction?.Invoke(campaignConfigResult);

        return campaignConfigResult;
    }

    private Humidifier.Personalize.CampaignTypes.CampaignConfig CreateCampaignConfig()
    {
        var campaignConfigResult = new Humidifier.Personalize.CampaignTypes.CampaignConfig();

        return campaignConfigResult;
    }

} // End Of Class

public static class InnerCampaignCampaignConfigFactoryExtensions
{
}
