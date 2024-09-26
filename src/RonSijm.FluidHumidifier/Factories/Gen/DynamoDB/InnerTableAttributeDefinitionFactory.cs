// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerTableAttributeDefinitionFactory(Action<Humidifier.DynamoDB.TableTypes.AttributeDefinition> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.TableTypes.AttributeDefinition>
{

    protected override Humidifier.DynamoDB.TableTypes.AttributeDefinition Create()
    {
        var attributeDefinitionResult = CreateAttributeDefinition();
        factoryAction?.Invoke(attributeDefinitionResult);

        return attributeDefinitionResult;
    }

    private Humidifier.DynamoDB.TableTypes.AttributeDefinition CreateAttributeDefinition()
    {
        var attributeDefinitionResult = new Humidifier.DynamoDB.TableTypes.AttributeDefinition();

        return attributeDefinitionResult;
    }

} // End Of Class

public static class InnerTableAttributeDefinitionFactoryExtensions
{
}
