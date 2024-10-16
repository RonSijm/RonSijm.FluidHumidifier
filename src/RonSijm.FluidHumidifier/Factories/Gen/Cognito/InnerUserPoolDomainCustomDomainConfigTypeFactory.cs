// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolDomainCustomDomainConfigTypeFactory(Action<Humidifier.Cognito.UserPoolDomainTypes.CustomDomainConfigType> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolDomainTypes.CustomDomainConfigType>
{

    protected override Humidifier.Cognito.UserPoolDomainTypes.CustomDomainConfigType Create()
    {
        var customDomainConfigTypeResult = CreateCustomDomainConfigType();
        factoryAction?.Invoke(customDomainConfigTypeResult);

        return customDomainConfigTypeResult;
    }

    private Humidifier.Cognito.UserPoolDomainTypes.CustomDomainConfigType CreateCustomDomainConfigType()
    {
        var customDomainConfigTypeResult = new Humidifier.Cognito.UserPoolDomainTypes.CustomDomainConfigType();

        return customDomainConfigTypeResult;
    }

} // End Of Class

public static class InnerUserPoolDomainCustomDomainConfigTypeFactoryExtensions
{
}
