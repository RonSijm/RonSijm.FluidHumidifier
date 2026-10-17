// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerOAuth2CredentialProviderGithubOauth2ProviderConfigInputFactory(Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.GithubOauth2ProviderConfigInput> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.GithubOauth2ProviderConfigInput>
{

    internal InnerOAuth2CredentialProviderSecretReferenceFactory ClientSecretConfigFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.GithubOauth2ProviderConfigInput Create()
    {
        var githubOauth2ProviderConfigInputResult = CreateGithubOauth2ProviderConfigInput();
        factoryAction?.Invoke(githubOauth2ProviderConfigInputResult);

        return githubOauth2ProviderConfigInputResult;
    }

    private Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.GithubOauth2ProviderConfigInput CreateGithubOauth2ProviderConfigInput()
    {
        var githubOauth2ProviderConfigInputResult = new Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.GithubOauth2ProviderConfigInput();

        return githubOauth2ProviderConfigInputResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.GithubOauth2ProviderConfigInput result)
    {
        base.CreateChildren(result);

        result.ClientSecretConfig ??= ClientSecretConfigFactory?.Build();
    }

} // End Of Class

public static class InnerOAuth2CredentialProviderGithubOauth2ProviderConfigInputFactoryExtensions
{
    public static CombinedResult<InnerOAuth2CredentialProviderGithubOauth2ProviderConfigInputFactory, InnerOAuth2CredentialProviderSecretReferenceFactory> WithClientSecretConfig(this InnerOAuth2CredentialProviderGithubOauth2ProviderConfigInputFactory parentFactory, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference> subFactoryAction = null)
    {
        parentFactory.ClientSecretConfigFactory = new InnerOAuth2CredentialProviderSecretReferenceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ClientSecretConfigFactory);
    }

    public static CombinedResult<InnerOAuth2CredentialProviderGithubOauth2ProviderConfigInputFactory, T1, InnerOAuth2CredentialProviderSecretReferenceFactory> WithClientSecretConfig<T1>(this CombinedResult<InnerOAuth2CredentialProviderGithubOauth2ProviderConfigInputFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, WithClientSecretConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOAuth2CredentialProviderGithubOauth2ProviderConfigInputFactory, InnerOAuth2CredentialProviderSecretReferenceFactory> WithClientSecretConfig<T1>(this CombinedResult<T1, InnerOAuth2CredentialProviderGithubOauth2ProviderConfigInputFactory> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, WithClientSecretConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerOAuth2CredentialProviderGithubOauth2ProviderConfigInputFactory, T1, T2, InnerOAuth2CredentialProviderSecretReferenceFactory> WithClientSecretConfig<T1, T2>(this CombinedResult<InnerOAuth2CredentialProviderGithubOauth2ProviderConfigInputFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClientSecretConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOAuth2CredentialProviderGithubOauth2ProviderConfigInputFactory, T2, InnerOAuth2CredentialProviderSecretReferenceFactory> WithClientSecretConfig<T1, T2>(this CombinedResult<T1, InnerOAuth2CredentialProviderGithubOauth2ProviderConfigInputFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClientSecretConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOAuth2CredentialProviderGithubOauth2ProviderConfigInputFactory, InnerOAuth2CredentialProviderSecretReferenceFactory> WithClientSecretConfig<T1, T2>(this CombinedResult<T1, T2, InnerOAuth2CredentialProviderGithubOauth2ProviderConfigInputFactory> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClientSecretConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerOAuth2CredentialProviderGithubOauth2ProviderConfigInputFactory, T1, T2, T3, InnerOAuth2CredentialProviderSecretReferenceFactory> WithClientSecretConfig<T1, T2, T3>(this CombinedResult<InnerOAuth2CredentialProviderGithubOauth2ProviderConfigInputFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientSecretConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOAuth2CredentialProviderGithubOauth2ProviderConfigInputFactory, T2, T3, InnerOAuth2CredentialProviderSecretReferenceFactory> WithClientSecretConfig<T1, T2, T3>(this CombinedResult<T1, InnerOAuth2CredentialProviderGithubOauth2ProviderConfigInputFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientSecretConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOAuth2CredentialProviderGithubOauth2ProviderConfigInputFactory, T3, InnerOAuth2CredentialProviderSecretReferenceFactory> WithClientSecretConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerOAuth2CredentialProviderGithubOauth2ProviderConfigInputFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientSecretConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOAuth2CredentialProviderGithubOauth2ProviderConfigInputFactory, InnerOAuth2CredentialProviderSecretReferenceFactory> WithClientSecretConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOAuth2CredentialProviderGithubOauth2ProviderConfigInputFactory> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientSecretConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerOAuth2CredentialProviderGithubOauth2ProviderConfigInputFactory, T1, T2, T3, T4, InnerOAuth2CredentialProviderSecretReferenceFactory> WithClientSecretConfig<T1, T2, T3, T4>(this CombinedResult<InnerOAuth2CredentialProviderGithubOauth2ProviderConfigInputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientSecretConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOAuth2CredentialProviderGithubOauth2ProviderConfigInputFactory, T2, T3, T4, InnerOAuth2CredentialProviderSecretReferenceFactory> WithClientSecretConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerOAuth2CredentialProviderGithubOauth2ProviderConfigInputFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientSecretConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOAuth2CredentialProviderGithubOauth2ProviderConfigInputFactory, T3, T4, InnerOAuth2CredentialProviderSecretReferenceFactory> WithClientSecretConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOAuth2CredentialProviderGithubOauth2ProviderConfigInputFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientSecretConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOAuth2CredentialProviderGithubOauth2ProviderConfigInputFactory, T4, InnerOAuth2CredentialProviderSecretReferenceFactory> WithClientSecretConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOAuth2CredentialProviderGithubOauth2ProviderConfigInputFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientSecretConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerOAuth2CredentialProviderGithubOauth2ProviderConfigInputFactory, InnerOAuth2CredentialProviderSecretReferenceFactory> WithClientSecretConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOAuth2CredentialProviderGithubOauth2ProviderConfigInputFactory> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientSecretConfig(combinedResult.T5, subFactoryAction).T2);
}
