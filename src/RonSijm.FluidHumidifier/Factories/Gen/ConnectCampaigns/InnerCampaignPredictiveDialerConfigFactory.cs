// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ConnectCampaigns;

public class InnerCampaignPredictiveDialerConfigFactory(Action<Humidifier.ConnectCampaigns.CampaignTypes.PredictiveDialerConfig> factoryAction = null) : SubResourceFactory<Humidifier.ConnectCampaigns.CampaignTypes.PredictiveDialerConfig>
{

    protected override Humidifier.ConnectCampaigns.CampaignTypes.PredictiveDialerConfig Create()
    {
        var predictiveDialerConfigResult = CreatePredictiveDialerConfig();
        factoryAction?.Invoke(predictiveDialerConfigResult);

        return predictiveDialerConfigResult;
    }

    private Humidifier.ConnectCampaigns.CampaignTypes.PredictiveDialerConfig CreatePredictiveDialerConfig()
    {
        var predictiveDialerConfigResult = new Humidifier.ConnectCampaigns.CampaignTypes.PredictiveDialerConfig();

        return predictiveDialerConfigResult;
    }

} // End Of Class

public static class InnerCampaignPredictiveDialerConfigFactoryExtensions
{
}
