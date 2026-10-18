// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerTopicRuleDestinationInfluxDBDestinationPropertiesFactory(Action<Humidifier.IoT.TopicRuleDestinationTypes.InfluxDBDestinationProperties> factoryAction = null) : SubResourceFactory<Humidifier.IoT.TopicRuleDestinationTypes.InfluxDBDestinationProperties>
{

    protected override Humidifier.IoT.TopicRuleDestinationTypes.InfluxDBDestinationProperties Create()
    {
        var influxDBDestinationPropertiesResult = CreateInfluxDBDestinationProperties();
        factoryAction?.Invoke(influxDBDestinationPropertiesResult);

        return influxDBDestinationPropertiesResult;
    }

    private Humidifier.IoT.TopicRuleDestinationTypes.InfluxDBDestinationProperties CreateInfluxDBDestinationProperties()
    {
        var influxDBDestinationPropertiesResult = new Humidifier.IoT.TopicRuleDestinationTypes.InfluxDBDestinationProperties();

        return influxDBDestinationPropertiesResult;
    }

} // End Of Class

public static class InnerTopicRuleDestinationInfluxDBDestinationPropertiesFactoryExtensions
{
}
