// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ConnectCampaignsV2;

public class InnerCampaignWhatsAppOutboundConfigFactory(Action<Humidifier.ConnectCampaignsV2.CampaignTypes.WhatsAppOutboundConfig> factoryAction = null) : SubResourceFactory<Humidifier.ConnectCampaignsV2.CampaignTypes.WhatsAppOutboundConfig>
{

    protected override Humidifier.ConnectCampaignsV2.CampaignTypes.WhatsAppOutboundConfig Create()
    {
        var whatsAppOutboundConfigResult = CreateWhatsAppOutboundConfig();
        factoryAction?.Invoke(whatsAppOutboundConfigResult);

        return whatsAppOutboundConfigResult;
    }

    private Humidifier.ConnectCampaignsV2.CampaignTypes.WhatsAppOutboundConfig CreateWhatsAppOutboundConfig()
    {
        var whatsAppOutboundConfigResult = new Humidifier.ConnectCampaignsV2.CampaignTypes.WhatsAppOutboundConfig();

        return whatsAppOutboundConfigResult;
    }

} // End Of Class

public static class InnerCampaignWhatsAppOutboundConfigFactoryExtensions
{
}
