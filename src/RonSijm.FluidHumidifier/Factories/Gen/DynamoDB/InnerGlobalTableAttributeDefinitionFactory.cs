// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerGlobalTableAttributeDefinitionFactory(Action<Humidifier.DynamoDB.GlobalTableTypes.AttributeDefinition> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.GlobalTableTypes.AttributeDefinition>
{

    protected override Humidifier.DynamoDB.GlobalTableTypes.AttributeDefinition Create()
    {
        var attributeDefinitionResult = CreateAttributeDefinition();
        factoryAction?.Invoke(attributeDefinitionResult);

        return attributeDefinitionResult;
    }

    private Humidifier.DynamoDB.GlobalTableTypes.AttributeDefinition CreateAttributeDefinition()
    {
        var attributeDefinitionResult = new Humidifier.DynamoDB.GlobalTableTypes.AttributeDefinition();

        return attributeDefinitionResult;
    }

} // End Of Class

public static class InnerGlobalTableAttributeDefinitionFactoryExtensions
{
}
