// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerOAuth2CredentialProviderOauth2DiscoveryFactory(Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2Discovery> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2Discovery>
{

    internal InnerOAuth2CredentialProviderOauth2AuthorizationServerMetadataFactory AuthorizationServerMetadataFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2Discovery Create()
    {
        var oauth2DiscoveryResult = CreateOauth2Discovery();
        factoryAction?.Invoke(oauth2DiscoveryResult);

        return oauth2DiscoveryResult;
    }

    private Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2Discovery CreateOauth2Discovery()
    {
        var oauth2DiscoveryResult = new Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2Discovery();

        return oauth2DiscoveryResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2Discovery result)
    {
        base.CreateChildren(result);

        result.AuthorizationServerMetadata ??= AuthorizationServerMetadataFactory?.Build();
    }

} // End Of Class

public static class InnerOAuth2CredentialProviderOauth2DiscoveryFactoryExtensions
{
    public static CombinedResult<InnerOAuth2CredentialProviderOauth2DiscoveryFactory, InnerOAuth2CredentialProviderOauth2AuthorizationServerMetadataFactory> WithAuthorizationServerMetadata(this InnerOAuth2CredentialProviderOauth2DiscoveryFactory parentFactory, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2AuthorizationServerMetadata> subFactoryAction = null)
    {
        parentFactory.AuthorizationServerMetadataFactory = new InnerOAuth2CredentialProviderOauth2AuthorizationServerMetadataFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AuthorizationServerMetadataFactory);
    }

    public static CombinedResult<InnerOAuth2CredentialProviderOauth2DiscoveryFactory, T1, InnerOAuth2CredentialProviderOauth2AuthorizationServerMetadataFactory> WithAuthorizationServerMetadata<T1>(this CombinedResult<InnerOAuth2CredentialProviderOauth2DiscoveryFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2AuthorizationServerMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthorizationServerMetadata(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOAuth2CredentialProviderOauth2DiscoveryFactory, InnerOAuth2CredentialProviderOauth2AuthorizationServerMetadataFactory> WithAuthorizationServerMetadata<T1>(this CombinedResult<T1, InnerOAuth2CredentialProviderOauth2DiscoveryFactory> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2AuthorizationServerMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthorizationServerMetadata(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerOAuth2CredentialProviderOauth2DiscoveryFactory, T1, T2, InnerOAuth2CredentialProviderOauth2AuthorizationServerMetadataFactory> WithAuthorizationServerMetadata<T1, T2>(this CombinedResult<InnerOAuth2CredentialProviderOauth2DiscoveryFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2AuthorizationServerMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationServerMetadata(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOAuth2CredentialProviderOauth2DiscoveryFactory, T2, InnerOAuth2CredentialProviderOauth2AuthorizationServerMetadataFactory> WithAuthorizationServerMetadata<T1, T2>(this CombinedResult<T1, InnerOAuth2CredentialProviderOauth2DiscoveryFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2AuthorizationServerMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationServerMetadata(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOAuth2CredentialProviderOauth2DiscoveryFactory, InnerOAuth2CredentialProviderOauth2AuthorizationServerMetadataFactory> WithAuthorizationServerMetadata<T1, T2>(this CombinedResult<T1, T2, InnerOAuth2CredentialProviderOauth2DiscoveryFactory> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2AuthorizationServerMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationServerMetadata(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerOAuth2CredentialProviderOauth2DiscoveryFactory, T1, T2, T3, InnerOAuth2CredentialProviderOauth2AuthorizationServerMetadataFactory> WithAuthorizationServerMetadata<T1, T2, T3>(this CombinedResult<InnerOAuth2CredentialProviderOauth2DiscoveryFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2AuthorizationServerMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationServerMetadata(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOAuth2CredentialProviderOauth2DiscoveryFactory, T2, T3, InnerOAuth2CredentialProviderOauth2AuthorizationServerMetadataFactory> WithAuthorizationServerMetadata<T1, T2, T3>(this CombinedResult<T1, InnerOAuth2CredentialProviderOauth2DiscoveryFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2AuthorizationServerMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationServerMetadata(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOAuth2CredentialProviderOauth2DiscoveryFactory, T3, InnerOAuth2CredentialProviderOauth2AuthorizationServerMetadataFactory> WithAuthorizationServerMetadata<T1, T2, T3>(this CombinedResult<T1, T2, InnerOAuth2CredentialProviderOauth2DiscoveryFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2AuthorizationServerMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationServerMetadata(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOAuth2CredentialProviderOauth2DiscoveryFactory, InnerOAuth2CredentialProviderOauth2AuthorizationServerMetadataFactory> WithAuthorizationServerMetadata<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOAuth2CredentialProviderOauth2DiscoveryFactory> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2AuthorizationServerMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationServerMetadata(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerOAuth2CredentialProviderOauth2DiscoveryFactory, T1, T2, T3, T4, InnerOAuth2CredentialProviderOauth2AuthorizationServerMetadataFactory> WithAuthorizationServerMetadata<T1, T2, T3, T4>(this CombinedResult<InnerOAuth2CredentialProviderOauth2DiscoveryFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2AuthorizationServerMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationServerMetadata(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOAuth2CredentialProviderOauth2DiscoveryFactory, T2, T3, T4, InnerOAuth2CredentialProviderOauth2AuthorizationServerMetadataFactory> WithAuthorizationServerMetadata<T1, T2, T3, T4>(this CombinedResult<T1, InnerOAuth2CredentialProviderOauth2DiscoveryFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2AuthorizationServerMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationServerMetadata(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOAuth2CredentialProviderOauth2DiscoveryFactory, T3, T4, InnerOAuth2CredentialProviderOauth2AuthorizationServerMetadataFactory> WithAuthorizationServerMetadata<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOAuth2CredentialProviderOauth2DiscoveryFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2AuthorizationServerMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationServerMetadata(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOAuth2CredentialProviderOauth2DiscoveryFactory, T4, InnerOAuth2CredentialProviderOauth2AuthorizationServerMetadataFactory> WithAuthorizationServerMetadata<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOAuth2CredentialProviderOauth2DiscoveryFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2AuthorizationServerMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationServerMetadata(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerOAuth2CredentialProviderOauth2DiscoveryFactory, InnerOAuth2CredentialProviderOauth2AuthorizationServerMetadataFactory> WithAuthorizationServerMetadata<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOAuth2CredentialProviderOauth2DiscoveryFactory> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2AuthorizationServerMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationServerMetadata(combinedResult.T5, subFactoryAction).T2);
}
