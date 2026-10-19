// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AgentRegistry;

public class InnerRegistryCustomMetadataSchemaConfigurationFactory(Action<Humidifier.AgentRegistry.RegistryTypes.CustomMetadataSchemaConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.AgentRegistry.RegistryTypes.CustomMetadataSchemaConfiguration>
{

    protected override Humidifier.AgentRegistry.RegistryTypes.CustomMetadataSchemaConfiguration Create()
    {
        var customMetadataSchemaConfigurationResult = CreateCustomMetadataSchemaConfiguration();
        factoryAction?.Invoke(customMetadataSchemaConfigurationResult);

        return customMetadataSchemaConfigurationResult;
    }

    private Humidifier.AgentRegistry.RegistryTypes.CustomMetadataSchemaConfiguration CreateCustomMetadataSchemaConfiguration()
    {
        var customMetadataSchemaConfigurationResult = new Humidifier.AgentRegistry.RegistryTypes.CustomMetadataSchemaConfiguration();

        return customMetadataSchemaConfigurationResult;
    }

} // End Of Class

public static class InnerRegistryCustomMetadataSchemaConfigurationFactoryExtensions
{
}
