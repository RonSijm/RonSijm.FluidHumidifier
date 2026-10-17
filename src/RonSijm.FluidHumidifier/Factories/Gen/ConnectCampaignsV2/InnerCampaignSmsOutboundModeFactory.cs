// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ConnectCampaignsV2;

public class InnerCampaignSmsOutboundModeFactory(Action<Humidifier.ConnectCampaignsV2.CampaignTypes.SmsOutboundMode> factoryAction = null) : SubResourceFactory<Humidifier.ConnectCampaignsV2.CampaignTypes.SmsOutboundMode>
{

    protected override Humidifier.ConnectCampaignsV2.CampaignTypes.SmsOutboundMode Create()
    {
        var smsOutboundModeResult = CreateSmsOutboundMode();
        factoryAction?.Invoke(smsOutboundModeResult);

        return smsOutboundModeResult;
    }

    private Humidifier.ConnectCampaignsV2.CampaignTypes.SmsOutboundMode CreateSmsOutboundMode()
    {
        var smsOutboundModeResult = new Humidifier.ConnectCampaignsV2.CampaignTypes.SmsOutboundMode();

        return smsOutboundModeResult;
    }

} // End Of Class

public static class InnerCampaignSmsOutboundModeFactoryExtensions
{
}
