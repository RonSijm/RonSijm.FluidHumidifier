// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class InnerApplicationSettingsCampaignHookFactory(Action<Humidifier.Pinpoint.ApplicationSettingsTypes.CampaignHook> factoryAction = null) : SubResourceFactory<Humidifier.Pinpoint.ApplicationSettingsTypes.CampaignHook>
{

    protected override Humidifier.Pinpoint.ApplicationSettingsTypes.CampaignHook Create()
    {
        var campaignHookResult = CreateCampaignHook();
        factoryAction?.Invoke(campaignHookResult);

        return campaignHookResult;
    }

    private Humidifier.Pinpoint.ApplicationSettingsTypes.CampaignHook CreateCampaignHook()
    {
        var campaignHookResult = new Humidifier.Pinpoint.ApplicationSettingsTypes.CampaignHook();

        return campaignHookResult;
    }

} // End Of Class

public static class InnerApplicationSettingsCampaignHookFactoryExtensions
{
}
