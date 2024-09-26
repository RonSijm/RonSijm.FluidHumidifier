// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorProfileSalesforceConnectorProfileCredentialsFactory(Action<Humidifier.AppFlow.ConnectorProfileTypes.SalesforceConnectorProfileCredentials> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorProfileTypes.SalesforceConnectorProfileCredentials>
{

    internal InnerConnectorProfileConnectorOAuthRequestFactory ConnectorOAuthRequestFactory { get; set; }

    protected override Humidifier.AppFlow.ConnectorProfileTypes.SalesforceConnectorProfileCredentials Create()
    {
        var salesforceConnectorProfileCredentialsResult = CreateSalesforceConnectorProfileCredentials();
        factoryAction?.Invoke(salesforceConnectorProfileCredentialsResult);

        return salesforceConnectorProfileCredentialsResult;
    }

    private Humidifier.AppFlow.ConnectorProfileTypes.SalesforceConnectorProfileCredentials CreateSalesforceConnectorProfileCredentials()
    {
        var salesforceConnectorProfileCredentialsResult = new Humidifier.AppFlow.ConnectorProfileTypes.SalesforceConnectorProfileCredentials();

        return salesforceConnectorProfileCredentialsResult;
    }
    public override void CreateChildren(Humidifier.AppFlow.ConnectorProfileTypes.SalesforceConnectorProfileCredentials result)
    {
        base.CreateChildren(result);

        result.ConnectorOAuthRequest ??= ConnectorOAuthRequestFactory?.Build();
    }

} // End Of Class

public static class InnerConnectorProfileSalesforceConnectorProfileCredentialsFactoryExtensions
{
    public static CombinedResult<InnerConnectorProfileSalesforceConnectorProfileCredentialsFactory, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest(this InnerConnectorProfileSalesforceConnectorProfileCredentialsFactory parentFactory, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null)
    {
        parentFactory.ConnectorOAuthRequestFactory = new InnerConnectorProfileConnectorOAuthRequestFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConnectorOAuthRequestFactory);
    }

    public static CombinedResult<InnerConnectorProfileSalesforceConnectorProfileCredentialsFactory, T1, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1>(this CombinedResult<InnerConnectorProfileSalesforceConnectorProfileCredentialsFactory, T1> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorProfileSalesforceConnectorProfileCredentialsFactory, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1>(this CombinedResult<T1, InnerConnectorProfileSalesforceConnectorProfileCredentialsFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConnectorProfileSalesforceConnectorProfileCredentialsFactory, T1, T2, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2>(this CombinedResult<InnerConnectorProfileSalesforceConnectorProfileCredentialsFactory, T1, T2> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorProfileSalesforceConnectorProfileCredentialsFactory, T2, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2>(this CombinedResult<T1, InnerConnectorProfileSalesforceConnectorProfileCredentialsFactory, T2> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorProfileSalesforceConnectorProfileCredentialsFactory, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2>(this CombinedResult<T1, T2, InnerConnectorProfileSalesforceConnectorProfileCredentialsFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConnectorProfileSalesforceConnectorProfileCredentialsFactory, T1, T2, T3, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3>(this CombinedResult<InnerConnectorProfileSalesforceConnectorProfileCredentialsFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorProfileSalesforceConnectorProfileCredentialsFactory, T2, T3, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3>(this CombinedResult<T1, InnerConnectorProfileSalesforceConnectorProfileCredentialsFactory, T2, T3> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorProfileSalesforceConnectorProfileCredentialsFactory, T3, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectorProfileSalesforceConnectorProfileCredentialsFactory, T3> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorProfileSalesforceConnectorProfileCredentialsFactory, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectorProfileSalesforceConnectorProfileCredentialsFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConnectorProfileSalesforceConnectorProfileCredentialsFactory, T1, T2, T3, T4, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3, T4>(this CombinedResult<InnerConnectorProfileSalesforceConnectorProfileCredentialsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorProfileSalesforceConnectorProfileCredentialsFactory, T2, T3, T4, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectorProfileSalesforceConnectorProfileCredentialsFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorProfileSalesforceConnectorProfileCredentialsFactory, T3, T4, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectorProfileSalesforceConnectorProfileCredentialsFactory, T3, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorProfileSalesforceConnectorProfileCredentialsFactory, T4, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectorProfileSalesforceConnectorProfileCredentialsFactory, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConnectorProfileSalesforceConnectorProfileCredentialsFactory, InnerConnectorProfileConnectorOAuthRequestFactory> WithConnectorOAuthRequest<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectorProfileSalesforceConnectorProfileCredentialsFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorOAuthRequest(combinedResult.T5, subFactoryAction));
}
