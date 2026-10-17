// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ConnectCampaignsV2;

public class InnerCampaignTimeoutConfigFactory(Action<Humidifier.ConnectCampaignsV2.CampaignTypes.TimeoutConfig> factoryAction = null) : SubResourceFactory<Humidifier.ConnectCampaignsV2.CampaignTypes.TimeoutConfig>
{

    protected override Humidifier.ConnectCampaignsV2.CampaignTypes.TimeoutConfig Create()
    {
        var timeoutConfigResult = CreateTimeoutConfig();
        factoryAction?.Invoke(timeoutConfigResult);

        return timeoutConfigResult;
    }

    private Humidifier.ConnectCampaignsV2.CampaignTypes.TimeoutConfig CreateTimeoutConfig()
    {
        var timeoutConfigResult = new Humidifier.ConnectCampaignsV2.CampaignTypes.TimeoutConfig();

        return timeoutConfigResult;
    }

} // End Of Class

public static class InnerCampaignTimeoutConfigFactoryExtensions
{
}
