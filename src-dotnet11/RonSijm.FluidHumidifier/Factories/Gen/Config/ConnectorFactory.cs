// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Config;

public class ConnectorFactory(string resourceName = null, Action<Humidifier.Config.Connector> factoryAction = null) : ResourceFactory<Humidifier.Config.Connector>(resourceName)
{

    internal InnerConnectorConnectorConfigurationFactory ConnectorConfigurationFactory { get; set; }

    protected override Humidifier.Config.Connector Create()
    {
        var connectorResult = CreateConnector();
        factoryAction?.Invoke(connectorResult);

        return connectorResult;
    }

    private Humidifier.Config.Connector CreateConnector()
    {
        var connectorResult = new Humidifier.Config.Connector
        {
            GivenName = InputResourceName,
        };

        return connectorResult;
    }
    public override void CreateChildren(Humidifier.Config.Connector result)
    {
        base.CreateChildren(result);

        result.ConnectorConfiguration ??= ConnectorConfigurationFactory?.Build();
    }

} // End Of Class

public static class ConnectorFactoryExtensions
{
    public static CombinedResult<ConnectorFactory, InnerConnectorConnectorConfigurationFactory> WithConnectorConfiguration(this ConnectorFactory parentFactory, Action<Humidifier.Config.ConnectorTypes.ConnectorConfiguration> subFactoryAction = null)
    {
        parentFactory.ConnectorConfigurationFactory = new InnerConnectorConnectorConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConnectorConfigurationFactory);
    }

    public static CombinedResult<ConnectorFactory, T1, InnerConnectorConnectorConfigurationFactory> WithConnectorConfiguration<T1>(this CombinedResult<ConnectorFactory, T1> combinedResult, Action<Humidifier.Config.ConnectorTypes.ConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectorConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectorFactory, InnerConnectorConnectorConfigurationFactory> WithConnectorConfiguration<T1>(this CombinedResult<T1, ConnectorFactory> combinedResult, Action<Humidifier.Config.ConnectorTypes.ConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectorConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ConnectorFactory, T1, T2, InnerConnectorConnectorConfigurationFactory> WithConnectorConfiguration<T1, T2>(this CombinedResult<ConnectorFactory, T1, T2> combinedResult, Action<Humidifier.Config.ConnectorTypes.ConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectorConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectorFactory, T2, InnerConnectorConnectorConfigurationFactory> WithConnectorConfiguration<T1, T2>(this CombinedResult<T1, ConnectorFactory, T2> combinedResult, Action<Humidifier.Config.ConnectorTypes.ConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectorConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConnectorFactory, InnerConnectorConnectorConfigurationFactory> WithConnectorConfiguration<T1, T2>(this CombinedResult<T1, T2, ConnectorFactory> combinedResult, Action<Humidifier.Config.ConnectorTypes.ConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectorConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ConnectorFactory, T1, T2, T3, InnerConnectorConnectorConfigurationFactory> WithConnectorConfiguration<T1, T2, T3>(this CombinedResult<ConnectorFactory, T1, T2, T3> combinedResult, Action<Humidifier.Config.ConnectorTypes.ConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectorFactory, T2, T3, InnerConnectorConnectorConfigurationFactory> WithConnectorConfiguration<T1, T2, T3>(this CombinedResult<T1, ConnectorFactory, T2, T3> combinedResult, Action<Humidifier.Config.ConnectorTypes.ConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConnectorFactory, T3, InnerConnectorConnectorConfigurationFactory> WithConnectorConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, ConnectorFactory, T3> combinedResult, Action<Humidifier.Config.ConnectorTypes.ConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConnectorFactory, InnerConnectorConnectorConfigurationFactory> WithConnectorConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConnectorFactory> combinedResult, Action<Humidifier.Config.ConnectorTypes.ConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ConnectorFactory, T1, T2, T3, T4, InnerConnectorConnectorConfigurationFactory> WithConnectorConfiguration<T1, T2, T3, T4>(this CombinedResult<ConnectorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Config.ConnectorTypes.ConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectorFactory, T2, T3, T4, InnerConnectorConnectorConfigurationFactory> WithConnectorConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, ConnectorFactory, T2, T3, T4> combinedResult, Action<Humidifier.Config.ConnectorTypes.ConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConnectorFactory, T3, T4, InnerConnectorConnectorConfigurationFactory> WithConnectorConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConnectorFactory, T3, T4> combinedResult, Action<Humidifier.Config.ConnectorTypes.ConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConnectorFactory, T4, InnerConnectorConnectorConfigurationFactory> WithConnectorConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConnectorFactory, T4> combinedResult, Action<Humidifier.Config.ConnectorTypes.ConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ConnectorFactory, InnerConnectorConnectorConfigurationFactory> WithConnectorConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConnectorFactory> combinedResult, Action<Humidifier.Config.ConnectorTypes.ConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectorConfiguration(combinedResult.T5, subFactoryAction).T2);
}
