// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.InspectorV2;

public class ConnectorFactory(string resourceName = null, Action<Humidifier.InspectorV2.Connector> factoryAction = null) : ResourceFactory<Humidifier.InspectorV2.Connector>(resourceName)
{

    internal InnerConnectorProviderConfigurationFactory ProviderConfigurationFactory { get; set; }

    protected override Humidifier.InspectorV2.Connector Create()
    {
        var connectorResult = CreateConnector();
        factoryAction?.Invoke(connectorResult);

        return connectorResult;
    }

    private Humidifier.InspectorV2.Connector CreateConnector()
    {
        var connectorResult = new Humidifier.InspectorV2.Connector
        {
            GivenName = InputResourceName,
        };

        return connectorResult;
    }
    public override void CreateChildren(Humidifier.InspectorV2.Connector result)
    {
        base.CreateChildren(result);

        result.ProviderConfiguration ??= ProviderConfigurationFactory?.Build();
    }

} // End Of Class

public static class ConnectorFactoryExtensions
{
    public static CombinedResult<ConnectorFactory, InnerConnectorProviderConfigurationFactory> WithProviderConfiguration(this ConnectorFactory parentFactory, Action<Humidifier.InspectorV2.ConnectorTypes.ProviderConfiguration> subFactoryAction = null)
    {
        parentFactory.ProviderConfigurationFactory = new InnerConnectorProviderConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ProviderConfigurationFactory);
    }

    public static CombinedResult<ConnectorFactory, T1, InnerConnectorProviderConfigurationFactory> WithProviderConfiguration<T1>(this CombinedResult<ConnectorFactory, T1> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.ProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithProviderConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectorFactory, InnerConnectorProviderConfigurationFactory> WithProviderConfiguration<T1>(this CombinedResult<T1, ConnectorFactory> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.ProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithProviderConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ConnectorFactory, T1, T2, InnerConnectorProviderConfigurationFactory> WithProviderConfiguration<T1, T2>(this CombinedResult<ConnectorFactory, T1, T2> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.ProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProviderConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectorFactory, T2, InnerConnectorProviderConfigurationFactory> WithProviderConfiguration<T1, T2>(this CombinedResult<T1, ConnectorFactory, T2> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.ProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProviderConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConnectorFactory, InnerConnectorProviderConfigurationFactory> WithProviderConfiguration<T1, T2>(this CombinedResult<T1, T2, ConnectorFactory> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.ProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProviderConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ConnectorFactory, T1, T2, T3, InnerConnectorProviderConfigurationFactory> WithProviderConfiguration<T1, T2, T3>(this CombinedResult<ConnectorFactory, T1, T2, T3> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.ProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProviderConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectorFactory, T2, T3, InnerConnectorProviderConfigurationFactory> WithProviderConfiguration<T1, T2, T3>(this CombinedResult<T1, ConnectorFactory, T2, T3> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.ProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProviderConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConnectorFactory, T3, InnerConnectorProviderConfigurationFactory> WithProviderConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, ConnectorFactory, T3> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.ProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProviderConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConnectorFactory, InnerConnectorProviderConfigurationFactory> WithProviderConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConnectorFactory> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.ProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProviderConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ConnectorFactory, T1, T2, T3, T4, InnerConnectorProviderConfigurationFactory> WithProviderConfiguration<T1, T2, T3, T4>(this CombinedResult<ConnectorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.ProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProviderConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectorFactory, T2, T3, T4, InnerConnectorProviderConfigurationFactory> WithProviderConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, ConnectorFactory, T2, T3, T4> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.ProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProviderConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConnectorFactory, T3, T4, InnerConnectorProviderConfigurationFactory> WithProviderConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConnectorFactory, T3, T4> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.ProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProviderConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConnectorFactory, T4, InnerConnectorProviderConfigurationFactory> WithProviderConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConnectorFactory, T4> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.ProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProviderConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ConnectorFactory, InnerConnectorProviderConfigurationFactory> WithProviderConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConnectorFactory> combinedResult, Action<Humidifier.InspectorV2.ConnectorTypes.ProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProviderConfiguration(combinedResult.T5, subFactoryAction).T2);
}
