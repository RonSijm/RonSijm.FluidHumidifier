// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ConnectCampaignsV2;

public class InnerCampaignEmailOutboundConfigFactory(Action<Humidifier.ConnectCampaignsV2.CampaignTypes.EmailOutboundConfig> factoryAction = null) : SubResourceFactory<Humidifier.ConnectCampaignsV2.CampaignTypes.EmailOutboundConfig>
{

    protected override Humidifier.ConnectCampaignsV2.CampaignTypes.EmailOutboundConfig Create()
    {
        var emailOutboundConfigResult = CreateEmailOutboundConfig();
        factoryAction?.Invoke(emailOutboundConfigResult);

        return emailOutboundConfigResult;
    }

    private Humidifier.ConnectCampaignsV2.CampaignTypes.EmailOutboundConfig CreateEmailOutboundConfig()
    {
        var emailOutboundConfigResult = new Humidifier.ConnectCampaignsV2.CampaignTypes.EmailOutboundConfig();

        return emailOutboundConfigResult;
    }

} // End Of Class

public static class InnerCampaignEmailOutboundConfigFactoryExtensions
{
}
