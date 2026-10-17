// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class OAuth2CredentialProviderFactory(string resourceName = null, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProvider> factoryAction = null) : ResourceFactory<Humidifier.BedrockAgentCore.OAuth2CredentialProvider>(resourceName)
{

    internal InnerOAuth2CredentialProviderOauth2ProviderConfigInputFactory Oauth2ProviderConfigInputFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.OAuth2CredentialProvider Create()
    {
        var oAuth2CredentialProviderResult = CreateOAuth2CredentialProvider();
        factoryAction?.Invoke(oAuth2CredentialProviderResult);

        return oAuth2CredentialProviderResult;
    }

    private Humidifier.BedrockAgentCore.OAuth2CredentialProvider CreateOAuth2CredentialProvider()
    {
        var oAuth2CredentialProviderResult = new Humidifier.BedrockAgentCore.OAuth2CredentialProvider
        {
            GivenName = InputResourceName,
        };

        return oAuth2CredentialProviderResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.OAuth2CredentialProvider result)
    {
        base.CreateChildren(result);

        result.Oauth2ProviderConfigInput ??= Oauth2ProviderConfigInputFactory?.Build();
    }

} // End Of Class

public static class OAuth2CredentialProviderFactoryExtensions
{
    public static CombinedResult<OAuth2CredentialProviderFactory, InnerOAuth2CredentialProviderOauth2ProviderConfigInputFactory> WithOauth2ProviderConfigInput(this OAuth2CredentialProviderFactory parentFactory, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2ProviderConfigInput> subFactoryAction = null)
    {
        parentFactory.Oauth2ProviderConfigInputFactory = new InnerOAuth2CredentialProviderOauth2ProviderConfigInputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.Oauth2ProviderConfigInputFactory);
    }

    public static CombinedResult<OAuth2CredentialProviderFactory, T1, InnerOAuth2CredentialProviderOauth2ProviderConfigInputFactory> WithOauth2ProviderConfigInput<T1>(this CombinedResult<OAuth2CredentialProviderFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2ProviderConfigInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithOauth2ProviderConfigInput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OAuth2CredentialProviderFactory, InnerOAuth2CredentialProviderOauth2ProviderConfigInputFactory> WithOauth2ProviderConfigInput<T1>(this CombinedResult<T1, OAuth2CredentialProviderFactory> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2ProviderConfigInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithOauth2ProviderConfigInput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<OAuth2CredentialProviderFactory, T1, T2, InnerOAuth2CredentialProviderOauth2ProviderConfigInputFactory> WithOauth2ProviderConfigInput<T1, T2>(this CombinedResult<OAuth2CredentialProviderFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2ProviderConfigInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOauth2ProviderConfigInput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OAuth2CredentialProviderFactory, T2, InnerOAuth2CredentialProviderOauth2ProviderConfigInputFactory> WithOauth2ProviderConfigInput<T1, T2>(this CombinedResult<T1, OAuth2CredentialProviderFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2ProviderConfigInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOauth2ProviderConfigInput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, OAuth2CredentialProviderFactory, InnerOAuth2CredentialProviderOauth2ProviderConfigInputFactory> WithOauth2ProviderConfigInput<T1, T2>(this CombinedResult<T1, T2, OAuth2CredentialProviderFactory> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2ProviderConfigInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOauth2ProviderConfigInput(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<OAuth2CredentialProviderFactory, T1, T2, T3, InnerOAuth2CredentialProviderOauth2ProviderConfigInputFactory> WithOauth2ProviderConfigInput<T1, T2, T3>(this CombinedResult<OAuth2CredentialProviderFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2ProviderConfigInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOauth2ProviderConfigInput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OAuth2CredentialProviderFactory, T2, T3, InnerOAuth2CredentialProviderOauth2ProviderConfigInputFactory> WithOauth2ProviderConfigInput<T1, T2, T3>(this CombinedResult<T1, OAuth2CredentialProviderFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2ProviderConfigInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOauth2ProviderConfigInput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, OAuth2CredentialProviderFactory, T3, InnerOAuth2CredentialProviderOauth2ProviderConfigInputFactory> WithOauth2ProviderConfigInput<T1, T2, T3>(this CombinedResult<T1, T2, OAuth2CredentialProviderFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2ProviderConfigInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOauth2ProviderConfigInput(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, OAuth2CredentialProviderFactory, InnerOAuth2CredentialProviderOauth2ProviderConfigInputFactory> WithOauth2ProviderConfigInput<T1, T2, T3>(this CombinedResult<T1, T2, T3, OAuth2CredentialProviderFactory> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2ProviderConfigInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOauth2ProviderConfigInput(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<OAuth2CredentialProviderFactory, T1, T2, T3, T4, InnerOAuth2CredentialProviderOauth2ProviderConfigInputFactory> WithOauth2ProviderConfigInput<T1, T2, T3, T4>(this CombinedResult<OAuth2CredentialProviderFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2ProviderConfigInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOauth2ProviderConfigInput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OAuth2CredentialProviderFactory, T2, T3, T4, InnerOAuth2CredentialProviderOauth2ProviderConfigInputFactory> WithOauth2ProviderConfigInput<T1, T2, T3, T4>(this CombinedResult<T1, OAuth2CredentialProviderFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2ProviderConfigInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOauth2ProviderConfigInput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, OAuth2CredentialProviderFactory, T3, T4, InnerOAuth2CredentialProviderOauth2ProviderConfigInputFactory> WithOauth2ProviderConfigInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, OAuth2CredentialProviderFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2ProviderConfigInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOauth2ProviderConfigInput(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, OAuth2CredentialProviderFactory, T4, InnerOAuth2CredentialProviderOauth2ProviderConfigInputFactory> WithOauth2ProviderConfigInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, OAuth2CredentialProviderFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2ProviderConfigInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOauth2ProviderConfigInput(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, OAuth2CredentialProviderFactory, InnerOAuth2CredentialProviderOauth2ProviderConfigInputFactory> WithOauth2ProviderConfigInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, OAuth2CredentialProviderFactory> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2ProviderConfigInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOauth2ProviderConfigInput(combinedResult.T5, subFactoryAction).T2);
}
