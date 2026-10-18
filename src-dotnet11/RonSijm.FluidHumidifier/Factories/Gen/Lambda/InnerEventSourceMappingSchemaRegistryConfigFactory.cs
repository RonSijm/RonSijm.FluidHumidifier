// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerEventSourceMappingSchemaRegistryConfigFactory(Action<Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryConfig>
{

    protected override Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryConfig Create()
    {
        var schemaRegistryConfigResult = CreateSchemaRegistryConfig();
        factoryAction?.Invoke(schemaRegistryConfigResult);

        return schemaRegistryConfigResult;
    }

    private Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryConfig CreateSchemaRegistryConfig()
    {
        var schemaRegistryConfigResult = new Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryConfig();

        return schemaRegistryConfigResult;
    }

} // End Of Class

public static class InnerEventSourceMappingSchemaRegistryConfigFactoryExtensions
{
}
