// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class ConnectorV2Factory(string resourceName = null, Action<Humidifier.SecurityHub.ConnectorV2> factoryAction = null) : ResourceFactory<Humidifier.SecurityHub.ConnectorV2>(resourceName)
{

    internal InnerConnectorV2ProviderFactory ProviderFactory { get; set; }

    protected override Humidifier.SecurityHub.ConnectorV2 Create()
    {
        var connectorV2Result = CreateConnectorV2();
        factoryAction?.Invoke(connectorV2Result);

        return connectorV2Result;
    }

    private Humidifier.SecurityHub.ConnectorV2 CreateConnectorV2()
    {
        var connectorV2Result = new Humidifier.SecurityHub.ConnectorV2
        {
            GivenName = InputResourceName,
        };

        return connectorV2Result;
    }
    public override void CreateChildren(Humidifier.SecurityHub.ConnectorV2 result)
    {
        base.CreateChildren(result);

        result.Provider ??= ProviderFactory?.Build();
    }

} // End Of Class

public static class ConnectorV2FactoryExtensions
{
    public static CombinedResult<ConnectorV2Factory, InnerConnectorV2ProviderFactory> WithProvider(this ConnectorV2Factory parentFactory, Action<Humidifier.SecurityHub.ConnectorV2Types.Provider> subFactoryAction = null)
    {
        parentFactory.ProviderFactory = new InnerConnectorV2ProviderFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ProviderFactory);
    }

    public static CombinedResult<ConnectorV2Factory, T1, InnerConnectorV2ProviderFactory> WithProvider<T1>(this CombinedResult<ConnectorV2Factory, T1> combinedResult, Action<Humidifier.SecurityHub.ConnectorV2Types.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, WithProvider(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectorV2Factory, InnerConnectorV2ProviderFactory> WithProvider<T1>(this CombinedResult<T1, ConnectorV2Factory> combinedResult, Action<Humidifier.SecurityHub.ConnectorV2Types.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, WithProvider(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ConnectorV2Factory, T1, T2, InnerConnectorV2ProviderFactory> WithProvider<T1, T2>(this CombinedResult<ConnectorV2Factory, T1, T2> combinedResult, Action<Humidifier.SecurityHub.ConnectorV2Types.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectorV2Factory, T2, InnerConnectorV2ProviderFactory> WithProvider<T1, T2>(this CombinedResult<T1, ConnectorV2Factory, T2> combinedResult, Action<Humidifier.SecurityHub.ConnectorV2Types.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConnectorV2Factory, InnerConnectorV2ProviderFactory> WithProvider<T1, T2>(this CombinedResult<T1, T2, ConnectorV2Factory> combinedResult, Action<Humidifier.SecurityHub.ConnectorV2Types.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ConnectorV2Factory, T1, T2, T3, InnerConnectorV2ProviderFactory> WithProvider<T1, T2, T3>(this CombinedResult<ConnectorV2Factory, T1, T2, T3> combinedResult, Action<Humidifier.SecurityHub.ConnectorV2Types.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectorV2Factory, T2, T3, InnerConnectorV2ProviderFactory> WithProvider<T1, T2, T3>(this CombinedResult<T1, ConnectorV2Factory, T2, T3> combinedResult, Action<Humidifier.SecurityHub.ConnectorV2Types.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConnectorV2Factory, T3, InnerConnectorV2ProviderFactory> WithProvider<T1, T2, T3>(this CombinedResult<T1, T2, ConnectorV2Factory, T3> combinedResult, Action<Humidifier.SecurityHub.ConnectorV2Types.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConnectorV2Factory, InnerConnectorV2ProviderFactory> WithProvider<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConnectorV2Factory> combinedResult, Action<Humidifier.SecurityHub.ConnectorV2Types.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ConnectorV2Factory, T1, T2, T3, T4, InnerConnectorV2ProviderFactory> WithProvider<T1, T2, T3, T4>(this CombinedResult<ConnectorV2Factory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecurityHub.ConnectorV2Types.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectorV2Factory, T2, T3, T4, InnerConnectorV2ProviderFactory> WithProvider<T1, T2, T3, T4>(this CombinedResult<T1, ConnectorV2Factory, T2, T3, T4> combinedResult, Action<Humidifier.SecurityHub.ConnectorV2Types.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConnectorV2Factory, T3, T4, InnerConnectorV2ProviderFactory> WithProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConnectorV2Factory, T3, T4> combinedResult, Action<Humidifier.SecurityHub.ConnectorV2Types.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConnectorV2Factory, T4, InnerConnectorV2ProviderFactory> WithProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConnectorV2Factory, T4> combinedResult, Action<Humidifier.SecurityHub.ConnectorV2Types.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ConnectorV2Factory, InnerConnectorV2ProviderFactory> WithProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConnectorV2Factory> combinedResult, Action<Humidifier.SecurityHub.ConnectorV2Types.Provider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvider(combinedResult.T5, subFactoryAction).T2);
}
