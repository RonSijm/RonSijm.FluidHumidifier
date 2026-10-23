// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerPaymentManagerAuthorizerConfigurationFactory(Action<Humidifier.BedrockAgentCore.PaymentManagerTypes.AuthorizerConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.PaymentManagerTypes.AuthorizerConfiguration>
{

    internal InnerPaymentManagerCustomJWTAuthorizerFactory CustomJWTAuthorizerFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.PaymentManagerTypes.AuthorizerConfiguration Create()
    {
        var authorizerConfigurationResult = CreateAuthorizerConfiguration();
        factoryAction?.Invoke(authorizerConfigurationResult);

        return authorizerConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.PaymentManagerTypes.AuthorizerConfiguration CreateAuthorizerConfiguration()
    {
        var authorizerConfigurationResult = new Humidifier.BedrockAgentCore.PaymentManagerTypes.AuthorizerConfiguration();

        return authorizerConfigurationResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.PaymentManagerTypes.AuthorizerConfiguration result)
    {
        base.CreateChildren(result);

        result.CustomJWTAuthorizer ??= CustomJWTAuthorizerFactory?.Build();
    }

} // End Of Class

public static class InnerPaymentManagerAuthorizerConfigurationFactoryExtensions
{
    public static CombinedResult<InnerPaymentManagerAuthorizerConfigurationFactory, InnerPaymentManagerCustomJWTAuthorizerFactory> WithCustomJWTAuthorizer(this InnerPaymentManagerAuthorizerConfigurationFactory parentFactory, Action<Humidifier.BedrockAgentCore.PaymentManagerTypes.CustomJWTAuthorizer> subFactoryAction = null)
    {
        parentFactory.CustomJWTAuthorizerFactory = new InnerPaymentManagerCustomJWTAuthorizerFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CustomJWTAuthorizerFactory);
    }

    public static CombinedResult<InnerPaymentManagerAuthorizerConfigurationFactory, T1, InnerPaymentManagerCustomJWTAuthorizerFactory> WithCustomJWTAuthorizer<T1>(this CombinedResult<InnerPaymentManagerAuthorizerConfigurationFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentManagerTypes.CustomJWTAuthorizer> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPaymentManagerAuthorizerConfigurationFactory, InnerPaymentManagerCustomJWTAuthorizerFactory> WithCustomJWTAuthorizer<T1>(this CombinedResult<T1, InnerPaymentManagerAuthorizerConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentManagerTypes.CustomJWTAuthorizer> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerPaymentManagerAuthorizerConfigurationFactory, T1, T2, InnerPaymentManagerCustomJWTAuthorizerFactory> WithCustomJWTAuthorizer<T1, T2>(this CombinedResult<InnerPaymentManagerAuthorizerConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentManagerTypes.CustomJWTAuthorizer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPaymentManagerAuthorizerConfigurationFactory, T2, InnerPaymentManagerCustomJWTAuthorizerFactory> WithCustomJWTAuthorizer<T1, T2>(this CombinedResult<T1, InnerPaymentManagerAuthorizerConfigurationFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentManagerTypes.CustomJWTAuthorizer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPaymentManagerAuthorizerConfigurationFactory, InnerPaymentManagerCustomJWTAuthorizerFactory> WithCustomJWTAuthorizer<T1, T2>(this CombinedResult<T1, T2, InnerPaymentManagerAuthorizerConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentManagerTypes.CustomJWTAuthorizer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerPaymentManagerAuthorizerConfigurationFactory, T1, T2, T3, InnerPaymentManagerCustomJWTAuthorizerFactory> WithCustomJWTAuthorizer<T1, T2, T3>(this CombinedResult<InnerPaymentManagerAuthorizerConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentManagerTypes.CustomJWTAuthorizer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPaymentManagerAuthorizerConfigurationFactory, T2, T3, InnerPaymentManagerCustomJWTAuthorizerFactory> WithCustomJWTAuthorizer<T1, T2, T3>(this CombinedResult<T1, InnerPaymentManagerAuthorizerConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentManagerTypes.CustomJWTAuthorizer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPaymentManagerAuthorizerConfigurationFactory, T3, InnerPaymentManagerCustomJWTAuthorizerFactory> WithCustomJWTAuthorizer<T1, T2, T3>(this CombinedResult<T1, T2, InnerPaymentManagerAuthorizerConfigurationFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentManagerTypes.CustomJWTAuthorizer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPaymentManagerAuthorizerConfigurationFactory, InnerPaymentManagerCustomJWTAuthorizerFactory> WithCustomJWTAuthorizer<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPaymentManagerAuthorizerConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentManagerTypes.CustomJWTAuthorizer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerPaymentManagerAuthorizerConfigurationFactory, T1, T2, T3, T4, InnerPaymentManagerCustomJWTAuthorizerFactory> WithCustomJWTAuthorizer<T1, T2, T3, T4>(this CombinedResult<InnerPaymentManagerAuthorizerConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentManagerTypes.CustomJWTAuthorizer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPaymentManagerAuthorizerConfigurationFactory, T2, T3, T4, InnerPaymentManagerCustomJWTAuthorizerFactory> WithCustomJWTAuthorizer<T1, T2, T3, T4>(this CombinedResult<T1, InnerPaymentManagerAuthorizerConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentManagerTypes.CustomJWTAuthorizer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPaymentManagerAuthorizerConfigurationFactory, T3, T4, InnerPaymentManagerCustomJWTAuthorizerFactory> WithCustomJWTAuthorizer<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPaymentManagerAuthorizerConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentManagerTypes.CustomJWTAuthorizer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPaymentManagerAuthorizerConfigurationFactory, T4, InnerPaymentManagerCustomJWTAuthorizerFactory> WithCustomJWTAuthorizer<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPaymentManagerAuthorizerConfigurationFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentManagerTypes.CustomJWTAuthorizer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerPaymentManagerAuthorizerConfigurationFactory, InnerPaymentManagerCustomJWTAuthorizerFactory> WithCustomJWTAuthorizer<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPaymentManagerAuthorizerConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.PaymentManagerTypes.CustomJWTAuthorizer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T5, subFactoryAction).T2);
}
