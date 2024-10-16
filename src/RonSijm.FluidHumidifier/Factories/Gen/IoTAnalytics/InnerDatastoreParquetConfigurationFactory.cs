// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class InnerDatastoreParquetConfigurationFactory(Action<Humidifier.IoTAnalytics.DatastoreTypes.ParquetConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IoTAnalytics.DatastoreTypes.ParquetConfiguration>
{

    internal InnerDatastoreSchemaDefinitionFactory SchemaDefinitionFactory { get; set; }

    protected override Humidifier.IoTAnalytics.DatastoreTypes.ParquetConfiguration Create()
    {
        var parquetConfigurationResult = CreateParquetConfiguration();
        factoryAction?.Invoke(parquetConfigurationResult);

        return parquetConfigurationResult;
    }

    private Humidifier.IoTAnalytics.DatastoreTypes.ParquetConfiguration CreateParquetConfiguration()
    {
        var parquetConfigurationResult = new Humidifier.IoTAnalytics.DatastoreTypes.ParquetConfiguration();

        return parquetConfigurationResult;
    }
    public override void CreateChildren(Humidifier.IoTAnalytics.DatastoreTypes.ParquetConfiguration result)
    {
        base.CreateChildren(result);

        result.SchemaDefinition ??= SchemaDefinitionFactory?.Build();
    }

} // End Of Class

public static class InnerDatastoreParquetConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDatastoreParquetConfigurationFactory, InnerDatastoreSchemaDefinitionFactory> WithSchemaDefinition(this InnerDatastoreParquetConfigurationFactory parentFactory, Action<Humidifier.IoTAnalytics.DatastoreTypes.SchemaDefinition> subFactoryAction = null)
    {
        parentFactory.SchemaDefinitionFactory = new InnerDatastoreSchemaDefinitionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SchemaDefinitionFactory);
    }

    public static CombinedResult<InnerDatastoreParquetConfigurationFactory, T1, InnerDatastoreSchemaDefinitionFactory> WithSchemaDefinition<T1>(this CombinedResult<InnerDatastoreParquetConfigurationFactory, T1> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.SchemaDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchemaDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatastoreParquetConfigurationFactory, InnerDatastoreSchemaDefinitionFactory> WithSchemaDefinition<T1>(this CombinedResult<T1, InnerDatastoreParquetConfigurationFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.SchemaDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchemaDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDatastoreParquetConfigurationFactory, T1, T2, InnerDatastoreSchemaDefinitionFactory> WithSchemaDefinition<T1, T2>(this CombinedResult<InnerDatastoreParquetConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.SchemaDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchemaDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatastoreParquetConfigurationFactory, T2, InnerDatastoreSchemaDefinitionFactory> WithSchemaDefinition<T1, T2>(this CombinedResult<T1, InnerDatastoreParquetConfigurationFactory, T2> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.SchemaDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchemaDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatastoreParquetConfigurationFactory, InnerDatastoreSchemaDefinitionFactory> WithSchemaDefinition<T1, T2>(this CombinedResult<T1, T2, InnerDatastoreParquetConfigurationFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.SchemaDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchemaDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDatastoreParquetConfigurationFactory, T1, T2, T3, InnerDatastoreSchemaDefinitionFactory> WithSchemaDefinition<T1, T2, T3>(this CombinedResult<InnerDatastoreParquetConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.SchemaDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatastoreParquetConfigurationFactory, T2, T3, InnerDatastoreSchemaDefinitionFactory> WithSchemaDefinition<T1, T2, T3>(this CombinedResult<T1, InnerDatastoreParquetConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.SchemaDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatastoreParquetConfigurationFactory, T3, InnerDatastoreSchemaDefinitionFactory> WithSchemaDefinition<T1, T2, T3>(this CombinedResult<T1, T2, InnerDatastoreParquetConfigurationFactory, T3> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.SchemaDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatastoreParquetConfigurationFactory, InnerDatastoreSchemaDefinitionFactory> WithSchemaDefinition<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDatastoreParquetConfigurationFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.SchemaDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaDefinition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDatastoreParquetConfigurationFactory, T1, T2, T3, T4, InnerDatastoreSchemaDefinitionFactory> WithSchemaDefinition<T1, T2, T3, T4>(this CombinedResult<InnerDatastoreParquetConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.SchemaDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatastoreParquetConfigurationFactory, T2, T3, T4, InnerDatastoreSchemaDefinitionFactory> WithSchemaDefinition<T1, T2, T3, T4>(this CombinedResult<T1, InnerDatastoreParquetConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.SchemaDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatastoreParquetConfigurationFactory, T3, T4, InnerDatastoreSchemaDefinitionFactory> WithSchemaDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDatastoreParquetConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.SchemaDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatastoreParquetConfigurationFactory, T4, InnerDatastoreSchemaDefinitionFactory> WithSchemaDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDatastoreParquetConfigurationFactory, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.SchemaDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaDefinition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDatastoreParquetConfigurationFactory, InnerDatastoreSchemaDefinitionFactory> WithSchemaDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDatastoreParquetConfigurationFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatastoreTypes.SchemaDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaDefinition(combinedResult.T5, subFactoryAction));
}
