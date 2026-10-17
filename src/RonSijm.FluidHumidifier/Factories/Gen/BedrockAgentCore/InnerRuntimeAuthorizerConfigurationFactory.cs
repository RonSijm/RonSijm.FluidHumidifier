// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerRuntimeAuthorizerConfigurationFactory(Action<Humidifier.BedrockAgentCore.RuntimeTypes.AuthorizerConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.RuntimeTypes.AuthorizerConfiguration>
{

    internal InnerRuntimeCustomJWTAuthorizerConfigurationFactory CustomJWTAuthorizerFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.RuntimeTypes.AuthorizerConfiguration Create()
    {
        var authorizerConfigurationResult = CreateAuthorizerConfiguration();
        factoryAction?.Invoke(authorizerConfigurationResult);

        return authorizerConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.RuntimeTypes.AuthorizerConfiguration CreateAuthorizerConfiguration()
    {
        var authorizerConfigurationResult = new Humidifier.BedrockAgentCore.RuntimeTypes.AuthorizerConfiguration();

        return authorizerConfigurationResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.RuntimeTypes.AuthorizerConfiguration result)
    {
        base.CreateChildren(result);

        result.CustomJWTAuthorizer ??= CustomJWTAuthorizerFactory?.Build();
    }

} // End Of Class

public static class InnerRuntimeAuthorizerConfigurationFactoryExtensions
{
    public static CombinedResult<InnerRuntimeAuthorizerConfigurationFactory, InnerRuntimeCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer(this InnerRuntimeAuthorizerConfigurationFactory parentFactory, Action<Humidifier.BedrockAgentCore.RuntimeTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null)
    {
        parentFactory.CustomJWTAuthorizerFactory = new InnerRuntimeCustomJWTAuthorizerConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CustomJWTAuthorizerFactory);
    }

    public static CombinedResult<InnerRuntimeAuthorizerConfigurationFactory, T1, InnerRuntimeCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1>(this CombinedResult<InnerRuntimeAuthorizerConfigurationFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRuntimeAuthorizerConfigurationFactory, InnerRuntimeCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1>(this CombinedResult<T1, InnerRuntimeAuthorizerConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRuntimeAuthorizerConfigurationFactory, T1, T2, InnerRuntimeCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2>(this CombinedResult<InnerRuntimeAuthorizerConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRuntimeAuthorizerConfigurationFactory, T2, InnerRuntimeCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2>(this CombinedResult<T1, InnerRuntimeAuthorizerConfigurationFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRuntimeAuthorizerConfigurationFactory, InnerRuntimeCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2>(this CombinedResult<T1, T2, InnerRuntimeAuthorizerConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRuntimeAuthorizerConfigurationFactory, T1, T2, T3, InnerRuntimeCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2, T3>(this CombinedResult<InnerRuntimeAuthorizerConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRuntimeAuthorizerConfigurationFactory, T2, T3, InnerRuntimeCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2, T3>(this CombinedResult<T1, InnerRuntimeAuthorizerConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRuntimeAuthorizerConfigurationFactory, T3, InnerRuntimeCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2, T3>(this CombinedResult<T1, T2, InnerRuntimeAuthorizerConfigurationFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRuntimeAuthorizerConfigurationFactory, InnerRuntimeCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRuntimeAuthorizerConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRuntimeAuthorizerConfigurationFactory, T1, T2, T3, T4, InnerRuntimeCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2, T3, T4>(this CombinedResult<InnerRuntimeAuthorizerConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRuntimeAuthorizerConfigurationFactory, T2, T3, T4, InnerRuntimeCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2, T3, T4>(this CombinedResult<T1, InnerRuntimeAuthorizerConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRuntimeAuthorizerConfigurationFactory, T3, T4, InnerRuntimeCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRuntimeAuthorizerConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRuntimeAuthorizerConfigurationFactory, T4, InnerRuntimeCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRuntimeAuthorizerConfigurationFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRuntimeAuthorizerConfigurationFactory, InnerRuntimeCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRuntimeAuthorizerConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T5, subFactoryAction).T2);
}
