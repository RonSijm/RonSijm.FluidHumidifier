// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerEventSourceMappingSelfManagedKafkaEventSourceConfigFactory(Action<Humidifier.Lambda.EventSourceMappingTypes.SelfManagedKafkaEventSourceConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.EventSourceMappingTypes.SelfManagedKafkaEventSourceConfig>
{

    protected override Humidifier.Lambda.EventSourceMappingTypes.SelfManagedKafkaEventSourceConfig Create()
    {
        var selfManagedKafkaEventSourceConfigResult = CreateSelfManagedKafkaEventSourceConfig();
        factoryAction?.Invoke(selfManagedKafkaEventSourceConfigResult);

        return selfManagedKafkaEventSourceConfigResult;
    }

    private Humidifier.Lambda.EventSourceMappingTypes.SelfManagedKafkaEventSourceConfig CreateSelfManagedKafkaEventSourceConfig()
    {
        var selfManagedKafkaEventSourceConfigResult = new Humidifier.Lambda.EventSourceMappingTypes.SelfManagedKafkaEventSourceConfig();

        return selfManagedKafkaEventSourceConfigResult;
    }

} // End Of Class

public static class InnerEventSourceMappingSelfManagedKafkaEventSourceConfigFactoryExtensions
{
}
