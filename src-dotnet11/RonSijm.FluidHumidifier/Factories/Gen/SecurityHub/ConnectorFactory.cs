// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class ConnectorFactory(string resourceName = null, Action<Humidifier.SecurityHub.Connector> factoryAction = null) : ResourceFactory<Humidifier.SecurityHub.Connector>(resourceName)
{

    internal InnerConnectorProviderFactory ProviderFactory { get; set; }

    protected override Humidifier.SecurityHub.Connector Create()
    {
        var connectorResult = CreateConnector();
        factoryAction?.Invoke(connectorResult);

        return connectorResult;
    }

    private Humidifier.SecurityHub.Connector CreateConnector()
    {
        var connectorResult = new Humidifier.SecurityHub.Connector
        {
            GivenName = InputResourceName,
        };

        return connectorResult;
    }
    public override void CreateChildren(Humidifier.SecurityHub.Connector result)
    {
        base.CreateChildren(result);

        result.Provider ??= ProviderFactory?.Build();
    }

} // End Of Class

public static class ConnectorFactoryExtensions
{
    public static CombinedResult<ConnectorFactory, InnerConnectorProviderFactory> WithProvider(this ConnectorFactory parentFactory, Action<Humidifier.SecurityHub.ConnectorTypes.Provider> subFactoryAction = null)
    {
        parentFactory.ProviderFactory = new InnerConnectorProviderFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ProviderFactory);
    }

    public static CombinedResult<ConnectorFactory, T1, InnerConnectorProviderFactory> WithProvider<T1>(this CombinedResult<ConnectorFactory, T1> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, WithProvider(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectorFactory, InnerConnectorProviderFactory> WithProvider<T1>(this CombinedResult<T1, ConnectorFactory> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, WithProvider(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ConnectorFactory, T1, T2, InnerConnectorProviderFactory> WithProvider<T1, T2>(this CombinedResult<ConnectorFactory, T1, T2> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectorFactory, T2, InnerConnectorProviderFactory> WithProvider<T1, T2>(this CombinedResult<T1, ConnectorFactory, T2> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConnectorFactory, InnerConnectorProviderFactory> WithProvider<T1, T2>(this CombinedResult<T1, T2, ConnectorFactory> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ConnectorFactory, T1, T2, T3, InnerConnectorProviderFactory> WithProvider<T1, T2, T3>(this CombinedResult<ConnectorFactory, T1, T2, T3> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectorFactory, T2, T3, InnerConnectorProviderFactory> WithProvider<T1, T2, T3>(this CombinedResult<T1, ConnectorFactory, T2, T3> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConnectorFactory, T3, InnerConnectorProviderFactory> WithProvider<T1, T2, T3>(this CombinedResult<T1, T2, ConnectorFactory, T3> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConnectorFactory, InnerConnectorProviderFactory> WithProvider<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConnectorFactory> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ConnectorFactory, T1, T2, T3, T4, InnerConnectorProviderFactory> WithProvider<T1, T2, T3, T4>(this CombinedResult<ConnectorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectorFactory, T2, T3, T4, InnerConnectorProviderFactory> WithProvider<T1, T2, T3, T4>(this CombinedResult<T1, ConnectorFactory, T2, T3, T4> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConnectorFactory, T3, T4, InnerConnectorProviderFactory> WithProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConnectorFactory, T3, T4> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConnectorFactory, T4, InnerConnectorProviderFactory> WithProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConnectorFactory, T4> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ConnectorFactory, InnerConnectorProviderFactory> WithProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConnectorFactory> combinedResult, Action<Humidifier.SecurityHub.ConnectorTypes.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T5, subFactoryAction).T2);
}
