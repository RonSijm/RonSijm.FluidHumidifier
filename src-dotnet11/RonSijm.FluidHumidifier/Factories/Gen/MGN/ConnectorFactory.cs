// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MGN;

public class ConnectorFactory(string resourceName = null, Action<Humidifier.MGN.Connector> factoryAction = null) : ResourceFactory<Humidifier.MGN.Connector>(resourceName)
{

    internal InnerConnectorConnectorSsmCommandConfigFactory SsmCommandConfigFactory { get; set; }

    protected override Humidifier.MGN.Connector Create()
    {
        var connectorResult = CreateConnector();
        factoryAction?.Invoke(connectorResult);

        return connectorResult;
    }

    private Humidifier.MGN.Connector CreateConnector()
    {
        var connectorResult = new Humidifier.MGN.Connector
        {
            GivenName = InputResourceName,
        };

        return connectorResult;
    }
    public override void CreateChildren(Humidifier.MGN.Connector result)
    {
        base.CreateChildren(result);

        result.SsmCommandConfig ??= SsmCommandConfigFactory?.Build();
    }

} // End Of Class

public static class ConnectorFactoryExtensions
{
    public static CombinedResult<ConnectorFactory, InnerConnectorConnectorSsmCommandConfigFactory> WithSsmCommandConfig(this ConnectorFactory parentFactory, Action<Humidifier.MGN.ConnectorTypes.ConnectorSsmCommandConfig> subFactoryAction = null)
    {
        parentFactory.SsmCommandConfigFactory = new InnerConnectorConnectorSsmCommandConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SsmCommandConfigFactory);
    }

    public static CombinedResult<ConnectorFactory, T1, InnerConnectorConnectorSsmCommandConfigFactory> WithSsmCommandConfig<T1>(this CombinedResult<ConnectorFactory, T1> combinedResult, Action<Humidifier.MGN.ConnectorTypes.ConnectorSsmCommandConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSsmCommandConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectorFactory, InnerConnectorConnectorSsmCommandConfigFactory> WithSsmCommandConfig<T1>(this CombinedResult<T1, ConnectorFactory> combinedResult, Action<Humidifier.MGN.ConnectorTypes.ConnectorSsmCommandConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSsmCommandConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ConnectorFactory, T1, T2, InnerConnectorConnectorSsmCommandConfigFactory> WithSsmCommandConfig<T1, T2>(this CombinedResult<ConnectorFactory, T1, T2> combinedResult, Action<Humidifier.MGN.ConnectorTypes.ConnectorSsmCommandConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSsmCommandConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectorFactory, T2, InnerConnectorConnectorSsmCommandConfigFactory> WithSsmCommandConfig<T1, T2>(this CombinedResult<T1, ConnectorFactory, T2> combinedResult, Action<Humidifier.MGN.ConnectorTypes.ConnectorSsmCommandConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSsmCommandConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConnectorFactory, InnerConnectorConnectorSsmCommandConfigFactory> WithSsmCommandConfig<T1, T2>(this CombinedResult<T1, T2, ConnectorFactory> combinedResult, Action<Humidifier.MGN.ConnectorTypes.ConnectorSsmCommandConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSsmCommandConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ConnectorFactory, T1, T2, T3, InnerConnectorConnectorSsmCommandConfigFactory> WithSsmCommandConfig<T1, T2, T3>(this CombinedResult<ConnectorFactory, T1, T2, T3> combinedResult, Action<Humidifier.MGN.ConnectorTypes.ConnectorSsmCommandConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSsmCommandConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectorFactory, T2, T3, InnerConnectorConnectorSsmCommandConfigFactory> WithSsmCommandConfig<T1, T2, T3>(this CombinedResult<T1, ConnectorFactory, T2, T3> combinedResult, Action<Humidifier.MGN.ConnectorTypes.ConnectorSsmCommandConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSsmCommandConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConnectorFactory, T3, InnerConnectorConnectorSsmCommandConfigFactory> WithSsmCommandConfig<T1, T2, T3>(this CombinedResult<T1, T2, ConnectorFactory, T3> combinedResult, Action<Humidifier.MGN.ConnectorTypes.ConnectorSsmCommandConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSsmCommandConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConnectorFactory, InnerConnectorConnectorSsmCommandConfigFactory> WithSsmCommandConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConnectorFactory> combinedResult, Action<Humidifier.MGN.ConnectorTypes.ConnectorSsmCommandConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSsmCommandConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ConnectorFactory, T1, T2, T3, T4, InnerConnectorConnectorSsmCommandConfigFactory> WithSsmCommandConfig<T1, T2, T3, T4>(this CombinedResult<ConnectorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MGN.ConnectorTypes.ConnectorSsmCommandConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSsmCommandConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectorFactory, T2, T3, T4, InnerConnectorConnectorSsmCommandConfigFactory> WithSsmCommandConfig<T1, T2, T3, T4>(this CombinedResult<T1, ConnectorFactory, T2, T3, T4> combinedResult, Action<Humidifier.MGN.ConnectorTypes.ConnectorSsmCommandConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSsmCommandConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConnectorFactory, T3, T4, InnerConnectorConnectorSsmCommandConfigFactory> WithSsmCommandConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConnectorFactory, T3, T4> combinedResult, Action<Humidifier.MGN.ConnectorTypes.ConnectorSsmCommandConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSsmCommandConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConnectorFactory, T4, InnerConnectorConnectorSsmCommandConfigFactory> WithSsmCommandConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConnectorFactory, T4> combinedResult, Action<Humidifier.MGN.ConnectorTypes.ConnectorSsmCommandConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSsmCommandConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ConnectorFactory, InnerConnectorConnectorSsmCommandConfigFactory> WithSsmCommandConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConnectorFactory> combinedResult, Action<Humidifier.MGN.ConnectorTypes.ConnectorSsmCommandConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSsmCommandConfig(combinedResult.T5, subFactoryAction).T2);
}
