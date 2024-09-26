// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorProfileGoogleAnalyticsConnectorProfileCredentialsFactory(Action<Humidifier.AppFlow.ConnectorProfileTypes.GoogleAnalyticsConnectorProfileCredentials> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorProfileTypes.GoogleAnalyticsConnectorProfileCredentials>
{

    internal InnerConnectorProfileConnectorOAuthRequestFactory ConnectorOAuthRequestFactory { get; set; }

    protected override Humidifier.AppFlow.ConnectorProfileTypes.GoogleAnalyticsConnectorProfileCredentials Create()
    {
        var googleAnalyticsConnectorProfileCredentialsResult = CreateGoogleAnalyticsConnectorProfileCredentials();
        factoryAction?.Invoke(googleAnalyticsConnectorProfileCredentialsResult);

        return googleAnalyticsConnectorProfileCredentialsResult;
    }

    private Humidifier.AppFlow.ConnectorProfileTypes.GoogleAnalyticsConnectorProfileCredentials CreateGoogleAnalyticsConnectorProfileCredentials()
    {
        var googleAnalyticsConnectorProfileCredentialsResult = new Humidifier.AppFlow.ConnectorProfileTypes.GoogleAnalyticsConnectorProfileCredentials();

        return googleAnalyticsConnectorProfileCredentialsResult;
    }
    public override void CreateChildren(Humidifier.AppFlow.ConnectorProfileTypes.GoogleAnalyticsConnectorProfileCredentials result)
    {
        base.CreateChildren(result);

        result.ConnectorOAuthRequest ??= ConnectorOAuthRequestFactory?.Build();
    }

} // End Of Class

public static class InnerConnectorProfileGoogleAnalyticsConnectorProfileCredentialsFactoryExtensions
{
    public static CombinedResult<InnerConnectorProfileGoogleAnalyticsConnectorProfileCredentialsFactory, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest(this InnerConnectorProfileGoogleAnalyticsConnectorProfileCredentialsFactory parentFactory, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null)
    {
        parentFactory.ConnectorOAuthRequestFactory = new InnerConnectorProfileConnectorOAuthRequestFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConnectorOAuthRequestFactory);
    }

    public static CombinedResult<InnerConnectorProfileGoogleAnalyticsConnectorProfileCredentialsFactory, T1, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1>(this CombinedResult<InnerConnectorProfileGoogleAnalyticsConnectorProfileCredentialsFactory, T1> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorProfileGoogleAnalyticsConnectorProfileCredentialsFactory, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1>(this CombinedResult<T1, InnerConnectorProfileGoogleAnalyticsConnectorProfileCredentialsFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConnectorProfileGoogleAnalyticsConnectorProfileCredentialsFactory, T1, T2, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2>(this CombinedResult<InnerConnectorProfileGoogleAnalyticsConnectorProfileCredentialsFactory, T1, T2> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorProfileGoogleAnalyticsConnectorProfileCredentialsFactory, T2, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2>(this CombinedResult<T1, InnerConnectorProfileGoogleAnalyticsConnectorProfileCredentialsFactory, T2> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorProfileGoogleAnalyticsConnectorProfileCredentialsFactory, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2>(this CombinedResult<T1, T2, InnerConnectorProfileGoogleAnalyticsConnectorProfileCredentialsFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConnectorProfileGoogleAnalyticsConnectorProfileCredentialsFactory, T1, T2, T3, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3>(this CombinedResult<InnerConnectorProfileGoogleAnalyticsConnectorProfileCredentialsFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorProfileGoogleAnalyticsConnectorProfileCredentialsFactory, T2, T3, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3>(this CombinedResult<T1, InnerConnectorProfileGoogleAnalyticsConnectorProfileCredentialsFactory, T2, T3> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorProfileGoogleAnalyticsConnectorProfileCredentialsFactory, T3, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectorProfileGoogleAnalyticsConnectorProfileCredentialsFactory, T3> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorProfileGoogleAnalyticsConnectorProfileCredentialsFactory, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectorProfileGoogleAnalyticsConnectorProfileCredentialsFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConnectorProfileGoogleAnalyticsConnectorProfileCredentialsFactory, T1, T2, T3, T4, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3, T4>(this CombinedResult<InnerConnectorProfileGoogleAnalyticsConnectorProfileCredentialsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorProfileGoogleAnalyticsConnectorProfileCredentialsFactory, T2, T3, T4, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectorProfileGoogleAnalyticsConnectorProfileCredentialsFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorProfileGoogleAnalyticsConnectorProfileCredentialsFactory, T3, T4, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectorProfileGoogleAnalyticsConnectorProfileCredentialsFactory, T3, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorProfileGoogleAnalyticsConnectorProfileCredentialsFactory, T4, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectorProfileGoogleAnalyticsConnectorProfileCredentialsFactory, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConnectorProfileGoogleAnalyticsConnectorProfileCredentialsFactory, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectorProfileGoogleAnalyticsConnectorProfileCredentialsFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T5, subFactoryAction));
}
