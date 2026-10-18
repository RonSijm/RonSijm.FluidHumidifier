// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ConnectCampaignsV2;

public class InnerCampaignRestrictedPeriodsFactory(Action<Humidifier.ConnectCampaignsV2.CampaignTypes.RestrictedPeriods> factoryAction = null) : SubResourceFactory<Humidifier.ConnectCampaignsV2.CampaignTypes.RestrictedPeriods>
{

    protected override Humidifier.ConnectCampaignsV2.CampaignTypes.RestrictedPeriods Create()
    {
        var restrictedPeriodsResult = CreateRestrictedPeriods();
        factoryAction?.Invoke(restrictedPeriodsResult);

        return restrictedPeriodsResult;
    }

    private Humidifier.ConnectCampaignsV2.CampaignTypes.RestrictedPeriods CreateRestrictedPeriods()
    {
        var restrictedPeriodsResult = new Humidifier.ConnectCampaignsV2.CampaignTypes.RestrictedPeriods();

        return restrictedPeriodsResult;
    }

} // End Of Class

public static class InnerCampaignRestrictedPeriodsFactoryExtensions
{
}
