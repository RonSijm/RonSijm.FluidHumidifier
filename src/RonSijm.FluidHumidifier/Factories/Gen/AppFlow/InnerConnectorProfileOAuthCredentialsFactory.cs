// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorProfileOAuthCredentialsFactory(Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuthCredentials> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorProfileTypes.OAuthCredentials>
{

    internal InnerConnectorProfileConnectorOAuthRequestFactory ConnectorOAuthRequestFactory { get; set; }

    protected override Humidifier.AppFlow.ConnectorProfileTypes.OAuthCredentials Create()
    {
        var oAuthCredentialsResult = CreateOAuthCredentials();
        factoryAction?.Invoke(oAuthCredentialsResult);

        return oAuthCredentialsResult;
    }

    private Humidifier.AppFlow.ConnectorProfileTypes.OAuthCredentials CreateOAuthCredentials()
    {
        var oAuthCredentialsResult = new Humidifier.AppFlow.ConnectorProfileTypes.OAuthCredentials();

        return oAuthCredentialsResult;
    }
    public override void CreateChildren(Humidifier.AppFlow.ConnectorProfileTypes.OAuthCredentials result)
    {
        base.CreateChildren(result);

        result.ConnectorOAuthRequest ??= ConnectorOAuthRequestFactory?.Build();
    }

} // End Of Class

public static class InnerConnectorProfileOAuthCredentialsFactoryExtensions
{
    public static CombinedResult<InnerConnectorProfileOAuthCredentialsFactory, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest(this InnerConnectorProfileOAuthCredentialsFactory parentFactory, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null)
    {
        parentFactory.ConnectorOAuthRequestFactory = new InnerConnectorProfileConnectorOAuthRequestFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConnectorOAuthRequestFactory);
    }

    public static CombinedResult<InnerConnectorProfileOAuthCredentialsFactory, T1, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1>(this CombinedResult<InnerConnectorProfileOAuthCredentialsFactory, T1> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorProfileOAuthCredentialsFactory, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1>(this CombinedResult<T1, InnerConnectorProfileOAuthCredentialsFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConnectorProfileOAuthCredentialsFactory, T1, T2, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2>(this CombinedResult<InnerConnectorProfileOAuthCredentialsFactory, T1, T2> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorProfileOAuthCredentialsFactory, T2, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2>(this CombinedResult<T1, InnerConnectorProfileOAuthCredentialsFactory, T2> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorProfileOAuthCredentialsFactory, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2>(this CombinedResult<T1, T2, InnerConnectorProfileOAuthCredentialsFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConnectorProfileOAuthCredentialsFactory, T1, T2, T3, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3>(this CombinedResult<InnerConnectorProfileOAuthCredentialsFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorProfileOAuthCredentialsFactory, T2, T3, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3>(this CombinedResult<T1, InnerConnectorProfileOAuthCredentialsFactory, T2, T3> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorProfileOAuthCredentialsFactory, T3, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectorProfileOAuthCredentialsFactory, T3> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorProfileOAuthCredentialsFactory, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectorProfileOAuthCredentialsFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConnectorProfileOAuthCredentialsFactory, T1, T2, T3, T4, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3, T4>(this CombinedResult<InnerConnectorProfileOAuthCredentialsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorProfileOAuthCredentialsFactory, T2, T3, T4, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectorProfileOAuthCredentialsFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorProfileOAuthCredentialsFactory, T3, T4, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectorProfileOAuthCredentialsFactory, T3, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorProfileOAuthCredentialsFactory, T4, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectorProfileOAuthCredentialsFactory, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConnectorProfileOAuthCredentialsFactory, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectorProfileOAuthCredentialsFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T5, subFactoryAction));
}
