// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolUserAttributeTypeFactory(Action<Humidifier.Cognito.UserPoolUserTypes.AttributeType> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolUserTypes.AttributeType>
{

    protected override Humidifier.Cognito.UserPoolUserTypes.AttributeType Create()
    {
        var attributeTypeResult = CreateAttributeType();
        factoryAction?.Invoke(attributeTypeResult);

        return attributeTypeResult;
    }

    private Humidifier.Cognito.UserPoolUserTypes.AttributeType CreateAttributeType()
    {
        var attributeTypeResult = new Humidifier.Cognito.UserPoolUserTypes.AttributeType();

        return attributeTypeResult;
    }

} // End Of Class

public static class InnerUserPoolUserAttributeTypeFactoryExtensions
{
}
