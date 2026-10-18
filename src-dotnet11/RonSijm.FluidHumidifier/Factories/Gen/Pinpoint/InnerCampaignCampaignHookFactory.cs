// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class InnerCampaignCampaignHookFactory(Action<Humidifier.Pinpoint.CampaignTypes.CampaignHook> factoryAction = null) : SubResourceFactory<Humidifier.Pinpoint.CampaignTypes.CampaignHook>
{

    protected override Humidifier.Pinpoint.CampaignTypes.CampaignHook Create()
    {
        var campaignHookResult = CreateCampaignHook();
        factoryAction?.Invoke(campaignHookResult);

        return campaignHookResult;
    }

    private Humidifier.Pinpoint.CampaignTypes.CampaignHook CreateCampaignHook()
    {
        var campaignHookResult = new Humidifier.Pinpoint.CampaignTypes.CampaignHook();

        return campaignHookResult;
    }

} // End Of Class

public static class InnerCampaignCampaignHookFactoryExtensions
{
}
