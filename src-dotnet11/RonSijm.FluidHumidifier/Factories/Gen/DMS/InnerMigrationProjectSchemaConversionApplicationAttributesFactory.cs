// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class InnerMigrationProjectSchemaConversionApplicationAttributesFactory(Action<Humidifier.DMS.MigrationProjectTypes.SchemaConversionApplicationAttributes> factoryAction = null) : SubResourceFactory<Humidifier.DMS.MigrationProjectTypes.SchemaConversionApplicationAttributes>
{

    protected override Humidifier.DMS.MigrationProjectTypes.SchemaConversionApplicationAttributes Create()
    {
        var schemaConversionApplicationAttributesResult = CreateSchemaConversionApplicationAttributes();
        factoryAction?.Invoke(schemaConversionApplicationAttributesResult);

        return schemaConversionApplicationAttributesResult;
    }

    private Humidifier.DMS.MigrationProjectTypes.SchemaConversionApplicationAttributes CreateSchemaConversionApplicationAttributes()
    {
        var schemaConversionApplicationAttributesResult = new Humidifier.DMS.MigrationProjectTypes.SchemaConversionApplicationAttributes();

        return schemaConversionApplicationAttributesResult;
    }

} // End Of Class

public static class InnerMigrationProjectSchemaConversionApplicationAttributesFactoryExtensions
{
}
