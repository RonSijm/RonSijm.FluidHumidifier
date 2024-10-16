// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class SchemaVersionFactory(string resourceName = null, Action<Humidifier.Glue.SchemaVersion> factoryAction = null) : ResourceFactory<Humidifier.Glue.SchemaVersion>(resourceName)
{

    internal InnerSchemaVersionSchemaFactory SchemaFactory { get; set; }

    protected override Humidifier.Glue.SchemaVersion Create()
    {
        var schemaVersionResult = CreateSchemaVersion();
        factoryAction?.Invoke(schemaVersionResult);

        return schemaVersionResult;
    }

    private Humidifier.Glue.SchemaVersion CreateSchemaVersion()
    {
        var schemaVersionResult = new Humidifier.Glue.SchemaVersion
        {
            GivenName = InputResourceName,
        };

        return schemaVersionResult;
    }
    public override void CreateChildren(Humidifier.Glue.SchemaVersion result)
    {
        base.CreateChildren(result);

        result.Schema ??= SchemaFactory?.Build();
    }

} // End Of Class

public static class SchemaVersionFactoryExtensions
{
    public static CombinedResult<SchemaVersionFactory, InnerSchemaVersionSchemaFactory> WithSchema(this SchemaVersionFactory parentFactory, Action<Humidifier.Glue.SchemaVersionTypes.Schema> subFactoryAction = null)
    {
        parentFactory.SchemaFactory = new InnerSchemaVersionSchemaFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SchemaFactory);
    }

    public static CombinedResult<SchemaVersionFactory, T1, InnerSchemaVersionSchemaFactory> WithSchema<T1>(this CombinedResult<SchemaVersionFactory, T1> combinedResult, Action<Humidifier.Glue.SchemaVersionTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchema(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SchemaVersionFactory, InnerSchemaVersionSchemaFactory> WithSchema<T1>(this CombinedResult<T1, SchemaVersionFactory> combinedResult, Action<Humidifier.Glue.SchemaVersionTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchema(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SchemaVersionFactory, T1, T2, InnerSchemaVersionSchemaFactory> WithSchema<T1, T2>(this CombinedResult<SchemaVersionFactory, T1, T2> combinedResult, Action<Humidifier.Glue.SchemaVersionTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SchemaVersionFactory, T2, InnerSchemaVersionSchemaFactory> WithSchema<T1, T2>(this CombinedResult<T1, SchemaVersionFactory, T2> combinedResult, Action<Humidifier.Glue.SchemaVersionTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SchemaVersionFactory, InnerSchemaVersionSchemaFactory> WithSchema<T1, T2>(this CombinedResult<T1, T2, SchemaVersionFactory> combinedResult, Action<Humidifier.Glue.SchemaVersionTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SchemaVersionFactory, T1, T2, T3, InnerSchemaVersionSchemaFactory> WithSchema<T1, T2, T3>(this CombinedResult<SchemaVersionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.SchemaVersionTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SchemaVersionFactory, T2, T3, InnerSchemaVersionSchemaFactory> WithSchema<T1, T2, T3>(this CombinedResult<T1, SchemaVersionFactory, T2, T3> combinedResult, Action<Humidifier.Glue.SchemaVersionTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SchemaVersionFactory, T3, InnerSchemaVersionSchemaFactory> WithSchema<T1, T2, T3>(this CombinedResult<T1, T2, SchemaVersionFactory, T3> combinedResult, Action<Humidifier.Glue.SchemaVersionTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SchemaVersionFactory, InnerSchemaVersionSchemaFactory> WithSchema<T1, T2, T3>(this CombinedResult<T1, T2, T3, SchemaVersionFactory> combinedResult, Action<Humidifier.Glue.SchemaVersionTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SchemaVersionFactory, T1, T2, T3, T4, InnerSchemaVersionSchemaFactory> WithSchema<T1, T2, T3, T4>(this CombinedResult<SchemaVersionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.SchemaVersionTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SchemaVersionFactory, T2, T3, T4, InnerSchemaVersionSchemaFactory> WithSchema<T1, T2, T3, T4>(this CombinedResult<T1, SchemaVersionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.SchemaVersionTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SchemaVersionFactory, T3, T4, InnerSchemaVersionSchemaFactory> WithSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, SchemaVersionFactory, T3, T4> combinedResult, Action<Humidifier.Glue.SchemaVersionTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SchemaVersionFactory, T4, InnerSchemaVersionSchemaFactory> WithSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SchemaVersionFactory, T4> combinedResult, Action<Humidifier.Glue.SchemaVersionTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SchemaVersionFactory, InnerSchemaVersionSchemaFactory> WithSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SchemaVersionFactory> combinedResult, Action<Humidifier.Glue.SchemaVersionTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T5, subFactoryAction));
}
