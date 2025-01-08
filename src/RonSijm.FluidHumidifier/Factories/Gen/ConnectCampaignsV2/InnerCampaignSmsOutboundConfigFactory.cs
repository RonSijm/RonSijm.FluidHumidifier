// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ConnectCampaignsV2;

public class InnerCampaignSmsOutboundConfigFactory(Action<Humidifier.ConnectCampaignsV2.CampaignTypes.SmsOutboundConfig> factoryAction = null) : SubResourceFactory<Humidifier.ConnectCampaignsV2.CampaignTypes.SmsOutboundConfig>
{

    protected override Humidifier.ConnectCampaignsV2.CampaignTypes.SmsOutboundConfig Create()
    {
        var smsOutboundConfigResult = CreateSmsOutboundConfig();
        factoryAction?.Invoke(smsOutboundConfigResult);

        return smsOutboundConfigResult;
    }

    private Humidifier.ConnectCampaignsV2.CampaignTypes.SmsOutboundConfig CreateSmsOutboundConfig()
    {
        var smsOutboundConfigResult = new Humidifier.ConnectCampaignsV2.CampaignTypes.SmsOutboundConfig();

        return smsOutboundConfigResult;
    }

} // End Of Class

public static class InnerCampaignSmsOutboundConfigFactoryExtensions
{
}
