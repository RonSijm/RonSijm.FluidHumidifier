// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ConnectCampaignsV2;

public class InnerCampaignScheduleFactory(Action<Humidifier.ConnectCampaignsV2.CampaignTypes.Schedule> factoryAction = null) : SubResourceFactory<Humidifier.ConnectCampaignsV2.CampaignTypes.Schedule>
{

    protected override Humidifier.ConnectCampaignsV2.CampaignTypes.Schedule Create()
    {
        var scheduleResult = CreateSchedule();
        factoryAction?.Invoke(scheduleResult);

        return scheduleResult;
    }

    private Humidifier.ConnectCampaignsV2.CampaignTypes.Schedule CreateSchedule()
    {
        var scheduleResult = new Humidifier.ConnectCampaignsV2.CampaignTypes.Schedule();

        return scheduleResult;
    }

} // End Of Class

public static class InnerCampaignScheduleFactoryExtensions
{
}
