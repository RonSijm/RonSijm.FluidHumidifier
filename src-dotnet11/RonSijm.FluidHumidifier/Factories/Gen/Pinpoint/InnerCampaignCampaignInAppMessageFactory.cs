// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class InnerCampaignCampaignInAppMessageFactory(Action<Humidifier.Pinpoint.CampaignTypes.CampaignInAppMessage> factoryAction = null) : SubResourceFactory<Humidifier.Pinpoint.CampaignTypes.CampaignInAppMessage>
{

    protected override Humidifier.Pinpoint.CampaignTypes.CampaignInAppMessage Create()
    {
        var campaignInAppMessageResult = CreateCampaignInAppMessage();
        factoryAction?.Invoke(campaignInAppMessageResult);

        return campaignInAppMessageResult;
    }

    private Humidifier.Pinpoint.CampaignTypes.CampaignInAppMessage CreateCampaignInAppMessage()
    {
        var campaignInAppMessageResult = new Humidifier.Pinpoint.CampaignTypes.CampaignInAppMessage();

        return campaignInAppMessageResult;
    }

} // End Of Class

public static class InnerCampaignCampaignInAppMessageFactoryExtensions
{
}
