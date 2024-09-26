// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetWise;

public class InnerCampaignTimeBasedSignalFetchConfigFactory(Action<Humidifier.IoTFleetWise.CampaignTypes.TimeBasedSignalFetchConfig> factoryAction = null) : SubResourceFactory<Humidifier.IoTFleetWise.CampaignTypes.TimeBasedSignalFetchConfig>
{

    protected override Humidifier.IoTFleetWise.CampaignTypes.TimeBasedSignalFetchConfig Create()
    {
        var timeBasedSignalFetchConfigResult = CreateTimeBasedSignalFetchConfig();
        factoryAction?.Invoke(timeBasedSignalFetchConfigResult);

        return timeBasedSignalFetchConfigResult;
    }

    private Humidifier.IoTFleetWise.CampaignTypes.TimeBasedSignalFetchConfig CreateTimeBasedSignalFetchConfig()
    {
        var timeBasedSignalFetchConfigResult = new Humidifier.IoTFleetWise.CampaignTypes.TimeBasedSignalFetchConfig();

        return timeBasedSignalFetchConfigResult;
    }

} // End Of Class

public static class InnerCampaignTimeBasedSignalFetchConfigFactoryExtensions
{
}
