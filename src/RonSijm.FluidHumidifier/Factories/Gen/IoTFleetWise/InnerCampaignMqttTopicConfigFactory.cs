// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetWise;

public class InnerCampaignMqttTopicConfigFactory(Action<Humidifier.IoTFleetWise.CampaignTypes.MqttTopicConfig> factoryAction = null) : SubResourceFactory<Humidifier.IoTFleetWise.CampaignTypes.MqttTopicConfig>
{

    protected override Humidifier.IoTFleetWise.CampaignTypes.MqttTopicConfig Create()
    {
        var mqttTopicConfigResult = CreateMqttTopicConfig();
        factoryAction?.Invoke(mqttTopicConfigResult);

        return mqttTopicConfigResult;
    }

    private Humidifier.IoTFleetWise.CampaignTypes.MqttTopicConfig CreateMqttTopicConfig()
    {
        var mqttTopicConfigResult = new Humidifier.IoTFleetWise.CampaignTypes.MqttTopicConfig();

        return mqttTopicConfigResult;
    }

} // End Of Class

public static class InnerCampaignMqttTopicConfigFactoryExtensions
{
}
