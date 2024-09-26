// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerEventSourceMappingAmazonManagedKafkaEventSourceConfigFactory(Action<Humidifier.Lambda.EventSourceMappingTypes.AmazonManagedKafkaEventSourceConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.EventSourceMappingTypes.AmazonManagedKafkaEventSourceConfig>
{

    protected override Humidifier.Lambda.EventSourceMappingTypes.AmazonManagedKafkaEventSourceConfig Create()
    {
        var amazonManagedKafkaEventSourceConfigResult = CreateAmazonManagedKafkaEventSourceConfig();
        factoryAction?.Invoke(amazonManagedKafkaEventSourceConfigResult);

        return amazonManagedKafkaEventSourceConfigResult;
    }

    private Humidifier.Lambda.EventSourceMappingTypes.AmazonManagedKafkaEventSourceConfig CreateAmazonManagedKafkaEventSourceConfig()
    {
        var amazonManagedKafkaEventSourceConfigResult = new Humidifier.Lambda.EventSourceMappingTypes.AmazonManagedKafkaEventSourceConfig();

        return amazonManagedKafkaEventSourceConfigResult;
    }

} // End Of Class

public static class InnerEventSourceMappingAmazonManagedKafkaEventSourceConfigFactoryExtensions
{
}
