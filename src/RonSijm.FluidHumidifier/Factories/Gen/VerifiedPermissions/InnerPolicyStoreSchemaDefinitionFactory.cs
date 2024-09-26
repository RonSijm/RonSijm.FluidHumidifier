// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VerifiedPermissions;

public class InnerPolicyStoreSchemaDefinitionFactory(Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.SchemaDefinition> factoryAction = null) : SubResourceFactory<Humidifier.VerifiedPermissions.PolicyStoreTypes.SchemaDefinition>
{

    protected override Humidifier.VerifiedPermissions.PolicyStoreTypes.SchemaDefinition Create()
    {
        var schemaDefinitionResult = CreateSchemaDefinition();
        factoryAction?.Invoke(schemaDefinitionResult);

        return schemaDefinitionResult;
    }

    private Humidifier.VerifiedPermissions.PolicyStoreTypes.SchemaDefinition CreateSchemaDefinition()
    {
        var schemaDefinitionResult = new Humidifier.VerifiedPermissions.PolicyStoreTypes.SchemaDefinition();

        return schemaDefinitionResult;
    }

} // End Of Class

public static class InnerPolicyStoreSchemaDefinitionFactoryExtensions
{
}
