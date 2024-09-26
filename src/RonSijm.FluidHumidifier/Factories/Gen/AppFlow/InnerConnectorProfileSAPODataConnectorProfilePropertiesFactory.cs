// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorProfileSAPODataConnectorProfilePropertiesFactory(Action<Humidifier.AppFlow.ConnectorProfileTypes.SAPODataConnectorProfileProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorProfileTypes.SAPODataConnectorProfileProperties>
{

    internal InnerConnectorProfileOAuthPropertiesFactory OAuthPropertiesFactory { get; set; }

    protected override Humidifier.AppFlow.ConnectorProfileTypes.SAPODataConnectorProfileProperties Create()
    {
        var sAPODataConnectorProfilePropertiesResult = CreateSAPODataConnectorProfileProperties();
        factoryAction?.Invoke(sAPODataConnectorProfilePropertiesResult);

        return sAPODataConnectorProfilePropertiesResult;
    }

    private Humidifier.AppFlow.ConnectorProfileTypes.SAPODataConnectorProfileProperties CreateSAPODataConnectorProfileProperties()
    {
        var sAPODataConnectorProfilePropertiesResult = new Humidifier.AppFlow.ConnectorProfileTypes.SAPODataConnectorProfileProperties();

        return sAPODataConnectorProfilePropertiesResult;
    }
    public override void CreateChildren(Humidifier.AppFlow.ConnectorProfileTypes.SAPODataConnectorProfileProperties result)
    {
        base.CreateChildren(result);

        result.OAuthProperties ??= OAuthPropertiesFactory?.Build();
    }

} // End Of Class

public static class InnerConnectorProfileSAPODataConnectorProfilePropertiesFactoryExtensions
{
    public static CombinedResult<InnerConnectorProfileSAPODataConnectorProfilePropertiesFactory, InnerConnectorProfileOAuthPropertiesFactory> WithOAuthProperties(this InnerConnectorProfileSAPODataConnectorProfilePropertiesFactory parentFactory, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuthProperties> subFactoryAction = null)
    {
        parentFactory.OAuthPropertiesFactory = new InnerConnectorProfileOAuthPropertiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OAuthPropertiesFactory);
    }

    public static CombinedResult<InnerConnectorProfileSAPODataConnectorProfilePropertiesFactory, T1, InnerConnectorProfileOAuthPropertiesFactory> WithOAuthProperties<T1>(this CombinedResult<InnerConnectorProfileSAPODataConnectorProfilePropertiesFactory, T1> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuthProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithOAuthProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorProfileSAPODataConnectorProfilePropertiesFactory, InnerConnectorProfileOAuthPropertiesFactory> WithOAuthProperties<T1>(this CombinedResult<T1, InnerConnectorProfileSAPODataConnectorProfilePropertiesFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuthProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithOAuthProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConnectorProfileSAPODataConnectorProfilePropertiesFactory, T1, T2, InnerConnectorProfileOAuthPropertiesFactory> WithOAuthProperties<T1, T2>(this CombinedResult<InnerConnectorProfileSAPODataConnectorProfilePropertiesFactory, T1, T2> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuthProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOAuthProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorProfileSAPODataConnectorProfilePropertiesFactory, T2, InnerConnectorProfileOAuthPropertiesFactory> WithOAuthProperties<T1, T2>(this CombinedResult<T1, InnerConnectorProfileSAPODataConnectorProfilePropertiesFactory, T2> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuthProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOAuthProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorProfileSAPODataConnectorProfilePropertiesFactory, InnerConnectorProfileOAuthPropertiesFactory> WithOAuthProperties<T1, T2>(this CombinedResult<T1, T2, InnerConnectorProfileSAPODataConnectorProfilePropertiesFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuthProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOAuthProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConnectorProfileSAPODataConnectorProfilePropertiesFactory, T1, T2, T3, InnerConnectorProfileOAuthPropertiesFactory> WithOAuthProperties<T1, T2, T3>(this CombinedResult<InnerConnectorProfileSAPODataConnectorProfilePropertiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuthProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorProfileSAPODataConnectorProfilePropertiesFactory, T2, T3, InnerConnectorProfileOAuthPropertiesFactory> WithOAuthProperties<T1, T2, T3>(this CombinedResult<T1, InnerConnectorProfileSAPODataConnectorProfilePropertiesFactory, T2, T3> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuthProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorProfileSAPODataConnectorProfilePropertiesFactory, T3, InnerConnectorProfileOAuthPropertiesFactory> WithOAuthProperties<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectorProfileSAPODataConnectorProfilePropertiesFactory, T3> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuthProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorProfileSAPODataConnectorProfilePropertiesFactory, InnerConnectorProfileOAuthPropertiesFactory> WithOAuthProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectorProfileSAPODataConnectorProfilePropertiesFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuthProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConnectorProfileSAPODataConnectorProfilePropertiesFactory, T1, T2, T3, T4, InnerConnectorProfileOAuthPropertiesFactory> WithOAuthProperties<T1, T2, T3, T4>(this CombinedResult<InnerConnectorProfileSAPODataConnectorProfilePropertiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuthProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorProfileSAPODataConnectorProfilePropertiesFactory, T2, T3, T4, InnerConnectorProfileOAuthPropertiesFactory> WithOAuthProperties<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectorProfileSAPODataConnectorProfilePropertiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuthProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorProfileSAPODataConnectorProfilePropertiesFactory, T3, T4, InnerConnectorProfileOAuthPropertiesFactory> WithOAuthProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectorProfileSAPODataConnectorProfilePropertiesFactory, T3, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuthProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorProfileSAPODataConnectorProfilePropertiesFactory, T4, InnerConnectorProfileOAuthPropertiesFactory> WithOAuthProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectorProfileSAPODataConnectorProfilePropertiesFactory, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuthProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConnectorProfileSAPODataConnectorProfilePropertiesFactory, InnerConnectorProfileOAuthPropertiesFactory> WithOAuthProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectorProfileSAPODataConnectorProfilePropertiesFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuthProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthProperties(combinedResult.T5, subFactoryAction));
}
