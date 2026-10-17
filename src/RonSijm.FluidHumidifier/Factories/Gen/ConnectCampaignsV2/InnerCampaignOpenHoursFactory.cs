// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ConnectCampaignsV2;

public class InnerCampaignOpenHoursFactory(Action<Humidifier.ConnectCampaignsV2.CampaignTypes.OpenHours> factoryAction = null) : SubResourceFactory<Humidifier.ConnectCampaignsV2.CampaignTypes.OpenHours>
{

    protected override Humidifier.ConnectCampaignsV2.CampaignTypes.OpenHours Create()
    {
        var openHoursResult = CreateOpenHours();
        factoryAction?.Invoke(openHoursResult);

        return openHoursResult;
    }

    private Humidifier.ConnectCampaignsV2.CampaignTypes.OpenHours CreateOpenHours()
    {
        var openHoursResult = new Humidifier.ConnectCampaignsV2.CampaignTypes.OpenHours();

        return openHoursResult;
    }

} // End Of Class

public static class InnerCampaignOpenHoursFactoryExtensions
{
}
