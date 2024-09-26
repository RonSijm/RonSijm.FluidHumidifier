// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EntityResolution;

public class SchemaMappingFactory(string resourceName = null, Action<Humidifier.EntityResolution.SchemaMapping> factoryAction = null) : ResourceFactory<Humidifier.EntityResolution.SchemaMapping>(resourceName)
{

    internal List<InnerSchemaMappingSchemaInputAttributeFactory> MappedInputFieldsFactories { get; set; } = [];

    protected override Humidifier.EntityResolution.SchemaMapping Create()
    {
        var schemaMappingResult = CreateSchemaMapping();
        factoryAction?.Invoke(schemaMappingResult);

        return schemaMappingResult;
    }

    private Humidifier.EntityResolution.SchemaMapping CreateSchemaMapping()
    {
        var schemaMappingResult = new Humidifier.EntityResolution.SchemaMapping
        {
            GivenName = InputResourceName,
        };

        return schemaMappingResult;
    }
    public override void CreateChildren(Humidifier.EntityResolution.SchemaMapping result)
    {
        base.CreateChildren(result);

        result.MappedInputFields = MappedInputFieldsFactories.Any() ? MappedInputFieldsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class SchemaMappingFactoryExtensions
{
    public static CombinedResult<SchemaMappingFactory, InnerSchemaMappingSchemaInputAttributeFactory> WithMappedInputFields(this SchemaMappingFactory parentFactory, Action<Humidifier.EntityResolution.SchemaMappingTypes.SchemaInputAttribute> subFactoryAction = null)
    {
        var factory = new InnerSchemaMappingSchemaInputAttributeFactory(subFactoryAction);
        parentFactory.MappedInputFieldsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<SchemaMappingFactory, T1, InnerSchemaMappingSchemaInputAttributeFactory> WithMappedInputFields<T1>(this CombinedResult<SchemaMappingFactory, T1> combinedResult, Action<Humidifier.EntityResolution.SchemaMappingTypes.SchemaInputAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, WithMappedInputFields(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SchemaMappingFactory, InnerSchemaMappingSchemaInputAttributeFactory> WithMappedInputFields<T1>(this CombinedResult<T1, SchemaMappingFactory> combinedResult, Action<Humidifier.EntityResolution.SchemaMappingTypes.SchemaInputAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, WithMappedInputFields(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SchemaMappingFactory, T1, T2, InnerSchemaMappingSchemaInputAttributeFactory> WithMappedInputFields<T1, T2>(this CombinedResult<SchemaMappingFactory, T1, T2> combinedResult, Action<Humidifier.EntityResolution.SchemaMappingTypes.SchemaInputAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMappedInputFields(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SchemaMappingFactory, T2, InnerSchemaMappingSchemaInputAttributeFactory> WithMappedInputFields<T1, T2>(this CombinedResult<T1, SchemaMappingFactory, T2> combinedResult, Action<Humidifier.EntityResolution.SchemaMappingTypes.SchemaInputAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMappedInputFields(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SchemaMappingFactory, InnerSchemaMappingSchemaInputAttributeFactory> WithMappedInputFields<T1, T2>(this CombinedResult<T1, T2, SchemaMappingFactory> combinedResult, Action<Humidifier.EntityResolution.SchemaMappingTypes.SchemaInputAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMappedInputFields(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SchemaMappingFactory, T1, T2, T3, InnerSchemaMappingSchemaInputAttributeFactory> WithMappedInputFields<T1, T2, T3>(this CombinedResult<SchemaMappingFactory, T1, T2, T3> combinedResult, Action<Humidifier.EntityResolution.SchemaMappingTypes.SchemaInputAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMappedInputFields(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SchemaMappingFactory, T2, T3, InnerSchemaMappingSchemaInputAttributeFactory> WithMappedInputFields<T1, T2, T3>(this CombinedResult<T1, SchemaMappingFactory, T2, T3> combinedResult, Action<Humidifier.EntityResolution.SchemaMappingTypes.SchemaInputAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMappedInputFields(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SchemaMappingFactory, T3, InnerSchemaMappingSchemaInputAttributeFactory> WithMappedInputFields<T1, T2, T3>(this CombinedResult<T1, T2, SchemaMappingFactory, T3> combinedResult, Action<Humidifier.EntityResolution.SchemaMappingTypes.SchemaInputAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMappedInputFields(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SchemaMappingFactory, InnerSchemaMappingSchemaInputAttributeFactory> WithMappedInputFields<T1, T2, T3>(this CombinedResult<T1, T2, T3, SchemaMappingFactory> combinedResult, Action<Humidifier.EntityResolution.SchemaMappingTypes.SchemaInputAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMappedInputFields(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SchemaMappingFactory, T1, T2, T3, T4, InnerSchemaMappingSchemaInputAttributeFactory> WithMappedInputFields<T1, T2, T3, T4>(this CombinedResult<SchemaMappingFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EntityResolution.SchemaMappingTypes.SchemaInputAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMappedInputFields(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SchemaMappingFactory, T2, T3, T4, InnerSchemaMappingSchemaInputAttributeFactory> WithMappedInputFields<T1, T2, T3, T4>(this CombinedResult<T1, SchemaMappingFactory, T2, T3, T4> combinedResult, Action<Humidifier.EntityResolution.SchemaMappingTypes.SchemaInputAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMappedInputFields(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SchemaMappingFactory, T3, T4, InnerSchemaMappingSchemaInputAttributeFactory> WithMappedInputFields<T1, T2, T3, T4>(this CombinedResult<T1, T2, SchemaMappingFactory, T3, T4> combinedResult, Action<Humidifier.EntityResolution.SchemaMappingTypes.SchemaInputAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMappedInputFields(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SchemaMappingFactory, T4, InnerSchemaMappingSchemaInputAttributeFactory> WithMappedInputFields<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SchemaMappingFactory, T4> combinedResult, Action<Humidifier.EntityResolution.SchemaMappingTypes.SchemaInputAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMappedInputFields(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SchemaMappingFactory, InnerSchemaMappingSchemaInputAttributeFactory> WithMappedInputFields<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SchemaMappingFactory> combinedResult, Action<Humidifier.EntityResolution.SchemaMappingTypes.SchemaInputAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMappedInputFields(combinedResult.T5, subFactoryAction));
}
