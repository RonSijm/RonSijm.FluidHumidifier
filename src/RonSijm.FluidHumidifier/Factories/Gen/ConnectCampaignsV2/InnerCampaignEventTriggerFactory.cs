// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ConnectCampaignsV2;

public class InnerCampaignEventTriggerFactory(Action<Humidifier.ConnectCampaignsV2.CampaignTypes.EventTrigger> factoryAction = null) : SubResourceFactory<Humidifier.ConnectCampaignsV2.CampaignTypes.EventTrigger>
{

    protected override Humidifier.ConnectCampaignsV2.CampaignTypes.EventTrigger Create()
    {
        var eventTriggerResult = CreateEventTrigger();
        factoryAction?.Invoke(eventTriggerResult);

        return eventTriggerResult;
    }

    private Humidifier.ConnectCampaignsV2.CampaignTypes.EventTrigger CreateEventTrigger()
    {
        var eventTriggerResult = new Humidifier.ConnectCampaignsV2.CampaignTypes.EventTrigger();

        return eventTriggerResult;
    }

} // End Of Class

public static class InnerCampaignEventTriggerFactoryExtensions
{
}
