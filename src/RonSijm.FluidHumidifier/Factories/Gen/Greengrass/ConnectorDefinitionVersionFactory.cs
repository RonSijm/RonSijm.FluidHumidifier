// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class ConnectorDefinitionVersionFactory(string resourceName = null, Action<Humidifier.Greengrass.ConnectorDefinitionVersion> factoryAction = null) : ResourceFactory<Humidifier.Greengrass.ConnectorDefinitionVersion>(resourceName)
{

    internal List<InnerConnectorDefinitionVersionConnectorFactory> ConnectorsFactories { get; set; } = [];

    protected override Humidifier.Greengrass.ConnectorDefinitionVersion Create()
    {
        var connectorDefinitionVersionResult = CreateConnectorDefinitionVersion();
        factoryAction?.Invoke(connectorDefinitionVersionResult);

        return connectorDefinitionVersionResult;
    }

    private Humidifier.Greengrass.ConnectorDefinitionVersion CreateConnectorDefinitionVersion()
    {
        var connectorDefinitionVersionResult = new Humidifier.Greengrass.ConnectorDefinitionVersion
        {
            GivenName = InputResourceName,
        };

        return connectorDefinitionVersionResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.ConnectorDefinitionVersion result)
    {
        base.CreateChildren(result);

        result.Connectors = ConnectorsFactories.Any() ? ConnectorsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ConnectorDefinitionVersionFactoryExtensions
{
    public static CombinedResult<ConnectorDefinitionVersionFactory, InnerConnectorDefinitionVersionConnectorFactory> WithConnectors(this ConnectorDefinitionVersionFactory parentFactory, Action<Humidifier.Greengrass.ConnectorDefinitionVersionTypes.Connector> subFactoryAction = null)
    {
        var factory = new InnerConnectorDefinitionVersionConnectorFactory(subFactoryAction);
        parentFactory.ConnectorsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ConnectorDefinitionVersionFactory, T1, InnerConnectorDefinitionVersionConnectorFactory> WithConnectors<T1>(this CombinedResult<ConnectorDefinitionVersionFactory, T1> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionVersionTypes.Connector> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectorDefinitionVersionFactory, InnerConnectorDefinitionVersionConnectorFactory> WithConnectors<T1>(this CombinedResult<T1, ConnectorDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionVersionTypes.Connector> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ConnectorDefinitionVersionFactory, T1, T2, InnerConnectorDefinitionVersionConnectorFactory> WithConnectors<T1, T2>(this CombinedResult<ConnectorDefinitionVersionFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionVersionTypes.Connector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectorDefinitionVersionFactory, T2, InnerConnectorDefinitionVersionConnectorFactory> WithConnectors<T1, T2>(this CombinedResult<T1, ConnectorDefinitionVersionFactory, T2> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionVersionTypes.Connector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectorDefinitionVersionFactory, InnerConnectorDefinitionVersionConnectorFactory> WithConnectors<T1, T2>(this CombinedResult<T1, T2, ConnectorDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionVersionTypes.Connector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ConnectorDefinitionVersionFactory, T1, T2, T3, InnerConnectorDefinitionVersionConnectorFactory> WithConnectors<T1, T2, T3>(this CombinedResult<ConnectorDefinitionVersionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionVersionTypes.Connector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectorDefinitionVersionFactory, T2, T3, InnerConnectorDefinitionVersionConnectorFactory> WithConnectors<T1, T2, T3>(this CombinedResult<T1, ConnectorDefinitionVersionFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionVersionTypes.Connector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectorDefinitionVersionFactory, T3, InnerConnectorDefinitionVersionConnectorFactory> WithConnectors<T1, T2, T3>(this CombinedResult<T1, T2, ConnectorDefinitionVersionFactory, T3> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionVersionTypes.Connector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConnectorDefinitionVersionFactory, InnerConnectorDefinitionVersionConnectorFactory> WithConnectors<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConnectorDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionVersionTypes.Connector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectors(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ConnectorDefinitionVersionFactory, T1, T2, T3, T4, InnerConnectorDefinitionVersionConnectorFactory> WithConnectors<T1, T2, T3, T4>(this CombinedResult<ConnectorDefinitionVersionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionVersionTypes.Connector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectorDefinitionVersionFactory, T2, T3, T4, InnerConnectorDefinitionVersionConnectorFactory> WithConnectors<T1, T2, T3, T4>(this CombinedResult<T1, ConnectorDefinitionVersionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionVersionTypes.Connector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectorDefinitionVersionFactory, T3, T4, InnerConnectorDefinitionVersionConnectorFactory> WithConnectors<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConnectorDefinitionVersionFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionVersionTypes.Connector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConnectorDefinitionVersionFactory, T4, InnerConnectorDefinitionVersionConnectorFactory> WithConnectors<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConnectorDefinitionVersionFactory, T4> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionVersionTypes.Connector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectors(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ConnectorDefinitionVersionFactory, InnerConnectorDefinitionVersionConnectorFactory> WithConnectors<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConnectorDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionVersionTypes.Connector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectors(combinedResult.T5, subFactoryAction));
}
