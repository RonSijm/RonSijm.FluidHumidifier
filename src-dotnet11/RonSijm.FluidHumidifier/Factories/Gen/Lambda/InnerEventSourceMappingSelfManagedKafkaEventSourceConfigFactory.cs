// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerEventSourceMappingSelfManagedKafkaEventSourceConfigFactory(Action<Humidifier.Lambda.EventSourceMappingTypes.SelfManagedKafkaEventSourceConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.EventSourceMappingTypes.SelfManagedKafkaEventSourceConfig>
{

    internal InnerEventSourceMappingSchemaRegistryConfigFactory SchemaRegistryConfigFactory { get; set; }

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
    public override void CreateChildren(Humidifier.Lambda.EventSourceMappingTypes.SelfManagedKafkaEventSourceConfig result)
    {
        base.CreateChildren(result);

        result.SchemaRegistryConfig ??= SchemaRegistryConfigFactory?.Build();
    }

} // End Of Class

public static class InnerEventSourceMappingSelfManagedKafkaEventSourceConfigFactoryExtensions
{
    public static CombinedResult<InnerEventSourceMappingSelfManagedKafkaEventSourceConfigFactory, InnerEventSourceMappingSchemaRegistryConfigFactory> WithSchemaRegistryConfig(this InnerEventSourceMappingSelfManagedKafkaEventSourceConfigFactory parentFactory, Action<Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryConfig> subFactoryAction = null)
    {
        parentFactory.SchemaRegistryConfigFactory = new InnerEventSourceMappingSchemaRegistryConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SchemaRegistryConfigFactory);
    }

    public static CombinedResult<InnerEventSourceMappingSelfManagedKafkaEventSourceConfigFactory, T1, InnerEventSourceMappingSchemaRegistryConfigFactory> WithSchemaRegistryConfig<T1>(this CombinedResult<InnerEventSourceMappingSelfManagedKafkaEventSourceConfigFactory, T1> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchemaRegistryConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEventSourceMappingSelfManagedKafkaEventSourceConfigFactory, InnerEventSourceMappingSchemaRegistryConfigFactory> WithSchemaRegistryConfig<T1>(this CombinedResult<T1, InnerEventSourceMappingSelfManagedKafkaEventSourceConfigFactory> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchemaRegistryConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerEventSourceMappingSelfManagedKafkaEventSourceConfigFactory, T1, T2, InnerEventSourceMappingSchemaRegistryConfigFactory> WithSchemaRegistryConfig<T1, T2>(this CombinedResult<InnerEventSourceMappingSelfManagedKafkaEventSourceConfigFactory, T1, T2> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchemaRegistryConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEventSourceMappingSelfManagedKafkaEventSourceConfigFactory, T2, InnerEventSourceMappingSchemaRegistryConfigFactory> WithSchemaRegistryConfig<T1, T2>(this CombinedResult<T1, InnerEventSourceMappingSelfManagedKafkaEventSourceConfigFactory, T2> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchemaRegistryConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEventSourceMappingSelfManagedKafkaEventSourceConfigFactory, InnerEventSourceMappingSchemaRegistryConfigFactory> WithSchemaRegistryConfig<T1, T2>(this CombinedResult<T1, T2, InnerEventSourceMappingSelfManagedKafkaEventSourceConfigFactory> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchemaRegistryConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerEventSourceMappingSelfManagedKafkaEventSourceConfigFactory, T1, T2, T3, InnerEventSourceMappingSchemaRegistryConfigFactory> WithSchemaRegistryConfig<T1, T2, T3>(this CombinedResult<InnerEventSourceMappingSelfManagedKafkaEventSourceConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaRegistryConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEventSourceMappingSelfManagedKafkaEventSourceConfigFactory, T2, T3, InnerEventSourceMappingSchemaRegistryConfigFactory> WithSchemaRegistryConfig<T1, T2, T3>(this CombinedResult<T1, InnerEventSourceMappingSelfManagedKafkaEventSourceConfigFactory, T2, T3> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaRegistryConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEventSourceMappingSelfManagedKafkaEventSourceConfigFactory, T3, InnerEventSourceMappingSchemaRegistryConfigFactory> WithSchemaRegistryConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerEventSourceMappingSelfManagedKafkaEventSourceConfigFactory, T3> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaRegistryConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEventSourceMappingSelfManagedKafkaEventSourceConfigFactory, InnerEventSourceMappingSchemaRegistryConfigFactory> WithSchemaRegistryConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEventSourceMappingSelfManagedKafkaEventSourceConfigFactory> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaRegistryConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerEventSourceMappingSelfManagedKafkaEventSourceConfigFactory, T1, T2, T3, T4, InnerEventSourceMappingSchemaRegistryConfigFactory> WithSchemaRegistryConfig<T1, T2, T3, T4>(this CombinedResult<InnerEventSourceMappingSelfManagedKafkaEventSourceConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaRegistryConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEventSourceMappingSelfManagedKafkaEventSourceConfigFactory, T2, T3, T4, InnerEventSourceMappingSchemaRegistryConfigFactory> WithSchemaRegistryConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerEventSourceMappingSelfManagedKafkaEventSourceConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaRegistryConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEventSourceMappingSelfManagedKafkaEventSourceConfigFactory, T3, T4, InnerEventSourceMappingSchemaRegistryConfigFactory> WithSchemaRegistryConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEventSourceMappingSelfManagedKafkaEventSourceConfigFactory, T3, T4> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaRegistryConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEventSourceMappingSelfManagedKafkaEventSourceConfigFactory, T4, InnerEventSourceMappingSchemaRegistryConfigFactory> WithSchemaRegistryConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEventSourceMappingSelfManagedKafkaEventSourceConfigFactory, T4> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaRegistryConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerEventSourceMappingSelfManagedKafkaEventSourceConfigFactory, InnerEventSourceMappingSchemaRegistryConfigFactory> WithSchemaRegistryConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEventSourceMappingSelfManagedKafkaEventSourceConfigFactory> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaRegistryConfig(combinedResult.T5, subFactoryAction).T2);
}
