// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class SchemaFactory(string resourceName = null, Action<Humidifier.Glue.Schema> factoryAction = null) : ResourceFactory<Humidifier.Glue.Schema>(resourceName)
{

    internal InnerSchemaRegistryFactory RegistryFactory { get; set; }

    internal InnerSchemaSchemaVersionFactory CheckpointVersionFactory { get; set; }

    protected override Humidifier.Glue.Schema Create()
    {
        var schemaResult = CreateSchema();
        factoryAction?.Invoke(schemaResult);

        return schemaResult;
    }

    private Humidifier.Glue.Schema CreateSchema()
    {
        var schemaResult = new Humidifier.Glue.Schema
        {
            GivenName = InputResourceName,
        };

        return schemaResult;
    }
    public override void CreateChildren(Humidifier.Glue.Schema result)
    {
        base.CreateChildren(result);

        result.Registry ??= RegistryFactory?.Build();
        result.CheckpointVersion ??= CheckpointVersionFactory?.Build();
    }

} // End Of Class

public static class SchemaFactoryExtensions
{
    public static CombinedResult<SchemaFactory, InnerSchemaRegistryFactory> WithRegistry(this SchemaFactory parentFactory, Action<Humidifier.Glue.SchemaTypes.Registry> subFactoryAction = null)
    {
        parentFactory.RegistryFactory = new InnerSchemaRegistryFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RegistryFactory);
    }

    public static CombinedResult<SchemaFactory, InnerSchemaSchemaVersionFactory> WithCheckpointVersion(this SchemaFactory parentFactory, Action<Humidifier.Glue.SchemaTypes.SchemaVersion> subFactoryAction = null)
    {
        parentFactory.CheckpointVersionFactory = new InnerSchemaSchemaVersionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CheckpointVersionFactory);
    }

    public static CombinedResult<SchemaFactory, T1, InnerSchemaRegistryFactory> WithRegistry<T1>(this CombinedResult<SchemaFactory, T1> combinedResult, Action<Humidifier.Glue.SchemaTypes.Registry> subFactoryAction = null) => new (combinedResult, combinedResult, WithRegistry(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SchemaFactory, InnerSchemaRegistryFactory> WithRegistry<T1>(this CombinedResult<T1, SchemaFactory> combinedResult, Action<Humidifier.Glue.SchemaTypes.Registry> subFactoryAction = null) => new (combinedResult, combinedResult, WithRegistry(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SchemaFactory, T1, T2, InnerSchemaRegistryFactory> WithRegistry<T1, T2>(this CombinedResult<SchemaFactory, T1, T2> combinedResult, Action<Humidifier.Glue.SchemaTypes.Registry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRegistry(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SchemaFactory, T2, InnerSchemaRegistryFactory> WithRegistry<T1, T2>(this CombinedResult<T1, SchemaFactory, T2> combinedResult, Action<Humidifier.Glue.SchemaTypes.Registry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRegistry(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SchemaFactory, InnerSchemaRegistryFactory> WithRegistry<T1, T2>(this CombinedResult<T1, T2, SchemaFactory> combinedResult, Action<Humidifier.Glue.SchemaTypes.Registry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRegistry(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SchemaFactory, T1, T2, T3, InnerSchemaRegistryFactory> WithRegistry<T1, T2, T3>(this CombinedResult<SchemaFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.SchemaTypes.Registry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRegistry(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SchemaFactory, T2, T3, InnerSchemaRegistryFactory> WithRegistry<T1, T2, T3>(this CombinedResult<T1, SchemaFactory, T2, T3> combinedResult, Action<Humidifier.Glue.SchemaTypes.Registry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRegistry(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SchemaFactory, T3, InnerSchemaRegistryFactory> WithRegistry<T1, T2, T3>(this CombinedResult<T1, T2, SchemaFactory, T3> combinedResult, Action<Humidifier.Glue.SchemaTypes.Registry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRegistry(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SchemaFactory, InnerSchemaRegistryFactory> WithRegistry<T1, T2, T3>(this CombinedResult<T1, T2, T3, SchemaFactory> combinedResult, Action<Humidifier.Glue.SchemaTypes.Registry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRegistry(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SchemaFactory, T1, T2, T3, T4, InnerSchemaRegistryFactory> WithRegistry<T1, T2, T3, T4>(this CombinedResult<SchemaFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.SchemaTypes.Registry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegistry(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SchemaFactory, T2, T3, T4, InnerSchemaRegistryFactory> WithRegistry<T1, T2, T3, T4>(this CombinedResult<T1, SchemaFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.SchemaTypes.Registry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegistry(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SchemaFactory, T3, T4, InnerSchemaRegistryFactory> WithRegistry<T1, T2, T3, T4>(this CombinedResult<T1, T2, SchemaFactory, T3, T4> combinedResult, Action<Humidifier.Glue.SchemaTypes.Registry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegistry(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SchemaFactory, T4, InnerSchemaRegistryFactory> WithRegistry<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SchemaFactory, T4> combinedResult, Action<Humidifier.Glue.SchemaTypes.Registry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegistry(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SchemaFactory, InnerSchemaRegistryFactory> WithRegistry<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SchemaFactory> combinedResult, Action<Humidifier.Glue.SchemaTypes.Registry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegistry(combinedResult.T5, subFactoryAction));
    public static CombinedResult<SchemaFactory, T1, InnerSchemaSchemaVersionFactory> WithCheckpointVersion<T1>(this CombinedResult<SchemaFactory, T1> combinedResult, Action<Humidifier.Glue.SchemaTypes.SchemaVersion> subFactoryAction = null) => new (combinedResult, combinedResult, WithCheckpointVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SchemaFactory, InnerSchemaSchemaVersionFactory> WithCheckpointVersion<T1>(this CombinedResult<T1, SchemaFactory> combinedResult, Action<Humidifier.Glue.SchemaTypes.SchemaVersion> subFactoryAction = null) => new (combinedResult, combinedResult, WithCheckpointVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SchemaFactory, T1, T2, InnerSchemaSchemaVersionFactory> WithCheckpointVersion<T1, T2>(this CombinedResult<SchemaFactory, T1, T2> combinedResult, Action<Humidifier.Glue.SchemaTypes.SchemaVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCheckpointVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SchemaFactory, T2, InnerSchemaSchemaVersionFactory> WithCheckpointVersion<T1, T2>(this CombinedResult<T1, SchemaFactory, T2> combinedResult, Action<Humidifier.Glue.SchemaTypes.SchemaVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCheckpointVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SchemaFactory, InnerSchemaSchemaVersionFactory> WithCheckpointVersion<T1, T2>(this CombinedResult<T1, T2, SchemaFactory> combinedResult, Action<Humidifier.Glue.SchemaTypes.SchemaVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCheckpointVersion(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SchemaFactory, T1, T2, T3, InnerSchemaSchemaVersionFactory> WithCheckpointVersion<T1, T2, T3>(this CombinedResult<SchemaFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.SchemaTypes.SchemaVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCheckpointVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SchemaFactory, T2, T3, InnerSchemaSchemaVersionFactory> WithCheckpointVersion<T1, T2, T3>(this CombinedResult<T1, SchemaFactory, T2, T3> combinedResult, Action<Humidifier.Glue.SchemaTypes.SchemaVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCheckpointVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SchemaFactory, T3, InnerSchemaSchemaVersionFactory> WithCheckpointVersion<T1, T2, T3>(this CombinedResult<T1, T2, SchemaFactory, T3> combinedResult, Action<Humidifier.Glue.SchemaTypes.SchemaVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCheckpointVersion(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SchemaFactory, InnerSchemaSchemaVersionFactory> WithCheckpointVersion<T1, T2, T3>(this CombinedResult<T1, T2, T3, SchemaFactory> combinedResult, Action<Humidifier.Glue.SchemaTypes.SchemaVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCheckpointVersion(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SchemaFactory, T1, T2, T3, T4, InnerSchemaSchemaVersionFactory> WithCheckpointVersion<T1, T2, T3, T4>(this CombinedResult<SchemaFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.SchemaTypes.SchemaVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCheckpointVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SchemaFactory, T2, T3, T4, InnerSchemaSchemaVersionFactory> WithCheckpointVersion<T1, T2, T3, T4>(this CombinedResult<T1, SchemaFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.SchemaTypes.SchemaVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCheckpointVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SchemaFactory, T3, T4, InnerSchemaSchemaVersionFactory> WithCheckpointVersion<T1, T2, T3, T4>(this CombinedResult<T1, T2, SchemaFactory, T3, T4> combinedResult, Action<Humidifier.Glue.SchemaTypes.SchemaVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCheckpointVersion(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SchemaFactory, T4, InnerSchemaSchemaVersionFactory> WithCheckpointVersion<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SchemaFactory, T4> combinedResult, Action<Humidifier.Glue.SchemaTypes.SchemaVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCheckpointVersion(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SchemaFactory, InnerSchemaSchemaVersionFactory> WithCheckpointVersion<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SchemaFactory> combinedResult, Action<Humidifier.Glue.SchemaTypes.SchemaVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCheckpointVersion(combinedResult.T5, subFactoryAction));
}
