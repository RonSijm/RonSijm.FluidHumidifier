// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class ConnectorFactory(string resourceName = null, Action<Humidifier.AppFlow.Connector> factoryAction = null) : ResourceFactory<Humidifier.AppFlow.Connector>(resourceName)
{

    internal InnerConnectorConnectorProvisioningConfigFactory ConnectorProvisioningConfigFactory { get; set; }

    protected override Humidifier.AppFlow.Connector Create()
    {
        var connectorResult = CreateConnector();
        factoryAction?.Invoke(connectorResult);

        return connectorResult;
    }

    private Humidifier.AppFlow.Connector CreateConnector()
    {
        var connectorResult = new Humidifier.AppFlow.Connector
        {
            GivenName = InputResourceName,
        };

        return connectorResult;
    }
    public override void CreateChildren(Humidifier.AppFlow.Connector result)
    {
        base.CreateChildren(result);

        result.ConnectorProvisioningConfig ??= ConnectorProvisioningConfigFactory?.Build();
    }

} // End Of Class

public static class ConnectorFactoryExtensions
{
    public static CombinedResult<ConnectorFactory, InnerConnectorConnectorProvisioningConfigFactory> WithConnectorProvisioningConfig(this ConnectorFactory parentFactory, Action<Humidifier.AppFlow.ConnectorTypes.ConnectorProvisioningConfig> subFactoryAction = null)
    {
        parentFactory.ConnectorProvisioningConfigFactory = new InnerConnectorConnectorProvisioningConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConnectorProvisioningConfigFactory);
    }

    public static CombinedResult<ConnectorFactory, T1, InnerConnectorConnectorProvisioningConfigFactory> WithConnectorProvisioningConfig<T1>(this CombinedResult<ConnectorFactory, T1> combinedResult, Action<Humidifier.AppFlow.ConnectorTypes.ConnectorProvisioningConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectorProvisioningConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectorFactory, InnerConnectorConnectorProvisioningConfigFactory> WithConnectorProvisioningConfig<T1>(this CombinedResult<T1, ConnectorFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorTypes.ConnectorProvisioningConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectorProvisioningConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ConnectorFactory, T1, T2, InnerConnectorConnectorProvisioningConfigFactory> WithConnectorProvisioningConfig<T1, T2>(this CombinedResult<ConnectorFactory, T1, T2> combinedResult, Action<Humidifier.AppFlow.ConnectorTypes.ConnectorProvisioningConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectorProvisioningConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectorFactory, T2, InnerConnectorConnectorProvisioningConfigFactory> WithConnectorProvisioningConfig<T1, T2>(this CombinedResult<T1, ConnectorFactory, T2> combinedResult, Action<Humidifier.AppFlow.ConnectorTypes.ConnectorProvisioningConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectorProvisioningConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectorFactory, InnerConnectorConnectorProvisioningConfigFactory> WithConnectorProvisioningConfig<T1, T2>(this CombinedResult<T1, T2, ConnectorFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorTypes.ConnectorProvisioningConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectorProvisioningConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ConnectorFactory, T1, T2, T3, InnerConnectorConnectorProvisioningConfigFactory> WithConnectorProvisioningConfig<T1, T2, T3>(this CombinedResult<ConnectorFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFlow.ConnectorTypes.ConnectorProvisioningConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorProvisioningConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectorFactory, T2, T3, InnerConnectorConnectorProvisioningConfigFactory> WithConnectorProvisioningConfig<T1, T2, T3>(this CombinedResult<T1, ConnectorFactory, T2, T3> combinedResult, Action<Humidifier.AppFlow.ConnectorTypes.ConnectorProvisioningConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorProvisioningConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectorFactory, T3, InnerConnectorConnectorProvisioningConfigFactory> WithConnectorProvisioningConfig<T1, T2, T3>(this CombinedResult<T1, T2, ConnectorFactory, T3> combinedResult, Action<Humidifier.AppFlow.ConnectorTypes.ConnectorProvisioningConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorProvisioningConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConnectorFactory, InnerConnectorConnectorProvisioningConfigFactory> WithConnectorProvisioningConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConnectorFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorTypes.ConnectorProvisioningConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorProvisioningConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ConnectorFactory, T1, T2, T3, T4, InnerConnectorConnectorProvisioningConfigFactory> WithConnectorProvisioningConfig<T1, T2, T3, T4>(this CombinedResult<ConnectorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorTypes.ConnectorProvisioningConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorProvisioningConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectorFactory, T2, T3, T4, InnerConnectorConnectorProvisioningConfigFactory> WithConnectorProvisioningConfig<T1, T2, T3, T4>(this CombinedResult<T1, ConnectorFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorTypes.ConnectorProvisioningConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorProvisioningConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectorFactory, T3, T4, InnerConnectorConnectorProvisioningConfigFactory> WithConnectorProvisioningConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConnectorFactory, T3, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorTypes.ConnectorProvisioningConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorProvisioningConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConnectorFactory, T4, InnerConnectorConnectorProvisioningConfigFactory> WithConnectorProvisioningConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConnectorFactory, T4> combinedResult, Action<Humidifier.AppFlow.ConnectorTypes.ConnectorProvisioningConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorProvisioningConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ConnectorFactory, InnerConnectorConnectorProvisioningConfigFactory> WithConnectorProvisioningConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConnectorFactory> combinedResult, Action<Humidifier.AppFlow.ConnectorTypes.ConnectorProvisioningConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorProvisioningConfig(combinedResult.T5, subFactoryAction));
}
