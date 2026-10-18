// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerOAuth2CredentialProviderOnBehalfOfTokenExchangeConfigFactory(Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.OnBehalfOfTokenExchangeConfig> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.OnBehalfOfTokenExchangeConfig>
{

    internal InnerOAuth2CredentialProviderTokenExchangeGrantTypeConfigFactory TokenExchangeGrantTypeConfigFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.OnBehalfOfTokenExchangeConfig Create()
    {
        var onBehalfOfTokenExchangeConfigResult = CreateOnBehalfOfTokenExchangeConfig();
        factoryAction?.Invoke(onBehalfOfTokenExchangeConfigResult);

        return onBehalfOfTokenExchangeConfigResult;
    }

    private Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.OnBehalfOfTokenExchangeConfig CreateOnBehalfOfTokenExchangeConfig()
    {
        var onBehalfOfTokenExchangeConfigResult = new Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.OnBehalfOfTokenExchangeConfig();

        return onBehalfOfTokenExchangeConfigResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.OnBehalfOfTokenExchangeConfig result)
    {
        base.CreateChildren(result);

        result.TokenExchangeGrantTypeConfig ??= TokenExchangeGrantTypeConfigFactory?.Build();
    }

} // End Of Class

public static class InnerOAuth2CredentialProviderOnBehalfOfTokenExchangeConfigFactoryExtensions
{
    public static CombinedResult<InnerOAuth2CredentialProviderOnBehalfOfTokenExchangeConfigFactory, InnerOAuth2CredentialProviderTokenExchangeGrantTypeConfigFactory> WithTokenExchangeGrantTypeConfig(this InnerOAuth2CredentialProviderOnBehalfOfTokenExchangeConfigFactory parentFactory, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.TokenExchangeGrantTypeConfig> subFactoryAction = null)
    {
        parentFactory.TokenExchangeGrantTypeConfigFactory = new InnerOAuth2CredentialProviderTokenExchangeGrantTypeConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TokenExchangeGrantTypeConfigFactory);
    }

    public static CombinedResult<InnerOAuth2CredentialProviderOnBehalfOfTokenExchangeConfigFactory, T1, InnerOAuth2CredentialProviderTokenExchangeGrantTypeConfigFactory> WithTokenExchangeGrantTypeConfig<T1>(this CombinedResult<InnerOAuth2CredentialProviderOnBehalfOfTokenExchangeConfigFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.TokenExchangeGrantTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithTokenExchangeGrantTypeConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOAuth2CredentialProviderOnBehalfOfTokenExchangeConfigFactory, InnerOAuth2CredentialProviderTokenExchangeGrantTypeConfigFactory> WithTokenExchangeGrantTypeConfig<T1>(this CombinedResult<T1, InnerOAuth2CredentialProviderOnBehalfOfTokenExchangeConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.TokenExchangeGrantTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithTokenExchangeGrantTypeConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerOAuth2CredentialProviderOnBehalfOfTokenExchangeConfigFactory, T1, T2, InnerOAuth2CredentialProviderTokenExchangeGrantTypeConfigFactory> WithTokenExchangeGrantTypeConfig<T1, T2>(this CombinedResult<InnerOAuth2CredentialProviderOnBehalfOfTokenExchangeConfigFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.TokenExchangeGrantTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTokenExchangeGrantTypeConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOAuth2CredentialProviderOnBehalfOfTokenExchangeConfigFactory, T2, InnerOAuth2CredentialProviderTokenExchangeGrantTypeConfigFactory> WithTokenExchangeGrantTypeConfig<T1, T2>(this CombinedResult<T1, InnerOAuth2CredentialProviderOnBehalfOfTokenExchangeConfigFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.TokenExchangeGrantTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTokenExchangeGrantTypeConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOAuth2CredentialProviderOnBehalfOfTokenExchangeConfigFactory, InnerOAuth2CredentialProviderTokenExchangeGrantTypeConfigFactory> WithTokenExchangeGrantTypeConfig<T1, T2>(this CombinedResult<T1, T2, InnerOAuth2CredentialProviderOnBehalfOfTokenExchangeConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.TokenExchangeGrantTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTokenExchangeGrantTypeConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerOAuth2CredentialProviderOnBehalfOfTokenExchangeConfigFactory, T1, T2, T3, InnerOAuth2CredentialProviderTokenExchangeGrantTypeConfigFactory> WithTokenExchangeGrantTypeConfig<T1, T2, T3>(this CombinedResult<InnerOAuth2CredentialProviderOnBehalfOfTokenExchangeConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.TokenExchangeGrantTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTokenExchangeGrantTypeConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOAuth2CredentialProviderOnBehalfOfTokenExchangeConfigFactory, T2, T3, InnerOAuth2CredentialProviderTokenExchangeGrantTypeConfigFactory> WithTokenExchangeGrantTypeConfig<T1, T2, T3>(this CombinedResult<T1, InnerOAuth2CredentialProviderOnBehalfOfTokenExchangeConfigFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.TokenExchangeGrantTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTokenExchangeGrantTypeConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOAuth2CredentialProviderOnBehalfOfTokenExchangeConfigFactory, T3, InnerOAuth2CredentialProviderTokenExchangeGrantTypeConfigFactory> WithTokenExchangeGrantTypeConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerOAuth2CredentialProviderOnBehalfOfTokenExchangeConfigFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.TokenExchangeGrantTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTokenExchangeGrantTypeConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOAuth2CredentialProviderOnBehalfOfTokenExchangeConfigFactory, InnerOAuth2CredentialProviderTokenExchangeGrantTypeConfigFactory> WithTokenExchangeGrantTypeConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOAuth2CredentialProviderOnBehalfOfTokenExchangeConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.TokenExchangeGrantTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTokenExchangeGrantTypeConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerOAuth2CredentialProviderOnBehalfOfTokenExchangeConfigFactory, T1, T2, T3, T4, InnerOAuth2CredentialProviderTokenExchangeGrantTypeConfigFactory> WithTokenExchangeGrantTypeConfig<T1, T2, T3, T4>(this CombinedResult<InnerOAuth2CredentialProviderOnBehalfOfTokenExchangeConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.TokenExchangeGrantTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTokenExchangeGrantTypeConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOAuth2CredentialProviderOnBehalfOfTokenExchangeConfigFactory, T2, T3, T4, InnerOAuth2CredentialProviderTokenExchangeGrantTypeConfigFactory> WithTokenExchangeGrantTypeConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerOAuth2CredentialProviderOnBehalfOfTokenExchangeConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.TokenExchangeGrantTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTokenExchangeGrantTypeConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOAuth2CredentialProviderOnBehalfOfTokenExchangeConfigFactory, T3, T4, InnerOAuth2CredentialProviderTokenExchangeGrantTypeConfigFactory> WithTokenExchangeGrantTypeConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOAuth2CredentialProviderOnBehalfOfTokenExchangeConfigFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.TokenExchangeGrantTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTokenExchangeGrantTypeConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOAuth2CredentialProviderOnBehalfOfTokenExchangeConfigFactory, T4, InnerOAuth2CredentialProviderTokenExchangeGrantTypeConfigFactory> WithTokenExchangeGrantTypeConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOAuth2CredentialProviderOnBehalfOfTokenExchangeConfigFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.TokenExchangeGrantTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTokenExchangeGrantTypeConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerOAuth2CredentialProviderOnBehalfOfTokenExchangeConfigFactory, InnerOAuth2CredentialProviderTokenExchangeGrantTypeConfigFactory> WithTokenExchangeGrantTypeConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOAuth2CredentialProviderOnBehalfOfTokenExchangeConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.TokenExchangeGrantTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTokenExchangeGrantTypeConfig(combinedResult.T5, subFactoryAction).T2);
}
