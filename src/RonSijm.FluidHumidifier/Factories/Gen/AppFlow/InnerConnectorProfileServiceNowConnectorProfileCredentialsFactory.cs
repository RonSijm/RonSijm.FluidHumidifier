// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorProfileServiceNowConnectorProfileCredentialsFactory(Action<Humidifier.AppFlow.ConnectorProfileTypes.ServiceNowConnectorProfileCredentials> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorProfileTypes.ServiceNowConnectorProfileCredentials>
{

    internal InnerConnectorProfileOAuth2CredentialsFactory OAuth2CredentialsFactory { get; set; }

    protected override Humidifier.AppFlow.ConnectorProfileTypes.ServiceNowConnectorProfileCredentials Create()
    {
        var serviceNowConnectorProfileCredentialsResult = CreateServiceNowConnectorProfileCredentials();
        factoryAction?.Invoke(serviceNowConnectorProfileCredentialsResult);

        return serviceNowConnectorProfileCredentialsResult;
    }

    private Humidifier.AppFlow.ConnectorProfileTypes.ServiceNowConnectorProfileCredentials CreateServiceNowConnectorProfileCredentials()
    {
        var serviceNowConnectorProfileCredentialsResult = new Humidifier.AppFlow.ConnectorProfileTypes.ServiceNowConnectorProfileCredentials();

        return serviceNowConnectorProfileCredentialsResult;
    }
    public override void CreateChildren(Humidifier.AppFlow.ConnectorProfileTypes.ServiceNowConnectorProfileCredentials result)
    {
        base.CreateChildren(result);

        result.OAuth2Credentials ??= OAuth2CredentialsFactory?.Build();
    }

} // End Of Class

public static class InnerConnectorProfileServiceNowConnectorProfileCredentialsFactoryExtensions
{
    public static CombinedResult<InnerConnectorProfileServiceNowConnectorProfileCredentialsFactory, InnerConnectorProfileOAuth2CredentialsFactory> WithOAuth2Credentials(this InnerConnectorProfileServiceNowConnectorProfileCredentialsFactory parentFactory, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Credentials> subFactoryAction = null)
    {
        parentFactory.OAuth2CredentialsFactory = new InnerConnectorProfileOAuth2CredentialsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OAuth2CredentialsFactory);
    }

    public static CombinedResult<InnerConnectorProfileServiceNowConnectorProfileCredentialsFactory, T1, InnerConnectorProfileOAuth2CredentialsFactory> WithOAuth2Credentials<T1>(this CombinedResult<InnerConnectorProfileServiceNowConnectorProfileCredentialsFactory, T1> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Credentials> subFactoryAction = null) => new (combinedResult, combinedResult, WithOAuth2Credentials(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorProfileServiceNowConnectorProfileCredentialsFactory, InnerConnectorProfileOAuth2CredentialsFactory> WithOAuth2Credentials<T1>(this CombinedResult<T1, InnerConnectorProfileServiceNowConnectorProfileCredentialsFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Credentials> subFactoryAction = null) => new (combinedResult, combinedResult, WithOAuth2Credentials(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConnectorProfileServiceNowConnectorProfileCredentialsFactory, T1, T2, InnerConnectorProfileOAuth2CredentialsFactory> WithOAuth2Credentials<T1, T2>(this CombinedResult<InnerConnectorProfileServiceNowConnectorProfileCredentialsFactory, T1, T2> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Credentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOAuth2Credentials(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorProfileServiceNowConnectorProfileCredentialsFactory, T2, InnerConnectorProfileOAuth2CredentialsFactory> WithOAuth2Credentials<T1, T2>(this CombinedResult<T1, InnerConnectorProfileServiceNowConnectorProfileCredentialsFactory, T2> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Credentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOAuth2Credentials(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorProfileServiceNowConnectorProfileCredentialsFactory, InnerConnectorProfileOAuth2CredentialsFactory> WithOAuth2Credentials<T1, T2>(this CombinedResult<T1, T2, InnerConnectorProfileServiceNowConnectorProfileCredentialsFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Credentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOAuth2Credentials(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConnectorProfileServiceNowConnectorProfileCredentialsFactory, T1, T2, T3, InnerConnectorProfileOAuth2CredentialsFactory> WithOAuth2Credentials<T1, T2, T3>(this CombinedResult<InnerConnectorProfileServiceNowConnectorProfileCredentialsFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Credentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuth2Credentials(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorProfileServiceNowConnectorProfileCredentialsFactory, T2, T3, InnerConnectorProfileOAuth2CredentialsFactory> WithOAuth2Credentials<T1, T2, T3>(this CombinedResult<T1, InnerConnectorProfileServiceNowConnectorProfileCredentialsFactory, T2, T3> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Credentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuth2Credentials(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorProfileServiceNowConnectorProfileCredentialsFactory, T3, InnerConnectorProfileOAuth2CredentialsFactory> WithOAuth2Credentials<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectorProfileServiceNowConnectorProfileCredentialsFactory, T3> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Credentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuth2Credentials(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorProfileServiceNowConnectorProfileCredentialsFactory, InnerConnectorProfileOAuth2CredentialsFactory> WithOAuth2Credentials<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectorProfileServiceNowConnectorProfileCredentialsFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Credentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuth2Credentials(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConnectorProfileServiceNowConnectorProfileCredentialsFactory, T1, T2, T3, T4, InnerConnectorProfileOAuth2CredentialsFactory> WithOAuth2Credentials<T1, T2, T3, T4>(this CombinedResult<InnerConnectorProfileServiceNowConnectorProfileCredentialsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Credentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuth2Credentials(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorProfileServiceNowConnectorProfileCredentialsFactory, T2, T3, T4, InnerConnectorProfileOAuth2CredentialsFactory> WithOAuth2Credentials<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectorProfileServiceNowConnectorProfileCredentialsFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Credentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuth2Credentials(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorProfileServiceNowConnectorProfileCredentialsFactory, T3, T4, InnerConnectorProfileOAuth2CredentialsFactory> WithOAuth2Credentials<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectorProfileServiceNowConnectorProfileCredentialsFactory, T3, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Credentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuth2Credentials(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorProfileServiceNowConnectorProfileCredentialsFactory, T4, InnerConnectorProfileOAuth2CredentialsFactory> WithOAuth2Credentials<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectorProfileServiceNowConnectorProfileCredentialsFactory, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Credentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuth2Credentials(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConnectorProfileServiceNowConnectorProfileCredentialsFactory, InnerConnectorProfileOAuth2CredentialsFactory> WithOAuth2Credentials<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectorProfileServiceNowConnectorProfileCredentialsFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Credentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuth2Credentials(combinedResult.T5, subFactoryAction));
}
