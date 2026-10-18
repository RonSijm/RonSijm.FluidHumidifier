// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetWise;

public class InnerCampaignTimestreamConfigFactory(Action<Humidifier.IoTFleetWise.CampaignTypes.TimestreamConfig> factoryAction = null) : SubResourceFactory<Humidifier.IoTFleetWise.CampaignTypes.TimestreamConfig>
{

    protected override Humidifier.IoTFleetWise.CampaignTypes.TimestreamConfig Create()
    {
        var timestreamConfigResult = CreateTimestreamConfig();
        factoryAction?.Invoke(timestreamConfigResult);

        return timestreamConfigResult;
    }

    private Humidifier.IoTFleetWise.CampaignTypes.TimestreamConfig CreateTimestreamConfig()
    {
        var timestreamConfigResult = new Humidifier.IoTFleetWise.CampaignTypes.TimestreamConfig();

        return timestreamConfigResult;
    }

} // End Of Class

public static class InnerCampaignTimestreamConfigFactoryExtensions
{
}
