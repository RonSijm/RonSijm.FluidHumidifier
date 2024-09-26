// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class ConnectorDefinitionFactory(string resourceName = null, Action<Humidifier.Greengrass.ConnectorDefinition> factoryAction = null) : ResourceFactory<Humidifier.Greengrass.ConnectorDefinition>(resourceName)
{

    internal InnerConnectorDefinitionConnectorDefinitionVersionFactory InitialVersionFactory { get; set; }

    protected override Humidifier.Greengrass.ConnectorDefinition Create()
    {
        var connectorDefinitionResult = CreateConnectorDefinition();
        factoryAction?.Invoke(connectorDefinitionResult);

        return connectorDefinitionResult;
    }

    private Humidifier.Greengrass.ConnectorDefinition CreateConnectorDefinition()
    {
        var connectorDefinitionResult = new Humidifier.Greengrass.ConnectorDefinition
        {
            GivenName = InputResourceName,
        };

        return connectorDefinitionResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.ConnectorDefinition result)
    {
        base.CreateChildren(result);

        result.InitialVersion ??= InitialVersionFactory?.Build();
    }

} // End Of Class

public static class ConnectorDefinitionFactoryExtensions
{
    public static CombinedResult<ConnectorDefinitionFactory, InnerConnectorDefinitionConnectorDefinitionVersionFactory> WithInitialVersion(this ConnectorDefinitionFactory parentFactory, Action<Humidifier.Greengrass.ConnectorDefinitionTypes.ConnectorDefinitionVersion> subFactoryAction = null)
    {
        parentFactory.InitialVersionFactory = new InnerConnectorDefinitionConnectorDefinitionVersionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InitialVersionFactory);
    }

    public static CombinedResult<ConnectorDefinitionFactory, T1, InnerConnectorDefinitionConnectorDefinitionVersionFactory> WithInitialVersion<T1>(this CombinedResult<ConnectorDefinitionFactory, T1> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionTypes.ConnectorDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, WithInitialVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectorDefinitionFactory, InnerConnectorDefinitionConnectorDefinitionVersionFactory> WithInitialVersion<T1>(this CombinedResult<T1, ConnectorDefinitionFactory> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionTypes.ConnectorDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, WithInitialVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ConnectorDefinitionFactory, T1, T2, InnerConnectorDefinitionConnectorDefinitionVersionFactory> WithInitialVersion<T1, T2>(this CombinedResult<ConnectorDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionTypes.ConnectorDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectorDefinitionFactory, T2, InnerConnectorDefinitionConnectorDefinitionVersionFactory> WithInitialVersion<T1, T2>(this CombinedResult<T1, ConnectorDefinitionFactory, T2> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionTypes.ConnectorDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectorDefinitionFactory, InnerConnectorDefinitionConnectorDefinitionVersionFactory> WithInitialVersion<T1, T2>(this CombinedResult<T1, T2, ConnectorDefinitionFactory> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionTypes.ConnectorDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ConnectorDefinitionFactory, T1, T2, T3, InnerConnectorDefinitionConnectorDefinitionVersionFactory> WithInitialVersion<T1, T2, T3>(this CombinedResult<ConnectorDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionTypes.ConnectorDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectorDefinitionFactory, T2, T3, InnerConnectorDefinitionConnectorDefinitionVersionFactory> WithInitialVersion<T1, T2, T3>(this CombinedResult<T1, ConnectorDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionTypes.ConnectorDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectorDefinitionFactory, T3, InnerConnectorDefinitionConnectorDefinitionVersionFactory> WithInitialVersion<T1, T2, T3>(this CombinedResult<T1, T2, ConnectorDefinitionFactory, T3> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionTypes.ConnectorDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConnectorDefinitionFactory, InnerConnectorDefinitionConnectorDefinitionVersionFactory> WithInitialVersion<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConnectorDefinitionFactory> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionTypes.ConnectorDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ConnectorDefinitionFactory, T1, T2, T3, T4, InnerConnectorDefinitionConnectorDefinitionVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<ConnectorDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionTypes.ConnectorDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectorDefinitionFactory, T2, T3, T4, InnerConnectorDefinitionConnectorDefinitionVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<T1, ConnectorDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionTypes.ConnectorDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectorDefinitionFactory, T3, T4, InnerConnectorDefinitionConnectorDefinitionVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConnectorDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionTypes.ConnectorDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConnectorDefinitionFactory, T4, InnerConnectorDefinitionConnectorDefinitionVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConnectorDefinitionFactory, T4> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionTypes.ConnectorDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ConnectorDefinitionFactory, InnerConnectorDefinitionConnectorDefinitionVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConnectorDefinitionFactory> combinedResult, Action<Humidifier.Greengrass.ConnectorDefinitionTypes.ConnectorDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T5, subFactoryAction));
}
