// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerOAuth2CredentialProviderPrivateKeyJwtConfigFactory(Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateKeyJwtConfig> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateKeyJwtConfig>
{

    internal InnerOAuth2CredentialProviderPrivateKeySourceFactory PrivateKeySourceFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateKeyJwtConfig Create()
    {
        var privateKeyJwtConfigResult = CreatePrivateKeyJwtConfig();
        factoryAction?.Invoke(privateKeyJwtConfigResult);

        return privateKeyJwtConfigResult;
    }

    private Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateKeyJwtConfig CreatePrivateKeyJwtConfig()
    {
        var privateKeyJwtConfigResult = new Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateKeyJwtConfig();

        return privateKeyJwtConfigResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateKeyJwtConfig result)
    {
        base.CreateChildren(result);

        result.PrivateKeySource ??= PrivateKeySourceFactory?.Build();
    }

} // End Of Class

public static class InnerOAuth2CredentialProviderPrivateKeyJwtConfigFactoryExtensions
{
    public static CombinedResult<InnerOAuth2CredentialProviderPrivateKeyJwtConfigFactory, InnerOAuth2CredentialProviderPrivateKeySourceFactory> WithPrivateKeySource(this InnerOAuth2CredentialProviderPrivateKeyJwtConfigFactory parentFactory, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateKeySource> subFactoryAction = null)
    {
        parentFactory.PrivateKeySourceFactory = new InnerOAuth2CredentialProviderPrivateKeySourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PrivateKeySourceFactory);
    }

    public static CombinedResult<InnerOAuth2CredentialProviderPrivateKeyJwtConfigFactory, T1, InnerOAuth2CredentialProviderPrivateKeySourceFactory> WithPrivateKeySource<T1>(this CombinedResult<InnerOAuth2CredentialProviderPrivateKeyJwtConfigFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateKeySource> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrivateKeySource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOAuth2CredentialProviderPrivateKeyJwtConfigFactory, InnerOAuth2CredentialProviderPrivateKeySourceFactory> WithPrivateKeySource<T1>(this CombinedResult<T1, InnerOAuth2CredentialProviderPrivateKeyJwtConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateKeySource> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrivateKeySource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerOAuth2CredentialProviderPrivateKeyJwtConfigFactory, T1, T2, InnerOAuth2CredentialProviderPrivateKeySourceFactory> WithPrivateKeySource<T1, T2>(this CombinedResult<InnerOAuth2CredentialProviderPrivateKeyJwtConfigFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateKeySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrivateKeySource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOAuth2CredentialProviderPrivateKeyJwtConfigFactory, T2, InnerOAuth2CredentialProviderPrivateKeySourceFactory> WithPrivateKeySource<T1, T2>(this CombinedResult<T1, InnerOAuth2CredentialProviderPrivateKeyJwtConfigFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateKeySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrivateKeySource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOAuth2CredentialProviderPrivateKeyJwtConfigFactory, InnerOAuth2CredentialProviderPrivateKeySourceFactory> WithPrivateKeySource<T1, T2>(this CombinedResult<T1, T2, InnerOAuth2CredentialProviderPrivateKeyJwtConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateKeySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrivateKeySource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerOAuth2CredentialProviderPrivateKeyJwtConfigFactory, T1, T2, T3, InnerOAuth2CredentialProviderPrivateKeySourceFactory> WithPrivateKeySource<T1, T2, T3>(this CombinedResult<InnerOAuth2CredentialProviderPrivateKeyJwtConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateKeySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateKeySource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOAuth2CredentialProviderPrivateKeyJwtConfigFactory, T2, T3, InnerOAuth2CredentialProviderPrivateKeySourceFactory> WithPrivateKeySource<T1, T2, T3>(this CombinedResult<T1, InnerOAuth2CredentialProviderPrivateKeyJwtConfigFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateKeySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateKeySource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOAuth2CredentialProviderPrivateKeyJwtConfigFactory, T3, InnerOAuth2CredentialProviderPrivateKeySourceFactory> WithPrivateKeySource<T1, T2, T3>(this CombinedResult<T1, T2, InnerOAuth2CredentialProviderPrivateKeyJwtConfigFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateKeySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateKeySource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOAuth2CredentialProviderPrivateKeyJwtConfigFactory, InnerOAuth2CredentialProviderPrivateKeySourceFactory> WithPrivateKeySource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOAuth2CredentialProviderPrivateKeyJwtConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateKeySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateKeySource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerOAuth2CredentialProviderPrivateKeyJwtConfigFactory, T1, T2, T3, T4, InnerOAuth2CredentialProviderPrivateKeySourceFactory> WithPrivateKeySource<T1, T2, T3, T4>(this CombinedResult<InnerOAuth2CredentialProviderPrivateKeyJwtConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateKeySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateKeySource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOAuth2CredentialProviderPrivateKeyJwtConfigFactory, T2, T3, T4, InnerOAuth2CredentialProviderPrivateKeySourceFactory> WithPrivateKeySource<T1, T2, T3, T4>(this CombinedResult<T1, InnerOAuth2CredentialProviderPrivateKeyJwtConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateKeySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateKeySource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOAuth2CredentialProviderPrivateKeyJwtConfigFactory, T3, T4, InnerOAuth2CredentialProviderPrivateKeySourceFactory> WithPrivateKeySource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOAuth2CredentialProviderPrivateKeyJwtConfigFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateKeySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateKeySource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOAuth2CredentialProviderPrivateKeyJwtConfigFactory, T4, InnerOAuth2CredentialProviderPrivateKeySourceFactory> WithPrivateKeySource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOAuth2CredentialProviderPrivateKeyJwtConfigFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateKeySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateKeySource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerOAuth2CredentialProviderPrivateKeyJwtConfigFactory, InnerOAuth2CredentialProviderPrivateKeySourceFactory> WithPrivateKeySource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOAuth2CredentialProviderPrivateKeyJwtConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateKeySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateKeySource(combinedResult.T5, subFactoryAction).T2);
}
