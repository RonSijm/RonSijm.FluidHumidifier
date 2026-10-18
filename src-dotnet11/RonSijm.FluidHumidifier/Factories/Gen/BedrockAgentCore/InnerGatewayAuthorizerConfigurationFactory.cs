// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayAuthorizerConfigurationFactory(Action<Humidifier.BedrockAgentCore.GatewayTypes.AuthorizerConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTypes.AuthorizerConfiguration>
{

    internal InnerGatewayCustomJWTAuthorizerConfigurationFactory CustomJWTAuthorizerFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.GatewayTypes.AuthorizerConfiguration Create()
    {
        var authorizerConfigurationResult = CreateAuthorizerConfiguration();
        factoryAction?.Invoke(authorizerConfigurationResult);

        return authorizerConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTypes.AuthorizerConfiguration CreateAuthorizerConfiguration()
    {
        var authorizerConfigurationResult = new Humidifier.BedrockAgentCore.GatewayTypes.AuthorizerConfiguration();

        return authorizerConfigurationResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.GatewayTypes.AuthorizerConfiguration result)
    {
        base.CreateChildren(result);

        result.CustomJWTAuthorizer ??= CustomJWTAuthorizerFactory?.Build();
    }

} // End Of Class

public static class InnerGatewayAuthorizerConfigurationFactoryExtensions
{
    public static CombinedResult<InnerGatewayAuthorizerConfigurationFactory, InnerGatewayCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer(this InnerGatewayAuthorizerConfigurationFactory parentFactory, Action<Humidifier.BedrockAgentCore.GatewayTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null)
    {
        parentFactory.CustomJWTAuthorizerFactory = new InnerGatewayCustomJWTAuthorizerConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CustomJWTAuthorizerFactory);
    }

    public static CombinedResult<InnerGatewayAuthorizerConfigurationFactory, T1, InnerGatewayCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1>(this CombinedResult<InnerGatewayAuthorizerConfigurationFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayAuthorizerConfigurationFactory, InnerGatewayCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1>(this CombinedResult<T1, InnerGatewayAuthorizerConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayAuthorizerConfigurationFactory, T1, T2, InnerGatewayCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2>(this CombinedResult<InnerGatewayAuthorizerConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayAuthorizerConfigurationFactory, T2, InnerGatewayCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2>(this CombinedResult<T1, InnerGatewayAuthorizerConfigurationFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayAuthorizerConfigurationFactory, InnerGatewayCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2>(this CombinedResult<T1, T2, InnerGatewayAuthorizerConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayAuthorizerConfigurationFactory, T1, T2, T3, InnerGatewayCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2, T3>(this CombinedResult<InnerGatewayAuthorizerConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayAuthorizerConfigurationFactory, T2, T3, InnerGatewayCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2, T3>(this CombinedResult<T1, InnerGatewayAuthorizerConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayAuthorizerConfigurationFactory, T3, InnerGatewayCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayAuthorizerConfigurationFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayAuthorizerConfigurationFactory, InnerGatewayCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayAuthorizerConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayAuthorizerConfigurationFactory, T1, T2, T3, T4, InnerGatewayCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2, T3, T4>(this CombinedResult<InnerGatewayAuthorizerConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayAuthorizerConfigurationFactory, T2, T3, T4, InnerGatewayCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayAuthorizerConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayAuthorizerConfigurationFactory, T3, T4, InnerGatewayCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayAuthorizerConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayAuthorizerConfigurationFactory, T4, InnerGatewayCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayAuthorizerConfigurationFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayAuthorizerConfigurationFactory, InnerGatewayCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayAuthorizerConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T5, subFactoryAction).T2);
}
