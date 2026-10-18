// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessCustomJWTAuthorizerConfigurationFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.CustomJWTAuthorizerConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.CustomJWTAuthorizerConfiguration>
{

    internal InnerHarnessPrivateEndpointFactory PrivateEndpointFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.HarnessTypes.CustomJWTAuthorizerConfiguration Create()
    {
        var customJWTAuthorizerConfigurationResult = CreateCustomJWTAuthorizerConfiguration();
        factoryAction?.Invoke(customJWTAuthorizerConfigurationResult);

        return customJWTAuthorizerConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.CustomJWTAuthorizerConfiguration CreateCustomJWTAuthorizerConfiguration()
    {
        var customJWTAuthorizerConfigurationResult = new Humidifier.BedrockAgentCore.HarnessTypes.CustomJWTAuthorizerConfiguration();

        return customJWTAuthorizerConfigurationResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.HarnessTypes.CustomJWTAuthorizerConfiguration result)
    {
        base.CreateChildren(result);

        result.PrivateEndpoint ??= PrivateEndpointFactory?.Build();
    }

} // End Of Class

public static class InnerHarnessCustomJWTAuthorizerConfigurationFactoryExtensions
{
    public static CombinedResult<InnerHarnessCustomJWTAuthorizerConfigurationFactory, InnerHarnessPrivateEndpointFactory> WithPrivateEndpoint(this InnerHarnessCustomJWTAuthorizerConfigurationFactory parentFactory, Action<Humidifier.BedrockAgentCore.HarnessTypes.PrivateEndpoint> subFactoryAction = null)
    {
        parentFactory.PrivateEndpointFactory = new InnerHarnessPrivateEndpointFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PrivateEndpointFactory);
    }

    public static CombinedResult<InnerHarnessCustomJWTAuthorizerConfigurationFactory, T1, InnerHarnessPrivateEndpointFactory> WithPrivateEndpoint<T1>(this CombinedResult<InnerHarnessCustomJWTAuthorizerConfigurationFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.PrivateEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrivateEndpoint(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessCustomJWTAuthorizerConfigurationFactory, InnerHarnessPrivateEndpointFactory> WithPrivateEndpoint<T1>(this CombinedResult<T1, InnerHarnessCustomJWTAuthorizerConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.PrivateEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrivateEndpoint(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessCustomJWTAuthorizerConfigurationFactory, T1, T2, InnerHarnessPrivateEndpointFactory> WithPrivateEndpoint<T1, T2>(this CombinedResult<InnerHarnessCustomJWTAuthorizerConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.PrivateEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrivateEndpoint(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessCustomJWTAuthorizerConfigurationFactory, T2, InnerHarnessPrivateEndpointFactory> WithPrivateEndpoint<T1, T2>(this CombinedResult<T1, InnerHarnessCustomJWTAuthorizerConfigurationFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.PrivateEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrivateEndpoint(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessCustomJWTAuthorizerConfigurationFactory, InnerHarnessPrivateEndpointFactory> WithPrivateEndpoint<T1, T2>(this CombinedResult<T1, T2, InnerHarnessCustomJWTAuthorizerConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.PrivateEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrivateEndpoint(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessCustomJWTAuthorizerConfigurationFactory, T1, T2, T3, InnerHarnessPrivateEndpointFactory> WithPrivateEndpoint<T1, T2, T3>(this CombinedResult<InnerHarnessCustomJWTAuthorizerConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.PrivateEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateEndpoint(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessCustomJWTAuthorizerConfigurationFactory, T2, T3, InnerHarnessPrivateEndpointFactory> WithPrivateEndpoint<T1, T2, T3>(this CombinedResult<T1, InnerHarnessCustomJWTAuthorizerConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.PrivateEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateEndpoint(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessCustomJWTAuthorizerConfigurationFactory, T3, InnerHarnessPrivateEndpointFactory> WithPrivateEndpoint<T1, T2, T3>(this CombinedResult<T1, T2, InnerHarnessCustomJWTAuthorizerConfigurationFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.PrivateEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateEndpoint(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHarnessCustomJWTAuthorizerConfigurationFactory, InnerHarnessPrivateEndpointFactory> WithPrivateEndpoint<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerHarnessCustomJWTAuthorizerConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.PrivateEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateEndpoint(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessCustomJWTAuthorizerConfigurationFactory, T1, T2, T3, T4, InnerHarnessPrivateEndpointFactory> WithPrivateEndpoint<T1, T2, T3, T4>(this CombinedResult<InnerHarnessCustomJWTAuthorizerConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.PrivateEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateEndpoint(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessCustomJWTAuthorizerConfigurationFactory, T2, T3, T4, InnerHarnessPrivateEndpointFactory> WithPrivateEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, InnerHarnessCustomJWTAuthorizerConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.PrivateEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateEndpoint(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessCustomJWTAuthorizerConfigurationFactory, T3, T4, InnerHarnessPrivateEndpointFactory> WithPrivateEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerHarnessCustomJWTAuthorizerConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.PrivateEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateEndpoint(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHarnessCustomJWTAuthorizerConfigurationFactory, T4, InnerHarnessPrivateEndpointFactory> WithPrivateEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerHarnessCustomJWTAuthorizerConfigurationFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.PrivateEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateEndpoint(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerHarnessCustomJWTAuthorizerConfigurationFactory, InnerHarnessPrivateEndpointFactory> WithPrivateEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerHarnessCustomJWTAuthorizerConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.PrivateEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateEndpoint(combinedResult.T5, subFactoryAction).T2);
}
