// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EventSchemas;

public class SchemaFactory(string resourceName = null, Action<Humidifier.EventSchemas.Schema> factoryAction = null) : ResourceFactory<Humidifier.EventSchemas.Schema>(resourceName)
{

    internal List<InnerSchemaTagsEntryFactory> TagsFactories { get; set; } = [];

    protected override Humidifier.EventSchemas.Schema Create()
    {
        var schemaResult = CreateSchema();
        factoryAction?.Invoke(schemaResult);

        return schemaResult;
    }

    private Humidifier.EventSchemas.Schema CreateSchema()
    {
        var schemaResult = new Humidifier.EventSchemas.Schema
        {
            GivenName = InputResourceName,
        };

        return schemaResult;
    }
    public override void CreateChildren(Humidifier.EventSchemas.Schema result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class SchemaFactoryExtensions
{
    public static CombinedResult<SchemaFactory, InnerSchemaTagsEntryFactory> WithTags(this SchemaFactory parentFactory, Action<Humidifier.EventSchemas.SchemaTypes.TagsEntry> subFactoryAction = null)
    {
        var factory = new InnerSchemaTagsEntryFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<SchemaFactory, T1, InnerSchemaTagsEntryFactory> WithTags<T1>(this CombinedResult<SchemaFactory, T1> combinedResult, Action<Humidifier.EventSchemas.SchemaTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SchemaFactory, InnerSchemaTagsEntryFactory> WithTags<T1>(this CombinedResult<T1, SchemaFactory> combinedResult, Action<Humidifier.EventSchemas.SchemaTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SchemaFactory, T1, T2, InnerSchemaTagsEntryFactory> WithTags<T1, T2>(this CombinedResult<SchemaFactory, T1, T2> combinedResult, Action<Humidifier.EventSchemas.SchemaTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SchemaFactory, T2, InnerSchemaTagsEntryFactory> WithTags<T1, T2>(this CombinedResult<T1, SchemaFactory, T2> combinedResult, Action<Humidifier.EventSchemas.SchemaTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SchemaFactory, InnerSchemaTagsEntryFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, SchemaFactory> combinedResult, Action<Humidifier.EventSchemas.SchemaTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SchemaFactory, T1, T2, T3, InnerSchemaTagsEntryFactory> WithTags<T1, T2, T3>(this CombinedResult<SchemaFactory, T1, T2, T3> combinedResult, Action<Humidifier.EventSchemas.SchemaTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SchemaFactory, T2, T3, InnerSchemaTagsEntryFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, SchemaFactory, T2, T3> combinedResult, Action<Humidifier.EventSchemas.SchemaTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SchemaFactory, T3, InnerSchemaTagsEntryFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, SchemaFactory, T3> combinedResult, Action<Humidifier.EventSchemas.SchemaTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SchemaFactory, InnerSchemaTagsEntryFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, SchemaFactory> combinedResult, Action<Humidifier.EventSchemas.SchemaTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SchemaFactory, T1, T2, T3, T4, InnerSchemaTagsEntryFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<SchemaFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EventSchemas.SchemaTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SchemaFactory, T2, T3, T4, InnerSchemaTagsEntryFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, SchemaFactory, T2, T3, T4> combinedResult, Action<Humidifier.EventSchemas.SchemaTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SchemaFactory, T3, T4, InnerSchemaTagsEntryFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, SchemaFactory, T3, T4> combinedResult, Action<Humidifier.EventSchemas.SchemaTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SchemaFactory, T4, InnerSchemaTagsEntryFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SchemaFactory, T4> combinedResult, Action<Humidifier.EventSchemas.SchemaTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SchemaFactory, InnerSchemaTagsEntryFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SchemaFactory> combinedResult, Action<Humidifier.EventSchemas.SchemaTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction));
}
