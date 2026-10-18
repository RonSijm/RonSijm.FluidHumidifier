// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class PaymentCredentialProviderFactory(string resourceName = null, Action<Humidifier.BedrockAgentCore.PaymentCredentialProvider> factoryAction = null) : ResourceFactory<Humidifier.BedrockAgentCore.PaymentCredentialProvider>(resourceName)
{

    internal InnerPaymentCredentialProviderPaymentProviderConfigurationInputFactory ProviderConfigurationInputFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.PaymentCredentialProvider Create()
    {
        var paymentCredentialProviderResult = CreatePaymentCredentialProvider();
        factoryAction?.Invoke(paymentCredentialProviderResult);

        return paymentCredentialProviderResult;
    }

    private Humidifier.BedrockAgentCore.PaymentCredentialProvider CreatePaymentCredentialProvider()
    {
        var paymentCredentialProviderResult = new Humidifier.BedrockAgentCore.PaymentCredentialProvider
        {
            GivenName = InputResourceName,
        };

        return paymentCredentialProviderResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.PaymentCredentialProvider result)
    {
        base.CreateChildren(result);

        result.ProviderConfigurationInput ??= ProviderConfigurationInputFactory?.Build();
    }

} // End Of Class

public static class PaymentCredentialProviderFactoryExtensions
{
    public static CombinedResult<PaymentCredentialProviderFactory, InnerPaymentCredentialProviderPaymentProviderConfigurationInputFactory> WithProviderConfigurationInput(this PaymentCredentialProviderFactory parentFactory, Action<Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.PaymentProviderConfigurationInput> subFactoryAction = null)
    {
        parentFactory.ProviderConfigurationInputFactory = new InnerPaymentCredentialProviderPaymentProviderConfigurationInputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ProviderConfigurationInputFactory);
    }

    public static CombinedResult<PaymentCredentialProviderFactory, T1, InnerPaymentCredentialProviderPaymentProviderConfigurationInputFactory> WithProviderConfigurationInput<T1>(this CombinedResult<PaymentCredentialProviderFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.PaymentProviderConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithProviderConfigurationInput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PaymentCredentialProviderFactory, InnerPaymentCredentialProviderPaymentProviderConfigurationInputFactory> WithProviderConfigurationInput<T1>(this CombinedResult<T1, PaymentCredentialProviderFactory> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.PaymentProviderConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithProviderConfigurationInput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<PaymentCredentialProviderFactory, T1, T2, InnerPaymentCredentialProviderPaymentProviderConfigurationInputFactory> WithProviderConfigurationInput<T1, T2>(this CombinedResult<PaymentCredentialProviderFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.PaymentProviderConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProviderConfigurationInput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PaymentCredentialProviderFactory, T2, InnerPaymentCredentialProviderPaymentProviderConfigurationInputFactory> WithProviderConfigurationInput<T1, T2>(this CombinedResult<T1, PaymentCredentialProviderFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.PaymentProviderConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProviderConfigurationInput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PaymentCredentialProviderFactory, InnerPaymentCredentialProviderPaymentProviderConfigurationInputFactory> WithProviderConfigurationInput<T1, T2>(this CombinedResult<T1, T2, PaymentCredentialProviderFactory> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.PaymentProviderConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProviderConfigurationInput(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<PaymentCredentialProviderFactory, T1, T2, T3, InnerPaymentCredentialProviderPaymentProviderConfigurationInputFactory> WithProviderConfigurationInput<T1, T2, T3>(this CombinedResult<PaymentCredentialProviderFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.PaymentProviderConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProviderConfigurationInput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PaymentCredentialProviderFactory, T2, T3, InnerPaymentCredentialProviderPaymentProviderConfigurationInputFactory> WithProviderConfigurationInput<T1, T2, T3>(this CombinedResult<T1, PaymentCredentialProviderFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.PaymentProviderConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProviderConfigurationInput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PaymentCredentialProviderFactory, T3, InnerPaymentCredentialProviderPaymentProviderConfigurationInputFactory> WithProviderConfigurationInput<T1, T2, T3>(this CombinedResult<T1, T2, PaymentCredentialProviderFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.PaymentProviderConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProviderConfigurationInput(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PaymentCredentialProviderFactory, InnerPaymentCredentialProviderPaymentProviderConfigurationInputFactory> WithProviderConfigurationInput<T1, T2, T3>(this CombinedResult<T1, T2, T3, PaymentCredentialProviderFactory> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.PaymentProviderConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProviderConfigurationInput(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<PaymentCredentialProviderFactory, T1, T2, T3, T4, InnerPaymentCredentialProviderPaymentProviderConfigurationInputFactory> WithProviderConfigurationInput<T1, T2, T3, T4>(this CombinedResult<PaymentCredentialProviderFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.PaymentProviderConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProviderConfigurationInput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PaymentCredentialProviderFactory, T2, T3, T4, InnerPaymentCredentialProviderPaymentProviderConfigurationInputFactory> WithProviderConfigurationInput<T1, T2, T3, T4>(this CombinedResult<T1, PaymentCredentialProviderFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.PaymentProviderConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProviderConfigurationInput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PaymentCredentialProviderFactory, T3, T4, InnerPaymentCredentialProviderPaymentProviderConfigurationInputFactory> WithProviderConfigurationInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, PaymentCredentialProviderFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.PaymentProviderConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProviderConfigurationInput(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PaymentCredentialProviderFactory, T4, InnerPaymentCredentialProviderPaymentProviderConfigurationInputFactory> WithProviderConfigurationInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PaymentCredentialProviderFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.PaymentProviderConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProviderConfigurationInput(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, PaymentCredentialProviderFactory, InnerPaymentCredentialProviderPaymentProviderConfigurationInputFactory> WithProviderConfigurationInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PaymentCredentialProviderFactory> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.PaymentProviderConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProviderConfigurationInput(combinedResult.T5, subFactoryAction).T2);
}
