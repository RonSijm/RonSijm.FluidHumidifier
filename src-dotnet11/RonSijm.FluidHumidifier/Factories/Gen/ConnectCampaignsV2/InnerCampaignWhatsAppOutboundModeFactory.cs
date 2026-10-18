// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ConnectCampaignsV2;

public class InnerCampaignWhatsAppOutboundModeFactory(Action<Humidifier.ConnectCampaignsV2.CampaignTypes.WhatsAppOutboundMode> factoryAction = null) : SubResourceFactory<Humidifier.ConnectCampaignsV2.CampaignTypes.WhatsAppOutboundMode>
{

    protected override Humidifier.ConnectCampaignsV2.CampaignTypes.WhatsAppOutboundMode Create()
    {
        var whatsAppOutboundModeResult = CreateWhatsAppOutboundMode();
        factoryAction?.Invoke(whatsAppOutboundModeResult);

        return whatsAppOutboundModeResult;
    }

    private Humidifier.ConnectCampaignsV2.CampaignTypes.WhatsAppOutboundMode CreateWhatsAppOutboundMode()
    {
        var whatsAppOutboundModeResult = new Humidifier.ConnectCampaignsV2.CampaignTypes.WhatsAppOutboundMode();

        return whatsAppOutboundModeResult;
    }

} // End Of Class

public static class InnerCampaignWhatsAppOutboundModeFactoryExtensions
{
}
