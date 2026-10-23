// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerPaymentManagerCustomJWTAuthorizerFactory(Action<Humidifier.BedrockAgentCore.PaymentManagerTypes.CustomJWTAuthorizer> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.PaymentManagerTypes.CustomJWTAuthorizer>
{

    protected override Humidifier.BedrockAgentCore.PaymentManagerTypes.CustomJWTAuthorizer Create()
    {
        var customJWTAuthorizerResult = CreateCustomJWTAuthorizer();
        factoryAction?.Invoke(customJWTAuthorizerResult);

        return customJWTAuthorizerResult;
    }

    private Humidifier.BedrockAgentCore.PaymentManagerTypes.CustomJWTAuthorizer CreateCustomJWTAuthorizer()
    {
        var customJWTAuthorizerResult = new Humidifier.BedrockAgentCore.PaymentManagerTypes.CustomJWTAuthorizer();

        return customJWTAuthorizerResult;
    }

} // End Of Class

public static class InnerPaymentManagerCustomJWTAuthorizerFactoryExtensions
{
}
