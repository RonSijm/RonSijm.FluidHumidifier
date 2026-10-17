// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerOAuth2CredentialProviderMicrosoftOauth2ProviderConfigInputFactory(Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.MicrosoftOauth2ProviderConfigInput> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.MicrosoftOauth2ProviderConfigInput>
{

    internal InnerOAuth2CredentialProviderSecretReferenceFactory ClientSecretConfigFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.MicrosoftOauth2ProviderConfigInput Create()
    {
        var microsoftOauth2ProviderConfigInputResult = CreateMicrosoftOauth2ProviderConfigInput();
        factoryAction?.Invoke(microsoftOauth2ProviderConfigInputResult);

        return microsoftOauth2ProviderConfigInputResult;
    }

    private Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.MicrosoftOauth2ProviderConfigInput CreateMicrosoftOauth2ProviderConfigInput()
    {
        var microsoftOauth2ProviderConfigInputResult = new Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.MicrosoftOauth2ProviderConfigInput();

        return microsoftOauth2ProviderConfigInputResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.MicrosoftOauth2ProviderConfigInput result)
    {
        base.CreateChildren(result);

        result.ClientSecretConfig ??= ClientSecretConfigFactory?.Build();
    }

} // End Of Class

public static class InnerOAuth2CredentialProviderMicrosoftOauth2ProviderConfigInputFactoryExtensions
{
    public static CombinedResult<InnerOAuth2CredentialProviderMicrosoftOauth2ProviderConfigInputFactory, InnerOAuth2CredentialProviderSecretReferenceFactory> WithClientSecretConfig(this InnerOAuth2CredentialProviderMicrosoftOauth2ProviderConfigInputFactory parentFactory, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference> subFactoryAction = null)
    {
        parentFactory.ClientSecretConfigFactory = new InnerOAuth2CredentialProviderSecretReferenceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ClientSecretConfigFactory);
    }

    public static CombinedResult<InnerOAuth2CredentialProviderMicrosoftOauth2ProviderConfigInputFactory, T1, InnerOAuth2CredentialProviderSecretReferenceFactory> WithClientSecretConfig<T1>(this CombinedResult<InnerOAuth2CredentialProviderMicrosoftOauth2ProviderConfigInputFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, WithClientSecretConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOAuth2CredentialProviderMicrosoftOauth2ProviderConfigInputFactory, InnerOAuth2CredentialProviderSecretReferenceFactory> WithClientSecretConfig<T1>(this CombinedResult<T1, InnerOAuth2CredentialProviderMicrosoftOauth2ProviderConfigInputFactory> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, WithClientSecretConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerOAuth2CredentialProviderMicrosoftOauth2ProviderConfigInputFactory, T1, T2, InnerOAuth2CredentialProviderSecretReferenceFactory> WithClientSecretConfig<T1, T2>(this CombinedResult<InnerOAuth2CredentialProviderMicrosoftOauth2ProviderConfigInputFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClientSecretConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOAuth2CredentialProviderMicrosoftOauth2ProviderConfigInputFactory, T2, InnerOAuth2CredentialProviderSecretReferenceFactory> WithClientSecretConfig<T1, T2>(this CombinedResult<T1, InnerOAuth2CredentialProviderMicrosoftOauth2ProviderConfigInputFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClientSecretConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOAuth2CredentialProviderMicrosoftOauth2ProviderConfigInputFactory, InnerOAuth2CredentialProviderSecretReferenceFactory> WithClientSecretConfig<T1, T2>(this CombinedResult<T1, T2, InnerOAuth2CredentialProviderMicrosoftOauth2ProviderConfigInputFactory> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClientSecretConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerOAuth2CredentialProviderMicrosoftOauth2ProviderConfigInputFactory, T1, T2, T3, InnerOAuth2CredentialProviderSecretReferenceFactory> WithClientSecretConfig<T1, T2, T3>(this CombinedResult<InnerOAuth2CredentialProviderMicrosoftOauth2ProviderConfigInputFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientSecretConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOAuth2CredentialProviderMicrosoftOauth2ProviderConfigInputFactory, T2, T3, InnerOAuth2CredentialProviderSecretReferenceFactory> WithClientSecretConfig<T1, T2, T3>(this CombinedResult<T1, InnerOAuth2CredentialProviderMicrosoftOauth2ProviderConfigInputFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientSecretConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOAuth2CredentialProviderMicrosoftOauth2ProviderConfigInputFactory, T3, InnerOAuth2CredentialProviderSecretReferenceFactory> WithClientSecretConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerOAuth2CredentialProviderMicrosoftOauth2ProviderConfigInputFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientSecretConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOAuth2CredentialProviderMicrosoftOauth2ProviderConfigInputFactory, InnerOAuth2CredentialProviderSecretReferenceFactory> WithClientSecretConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOAuth2CredentialProviderMicrosoftOauth2ProviderConfigInputFactory> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientSecretConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerOAuth2CredentialProviderMicrosoftOauth2ProviderConfigInputFactory, T1, T2, T3, T4, InnerOAuth2CredentialProviderSecretReferenceFactory> WithClientSecretConfig<T1, T2, T3, T4>(this CombinedResult<InnerOAuth2CredentialProviderMicrosoftOauth2ProviderConfigInputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientSecretConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOAuth2CredentialProviderMicrosoftOauth2ProviderConfigInputFactory, T2, T3, T4, InnerOAuth2CredentialProviderSecretReferenceFactory> WithClientSecretConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerOAuth2CredentialProviderMicrosoftOauth2ProviderConfigInputFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientSecretConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOAuth2CredentialProviderMicrosoftOauth2ProviderConfigInputFactory, T3, T4, InnerOAuth2CredentialProviderSecretReferenceFactory> WithClientSecretConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOAuth2CredentialProviderMicrosoftOauth2ProviderConfigInputFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientSecretConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOAuth2CredentialProviderMicrosoftOauth2ProviderConfigInputFactory, T4, InnerOAuth2CredentialProviderSecretReferenceFactory> WithClientSecretConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOAuth2CredentialProviderMicrosoftOauth2ProviderConfigInputFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientSecretConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerOAuth2CredentialProviderMicrosoftOauth2ProviderConfigInputFactory, InnerOAuth2CredentialProviderSecretReferenceFactory> WithClientSecretConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOAuth2CredentialProviderMicrosoftOauth2ProviderConfigInputFactory> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientSecretConfig(combinedResult.T5, subFactoryAction).T2);
}
