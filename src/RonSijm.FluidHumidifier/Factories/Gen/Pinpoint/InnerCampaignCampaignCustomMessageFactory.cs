// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class InnerCampaignCampaignCustomMessageFactory(Action<Humidifier.Pinpoint.CampaignTypes.CampaignCustomMessage> factoryAction = null) : SubResourceFactory<Humidifier.Pinpoint.CampaignTypes.CampaignCustomMessage>
{

    protected override Humidifier.Pinpoint.CampaignTypes.CampaignCustomMessage Create()
    {
        var campaignCustomMessageResult = CreateCampaignCustomMessage();
        factoryAction?.Invoke(campaignCustomMessageResult);

        return campaignCustomMessageResult;
    }

    private Humidifier.Pinpoint.CampaignTypes.CampaignCustomMessage CreateCampaignCustomMessage()
    {
        var campaignCustomMessageResult = new Humidifier.Pinpoint.CampaignTypes.CampaignCustomMessage();

        return campaignCustomMessageResult;
    }

} // End Of Class

public static class InnerCampaignCampaignCustomMessageFactoryExtensions
{
}
