// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorProfileZendeskConnectorProfileCredentialsFactory(Action<Humidifier.AppFlow.ConnectorProfileTypes.ZendeskConnectorProfileCredentials> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorProfileTypes.ZendeskConnectorProfileCredentials>
{

    internal InnerConnectorProfileConnectorOAuthRequestFactory ConnectorOAuthRequestFactory { get; set; }

    protected override Humidifier.AppFlow.ConnectorProfileTypes.ZendeskConnectorProfileCredentials Create()
    {
        var zendeskConnectorProfileCredentialsResult = CreateZendeskConnectorProfileCredentials();
        factoryAction?.Invoke(zendeskConnectorProfileCredentialsResult);

        return zendeskConnectorProfileCredentialsResult;
    }

    private Humidifier.AppFlow.ConnectorProfileTypes.ZendeskConnectorProfileCredentials CreateZendeskConnectorProfileCredentials()
    {
        var zendeskConnectorProfileCredentialsResult = new Humidifier.AppFlow.ConnectorProfileTypes.ZendeskConnectorProfileCredentials();

        return zendeskConnectorProfileCredentialsResult;
    }
    public override void CreateChildren(Humidifier.AppFlow.ConnectorProfileTypes.ZendeskConnectorProfileCredentials result)
    {
        base.CreateChildren(result);

        result.ConnectorOAuthRequest ??= ConnectorOAuthRequestFactory?.Build();
    }

} // End Of Class

public static class InnerConnectorProfileZendeskConnectorProfileCredentialsFactoryExtensions
{
    public static CombinedResult<InnerConnectorProfileZendeskConnectorProfileCredentialsFactory, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest(this InnerConnectorProfileZendeskConnectorProfileCredentialsFactory parentFactory, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null)
    {
        parentFactory.ConnectorOAuthRequestFactory = new InnerConnectorProfileConnectorOAuthRequestFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConnectorOAuthRequestFactory);
    }

    public static CombinedResult<InnerConnectorProfileZendeskConnectorProfileCredentialsFactory, T1, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1>(this CombinedResult<InnerConnectorProfileZendeskConnectorProfileCredentialsFactory, T1> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorProfileZendeskConnectorProfileCredentialsFactory, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1>(this CombinedResult<T1, InnerConnectorProfileZendeskConnectorProfileCredentialsFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConnectorProfileZendeskConnectorProfileCredentialsFactory, T1, T2, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2>(this CombinedResult<InnerConnectorProfileZendeskConnectorProfileCredentialsFactory, T1, T2> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorProfileZendeskConnectorProfileCredentialsFactory, T2, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2>(this CombinedResult<T1, InnerConnectorProfileZendeskConnectorProfileCredentialsFactory, T2> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorProfileZendeskConnectorProfileCredentialsFactory, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2>(this CombinedResult<T1, T2, InnerConnectorProfileZendeskConnectorProfileCredentialsFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConnectorProfileZendeskConnectorProfileCredentialsFactory, T1, T2, T3, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3>(this CombinedResult<InnerConnectorProfileZendeskConnectorProfileCredentialsFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorProfileZendeskConnectorProfileCredentialsFactory, T2, T3, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3>(this CombinedResult<T1, InnerConnectorProfileZendeskConnectorProfileCredentialsFactory, T2, T3> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorProfileZendeskConnectorProfileCredentialsFactory, T3, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectorProfileZendeskConnectorProfileCredentialsFactory, T3> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorProfileZendeskConnectorProfileCredentialsFactory, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectorProfileZendeskConnectorProfileCredentialsFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConnectorProfileZendeskConnectorProfileCredentialsFactory, T1, T2, T3, T4, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3, T4>(this CombinedResult<InnerConnectorProfileZendeskConnectorProfileCredentialsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorProfileZendeskConnectorProfileCredentialsFactory, T2, T3, T4, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectorProfileZendeskConnectorProfileCredentialsFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorProfileZendeskConnectorProfileCredentialsFactory, T3, T4, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectorProfileZendeskConnectorProfileCredentialsFactory, T3, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorProfileZendeskConnectorProfileCredentialsFactory, T4, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectorProfileZendeskConnectorProfileCredentialsFactory, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConnectorProfileZendeskConnectorProfileCredentialsFactory, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectorProfileZendeskConnectorProfileCredentialsFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T5, subFactoryAction));
}
