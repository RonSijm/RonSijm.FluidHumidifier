// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class ApiKeyCredentialProviderFactory(string resourceName = null, Action<Humidifier.BedrockAgentCore.ApiKeyCredentialProvider> factoryAction = null) : ResourceFactory<Humidifier.BedrockAgentCore.ApiKeyCredentialProvider>(resourceName)
{

    internal InnerApiKeyCredentialProviderSecretReferenceFactory ApiKeySecretConfigFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.ApiKeyCredentialProvider Create()
    {
        var apiKeyCredentialProviderResult = CreateApiKeyCredentialProvider();
        factoryAction?.Invoke(apiKeyCredentialProviderResult);

        return apiKeyCredentialProviderResult;
    }

    private Humidifier.BedrockAgentCore.ApiKeyCredentialProvider CreateApiKeyCredentialProvider()
    {
        var apiKeyCredentialProviderResult = new Humidifier.BedrockAgentCore.ApiKeyCredentialProvider
        {
            GivenName = InputResourceName,
        };

        return apiKeyCredentialProviderResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.ApiKeyCredentialProvider result)
    {
        base.CreateChildren(result);

        result.ApiKeySecretConfig ??= ApiKeySecretConfigFactory?.Build();
    }

} // End Of Class

public static class ApiKeyCredentialProviderFactoryExtensions
{
    public static CombinedResult<ApiKeyCredentialProviderFactory, InnerApiKeyCredentialProviderSecretReferenceFactory> WithApiKeySecretConfig(this ApiKeyCredentialProviderFactory parentFactory, Action<Humidifier.BedrockAgentCore.ApiKeyCredentialProviderTypes.SecretReference> subFactoryAction = null)
    {
        parentFactory.ApiKeySecretConfigFactory = new InnerApiKeyCredentialProviderSecretReferenceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ApiKeySecretConfigFactory);
    }

    public static CombinedResult<ApiKeyCredentialProviderFactory, T1, InnerApiKeyCredentialProviderSecretReferenceFactory> WithApiKeySecretConfig<T1>(this CombinedResult<ApiKeyCredentialProviderFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.ApiKeyCredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, WithApiKeySecretConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ApiKeyCredentialProviderFactory, InnerApiKeyCredentialProviderSecretReferenceFactory> WithApiKeySecretConfig<T1>(this CombinedResult<T1, ApiKeyCredentialProviderFactory> combinedResult, Action<Humidifier.BedrockAgentCore.ApiKeyCredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, WithApiKeySecretConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ApiKeyCredentialProviderFactory, T1, T2, InnerApiKeyCredentialProviderSecretReferenceFactory> WithApiKeySecretConfig<T1, T2>(this CombinedResult<ApiKeyCredentialProviderFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.ApiKeyCredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApiKeySecretConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ApiKeyCredentialProviderFactory, T2, InnerApiKeyCredentialProviderSecretReferenceFactory> WithApiKeySecretConfig<T1, T2>(this CombinedResult<T1, ApiKeyCredentialProviderFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.ApiKeyCredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApiKeySecretConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ApiKeyCredentialProviderFactory, InnerApiKeyCredentialProviderSecretReferenceFactory> WithApiKeySecretConfig<T1, T2>(this CombinedResult<T1, T2, ApiKeyCredentialProviderFactory> combinedResult, Action<Humidifier.BedrockAgentCore.ApiKeyCredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApiKeySecretConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ApiKeyCredentialProviderFactory, T1, T2, T3, InnerApiKeyCredentialProviderSecretReferenceFactory> WithApiKeySecretConfig<T1, T2, T3>(this CombinedResult<ApiKeyCredentialProviderFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.ApiKeyCredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiKeySecretConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ApiKeyCredentialProviderFactory, T2, T3, InnerApiKeyCredentialProviderSecretReferenceFactory> WithApiKeySecretConfig<T1, T2, T3>(this CombinedResult<T1, ApiKeyCredentialProviderFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.ApiKeyCredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiKeySecretConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ApiKeyCredentialProviderFactory, T3, InnerApiKeyCredentialProviderSecretReferenceFactory> WithApiKeySecretConfig<T1, T2, T3>(this CombinedResult<T1, T2, ApiKeyCredentialProviderFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.ApiKeyCredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiKeySecretConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ApiKeyCredentialProviderFactory, InnerApiKeyCredentialProviderSecretReferenceFactory> WithApiKeySecretConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ApiKeyCredentialProviderFactory> combinedResult, Action<Humidifier.BedrockAgentCore.ApiKeyCredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiKeySecretConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ApiKeyCredentialProviderFactory, T1, T2, T3, T4, InnerApiKeyCredentialProviderSecretReferenceFactory> WithApiKeySecretConfig<T1, T2, T3, T4>(this CombinedResult<ApiKeyCredentialProviderFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.ApiKeyCredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiKeySecretConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ApiKeyCredentialProviderFactory, T2, T3, T4, InnerApiKeyCredentialProviderSecretReferenceFactory> WithApiKeySecretConfig<T1, T2, T3, T4>(this CombinedResult<T1, ApiKeyCredentialProviderFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.ApiKeyCredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiKeySecretConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ApiKeyCredentialProviderFactory, T3, T4, InnerApiKeyCredentialProviderSecretReferenceFactory> WithApiKeySecretConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ApiKeyCredentialProviderFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.ApiKeyCredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiKeySecretConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ApiKeyCredentialProviderFactory, T4, InnerApiKeyCredentialProviderSecretReferenceFactory> WithApiKeySecretConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ApiKeyCredentialProviderFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.ApiKeyCredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiKeySecretConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ApiKeyCredentialProviderFactory, InnerApiKeyCredentialProviderSecretReferenceFactory> WithApiKeySecretConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ApiKeyCredentialProviderFactory> combinedResult, Action<Humidifier.BedrockAgentCore.ApiKeyCredentialProviderTypes.SecretReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiKeySecretConfig(combinedResult.T5, subFactoryAction).T2);
}
