// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class InnerCampaignCampaignSmsMessageFactory(Action<Humidifier.Pinpoint.CampaignTypes.CampaignSmsMessage> factoryAction = null) : SubResourceFactory<Humidifier.Pinpoint.CampaignTypes.CampaignSmsMessage>
{

    protected override Humidifier.Pinpoint.CampaignTypes.CampaignSmsMessage Create()
    {
        var campaignSmsMessageResult = CreateCampaignSmsMessage();
        factoryAction?.Invoke(campaignSmsMessageResult);

        return campaignSmsMessageResult;
    }

    private Humidifier.Pinpoint.CampaignTypes.CampaignSmsMessage CreateCampaignSmsMessage()
    {
        var campaignSmsMessageResult = new Humidifier.Pinpoint.CampaignTypes.CampaignSmsMessage();

        return campaignSmsMessageResult;
    }

} // End Of Class

public static class InnerCampaignCampaignSmsMessageFactoryExtensions
{
}
