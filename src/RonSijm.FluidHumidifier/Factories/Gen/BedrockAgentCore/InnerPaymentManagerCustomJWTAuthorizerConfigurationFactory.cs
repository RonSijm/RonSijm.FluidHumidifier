// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerPaymentManagerCustomJWTAuthorizerConfigurationFactory(Action<Humidifier.BedrockAgentCore.PaymentManagerTypes.CustomJWTAuthorizerConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.PaymentManagerTypes.CustomJWTAuthorizerConfiguration>
{

    protected override Humidifier.BedrockAgentCore.PaymentManagerTypes.CustomJWTAuthorizerConfiguration Create()
    {
        var customJWTAuthorizerConfigurationResult = CreateCustomJWTAuthorizerConfiguration();
        factoryAction?.Invoke(customJWTAuthorizerConfigurationResult);

        return customJWTAuthorizerConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.PaymentManagerTypes.CustomJWTAuthorizerConfiguration CreateCustomJWTAuthorizerConfiguration()
    {
        var customJWTAuthorizerConfigurationResult = new Humidifier.BedrockAgentCore.PaymentManagerTypes.CustomJWTAuthorizerConfiguration();

        return customJWTAuthorizerConfigurationResult;
    }

} // End Of Class

public static class InnerPaymentManagerCustomJWTAuthorizerConfigurationFactoryExtensions
{
}
