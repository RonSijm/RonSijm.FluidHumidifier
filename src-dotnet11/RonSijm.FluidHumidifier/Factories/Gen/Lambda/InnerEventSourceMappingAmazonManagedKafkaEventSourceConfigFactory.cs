// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerEventSourceMappingAmazonManagedKafkaEventSourceConfigFactory(Action<Humidifier.Lambda.EventSourceMappingTypes.AmazonManagedKafkaEventSourceConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.EventSourceMappingTypes.AmazonManagedKafkaEventSourceConfig>
{

    internal InnerEventSourceMappingSchemaRegistryConfigFactory SchemaRegistryConfigFactory { get; set; }

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
    public override void CreateChildren(Humidifier.Lambda.EventSourceMappingTypes.AmazonManagedKafkaEventSourceConfig result)
    {
        base.CreateChildren(result);

        result.SchemaRegistryConfig ??= SchemaRegistryConfigFactory?.Build();
    }

} // End Of Class

public static class InnerEventSourceMappingAmazonManagedKafkaEventSourceConfigFactoryExtensions
{
    public static CombinedResult<InnerEventSourceMappingAmazonManagedKafkaEventSourceConfigFactory, InnerEventSourceMappingSchemaRegistryConfigFactory> WithSchemaRegistryConfig(this InnerEventSourceMappingAmazonManagedKafkaEventSourceConfigFactory parentFactory, Action<Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryConfig> subFactoryAction = null)
    {
        parentFactory.SchemaRegistryConfigFactory = new InnerEventSourceMappingSchemaRegistryConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SchemaRegistryConfigFactory);
    }

    public static CombinedResult<InnerEventSourceMappingAmazonManagedKafkaEventSourceConfigFactory, T1, InnerEventSourceMappingSchemaRegistryConfigFactory> WithSchemaRegistryConfig<T1>(this CombinedResult<InnerEventSourceMappingAmazonManagedKafkaEventSourceConfigFactory, T1> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchemaRegistryConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEventSourceMappingAmazonManagedKafkaEventSourceConfigFactory, InnerEventSourceMappingSchemaRegistryConfigFactory> WithSchemaRegistryConfig<T1>(this CombinedResult<T1, InnerEventSourceMappingAmazonManagedKafkaEventSourceConfigFactory> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchemaRegistryConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerEventSourceMappingAmazonManagedKafkaEventSourceConfigFactory, T1, T2, InnerEventSourceMappingSchemaRegistryConfigFactory> WithSchemaRegistryConfig<T1, T2>(this CombinedResult<InnerEventSourceMappingAmazonManagedKafkaEventSourceConfigFactory, T1, T2> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchemaRegistryConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEventSourceMappingAmazonManagedKafkaEventSourceConfigFactory, T2, InnerEventSourceMappingSchemaRegistryConfigFactory> WithSchemaRegistryConfig<T1, T2>(this CombinedResult<T1, InnerEventSourceMappingAmazonManagedKafkaEventSourceConfigFactory, T2> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchemaRegistryConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEventSourceMappingAmazonManagedKafkaEventSourceConfigFactory, InnerEventSourceMappingSchemaRegistryConfigFactory> WithSchemaRegistryConfig<T1, T2>(this CombinedResult<T1, T2, InnerEventSourceMappingAmazonManagedKafkaEventSourceConfigFactory> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchemaRegistryConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerEventSourceMappingAmazonManagedKafkaEventSourceConfigFactory, T1, T2, T3, InnerEventSourceMappingSchemaRegistryConfigFactory> WithSchemaRegistryConfig<T1, T2, T3>(this CombinedResult<InnerEventSourceMappingAmazonManagedKafkaEventSourceConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaRegistryConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEventSourceMappingAmazonManagedKafkaEventSourceConfigFactory, T2, T3, InnerEventSourceMappingSchemaRegistryConfigFactory> WithSchemaRegistryConfig<T1, T2, T3>(this CombinedResult<T1, InnerEventSourceMappingAmazonManagedKafkaEventSourceConfigFactory, T2, T3> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaRegistryConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEventSourceMappingAmazonManagedKafkaEventSourceConfigFactory, T3, InnerEventSourceMappingSchemaRegistryConfigFactory> WithSchemaRegistryConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerEventSourceMappingAmazonManagedKafkaEventSourceConfigFactory, T3> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaRegistryConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEventSourceMappingAmazonManagedKafkaEventSourceConfigFactory, InnerEventSourceMappingSchemaRegistryConfigFactory> WithSchemaRegistryConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEventSourceMappingAmazonManagedKafkaEventSourceConfigFactory> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaRegistryConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerEventSourceMappingAmazonManagedKafkaEventSourceConfigFactory, T1, T2, T3, T4, InnerEventSourceMappingSchemaRegistryConfigFactory> WithSchemaRegistryConfig<T1, T2, T3, T4>(this CombinedResult<InnerEventSourceMappingAmazonManagedKafkaEventSourceConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaRegistryConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEventSourceMappingAmazonManagedKafkaEventSourceConfigFactory, T2, T3, T4, InnerEventSourceMappingSchemaRegistryConfigFactory> WithSchemaRegistryConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerEventSourceMappingAmazonManagedKafkaEventSourceConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaRegistryConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEventSourceMappingAmazonManagedKafkaEventSourceConfigFactory, T3, T4, InnerEventSourceMappingSchemaRegistryConfigFactory> WithSchemaRegistryConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEventSourceMappingAmazonManagedKafkaEventSourceConfigFactory, T3, T4> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaRegistryConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEventSourceMappingAmazonManagedKafkaEventSourceConfigFactory, T4, InnerEventSourceMappingSchemaRegistryConfigFactory> WithSchemaRegistryConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEventSourceMappingAmazonManagedKafkaEventSourceConfigFactory, T4> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaRegistryConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerEventSourceMappingAmazonManagedKafkaEventSourceConfigFactory, InnerEventSourceMappingSchemaRegistryConfigFactory> WithSchemaRegistryConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEventSourceMappingAmazonManagedKafkaEventSourceConfigFactory> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaRegistryConfig(combinedResult.T5, subFactoryAction).T2);
}
