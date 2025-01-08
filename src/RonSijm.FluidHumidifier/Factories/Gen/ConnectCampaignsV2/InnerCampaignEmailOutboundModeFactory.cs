// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ConnectCampaignsV2;

public class InnerCampaignEmailOutboundModeFactory(Action<Humidifier.ConnectCampaignsV2.CampaignTypes.EmailOutboundMode> factoryAction = null) : SubResourceFactory<Humidifier.ConnectCampaignsV2.CampaignTypes.EmailOutboundMode>
{

    protected override Humidifier.ConnectCampaignsV2.CampaignTypes.EmailOutboundMode Create()
    {
        var emailOutboundModeResult = CreateEmailOutboundMode();
        factoryAction?.Invoke(emailOutboundModeResult);

        return emailOutboundModeResult;
    }

    private Humidifier.ConnectCampaignsV2.CampaignTypes.EmailOutboundMode CreateEmailOutboundMode()
    {
        var emailOutboundModeResult = new Humidifier.ConnectCampaignsV2.CampaignTypes.EmailOutboundMode();

        return emailOutboundModeResult;
    }

} // End Of Class

public static class InnerCampaignEmailOutboundModeFactoryExtensions
{
}
