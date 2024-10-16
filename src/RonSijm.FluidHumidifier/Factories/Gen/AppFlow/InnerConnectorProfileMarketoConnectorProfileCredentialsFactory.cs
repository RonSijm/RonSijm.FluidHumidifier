// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorProfileMarketoConnectorProfileCredentialsFactory(Action<Humidifier.AppFlow.ConnectorProfileTypes.MarketoConnectorProfileCredentials> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorProfileTypes.MarketoConnectorProfileCredentials>
{

    internal InnerConnectorProfileConnectorOAuthRequestFactory ConnectorOAuthRequestFactory { get; set; }

    protected override Humidifier.AppFlow.ConnectorProfileTypes.MarketoConnectorProfileCredentials Create()
    {
        var marketoConnectorProfileCredentialsResult = CreateMarketoConnectorProfileCredentials();
        factoryAction?.Invoke(marketoConnectorProfileCredentialsResult);

        return marketoConnectorProfileCredentialsResult;
    }

    private Humidifier.AppFlow.ConnectorProfileTypes.MarketoConnectorProfileCredentials CreateMarketoConnectorProfileCredentials()
    {
        var marketoConnectorProfileCredentialsResult = new Humidifier.AppFlow.ConnectorProfileTypes.MarketoConnectorProfileCredentials();

        return marketoConnectorProfileCredentialsResult;
    }
    public override void CreateChildren(Humidifier.AppFlow.ConnectorProfileTypes.MarketoConnectorProfileCredentials result)
    {
        base.CreateChildren(result);

        result.ConnectorOAuthRequest ??= ConnectorOAuthRequestFactory?.Build();
    }

} // End Of Class

public static class InnerConnectorProfileMarketoConnectorProfileCredentialsFactoryExtensions
{
    public static CombinedResult<InnerConnectorProfileMarketoConnectorProfileCredentialsFactory, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest(this InnerConnectorProfileMarketoConnectorProfileCredentialsFactory parentFactory, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null)
    {
        parentFactory.ConnectorOAuthRequestFactory = new InnerConnectorProfileConnectorOAuthRequestFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConnectorOAuthRequestFactory);
    }

    public static CombinedResult<InnerConnectorProfileMarketoConnectorProfileCredentialsFactory, T1, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1>(this CombinedResult<InnerConnectorProfileMarketoConnectorProfileCredentialsFactory, T1> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorProfileMarketoConnectorProfileCredentialsFactory, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1>(this CombinedResult<T1, InnerConnectorProfileMarketoConnectorProfileCredentialsFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConnectorProfileMarketoConnectorProfileCredentialsFactory, T1, T2, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2>(this CombinedResult<InnerConnectorProfileMarketoConnectorProfileCredentialsFactory, T1, T2> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorProfileMarketoConnectorProfileCredentialsFactory, T2, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2>(this CombinedResult<T1, InnerConnectorProfileMarketoConnectorProfileCredentialsFactory, T2> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorProfileMarketoConnectorProfileCredentialsFactory, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2>(this CombinedResult<T1, T2, InnerConnectorProfileMarketoConnectorProfileCredentialsFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConnectorProfileMarketoConnectorProfileCredentialsFactory, T1, T2, T3, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3>(this CombinedResult<InnerConnectorProfileMarketoConnectorProfileCredentialsFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorProfileMarketoConnectorProfileCredentialsFactory, T2, T3, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3>(this CombinedResult<T1, InnerConnectorProfileMarketoConnectorProfileCredentialsFactory, T2, T3> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorProfileMarketoConnectorProfileCredentialsFactory, T3, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectorProfileMarketoConnectorProfileCredentialsFactory, T3> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorProfileMarketoConnectorProfileCredentialsFactory, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectorProfileMarketoConnectorProfileCredentialsFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConnectorProfileMarketoConnectorProfileCredentialsFactory, T1, T2, T3, T4, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3, T4>(this CombinedResult<InnerConnectorProfileMarketoConnectorProfileCredentialsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorProfileMarketoConnectorProfileCredentialsFactory, T2, T3, T4, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectorProfileMarketoConnectorProfileCredentialsFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorProfileMarketoConnectorProfileCredentialsFactory, T3, T4, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectorProfileMarketoConnectorProfileCredentialsFactory, T3, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorProfileMarketoConnectorProfileCredentialsFactory, T4, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectorProfileMarketoConnectorProfileCredentialsFactory, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConnectorProfileMarketoConnectorProfileCredentialsFactory, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectorProfileMarketoConnectorProfileCredentialsFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T5, subFactoryAction));
}
