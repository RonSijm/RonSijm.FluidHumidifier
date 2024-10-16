// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetWise;

public class InnerCampaignConditionBasedSignalFetchConfigFactory(Action<Humidifier.IoTFleetWise.CampaignTypes.ConditionBasedSignalFetchConfig> factoryAction = null) : SubResourceFactory<Humidifier.IoTFleetWise.CampaignTypes.ConditionBasedSignalFetchConfig>
{

    protected override Humidifier.IoTFleetWise.CampaignTypes.ConditionBasedSignalFetchConfig Create()
    {
        var conditionBasedSignalFetchConfigResult = CreateConditionBasedSignalFetchConfig();
        factoryAction?.Invoke(conditionBasedSignalFetchConfigResult);

        return conditionBasedSignalFetchConfigResult;
    }

    private Humidifier.IoTFleetWise.CampaignTypes.ConditionBasedSignalFetchConfig CreateConditionBasedSignalFetchConfig()
    {
        var conditionBasedSignalFetchConfigResult = new Humidifier.IoTFleetWise.CampaignTypes.ConditionBasedSignalFetchConfig();

        return conditionBasedSignalFetchConfigResult;
    }

} // End Of Class

public static class InnerCampaignConditionBasedSignalFetchConfigFactoryExtensions
{
}
