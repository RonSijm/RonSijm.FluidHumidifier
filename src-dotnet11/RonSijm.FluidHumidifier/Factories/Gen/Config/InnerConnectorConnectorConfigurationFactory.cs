// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Config;

public class InnerConnectorConnectorConfigurationFactory(Action<Humidifier.Config.ConnectorTypes.ConnectorConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Config.ConnectorTypes.ConnectorConfiguration>
{

    internal InnerConnectorAzureConnectorConfigurationFactory AzureFactory { get; set; }

    protected override Humidifier.Config.ConnectorTypes.ConnectorConfiguration Create()
    {
        var connectorConfigurationResult = CreateConnectorConfiguration();
        factoryAction?.Invoke(connectorConfigurationResult);

        return connectorConfigurationResult;
    }

    private Humidifier.Config.ConnectorTypes.ConnectorConfiguration CreateConnectorConfiguration()
    {
        var connectorConfigurationResult = new Humidifier.Config.ConnectorTypes.ConnectorConfiguration();

        return connectorConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Config.ConnectorTypes.ConnectorConfiguration result)
    {
        base.CreateChildren(result);

        result.Azure ??= AzureFactory?.Build();
    }

} // End Of Class

public static class InnerConnectorConnectorConfigurationFactoryExtensions
{
    public static CombinedResult<InnerConnectorConnectorConfigurationFactory, InnerConnectorAzureConnectorConfigurationFactory> WithAzure(this InnerConnectorConnectorConfigurationFactory parentFactory, Action<Humidifier.Config.ConnectorTypes.AzureConnectorConfiguration> subFactoryAction = null)
    {
        parentFactory.AzureFactory = new InnerConnectorAzureConnectorConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AzureFactory);
    }

    public static CombinedResult<InnerConnectorConnectorConfigurationFactory, T1, InnerConnectorAzureConnectorConfigurationFactory> WithAzure<T1>(this CombinedResult<InnerConnectorConnectorConfigurationFactory, T1> combinedResult, Action<Humidifier.Config.ConnectorTypes.AzureConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAzure(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectorConnectorConfigurationFactory, InnerConnectorAzureConnectorConfigurationFactory> WithAzure<T1>(this CombinedResult<T1, InnerConnectorConnectorConfigurationFactory> combinedResult, Action<Humidifier.Config.ConnectorTypes.AzureConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAzure(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerConnectorConnectorConfigurationFactory, T1, T2, InnerConnectorAzureConnectorConfigurationFactory> WithAzure<T1, T2>(this CombinedResult<InnerConnectorConnectorConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Config.ConnectorTypes.AzureConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAzure(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectorConnectorConfigurationFactory, T2, InnerConnectorAzureConnectorConfigurationFactory> WithAzure<T1, T2>(this CombinedResult<T1, InnerConnectorConnectorConfigurationFactory, T2> combinedResult, Action<Humidifier.Config.ConnectorTypes.AzureConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAzure(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectorConnectorConfigurationFactory, InnerConnectorAzureConnectorConfigurationFactory> WithAzure<T1, T2>(this CombinedResult<T1, T2, InnerConnectorConnectorConfigurationFactory> combinedResult, Action<Humidifier.Config.ConnectorTypes.AzureConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAzure(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerConnectorConnectorConfigurationFactory, T1, T2, T3, InnerConnectorAzureConnectorConfigurationFactory> WithAzure<T1, T2, T3>(this CombinedResult<InnerConnectorConnectorConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Config.ConnectorTypes.AzureConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAzure(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectorConnectorConfigurationFactory, T2, T3, InnerConnectorAzureConnectorConfigurationFactory> WithAzure<T1, T2, T3>(this CombinedResult<T1, InnerConnectorConnectorConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Config.ConnectorTypes.AzureConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAzure(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectorConnectorConfigurationFactory, T3, InnerConnectorAzureConnectorConfigurationFactory> WithAzure<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectorConnectorConfigurationFactory, T3> combinedResult, Action<Humidifier.Config.ConnectorTypes.AzureConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAzure(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConnectorConnectorConfigurationFactory, InnerConnectorAzureConnectorConfigurationFactory> WithAzure<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectorConnectorConfigurationFactory> combinedResult, Action<Humidifier.Config.ConnectorTypes.AzureConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAzure(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerConnectorConnectorConfigurationFactory, T1, T2, T3, T4, InnerConnectorAzureConnectorConfigurationFactory> WithAzure<T1, T2, T3, T4>(this CombinedResult<InnerConnectorConnectorConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Config.ConnectorTypes.AzureConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAzure(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectorConnectorConfigurationFactory, T2, T3, T4, InnerConnectorAzureConnectorConfigurationFactory> WithAzure<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectorConnectorConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Config.ConnectorTypes.AzureConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAzure(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectorConnectorConfigurationFactory, T3, T4, InnerConnectorAzureConnectorConfigurationFactory> WithAzure<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectorConnectorConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Config.ConnectorTypes.AzureConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAzure(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConnectorConnectorConfigurationFactory, T4, InnerConnectorAzureConnectorConfigurationFactory> WithAzure<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectorConnectorConfigurationFactory, T4> combinedResult, Action<Humidifier.Config.ConnectorTypes.AzureConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAzure(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerConnectorConnectorConfigurationFactory, InnerConnectorAzureConnectorConfigurationFactory> WithAzure<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectorConnectorConfigurationFactory> combinedResult, Action<Humidifier.Config.ConnectorTypes.AzureConnectorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAzure(combinedResult.T5, subFactoryAction).T2);
}
