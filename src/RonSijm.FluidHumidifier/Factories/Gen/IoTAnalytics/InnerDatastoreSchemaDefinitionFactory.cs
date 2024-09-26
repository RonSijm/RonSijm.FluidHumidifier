// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class InnerDatastoreSchemaDefinitionFactory(Action<Humidifier.IoTAnalytics.DatastoreTypes.SchemaDefinition> factoryAction = null) : SubResourceFactory<Humidifier.IoTAnalytics.DatastoreTypes.SchemaDefinition>
{

    protected override Humidifier.IoTAnalytics.DatastoreTypes.SchemaDefinition Create()
    {
        var schemaDefinitionResult = CreateSchemaDefinition();
        factoryAction?.Invoke(schemaDefinitionResult);

        return schemaDefinitionResult;
    }

    private Humidifier.IoTAnalytics.DatastoreTypes.SchemaDefinition CreateSchemaDefinition()
    {
        var schemaDefinitionResult = new Humidifier.IoTAnalytics.DatastoreTypes.SchemaDefinition();

        return schemaDefinitionResult;
    }

} // End Of Class

public static class InnerDatastoreSchemaDefinitionFactoryExtensions
{
}
