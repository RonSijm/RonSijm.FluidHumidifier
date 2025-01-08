// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ConnectCampaignsV2;

public class InnerCampaignPredictiveConfigFactory(Action<Humidifier.ConnectCampaignsV2.CampaignTypes.PredictiveConfig> factoryAction = null) : SubResourceFactory<Humidifier.ConnectCampaignsV2.CampaignTypes.PredictiveConfig>
{

    protected override Humidifier.ConnectCampaignsV2.CampaignTypes.PredictiveConfig Create()
    {
        var predictiveConfigResult = CreatePredictiveConfig();
        factoryAction?.Invoke(predictiveConfigResult);

        return predictiveConfigResult;
    }

    private Humidifier.ConnectCampaignsV2.CampaignTypes.PredictiveConfig CreatePredictiveConfig()
    {
        var predictiveConfigResult = new Humidifier.ConnectCampaignsV2.CampaignTypes.PredictiveConfig();

        return predictiveConfigResult;
    }

} // End Of Class

public static class InnerCampaignPredictiveConfigFactoryExtensions
{
}
