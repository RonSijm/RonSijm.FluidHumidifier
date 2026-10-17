// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ConnectCampaignsV2;

public class InnerCampaignLocalTimeZoneConfigFactory(Action<Humidifier.ConnectCampaignsV2.CampaignTypes.LocalTimeZoneConfig> factoryAction = null) : SubResourceFactory<Humidifier.ConnectCampaignsV2.CampaignTypes.LocalTimeZoneConfig>
{

    protected override Humidifier.ConnectCampaignsV2.CampaignTypes.LocalTimeZoneConfig Create()
    {
        var localTimeZoneConfigResult = CreateLocalTimeZoneConfig();
        factoryAction?.Invoke(localTimeZoneConfigResult);

        return localTimeZoneConfigResult;
    }

    private Humidifier.ConnectCampaignsV2.CampaignTypes.LocalTimeZoneConfig CreateLocalTimeZoneConfig()
    {
        var localTimeZoneConfigResult = new Humidifier.ConnectCampaignsV2.CampaignTypes.LocalTimeZoneConfig();

        return localTimeZoneConfigResult;
    }

} // End Of Class

public static class InnerCampaignLocalTimeZoneConfigFactoryExtensions
{
}
