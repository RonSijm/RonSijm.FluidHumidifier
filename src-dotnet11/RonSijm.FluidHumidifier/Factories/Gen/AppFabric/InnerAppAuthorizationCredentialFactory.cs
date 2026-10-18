// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFabric;

public class InnerAppAuthorizationCredentialFactory(Action<Humidifier.AppFabric.AppAuthorizationTypes.Credential> factoryAction = null) : SubResourceFactory<Humidifier.AppFabric.AppAuthorizationTypes.Credential>
{

    internal InnerAppAuthorizationApiKeyCredentialFactory ApiKeyCredentialFactory { get; set; }

    internal InnerAppAuthorizationOauth2CredentialFactory Oauth2CredentialFactory { get; set; }

    protected override Humidifier.AppFabric.AppAuthorizationTypes.Credential Create()
    {
        var credentialResult = CreateCredential();
        factoryAction?.Invoke(credentialResult);

        return credentialResult;
    }

    private Humidifier.AppFabric.AppAuthorizationTypes.Credential CreateCredential()
    {
        var credentialResult = new Humidifier.AppFabric.AppAuthorizationTypes.Credential();

        return credentialResult;
    }
    public override void CreateChildren(Humidifier.AppFabric.AppAuthorizationTypes.Credential result)
    {
        base.CreateChildren(result);

        result.ApiKeyCredential ??= ApiKeyCredentialFactory?.Build();
        result.Oauth2Credential ??= Oauth2CredentialFactory?.Build();
    }

} // End Of Class

