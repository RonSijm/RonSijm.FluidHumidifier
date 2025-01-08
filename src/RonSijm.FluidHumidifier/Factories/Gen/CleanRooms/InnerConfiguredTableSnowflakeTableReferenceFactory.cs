// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerConfiguredTableSnowflakeTableReferenceFactory(Action<Humidifier.CleanRooms.ConfiguredTableTypes.SnowflakeTableReference> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.ConfiguredTableTypes.SnowflakeTableReference>
{

    internal InnerConfiguredTableSnowflakeTableSchemaFactory TableSchemaFactory { get; set; }

    protected override Humidifier.CleanRooms.ConfiguredTableTypes.SnowflakeTableReference Create()
    {
        var snowflakeTableReferenceResult = CreateSnowflakeTableReference();
        factoryAction?.Invoke(snowflakeTableReferenceResult);

        return snowflakeTableReferenceResult;
    }

    private Humidifier.CleanRooms.ConfiguredTableTypes.SnowflakeTableReference CreateSnowflakeTableReference()
    {
        var snowflakeTableReferenceResult = new Humidifier.CleanRooms.ConfiguredTableTypes.SnowflakeTableReference();

        return snowflakeTableReferenceResult;
    }
    public override void CreateChildren(Humidifier.CleanRooms.ConfiguredTableTypes.SnowflakeTableReference result)
    {
        base.CreateChildren(result);

        result.TableSchema ??= TableSchemaFactory?.Build();
    }

} // End Of Class

public static class InnerConfiguredTableSnowflakeTableReferenceFactoryExtensions
{
    public static CombinedResult<InnerConfiguredTableSnowflakeTableReferenceFactory, InnerConfiguredTableSnowflakeTableSchemaFactory> WithTableSchema(this InnerConfiguredTableSnowflakeTableReferenceFactory parentFactory, Action<Humidifier.CleanRooms.ConfiguredTableTypes.SnowflakeTableSchema> subFactoryAction = null)
    {
        parentFactory.TableSchemaFactory = new InnerConfiguredTableSnowflakeTableSchemaFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TableSchemaFactory);
    }

    public static CombinedResult<InnerConfiguredTableSnowflakeTableReferenceFactory, T1, InnerConfiguredTableSnowflakeTableSchemaFactory> WithTableSchema<T1>(this CombinedResult<InnerConfiguredTableSnowflakeTableReferenceFactory, T1> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.SnowflakeTableSchema> subFactoryAction = null) => new (combinedResult, combinedResult, WithTableSchema(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfiguredTableSnowflakeTableReferenceFactory, InnerConfiguredTableSnowflakeTableSchemaFactory> WithTableSchema<T1>(this CombinedResult<T1, InnerConfiguredTableSnowflakeTableReferenceFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.SnowflakeTableSchema> subFactoryAction = null) => new (combinedResult, combinedResult, WithTableSchema(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConfiguredTableSnowflakeTableReferenceFactory, T1, T2, InnerConfiguredTableSnowflakeTableSchemaFactory> WithTableSchema<T1, T2>(this CombinedResult<InnerConfiguredTableSnowflakeTableReferenceFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.SnowflakeTableSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTableSchema(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfiguredTableSnowflakeTableReferenceFactory, T2, InnerConfiguredTableSnowflakeTableSchemaFactory> WithTableSchema<T1, T2>(this CombinedResult<T1, InnerConfiguredTableSnowflakeTableReferenceFactory, T2> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.SnowflakeTableSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTableSchema(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfiguredTableSnowflakeTableReferenceFactory, InnerConfiguredTableSnowflakeTableSchemaFactory> WithTableSchema<T1, T2>(this CombinedResult<T1, T2, InnerConfiguredTableSnowflakeTableReferenceFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.SnowflakeTableSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTableSchema(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConfiguredTableSnowflakeTableReferenceFactory, T1, T2, T3, InnerConfiguredTableSnowflakeTableSchemaFactory> WithTableSchema<T1, T2, T3>(this CombinedResult<InnerConfiguredTableSnowflakeTableReferenceFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.SnowflakeTableSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTableSchema(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfiguredTableSnowflakeTableReferenceFactory, T2, T3, InnerConfiguredTableSnowflakeTableSchemaFactory> WithTableSchema<T1, T2, T3>(this CombinedResult<T1, InnerConfiguredTableSnowflakeTableReferenceFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.SnowflakeTableSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTableSchema(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfiguredTableSnowflakeTableReferenceFactory, T3, InnerConfiguredTableSnowflakeTableSchemaFactory> WithTableSchema<T1, T2, T3>(this CombinedResult<T1, T2, InnerConfiguredTableSnowflakeTableReferenceFactory, T3> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.SnowflakeTableSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTableSchema(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConfiguredTableSnowflakeTableReferenceFactory, InnerConfiguredTableSnowflakeTableSchemaFactory> WithTableSchema<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConfiguredTableSnowflakeTableReferenceFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.SnowflakeTableSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTableSchema(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConfiguredTableSnowflakeTableReferenceFactory, T1, T2, T3, T4, InnerConfiguredTableSnowflakeTableSchemaFactory> WithTableSchema<T1, T2, T3, T4>(this CombinedResult<InnerConfiguredTableSnowflakeTableReferenceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.SnowflakeTableSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTableSchema(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfiguredTableSnowflakeTableReferenceFactory, T2, T3, T4, InnerConfiguredTableSnowflakeTableSchemaFactory> WithTableSchema<T1, T2, T3, T4>(this CombinedResult<T1, InnerConfiguredTableSnowflakeTableReferenceFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.SnowflakeTableSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTableSchema(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfiguredTableSnowflakeTableReferenceFactory, T3, T4, InnerConfiguredTableSnowflakeTableSchemaFactory> WithTableSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConfiguredTableSnowflakeTableReferenceFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.SnowflakeTableSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTableSchema(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConfiguredTableSnowflakeTableReferenceFactory, T4, InnerConfiguredTableSnowflakeTableSchemaFactory> WithTableSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConfiguredTableSnowflakeTableReferenceFactory, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.SnowflakeTableSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTableSchema(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConfiguredTableSnowflakeTableReferenceFactory, InnerConfiguredTableSnowflakeTableSchemaFactory> WithTableSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConfiguredTableSnowflakeTableReferenceFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.SnowflakeTableSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTableSchema(combinedResult.T5, subFactoryAction));
}
