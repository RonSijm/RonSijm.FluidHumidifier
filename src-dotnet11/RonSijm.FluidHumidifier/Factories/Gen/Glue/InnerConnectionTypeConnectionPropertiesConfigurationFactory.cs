// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerConnectionTypeConnectionPropertiesConfigurationFactory(Action<Humidifier.Glue.ConnectionTypeTypes.ConnectionPropertiesConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Glue.ConnectionTypeTypes.ConnectionPropertiesConfiguration>
{

    internal InnerConnectionTypeConnectorPropertyFactory UrlFactory { get; set; }

    protected override Humidifier.Glue.ConnectionTypeTypes.ConnectionPropertiesConfiguration Create()
    {
        var connectionPropertiesConfigurationResult = CreateConnectionPropertiesConfiguration();
        factoryAction?.Invoke(connectionPropertiesConfigurationResult);

        return connectionPropertiesConfigurationResult;
    }

    private Humidifier.Glue.ConnectionTypeTypes.ConnectionPropertiesConfiguration CreateConnectionPropertiesConfiguration()
    {
        var connectionPropertiesConfigurationResult = new Humidifier.Glue.ConnectionTypeTypes.ConnectionPropertiesConfiguration();

        return connectionPropertiesConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Glue.ConnectionTypeTypes.ConnectionPropertiesConfiguration result)
    {
        base.CreateChildren(result);

        result.Url ??= UrlFactory?.Build();
    }

} // End Of Class

public static class InnerConnectionTypeConnectionPropertiesConfigurationFactoryExtensions
{
    public static CombinedResult<InnerConnectionTypeConnectionPropertiesConfigurationFactory, InnerConnectionTypeConnectorPropertyFactory> WithUrl(this InnerConnectionTypeConnectionPropertiesConfigurationFactory parentFactory, Action<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty> subFactoryAction = null)
    {
        parentFactory.UrlFactory = new InnerConnectionTypeConnectorPropertyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.UrlFactory);
    }

    public static CombinedResult<InnerConnectionTypeConnectionPropertiesConfigurationFactory, T1, InnerConnectionTypeConnectorPropertyFactory> WithUrl<T1>(this CombinedResult<InnerConnectionTypeConnectionPropertiesConfigurationFactory, T1> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, WithUrl(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionTypeConnectionPropertiesConfigurationFactory, InnerConnectionTypeConnectorPropertyFactory> WithUrl<T1>(this CombinedResult<T1, InnerConnectionTypeConnectionPropertiesConfigurationFactory> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, WithUrl(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerConnectionTypeConnectionPropertiesConfigurationFactory, T1, T2, InnerConnectionTypeConnectorPropertyFactory> WithUrl<T1, T2>(this CombinedResult<InnerConnectionTypeConnectionPropertiesConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUrl(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionTypeConnectionPropertiesConfigurationFactory, T2, InnerConnectionTypeConnectorPropertyFactory> WithUrl<T1, T2>(this CombinedResult<T1, InnerConnectionTypeConnectionPropertiesConfigurationFactory, T2> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUrl(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectionTypeConnectionPropertiesConfigurationFactory, InnerConnectionTypeConnectorPropertyFactory> WithUrl<T1, T2>(this CombinedResult<T1, T2, InnerConnectionTypeConnectionPropertiesConfigurationFactory> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUrl(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerConnectionTypeConnectionPropertiesConfigurationFactory, T1, T2, T3, InnerConnectionTypeConnectorPropertyFactory> WithUrl<T1, T2, T3>(this CombinedResult<InnerConnectionTypeConnectionPropertiesConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUrl(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionTypeConnectionPropertiesConfigurationFactory, T2, T3, InnerConnectionTypeConnectorPropertyFactory> WithUrl<T1, T2, T3>(this CombinedResult<T1, InnerConnectionTypeConnectionPropertiesConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUrl(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectionTypeConnectionPropertiesConfigurationFactory, T3, InnerConnectionTypeConnectorPropertyFactory> WithUrl<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectionTypeConnectionPropertiesConfigurationFactory, T3> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUrl(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConnectionTypeConnectionPropertiesConfigurationFactory, InnerConnectionTypeConnectorPropertyFactory> WithUrl<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectionTypeConnectionPropertiesConfigurationFactory> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUrl(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerConnectionTypeConnectionPropertiesConfigurationFactory, T1, T2, T3, T4, InnerConnectionTypeConnectorPropertyFactory> WithUrl<T1, T2, T3, T4>(this CombinedResult<InnerConnectionTypeConnectionPropertiesConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUrl(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionTypeConnectionPropertiesConfigurationFactory, T2, T3, T4, InnerConnectionTypeConnectorPropertyFactory> WithUrl<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectionTypeConnectionPropertiesConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUrl(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectionTypeConnectionPropertiesConfigurationFactory, T3, T4, InnerConnectionTypeConnectorPropertyFactory> WithUrl<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectionTypeConnectionPropertiesConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUrl(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConnectionTypeConnectionPropertiesConfigurationFactory, T4, InnerConnectionTypeConnectorPropertyFactory> WithUrl<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectionTypeConnectionPropertiesConfigurationFactory, T4> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUrl(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerConnectionTypeConnectionPropertiesConfigurationFactory, InnerConnectionTypeConnectorPropertyFactory> WithUrl<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectionTypeConnectionPropertiesConfigurationFactory> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUrl(combinedResult.T5, subFactoryAction).T2);
}
