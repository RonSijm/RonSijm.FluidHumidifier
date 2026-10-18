// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class PaymentConnectorFactory(string resourceName = null, Action<Humidifier.BedrockAgentCore.PaymentConnector> factoryAction = null) : ResourceFactory<Humidifier.BedrockAgentCore.PaymentConnector>(resourceName)
{

    internal List<InnerPaymentConnectorCredentialsProviderConfigurationFactory> CredentialProviderConfigurationsFactories { get; set; } = [];

    protected override Humidifier.BedrockAgentCore.PaymentConnector Create()
    {
        var paymentConnectorResult = CreatePaymentConnector();
        factoryAction?.Invoke(paymentConnectorResult);

        return paymentConnectorResult;
    }

    private Humidifier.BedrockAgentCore.PaymentConnector CreatePaymentConnector()
    {
        var paymentConnectorResult = new Humidifier.BedrockAgentCore.PaymentConnector
        {
            GivenName = InputResourceName,
        };

        return paymentConnectorResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.PaymentConnector result)
    {
        base.CreateChildren(result);

        result.CredentialProviderConfigurations = CredentialProviderConfigurationsFactories.Any() ? CredentialProviderConfigurationsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class PaymentConnectorFactoryExtensions
{
    public static CombinedResult<PaymentConnectorFactory, InnerPaymentConnectorCredentialsProviderConfigurationFactory> WithCredentialProviderConfigurations(this PaymentConnectorFactory parentFactory, Action<Humidifier.BedrockAgentCore.PaymentConnectorTypes.CredentialsProviderConfiguration> subFactoryAction = null)
    {
        var factory = new InnerPaymentConnectorCredentialsProviderConfigurationFactory(subFactoryAction);
        parentFactory.CredentialProviderConfigurationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<PaymentConnectorFactory, T1, InnerPaymentConnectorCredentialsProviderConfigurationFactory> WithCredentialProviderConfigurations<T1>(this CombinedResult<PaymentConnectorFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentConnectorTypes.CredentialsProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCredentialProviderConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PaymentConnectorFactory, InnerPaymentConnectorCredentialsProviderConfigurationFactory> WithCredentialProviderConfigurations<T1>(this CombinedResult<T1, PaymentConnectorFactory> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentConnectorTypes.CredentialsProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCredentialProviderConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<PaymentConnectorFactory, T1, T2, InnerPaymentConnectorCredentialsProviderConfigurationFactory> WithCredentialProviderConfigurations<T1, T2>(this CombinedResult<PaymentConnectorFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentConnectorTypes.CredentialsProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCredentialProviderConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PaymentConnectorFactory, T2, InnerPaymentConnectorCredentialsProviderConfigurationFactory> WithCredentialProviderConfigurations<T1, T2>(this CombinedResult<T1, PaymentConnectorFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentConnectorTypes.CredentialsProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCredentialProviderConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PaymentConnectorFactory, InnerPaymentConnectorCredentialsProviderConfigurationFactory> WithCredentialProviderConfigurations<T1, T2>(this CombinedResult<T1, T2, PaymentConnectorFactory> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentConnectorTypes.CredentialsProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCredentialProviderConfigurations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<PaymentConnectorFactory, T1, T2, T3, InnerPaymentConnectorCredentialsProviderConfigurationFactory> WithCredentialProviderConfigurations<T1, T2, T3>(this CombinedResult<PaymentConnectorFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentConnectorTypes.CredentialsProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredentialProviderConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PaymentConnectorFactory, T2, T3, InnerPaymentConnectorCredentialsProviderConfigurationFactory> WithCredentialProviderConfigurations<T1, T2, T3>(this CombinedResult<T1, PaymentConnectorFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentConnectorTypes.CredentialsProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredentialProviderConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PaymentConnectorFactory, T3, InnerPaymentConnectorCredentialsProviderConfigurationFactory> WithCredentialProviderConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, PaymentConnectorFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentConnectorTypes.CredentialsProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredentialProviderConfigurations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PaymentConnectorFactory, InnerPaymentConnectorCredentialsProviderConfigurationFactory> WithCredentialProviderConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, T3, PaymentConnectorFactory> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentConnectorTypes.CredentialsProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredentialProviderConfigurations(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<PaymentConnectorFactory, T1, T2, T3, T4, InnerPaymentConnectorCredentialsProviderConfigurationFactory> WithCredentialProviderConfigurations<T1, T2, T3, T4>(this CombinedResult<PaymentConnectorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentConnectorTypes.CredentialsProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentialProviderConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PaymentConnectorFactory, T2, T3, T4, InnerPaymentConnectorCredentialsProviderConfigurationFactory> WithCredentialProviderConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, PaymentConnectorFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentConnectorTypes.CredentialsProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentialProviderConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PaymentConnectorFactory, T3, T4, InnerPaymentConnectorCredentialsProviderConfigurationFactory> WithCredentialProviderConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, PaymentConnectorFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentConnectorTypes.CredentialsProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentialProviderConfigurations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PaymentConnectorFactory, T4, InnerPaymentConnectorCredentialsProviderConfigurationFactory> WithCredentialProviderConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PaymentConnectorFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentConnectorTypes.CredentialsProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentialProviderConfigurations(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, PaymentConnectorFactory, InnerPaymentConnectorCredentialsProviderConfigurationFactory> WithCredentialProviderConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PaymentConnectorFactory> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentConnectorTypes.CredentialsProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentialProviderConfigurations(combinedResult.T5, subFactoryAction).T2);
}
