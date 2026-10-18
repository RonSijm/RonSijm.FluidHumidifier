// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class PaymentManagerFactory(string resourceName = null, Action<Humidifier.BedrockAgentCore.PaymentManager> factoryAction = null) : ResourceFactory<Humidifier.BedrockAgentCore.PaymentManager>(resourceName)
{

    internal InnerPaymentManagerAuthorizerConfigurationFactory AuthorizerConfigurationFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.PaymentManager Create()
    {
        var paymentManagerResult = CreatePaymentManager();
        factoryAction?.Invoke(paymentManagerResult);

        return paymentManagerResult;
    }

    private Humidifier.BedrockAgentCore.PaymentManager CreatePaymentManager()
    {
        var paymentManagerResult = new Humidifier.BedrockAgentCore.PaymentManager
        {
            GivenName = InputResourceName,
        };

        return paymentManagerResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.PaymentManager result)
    {
        base.CreateChildren(result);

        result.AuthorizerConfiguration ??= AuthorizerConfigurationFactory?.Build();
    }

} // End Of Class

public static class PaymentManagerFactoryExtensions
{
    public static CombinedResult<PaymentManagerFactory, InnerPaymentManagerAuthorizerConfigurationFactory> WithAuthorizerConfiguration(this PaymentManagerFactory parentFactory, Action<Humidifier.BedrockAgentCore.PaymentManagerTypes.AuthorizerConfiguration> subFactoryAction = null)
    {
        parentFactory.AuthorizerConfigurationFactory = new InnerPaymentManagerAuthorizerConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AuthorizerConfigurationFactory);
    }

    public static CombinedResult<PaymentManagerFactory, T1, InnerPaymentManagerAuthorizerConfigurationFactory> WithAuthorizerConfiguration<T1>(this CombinedResult<PaymentManagerFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentManagerTypes.AuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthorizerConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PaymentManagerFactory, InnerPaymentManagerAuthorizerConfigurationFactory> WithAuthorizerConfiguration<T1>(this CombinedResult<T1, PaymentManagerFactory> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentManagerTypes.AuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthorizerConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<PaymentManagerFactory, T1, T2, InnerPaymentManagerAuthorizerConfigurationFactory> WithAuthorizerConfiguration<T1, T2>(this CombinedResult<PaymentManagerFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentManagerTypes.AuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizerConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PaymentManagerFactory, T2, InnerPaymentManagerAuthorizerConfigurationFactory> WithAuthorizerConfiguration<T1, T2>(this CombinedResult<T1, PaymentManagerFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentManagerTypes.AuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizerConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PaymentManagerFactory, InnerPaymentManagerAuthorizerConfigurationFactory> WithAuthorizerConfiguration<T1, T2>(this CombinedResult<T1, T2, PaymentManagerFactory> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentManagerTypes.AuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizerConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<PaymentManagerFactory, T1, T2, T3, InnerPaymentManagerAuthorizerConfigurationFactory> WithAuthorizerConfiguration<T1, T2, T3>(this CombinedResult<PaymentManagerFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentManagerTypes.AuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizerConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PaymentManagerFactory, T2, T3, InnerPaymentManagerAuthorizerConfigurationFactory> WithAuthorizerConfiguration<T1, T2, T3>(this CombinedResult<T1, PaymentManagerFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentManagerTypes.AuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizerConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PaymentManagerFactory, T3, InnerPaymentManagerAuthorizerConfigurationFactory> WithAuthorizerConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, PaymentManagerFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentManagerTypes.AuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizerConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PaymentManagerFactory, InnerPaymentManagerAuthorizerConfigurationFactory> WithAuthorizerConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, PaymentManagerFactory> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentManagerTypes.AuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizerConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<PaymentManagerFactory, T1, T2, T3, T4, InnerPaymentManagerAuthorizerConfigurationFactory> WithAuthorizerConfiguration<T1, T2, T3, T4>(this CombinedResult<PaymentManagerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentManagerTypes.AuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizerConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PaymentManagerFactory, T2, T3, T4, InnerPaymentManagerAuthorizerConfigurationFactory> WithAuthorizerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, PaymentManagerFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentManagerTypes.AuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizerConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PaymentManagerFactory, T3, T4, InnerPaymentManagerAuthorizerConfigurationFactory> WithAuthorizerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, PaymentManagerFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentManagerTypes.AuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizerConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PaymentManagerFactory, T4, InnerPaymentManagerAuthorizerConfigurationFactory> WithAuthorizerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PaymentManagerFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentManagerTypes.AuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizerConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, PaymentManagerFactory, InnerPaymentManagerAuthorizerConfigurationFactory> WithAuthorizerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PaymentManagerFactory> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentManagerTypes.AuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizerConfiguration(combinedResult.T5, subFactoryAction).T2);
}
