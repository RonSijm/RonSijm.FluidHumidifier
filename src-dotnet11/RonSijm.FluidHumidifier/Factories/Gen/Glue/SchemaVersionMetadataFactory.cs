// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class SchemaVersionMetadataFactory(string resourceName = null, Action<Humidifier.Glue.SchemaVersionMetadata> factoryAction = null) : ResourceFactory<Humidifier.Glue.SchemaVersionMetadata>(resourceName)
{

    protected override Humidifier.Glue.SchemaVersionMetadata Create()
    {
        var schemaVersionMetadataResult = CreateSchemaVersionMetadata();
        factoryAction?.Invoke(schemaVersionMetadataResult);

        return schemaVersionMetadataResult;
    }

    private Humidifier.Glue.SchemaVersionMetadata CreateSchemaVersionMetadata()
    {
        var schemaVersionMetadataResult = new Humidifier.Glue.SchemaVersionMetadata
        {
            GivenName = InputResourceName,
        };

        return schemaVersionMetadataResult;
    }

} // End Of Class

public static class SchemaVersionMetadataFactoryExtensions
{
}
