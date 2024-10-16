// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerConnectorDefinitionConnectorDefinitionVersionFactory(Action<Humidifier.Greengrass.ConnectorDefinitionTypes.ConnectorDefinitionVersion> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.ConnectorDefinitionTypes.ConnectorDefinitionVersion>
{

    internal List<InnerConnectorDefinitionConnectorFactory> ConnectorsFactories { get; set; } = [];

    protected override Humidifier.Greengrass.ConnectorDefinitionTypes.ConnectorDefinitionVersion Create()
    {
        var connectorDefinitionVersionResult = CreateConnectorDefinitionVersion();
        factoryAction?.Invoke(connectorDefinitionVersionResult);

        return connectorDefinitionVersionResult;
    }

    private Humidifier.Greengrass.ConnectorDefinitionTypes.ConnectorDefinitionVersion CreateConnectorDefinitionVersion()
    {
        var connectorDefinitionVersionResult = new Humidifier.Greengrass.ConnectorDefinitionTypes.ConnectorDefinitionVersion();

        return connectorDefinitionVersionResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.ConnectorDefinitionTypes.ConnectorDefinitionVersion result)
    {
        base.CreateChildren(result);

        result.Connectors = ConnectorsFactories.Any() ? ConnectorsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class InnerConnectorDefinitionConnectorDefinitionVersionFactoryExtensions
{
    public static CombinedResult<InnerConnectorDefinitionConnectorDefinitionVersionFactory, InnerConnectorDefinitionConnectorFactory> WithConnectors(this InnerConnectorDefinitionConnectorDefinitionVersionFactory parentFactory, Action<Humidifier.Greengrass.ConnectorDefinitionTypes.Connector> subFactoryAction = null)
    {
        var factory = new InnerConnectorDefinitionConnectorFactory(subFactoryAction);
        parentFactory.ConnectorsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<InnerConnectorDefinitionConnectorDefinitionVersionFactory, T1, InnerConnectorDefinitionConnectorFactory> WithConnectors<T1>(this CombinedResult<InnerConnectorDefinitionConnectorDefinitionVersionFactory, T1> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionTypes.Connector> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorDefinitionConnectorDefinitionVersionFactory, InnerConnectorDefinitionConnectorFactory> WithConnectors<T1>(this CombinedResult<T1, InnerConnectorDefinitionConnectorDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionTypes.Connector> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConnectorDefinitionConnectorDefinitionVersionFactory, T1, T2, InnerConnectorDefinitionConnectorFactory> WithConnectors<T1, T2>(this CombinedResult<InnerConnectorDefinitionConnectorDefinitionVersionFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionTypes.Connector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorDefinitionConnectorDefinitionVersionFactory, T2, InnerConnectorDefinitionConnectorFactory> WithConnectors<T1, T2>(this CombinedResult<T1, InnerConnectorDefinitionConnectorDefinitionVersionFactory, T2> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionTypes.Connector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorDefinitionConnectorDefinitionVersionFactory, InnerConnectorDefinitionConnectorFactory> WithConnectors<T1, T2>(this CombinedResult<T1, T2, InnerConnectorDefinitionConnectorDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionTypes.Connector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConnectorDefinitionConnectorDefinitionVersionFactory, T1, T2, T3, InnerConnectorDefinitionConnectorFactory> WithConnectors<T1, T2, T3>(this CombinedResult<InnerConnectorDefinitionConnectorDefinitionVersionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionTypes.Connector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorDefinitionConnectorDefinitionVersionFactory, T2, T3, InnerConnectorDefinitionConnectorFactory> WithConnectors<T1, T2, T3>(this CombinedResult<T1, InnerConnectorDefinitionConnectorDefinitionVersionFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionTypes.Connector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorDefinitionConnectorDefinitionVersionFactory, T3, InnerConnectorDefinitionConnectorFactory> WithConnectors<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectorDefinitionConnectorDefinitionVersionFactory, T3> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionTypes.Connector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorDefinitionConnectorDefinitionVersionFactory, InnerConnectorDefinitionConnectorFactory> WithConnectors<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectorDefinitionConnectorDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionTypes.Connector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectors(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConnectorDefinitionConnectorDefinitionVersionFactory, T1, T2, T3, T4, InnerConnectorDefinitionConnectorFactory> WithConnectors<T1, T2, T3, T4>(this CombinedResult<InnerConnectorDefinitionConnectorDefinitionVersionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionTypes.Connector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorDefinitionConnectorDefinitionVersionFactory, T2, T3, T4, InnerConnectorDefinitionConnectorFactory> WithConnectors<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectorDefinitionConnectorDefinitionVersionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionTypes.Connector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorDefinitionConnectorDefinitionVersionFactory, T3, T4, InnerConnectorDefinitionConnectorFactory> WithConnectors<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectorDefinitionConnectorDefinitionVersionFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionTypes.Connector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorDefinitionConnectorDefinitionVersionFactory, T4, InnerConnectorDefinitionConnectorFactory> WithConnectors<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectorDefinitionConnectorDefinitionVersionFactory, T4> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionTypes.Connector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectors(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConnectorDefinitionConnectorDefinitionVersionFactory, InnerConnectorDefinitionConnectorFactory> WithConnectors<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectorDefinitionConnectorDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionTypes.Connector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectors(combinedResult.T5, subFactoryAction));
}
