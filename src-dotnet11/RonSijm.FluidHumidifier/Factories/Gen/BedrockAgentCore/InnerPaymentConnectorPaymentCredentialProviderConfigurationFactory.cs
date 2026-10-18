// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerPaymentConnectorPaymentCredentialProviderConfigurationFactory(Action<Humidifier.BedrockAgentCore.PaymentConnectorTypes.PaymentCredentialProviderConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.PaymentConnectorTypes.PaymentCredentialProviderConfiguration>
{

    protected override Humidifier.BedrockAgentCore.PaymentConnectorTypes.PaymentCredentialProviderConfiguration Create()
    {
        var paymentCredentialProviderConfigurationResult = CreatePaymentCredentialProviderConfiguration();
        factoryAction?.Invoke(paymentCredentialProviderConfigurationResult);

        return paymentCredentialProviderConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.PaymentConnectorTypes.PaymentCredentialProviderConfiguration CreatePaymentCredentialProviderConfiguration()
    {
        var paymentCredentialProviderConfigurationResult = new Humidifier.BedrockAgentCore.PaymentConnectorTypes.PaymentCredentialProviderConfiguration();

        return paymentCredentialProviderConfigurationResult;
    }

} // End Of Class

public static class InnerPaymentConnectorPaymentCredentialProviderConfigurationFactoryExtensions
{
}
