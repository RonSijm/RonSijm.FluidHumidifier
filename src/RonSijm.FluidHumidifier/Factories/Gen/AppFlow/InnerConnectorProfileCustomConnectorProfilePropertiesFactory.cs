// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorProfileCustomConnectorProfilePropertiesFactory(Action<Humidifier.AppFlow.ConnectorProfileTypes.CustomConnectorProfileProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorProfileTypes.CustomConnectorProfileProperties>
{

    internal InnerConnectorProfileOAuth2PropertiesFactory OAuth2PropertiesFactory { get; set; }

    protected override Humidifier.AppFlow.ConnectorProfileTypes.CustomConnectorProfileProperties Create()
    {
        var customConnectorProfilePropertiesResult = CreateCustomConnectorProfileProperties();
        factoryAction?.Invoke(customConnectorProfilePropertiesResult);

        return customConnectorProfilePropertiesResult;
    }

    private Humidifier.AppFlow.ConnectorProfileTypes.CustomConnectorProfileProperties CreateCustomConnectorProfileProperties()
    {
        var customConnectorProfilePropertiesResult = new Humidifier.AppFlow.ConnectorProfileTypes.CustomConnectorProfileProperties();

        return customConnectorProfilePropertiesResult;
    }
    public override void CreateChildren(Humidifier.AppFlow.ConnectorProfileTypes.CustomConnectorProfileProperties result)
    {
        base.CreateChildren(result);

        result.OAuth2Properties ??= OAuth2PropertiesFactory?.Build();
    }

} // End Of Class

public static class InnerConnectorProfileCustomConnectorProfilePropertiesFactoryExtensions
{
    public static CombinedResult<InnerConnectorProfileCustomConnectorProfilePropertiesFactory, InnerConnectorProfileOAuth2PropertiesFactory> WithOAuth2Properties(this InnerConnectorProfileCustomConnectorProfilePropertiesFactory parentFactory, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Properties> subFactoryAction = null)
    {
        parentFactory.OAuth2PropertiesFactory = new InnerConnectorProfileOAuth2PropertiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OAuth2PropertiesFactory);
    }

    public static CombinedResult<InnerConnectorProfileCustomConnectorProfilePropertiesFactory, T1, InnerConnectorProfileOAuth2PropertiesFactory> WithOAuth2Properties<T1>(this CombinedResult<InnerConnectorProfileCustomConnectorProfilePropertiesFactory, T1> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Properties> subFactoryAction = null) => new (combinedResult, combinedResult, WithOAuth2Properties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorProfileCustomConnectorProfilePropertiesFactory, InnerConnectorProfileOAuth2PropertiesFactory> WithOAuth2Properties<T1>(this CombinedResult<T1, InnerConnectorProfileCustomConnectorProfilePropertiesFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Properties> subFactoryAction = null) => new (combinedResult, combinedResult, WithOAuth2Properties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConnectorProfileCustomConnectorProfilePropertiesFactory, T1, T2, InnerConnectorProfileOAuth2PropertiesFactory> WithOAuth2Properties<T1, T2>(this CombinedResult<InnerConnectorProfileCustomConnectorProfilePropertiesFactory, T1, T2> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Properties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOAuth2Properties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorProfileCustomConnectorProfilePropertiesFactory, T2, InnerConnectorProfileOAuth2PropertiesFactory> WithOAuth2Properties<T1, T2>(this CombinedResult<T1, InnerConnectorProfileCustomConnectorProfilePropertiesFactory, T2> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Properties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOAuth2Properties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorProfileCustomConnectorProfilePropertiesFactory, InnerConnectorProfileOAuth2PropertiesFactory> WithOAuth2Properties<T1, T2>(this CombinedResult<T1, T2, InnerConnectorProfileCustomConnectorProfilePropertiesFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Properties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOAuth2Properties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConnectorProfileCustomConnectorProfilePropertiesFactory, T1, T2, T3, InnerConnectorProfileOAuth2PropertiesFactory> WithOAuth2Properties<T1, T2, T3>(this CombinedResult<InnerConnectorProfileCustomConnectorProfilePropertiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Properties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuth2Properties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorProfileCustomConnectorProfilePropertiesFactory, T2, T3, InnerConnectorProfileOAuth2PropertiesFactory> WithOAuth2Properties<T1, T2, T3>(this CombinedResult<T1, InnerConnectorProfileCustomConnectorProfilePropertiesFactory, T2, T3> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Properties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuth2Properties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorProfileCustomConnectorProfilePropertiesFactory, T3, InnerConnectorProfileOAuth2PropertiesFactory> WithOAuth2Properties<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectorProfileCustomConnectorProfilePropertiesFactory, T3> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Properties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuth2Properties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorProfileCustomConnectorProfilePropertiesFactory, InnerConnectorProfileOAuth2PropertiesFactory> WithOAuth2Properties<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectorProfileCustomConnectorProfilePropertiesFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Properties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuth2Properties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConnectorProfileCustomConnectorProfilePropertiesFactory, T1, T2, T3, T4, InnerConnectorProfileOAuth2PropertiesFactory> WithOAuth2Properties<T1, T2, T3, T4>(this CombinedResult<InnerConnectorProfileCustomConnectorProfilePropertiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Properties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuth2Properties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorProfileCustomConnectorProfilePropertiesFactory, T2, T3, T4, InnerConnectorProfileOAuth2PropertiesFactory> WithOAuth2Properties<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectorProfileCustomConnectorProfilePropertiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Properties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuth2Properties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorProfileCustomConnectorProfilePropertiesFactory, T3, T4, InnerConnectorProfileOAuth2PropertiesFactory> WithOAuth2Properties<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectorProfileCustomConnectorProfilePropertiesFactory, T3, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Properties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuth2Properties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorProfileCustomConnectorProfilePropertiesFactory, T4, InnerConnectorProfileOAuth2PropertiesFactory> WithOAuth2Properties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectorProfileCustomConnectorProfilePropertiesFactory, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Properties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuth2Properties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConnectorProfileCustomConnectorProfilePropertiesFactory, InnerConnectorProfileOAuth2PropertiesFactory> WithOAuth2Properties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectorProfileCustomConnectorProfilePropertiesFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Properties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuth2Properties(combinedResult.T5, subFactoryAction));
}