public static class InnerAppAuthorizationCredentialFactoryExtensions
{
    public static CombinedResult<InnerAppAuthorizationCredentialFactory, InnerAppAuthorizationApiKeyCredentialFactory> WithApiKeyCredential(this InnerAppAuthorizationCredentialFactory parentFactory, Action<Humidifier.AppFabric.AppAuthorizationTypes.ApiKeyCredential> subFactoryAction = null)
    {
        parentFactory.ApiKeyCredentialFactory = new InnerAppAuthorizationApiKeyCredentialFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ApiKeyCredentialFactory);
    }

    public static CombinedResult<InnerAppAuthorizationCredentialFactory, InnerAppAuthorizationOauth2CredentialFactory> WithOauth2Credential(this InnerAppAuthorizationCredentialFactory parentFactory, Action<Humidifier.AppFabric.AppAuthorizationTypes.Oauth2Credential> subFactoryAction = null)
    {
        parentFactory.Oauth2CredentialFactory = new InnerAppAuthorizationOauth2CredentialFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.Oauth2CredentialFactory);
    }

    public static CombinedResult<InnerAppAuthorizationCredentialFactory, T1, InnerAppAuthorizationApiKeyCredentialFactory> WithApiKeyCredential<T1>(this CombinedResult<InnerAppAuthorizationCredentialFactory, T1> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.ApiKeyCredential> subFactoryAction = null) => new (combinedResult, combinedResult, WithApiKeyCredential(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAppAuthorizationCredentialFactory, InnerAppAuthorizationApiKeyCredentialFactory> WithApiKeyCredential<T1>(this CombinedResult<T1, InnerAppAuthorizationCredentialFactory> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.ApiKeyCredential> subFactoryAction = null) => new (combinedResult, combinedResult, WithApiKeyCredential(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAppAuthorizationCredentialFactory, T1, T2, InnerAppAuthorizationApiKeyCredentialFactory> WithApiKeyCredential<T1, T2>(this CombinedResult<InnerAppAuthorizationCredentialFactory, T1, T2> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.ApiKeyCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApiKeyCredential(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAppAuthorizationCredentialFactory, T2, InnerAppAuthorizationApiKeyCredentialFactory> WithApiKeyCredential<T1, T2>(this CombinedResult<T1, InnerAppAuthorizationCredentialFactory, T2> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.ApiKeyCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApiKeyCredential(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAppAuthorizationCredentialFactory, InnerAppAuthorizationApiKeyCredentialFactory> WithApiKeyCredential<T1, T2>(this CombinedResult<T1, T2, InnerAppAuthorizationCredentialFactory> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.ApiKeyCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApiKeyCredential(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAppAuthorizationCredentialFactory, T1, T2, T3, InnerAppAuthorizationApiKeyCredentialFactory> WithApiKeyCredential<T1, T2, T3>(this CombinedResult<InnerAppAuthorizationCredentialFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.ApiKeyCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiKeyCredential(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAppAuthorizationCredentialFactory, T2, T3, InnerAppAuthorizationApiKeyCredentialFactory> WithApiKeyCredential<T1, T2, T3>(this CombinedResult<T1, InnerAppAuthorizationCredentialFactory, T2, T3> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.ApiKeyCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiKeyCredential(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAppAuthorizationCredentialFactory, T3, InnerAppAuthorizationApiKeyCredentialFactory> WithApiKeyCredential<T1, T2, T3>(this CombinedResult<T1, T2, InnerAppAuthorizationCredentialFactory, T3> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.ApiKeyCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiKeyCredential(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAppAuthorizationCredentialFactory, InnerAppAuthorizationApiKeyCredentialFactory> WithApiKeyCredential<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAppAuthorizationCredentialFactory> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.ApiKeyCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiKeyCredential(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAppAuthorizationCredentialFactory, T1, T2, T3, T4, InnerAppAuthorizationApiKeyCredentialFactory> WithApiKeyCredential<T1, T2, T3, T4>(this CombinedResult<InnerAppAuthorizationCredentialFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.ApiKeyCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiKeyCredential(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAppAuthorizationCredentialFactory, T2, T3, T4, InnerAppAuthorizationApiKeyCredentialFactory> WithApiKeyCredential<T1, T2, T3, T4>(this CombinedResult<T1, InnerAppAuthorizationCredentialFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.ApiKeyCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiKeyCredential(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAppAuthorizationCredentialFactory, T3, T4, InnerAppAuthorizationApiKeyCredentialFactory> WithApiKeyCredential<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAppAuthorizationCredentialFactory, T3, T4> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.ApiKeyCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiKeyCredential(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAppAuthorizationCredentialFactory, T4, InnerAppAuthorizationApiKeyCredentialFactory> WithApiKeyCredential<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAppAuthorizationCredentialFactory, T4> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.ApiKeyCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiKeyCredential(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAppAuthorizationCredentialFactory, InnerAppAuthorizationApiKeyCredentialFactory> WithApiKeyCredential<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAppAuthorizationCredentialFactory> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.ApiKeyCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiKeyCredential(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerAppAuthorizationCredentialFactory, T1, InnerAppAuthorizationOauth2CredentialFactory> WithOauth2Credential<T1>(this CombinedResult<InnerAppAuthorizationCredentialFactory, T1> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Oauth2Credential> subFactoryAction = null) => new (combinedResult, combinedResult, WithOauth2Credential(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAppAuthorizationCredentialFactory, InnerAppAuthorizationOauth2CredentialFactory> WithOauth2Credential<T1>(this CombinedResult<T1, InnerAppAuthorizationCredentialFactory> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Oauth2Credential> subFactoryAction = null) => new (combinedResult, combinedResult, WithOauth2Credential(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAppAuthorizationCredentialFactory, T1, T2, InnerAppAuthorizationOauth2CredentialFactory> WithOauth2Credential<T1, T2>(this CombinedResult<InnerAppAuthorizationCredentialFactory, T1, T2> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Oauth2Credential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOauth2Credential(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAppAuthorizationCredentialFactory, T2, InnerAppAuthorizationOauth2CredentialFactory> WithOauth2Credential<T1, T2>(this CombinedResult<T1, InnerAppAuthorizationCredentialFactory, T2> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Oauth2Credential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOauth2Credential(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAppAuthorizationCredentialFactory, InnerAppAuthorizationOauth2CredentialFactory> WithOauth2Credential<T1, T2>(this CombinedResult<T1, T2, InnerAppAuthorizationCredentialFactory> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Oauth2Credential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOauth2Credential(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAppAuthorizationCredentialFactory, T1, T2, T3, InnerAppAuthorizationOauth2CredentialFactory> WithOauth2Credential<T1, T2, T3>(this CombinedResult<InnerAppAuthorizationCredentialFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Oauth2Credential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOauth2Credential(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAppAuthorizationCredentialFactory, T2, T3, InnerAppAuthorizationOauth2CredentialFactory> WithOauth2Credential<T1, T2, T3>(this CombinedResult<T1, InnerAppAuthorizationCredentialFactory, T2, T3> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Oauth2Credential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOauth2Credential(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAppAuthorizationCredentialFactory, T3, InnerAppAuthorizationOauth2CredentialFactory> WithOauth2Credential<T1, T2, T3>(this CombinedResult<T1, T2, InnerAppAuthorizationCredentialFactory, T3> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Oauth2Credential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOauth2Credential(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAppAuthorizationCredentialFactory, InnerAppAuthorizationOauth2CredentialFactory> WithOauth2Credential<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAppAuthorizationCredentialFactory> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Oauth2Credential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOauth2Credential(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAppAuthorizationCredentialFactory, T1, T2, T3, T4, InnerAppAuthorizationOauth2CredentialFactory> WithOauth2Credential<T1, T2, T3, T4>(this CombinedResult<InnerAppAuthorizationCredentialFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Oauth2Credential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOauth2Credential(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAppAuthorizationCredentialFactory, T2, T3, T4, InnerAppAuthorizationOauth2CredentialFactory> WithOauth2Credential<T1, T2, T3, T4>(this CombinedResult<T1, InnerAppAuthorizationCredentialFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Oauth2Credential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOauth2Credential(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAppAuthorizationCredentialFactory, T3, T4, InnerAppAuthorizationOauth2CredentialFactory> WithOauth2Credential<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAppAuthorizationCredentialFactory, T3, T4> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Oauth2Credential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOauth2Credential(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAppAuthorizationCredentialFactory, T4, InnerAppAuthorizationOauth2CredentialFactory> WithOauth2Credential<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAppAuthorizationCredentialFactory, T4> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Oauth2Credential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOauth2Credential(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAppAuthorizationCredentialFactory, InnerAppAuthorizationOauth2CredentialFactory> WithOauth2Credential<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAppAuthorizationCredentialFactory> combinedResult, Action<Humidifier.AppFabric.AppAuthorizationTypes.Oauth2Credential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOauth2Credential(combinedResult.T5, subFactoryAction).T2);
}
