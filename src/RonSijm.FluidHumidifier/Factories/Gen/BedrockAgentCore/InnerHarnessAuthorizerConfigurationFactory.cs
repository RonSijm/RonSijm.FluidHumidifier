// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessAuthorizerConfigurationFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.AuthorizerConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.AuthorizerConfiguration>
{

    internal InnerHarnessCustomJWTAuthorizerConfigurationFactory CustomJWTAuthorizerFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.HarnessTypes.AuthorizerConfiguration Create()
    {
        var authorizerConfigurationResult = CreateAuthorizerConfiguration();
        factoryAction?.Invoke(authorizerConfigurationResult);

        return authorizerConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.AuthorizerConfiguration CreateAuthorizerConfiguration()
    {
        var authorizerConfigurationResult = new Humidifier.BedrockAgentCore.HarnessTypes.AuthorizerConfiguration();

        return authorizerConfigurationResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.HarnessTypes.AuthorizerConfiguration result)
    {
        base.CreateChildren(result);

        result.CustomJWTAuthorizer ??= CustomJWTAuthorizerFactory?.Build();
    }

} // End Of Class

public static class InnerHarnessAuthorizerConfigurationFactoryExtensions
{
    public static CombinedResult<InnerHarnessAuthorizerConfigurationFactory, InnerHarnessCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer(this InnerHarnessAuthorizerConfigurationFactory parentFactory, Action<Humidifier.BedrockAgentCore.HarnessTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null)
    {
        parentFactory.CustomJWTAuthorizerFactory = new InnerHarnessCustomJWTAuthorizerConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CustomJWTAuthorizerFactory);
    }

    public static CombinedResult<InnerHarnessAuthorizerConfigurationFactory, T1, InnerHarnessCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1>(this CombinedResult<InnerHarnessAuthorizerConfigurationFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessAuthorizerConfigurationFactory, InnerHarnessCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1>(this CombinedResult<T1, InnerHarnessAuthorizerConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessAuthorizerConfigurationFactory, T1, T2, InnerHarnessCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2>(this CombinedResult<InnerHarnessAuthorizerConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessAuthorizerConfigurationFactory, T2, InnerHarnessCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2>(this CombinedResult<T1, InnerHarnessAuthorizerConfigurationFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessAuthorizerConfigurationFactory, InnerHarnessCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2>(this CombinedResult<T1, T2, InnerHarnessAuthorizerConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessAuthorizerConfigurationFactory, T1, T2, T3, InnerHarnessCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2, T3>(this CombinedResult<InnerHarnessAuthorizerConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessAuthorizerConfigurationFactory, T2, T3, InnerHarnessCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2, T3>(this CombinedResult<T1, InnerHarnessAuthorizerConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessAuthorizerConfigurationFactory, T3, InnerHarnessCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2, T3>(this CombinedResult<T1, T2, InnerHarnessAuthorizerConfigurationFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHarnessAuthorizerConfigurationFactory, InnerHarnessCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerHarnessAuthorizerConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessAuthorizerConfigurationFactory, T1, T2, T3, T4, InnerHarnessCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2, T3, T4>(this CombinedResult<InnerHarnessAuthorizerConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessAuthorizerConfigurationFactory, T2, T3, T4, InnerHarnessCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2, T3, T4>(this CombinedResult<T1, InnerHarnessAuthorizerConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessAuthorizerConfigurationFactory, T3, T4, InnerHarnessCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerHarnessAuthorizerConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHarnessAuthorizerConfigurationFactory, T4, InnerHarnessCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerHarnessAuthorizerConfigurationFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerHarnessAuthorizerConfigurationFactory, InnerHarnessCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerHarnessAuthorizerConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T5, subFactoryAction).T2);
}
