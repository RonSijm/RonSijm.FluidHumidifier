// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class InnerCampaignCampaignEmailMessageFactory(Action<Humidifier.Pinpoint.CampaignTypes.CampaignEmailMessage> factoryAction = null) : SubResourceFactory<Humidifier.Pinpoint.CampaignTypes.CampaignEmailMessage>
{

    protected override Humidifier.Pinpoint.CampaignTypes.CampaignEmailMessage Create()
    {
        var campaignEmailMessageResult = CreateCampaignEmailMessage();
        factoryAction?.Invoke(campaignEmailMessageResult);

        return campaignEmailMessageResult;
    }

    private Humidifier.Pinpoint.CampaignTypes.CampaignEmailMessage CreateCampaignEmailMessage()
    {
        var campaignEmailMessageResult = new Humidifier.Pinpoint.CampaignTypes.CampaignEmailMessage();

        return campaignEmailMessageResult;
    }

} // End Of Class

public static class InnerCampaignCampaignEmailMessageFactoryExtensions
{
}
