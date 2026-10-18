// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EntityResolution;

public class InnerSchemaMappingSchemaInputAttributeFactory(Action<Humidifier.EntityResolution.SchemaMappingTypes.SchemaInputAttribute> factoryAction = null) : SubResourceFactory<Humidifier.EntityResolution.SchemaMappingTypes.SchemaInputAttribute>
{

    protected override Humidifier.EntityResolution.SchemaMappingTypes.SchemaInputAttribute Create()
    {
        var schemaInputAttributeResult = CreateSchemaInputAttribute();
        factoryAction?.Invoke(schemaInputAttributeResult);

        return schemaInputAttributeResult;
    }

    private Humidifier.EntityResolution.SchemaMappingTypes.SchemaInputAttribute CreateSchemaInputAttribute()
    {
        var schemaInputAttributeResult = new Humidifier.EntityResolution.SchemaMappingTypes.SchemaInputAttribute();

        return schemaInputAttributeResult;
    }

} // End Of Class

public static class InnerSchemaMappingSchemaInputAttributeFactoryExtensions
{
}
