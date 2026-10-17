// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerOAuth2CredentialProviderPrivateKeySourceFactory(Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateKeySource> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateKeySource>
{

    internal InnerOAuth2CredentialProviderKmsKeySourceTypeFactory KmsKeySourceFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateKeySource Create()
    {
        var privateKeySourceResult = CreatePrivateKeySource();
        factoryAction?.Invoke(privateKeySourceResult);

        return privateKeySourceResult;
    }

    private Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateKeySource CreatePrivateKeySource()
    {
        var privateKeySourceResult = new Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateKeySource();

        return privateKeySourceResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateKeySource result)
    {
        base.CreateChildren(result);

        result.KmsKeySource ??= KmsKeySourceFactory?.Build();
    }

} // End Of Class

public static class InnerOAuth2CredentialProviderPrivateKeySourceFactoryExtensions
{
    public static CombinedResult<InnerOAuth2CredentialProviderPrivateKeySourceFactory, InnerOAuth2CredentialProviderKmsKeySourceTypeFactory> WithKmsKeySource(this InnerOAuth2CredentialProviderPrivateKeySourceFactory parentFactory, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.KmsKeySourceType> subFactoryAction = null)
    {
        parentFactory.KmsKeySourceFactory = new InnerOAuth2CredentialProviderKmsKeySourceTypeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.KmsKeySourceFactory);
    }

    public static CombinedResult<InnerOAuth2CredentialProviderPrivateKeySourceFactory, T1, InnerOAuth2CredentialProviderKmsKeySourceTypeFactory> WithKmsKeySource<T1>(this CombinedResult<InnerOAuth2CredentialProviderPrivateKeySourceFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.KmsKeySourceType> subFactoryAction = null) => new (combinedResult, combinedResult, WithKmsKeySource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOAuth2CredentialProviderPrivateKeySourceFactory, InnerOAuth2CredentialProviderKmsKeySourceTypeFactory> WithKmsKeySource<T1>(this CombinedResult<T1, InnerOAuth2CredentialProviderPrivateKeySourceFactory> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.KmsKeySourceType> subFactoryAction = null) => new (combinedResult, combinedResult, WithKmsKeySource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerOAuth2CredentialProviderPrivateKeySourceFactory, T1, T2, InnerOAuth2CredentialProviderKmsKeySourceTypeFactory> WithKmsKeySource<T1, T2>(this CombinedResult<InnerOAuth2CredentialProviderPrivateKeySourceFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.KmsKeySourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKmsKeySource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOAuth2CredentialProviderPrivateKeySourceFactory, T2, InnerOAuth2CredentialProviderKmsKeySourceTypeFactory> WithKmsKeySource<T1, T2>(this CombinedResult<T1, InnerOAuth2CredentialProviderPrivateKeySourceFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.KmsKeySourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKmsKeySource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOAuth2CredentialProviderPrivateKeySourceFactory, InnerOAuth2CredentialProviderKmsKeySourceTypeFactory> WithKmsKeySource<T1, T2>(this CombinedResult<T1, T2, InnerOAuth2CredentialProviderPrivateKeySourceFactory> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.KmsKeySourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKmsKeySource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerOAuth2CredentialProviderPrivateKeySourceFactory, T1, T2, T3, InnerOAuth2CredentialProviderKmsKeySourceTypeFactory> WithKmsKeySource<T1, T2, T3>(this CombinedResult<InnerOAuth2CredentialProviderPrivateKeySourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.KmsKeySourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKmsKeySource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOAuth2CredentialProviderPrivateKeySourceFactory, T2, T3, InnerOAuth2CredentialProviderKmsKeySourceTypeFactory> WithKmsKeySource<T1, T2, T3>(this CombinedResult<T1, InnerOAuth2CredentialProviderPrivateKeySourceFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.KmsKeySourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKmsKeySource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOAuth2CredentialProviderPrivateKeySourceFactory, T3, InnerOAuth2CredentialProviderKmsKeySourceTypeFactory> WithKmsKeySource<T1, T2, T3>(this CombinedResult<T1, T2, InnerOAuth2CredentialProviderPrivateKeySourceFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.KmsKeySourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKmsKeySource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOAuth2CredentialProviderPrivateKeySourceFactory, InnerOAuth2CredentialProviderKmsKeySourceTypeFactory> WithKmsKeySource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOAuth2CredentialProviderPrivateKeySourceFactory> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.KmsKeySourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKmsKeySource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerOAuth2CredentialProviderPrivateKeySourceFactory, T1, T2, T3, T4, InnerOAuth2CredentialProviderKmsKeySourceTypeFactory> WithKmsKeySource<T1, T2, T3, T4>(this CombinedResult<InnerOAuth2CredentialProviderPrivateKeySourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.KmsKeySourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKmsKeySource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOAuth2CredentialProviderPrivateKeySourceFactory, T2, T3, T4, InnerOAuth2CredentialProviderKmsKeySourceTypeFactory> WithKmsKeySource<T1, T2, T3, T4>(this CombinedResult<T1, InnerOAuth2CredentialProviderPrivateKeySourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.KmsKeySourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKmsKeySource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOAuth2CredentialProviderPrivateKeySourceFactory, T3, T4, InnerOAuth2CredentialProviderKmsKeySourceTypeFactory> WithKmsKeySource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOAuth2CredentialProviderPrivateKeySourceFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.KmsKeySourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKmsKeySource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOAuth2CredentialProviderPrivateKeySourceFactory, T4, InnerOAuth2CredentialProviderKmsKeySourceTypeFactory> WithKmsKeySource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOAuth2CredentialProviderPrivateKeySourceFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.KmsKeySourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKmsKeySource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerOAuth2CredentialProviderPrivateKeySourceFactory, InnerOAuth2CredentialProviderKmsKeySourceTypeFactory> WithKmsKeySource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOAuth2CredentialProviderPrivateKeySourceFactory> combinedResult, Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.KmsKeySourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKmsKeySource(combinedResult.T5, subFactoryAction).T2);
}
