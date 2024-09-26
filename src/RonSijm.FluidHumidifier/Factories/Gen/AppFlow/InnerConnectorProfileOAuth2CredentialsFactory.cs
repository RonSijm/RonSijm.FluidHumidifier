// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorProfileOAuth2CredentialsFactory(Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Credentials> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Credentials>
{

    internal InnerConnectorProfileConnectorOAuthRequestFactory OAuthRequestFactory { get; set; }

    protected override Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Credentials Create()
    {
        var oAuth2CredentialsResult = CreateOAuth2Credentials();
        factoryAction?.Invoke(oAuth2CredentialsResult);

        return oAuth2CredentialsResult;
    }

    private Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Credentials CreateOAuth2Credentials()
    {
        var oAuth2CredentialsResult = new Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Credentials();

        return oAuth2CredentialsResult;
    }
    public override void CreateChildren(Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Credentials result)
    {
        base.CreateChildren(result);

        result.OAuthRequest ??= OAuthRequestFactory?.Build();
    }

} // End Of Class

public static class InnerConnectorProfileOAuth2CredentialsFactoryExtensions
{
    public static CombinedResult<InnerConnectorProfileOAuth2CredentialsFactory, InnerConnectorProfileConnectorOAuthRequestFactory> WithOAuthRequest(this InnerConnectorProfileOAuth2CredentialsFactory parentFactory, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null)
    {
        parentFactory.OAuthRequestFactory = new InnerConnectorProfileConnectorOAuthRequestFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OAuthRequestFactory);
    }

    public static CombinedResult<InnerConnectorProfileOAuth2CredentialsFactory, T1, InnerConnectorProfileConnectorOAuthRequestFactory> WithOAuthRequest<T1>(this CombinedResult<InnerConnectorProfileOAuth2CredentialsFactory, T1> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, WithOAuthRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorProfileOAuth2CredentialsFactory, InnerConnectorProfileConnectorOAuthRequestFactory> WithOAuthRequest<T1>(this CombinedResult<T1, InnerConnectorProfileOAuth2CredentialsFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, WithOAuthRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConnectorProfileOAuth2CredentialsFactory, T1, T2, InnerConnectorProfileConnectorOAuthRequestFactory> WithOAuthRequest<T1, T2>(this CombinedResult<InnerConnectorProfileOAuth2CredentialsFactory, T1, T2> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOAuthRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorProfileOAuth2CredentialsFactory, T2, InnerConnectorProfileConnectorOAuthRequestFactory> WithOAuthRequest<T1, T2>(this CombinedResult<T1, InnerConnectorProfileOAuth2CredentialsFactory, T2> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOAuthRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorProfileOAuth2CredentialsFactory, InnerConnectorProfileConnectorOAuthRequestFactory> WithOAuthRequest<T1, T2>(this CombinedResult<T1, T2, InnerConnectorProfileOAuth2CredentialsFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOAuthRequest(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConnectorProfileOAuth2CredentialsFactory, T1, T2, T3, InnerConnectorProfileConnectorOAuthRequestFactory> WithOAuthRequest<T1, T2, T3>(this CombinedResult<InnerConnectorProfileOAuth2CredentialsFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorProfileOAuth2CredentialsFactory, T2, T3, InnerConnectorProfileConnectorOAuthRequestFactory> WithOAuthRequest<T1, T2, T3>(this CombinedResult<T1, InnerConnectorProfileOAuth2CredentialsFactory, T2, T3> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorProfileOAuth2CredentialsFactory, T3, InnerConnectorProfileConnectorOAuthRequestFactory> WithOAuthRequest<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectorProfileOAuth2CredentialsFactory, T3> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthRequest(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorProfileOAuth2CredentialsFactory, InnerConnectorProfileConnectorOAuthRequestFactory> WithOAuthRequest<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectorProfileOAuth2CredentialsFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthRequest(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConnectorProfileOAuth2CredentialsFactory, T1, T2, T3, T4, InnerConnectorProfileConnectorOAuthRequestFactory> WithOAuthRequest<T1, T2, T3, T4>(this CombinedResult<InnerConnectorProfileOAuth2CredentialsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorProfileOAuth2CredentialsFactory, T2, T3, T4, InnerConnectorProfileConnectorOAuthRequestFactory> WithOAuthRequest<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectorProfileOAuth2CredentialsFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorProfileOAuth2CredentialsFactory, T3, T4, InnerConnectorProfileConnectorOAuthRequestFactory> WithOAuthRequest<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectorProfileOAuth2CredentialsFactory, T3, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthRequest(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorProfileOAuth2CredentialsFactory, T4, InnerConnectorProfileConnectorOAuthRequestFactory> WithOAuthRequest<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectorProfileOAuth2CredentialsFactory, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthRequest(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConnectorProfileOAuth2CredentialsFactory, InnerConnectorProfileConnectorOAuthRequestFactory> WithOAuthRequest<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectorProfileOAuth2CredentialsFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthRequest(combinedResult.T5, subFactoryAction));
}
