// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayCustomJWTAuthorizerConfigurationFactory(Action<Humidifier.BedrockAgentCore.GatewayTypes.CustomJWTAuthorizerConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTypes.CustomJWTAuthorizerConfiguration>
{

    internal InnerGatewayPrivateEndpointFactory PrivateEndpointFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.GatewayTypes.CustomJWTAuthorizerConfiguration Create()
    {
        var customJWTAuthorizerConfigurationResult = CreateCustomJWTAuthorizerConfiguration();
        factoryAction?.Invoke(customJWTAuthorizerConfigurationResult);

        return customJWTAuthorizerConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTypes.CustomJWTAuthorizerConfiguration CreateCustomJWTAuthorizerConfiguration()
    {
        var customJWTAuthorizerConfigurationResult = new Humidifier.BedrockAgentCore.GatewayTypes.CustomJWTAuthorizerConfiguration();

        return customJWTAuthorizerConfigurationResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.GatewayTypes.CustomJWTAuthorizerConfiguration result)
    {
        base.CreateChildren(result);

        result.PrivateEndpoint ??= PrivateEndpointFactory?.Build();
    }

} // End Of Class

public static class InnerGatewayCustomJWTAuthorizerConfigurationFactoryExtensions
{
    public static CombinedResult<InnerGatewayCustomJWTAuthorizerConfigurationFactory, InnerGatewayPrivateEndpointFactory> WithPrivateEndpoint(this InnerGatewayCustomJWTAuthorizerConfigurationFactory parentFactory, Action<Humidifier.BedrockAgentCore.GatewayTypes.PrivateEndpoint> subFactoryAction = null)
    {
        parentFactory.PrivateEndpointFactory = new InnerGatewayPrivateEndpointFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PrivateEndpointFactory);
    }

    public static CombinedResult<InnerGatewayCustomJWTAuthorizerConfigurationFactory, T1, InnerGatewayPrivateEndpointFactory> WithPrivateEndpoint<T1>(this CombinedResult<InnerGatewayCustomJWTAuthorizerConfigurationFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.PrivateEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrivateEndpoint(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayCustomJWTAuthorizerConfigurationFactory, InnerGatewayPrivateEndpointFactory> WithPrivateEndpoint<T1>(this CombinedResult<T1, InnerGatewayCustomJWTAuthorizerConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.PrivateEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrivateEndpoint(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayCustomJWTAuthorizerConfigurationFactory, T1, T2, InnerGatewayPrivateEndpointFactory> WithPrivateEndpoint<T1, T2>(this CombinedResult<InnerGatewayCustomJWTAuthorizerConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.PrivateEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrivateEndpoint(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayCustomJWTAuthorizerConfigurationFactory, T2, InnerGatewayPrivateEndpointFactory> WithPrivateEndpoint<T1, T2>(this CombinedResult<T1, InnerGatewayCustomJWTAuthorizerConfigurationFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.PrivateEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrivateEndpoint(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayCustomJWTAuthorizerConfigurationFactory, InnerGatewayPrivateEndpointFactory> WithPrivateEndpoint<T1, T2>(this CombinedResult<T1, T2, InnerGatewayCustomJWTAuthorizerConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.PrivateEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrivateEndpoint(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayCustomJWTAuthorizerConfigurationFactory, T1, T2, T3, InnerGatewayPrivateEndpointFactory> WithPrivateEndpoint<T1, T2, T3>(this CombinedResult<InnerGatewayCustomJWTAuthorizerConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.PrivateEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateEndpoint(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayCustomJWTAuthorizerConfigurationFactory, T2, T3, InnerGatewayPrivateEndpointFactory> WithPrivateEndpoint<T1, T2, T3>(this CombinedResult<T1, InnerGatewayCustomJWTAuthorizerConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.PrivateEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateEndpoint(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayCustomJWTAuthorizerConfigurationFactory, T3, InnerGatewayPrivateEndpointFactory> WithPrivateEndpoint<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayCustomJWTAuthorizerConfigurationFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.PrivateEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateEndpoint(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayCustomJWTAuthorizerConfigurationFactory, InnerGatewayPrivateEndpointFactory> WithPrivateEndpoint<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayCustomJWTAuthorizerConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.PrivateEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateEndpoint(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayCustomJWTAuthorizerConfigurationFactory, T1, T2, T3, T4, InnerGatewayPrivateEndpointFactory> WithPrivateEndpoint<T1, T2, T3, T4>(this CombinedResult<InnerGatewayCustomJWTAuthorizerConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.PrivateEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateEndpoint(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayCustomJWTAuthorizerConfigurationFactory, T2, T3, T4, InnerGatewayPrivateEndpointFactory> WithPrivateEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayCustomJWTAuthorizerConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.PrivateEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateEndpoint(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayCustomJWTAuthorizerConfigurationFactory, T3, T4, InnerGatewayPrivateEndpointFactory> WithPrivateEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayCustomJWTAuthorizerConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.PrivateEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateEndpoint(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayCustomJWTAuthorizerConfigurationFactory, T4, InnerGatewayPrivateEndpointFactory> WithPrivateEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayCustomJWTAuthorizerConfigurationFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.PrivateEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateEndpoint(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayCustomJWTAuthorizerConfigurationFactory, InnerGatewayPrivateEndpointFactory> WithPrivateEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayCustomJWTAuthorizerConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTypes.PrivateEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateEndpoint(combinedResult.T5, subFactoryAction).T2);
}
